using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.Item
{
	// Token: 0x02003BA8 RID: 15272
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkinItem : AutoAttachItem<RoleSkinData>, IStaticVariableResetter
	{
		// Token: 0x06027245 RID: 160325 RVA: 0x00AF384A File Offset: 0x00AF1A4A
		static RoleSkinItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinItem.CreateStaticDefaultValue), new Action(RoleSkinItem.ResetStaticDefaultValue));
		}

		// Token: 0x06027246 RID: 160326 RVA: 0x00AF3869 File Offset: 0x00AF1A69
		public static void CreateStaticDefaultValue()
		{
			RoleSkinItem.OffsetCurve = null;
			RoleSkinItem.ScaleCurve = null;
			RoleSkinItem.AlphaCurve = null;
		}

		// Token: 0x06027247 RID: 160327 RVA: 0x00AF387D File Offset: 0x00AF1A7D
		public static void ResetStaticDefaultValue()
		{
			RoleSkinItem.OffsetCurve = null;
			RoleSkinItem.ScaleCurve = null;
			RoleSkinItem.AlphaCurve = null;
		}

		// Token: 0x06027248 RID: 160328 RVA: 0x00AF3894 File Offset: 0x00AF1A94
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnSelectedItem))
			};
		}

		// Token: 0x06027249 RID: 160329 RVA: 0x00AF3A38 File Offset: 0x00AF1C38
		[NullableContext(1)]
		protected override void OnRefreshItem(RoleSkinData data)
		{
			base.SetTextureByPath(data.GetBuyPreviewRoleQualityBgPath(), base.GetTexture(1), null, null);
			base.SetTextureByPath(data.GetBuyPreviewRoleCardPath(), base.GetTexture(2), null, null);
			bool flag = data.GetSuitWeaponSkinId() > 0;
			if (flag)
			{
				string suitWeaponPreviewTexturePath = data.GetSuitWeaponPreviewTexturePath();
				base.SetTextureByPath(suitWeaponPreviewTexturePath, base.GetTexture(5), null, null);
				base.GetTexture(5).SetUIActive(true);
				string suitWeaponQualityBgPath = data.GetSuitWeaponQualityBgPath();
				base.SetTextureByPath(suitWeaponQualityBgPath, base.GetTexture(4), null, null);
				base.GetItem(4).SetUIActive(true);
				FColor color = FColor.FromHex(data.GetRoleSkinConfig().SuitWeaponSkinColor);
				base.GetTexture(10).SetColor(color);
			}
			else
			{
				base.GetTexture(5).SetUIActive(false);
				base.GetItem(4).SetUIActive(false);
			}
			base.GetItem(15).SetUIActive(data.GetHasNewFlag());
			base.GetItem(6).SetUIActive(data.IsWear());
			base.GetItem(7).SetUIActive(data.IsLocked());
			this.RefreshEffectItem(flag);
		}

		// Token: 0x0602724A RID: 160330 RVA: 0x00AF3B63 File Offset: 0x00AF1D63
		private void RefreshEffectItem(bool hasSuit)
		{
			base.GetItem(14).SetUIActive(hasSuit);
			base.GetItem(13).SetUIActive(hasSuit);
		}

		// Token: 0x0602724B RID: 160331 RVA: 0x00AF3B81 File Offset: 0x00AF1D81
		public override void OnSelect()
		{
			this.OnSelectedItem();
			base.GetItem(12).SetUIActive(true);
			base.GetItem(11).SetUIActive(false);
			base.GetItem(15).SetUIActive(false);
		}

		// Token: 0x0602724C RID: 160332 RVA: 0x00AF3BB3 File Offset: 0x00AF1DB3
		protected override void OnUnSelect()
		{
			base.GetItem(12).SetUIActive(false);
			base.GetItem(11).SetUIActive(true);
		}

		// Token: 0x0602724D RID: 160333 RVA: 0x00AF3BD1 File Offset: 0x00AF1DD1
		private void OnSelectedItem()
		{
			Action<int> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.CurrentShowItemIndex);
		}

		// Token: 0x0602724E RID: 160334 RVA: 0x00AF3BEC File Offset: 0x00AF1DEC
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			this.RefreshScaleByCurve(currentMovePercentage);
			this.RefreshAlphaByCurve(currentMovePercentage);
			this.RefreshOffset(currentMovePercentage);
			this.RefreshHierarchyIndex(currentMovePercentage);
		}

		// Token: 0x0602724F RID: 160335 RVA: 0x00AF3C1C File Offset: 0x00AF1E1C
		private void RefreshScaleByCurve(float percentage)
		{
			float floatValue = RoleSkinItem.ScaleCurve.GetFloatValue(percentage);
			FVector uiitemScale = new FVector(floatValue, floatValue, floatValue);
			this.RootItem.SetUIItemScale(uiitemScale);
		}

		// Token: 0x06027250 RID: 160336 RVA: 0x00AF3C4C File Offset: 0x00AF1E4C
		private void RefreshAlphaByCurve(float percentage)
		{
			float floatValue = RoleSkinItem.AlphaCurve.GetFloatValue(percentage);
			this.RootItem.SetUIItemAlpha(floatValue);
		}

		// Token: 0x06027251 RID: 160337 RVA: 0x00AF3C74 File Offset: 0x00AF1E74
		private void RefreshOffset(float percentage)
		{
			float floatValue = RoleSkinItem.OffsetCurve.GetFloatValue(percentage);
			if (percentage > 0.5f)
			{
				UUIButtonComponent button = base.GetButton(0);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetAnchorOffsetX(-1f * floatValue);
				return;
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(0);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetAnchorOffsetX(floatValue);
				return;
			}
		}

		// Token: 0x06027252 RID: 160338 RVA: 0x00AF3CDC File Offset: 0x00AF1EDC
		private void RefreshHierarchyIndex(float percentage)
		{
			int num = 2;
			if (percentage <= 0.25f)
			{
				num = 1;
			}
			else if (percentage >= 0.75f)
			{
				num = 1;
			}
			if (this.RootItem.GetHierarchyIndex() != num)
			{
				this.RootItem.SetHierarchyIndex(num);
			}
		}

		// Token: 0x06027253 RID: 160339 RVA: 0x00AF3D1B File Offset: 0x00AF1F1B
		public RoleSkinItem() : base(null)
		{
		}

		// Token: 0x04015548 RID: 87368
		public Action<int> ButtonFunction;

		// Token: 0x04015549 RID: 87369
		public static UCurveFloat OffsetCurve;

		// Token: 0x0401554A RID: 87370
		public static UCurveFloat ScaleCurve;

		// Token: 0x0401554B RID: 87371
		public static UCurveFloat AlphaCurve;

		// Token: 0x0401554C RID: 87372
		private const float INDEXQUARTER = 0.25f;

		// Token: 0x0401554D RID: 87373
		private const float INDEXHALF = 0.5f;

		// Token: 0x0401554E RID: 87374
		private const float INDEXTHREEQUARTER = 0.75f;

		// Token: 0x0401554F RID: 87375
		private const int MAXHIERARCHYINDEX = 2;

		// Token: 0x04015550 RID: 87376
		private const int MINHIERARCHYINDEX = 1;

		// Token: 0x0200980E RID: 38926
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F6E5 RID: 194277
			Button,
			// Token: 0x0402F6E6 RID: 194278
			QualityTextureBg,
			// Token: 0x0402F6E7 RID: 194279
			RoleTexture,
			// Token: 0x0402F6E8 RID: 194280
			QualityTexture,
			// Token: 0x0402F6E9 RID: 194281
			WeaponRootItem,
			// Token: 0x0402F6EA RID: 194282
			WeaponTexture,
			// Token: 0x0402F6EB RID: 194283
			WearItem,
			// Token: 0x0402F6EC RID: 194284
			LockItem,
			// Token: 0x0402F6ED RID: 194285
			MaskLeft,
			// Token: 0x0402F6EE RID: 194286
			MaskRight,
			// Token: 0x0402F6EF RID: 194287
			WeaponQualityTexture,
			// Token: 0x0402F6F0 RID: 194288
			TextureMask,
			// Token: 0x0402F6F1 RID: 194289
			TextureRoleSelect,
			// Token: 0x0402F6F2 RID: 194290
			EffectBItem,
			// Token: 0x0402F6F3 RID: 194291
			EffectAItem,
			// Token: 0x0402F6F4 RID: 194292
			NewItem
		}
	}
}
