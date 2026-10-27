using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.Item
{
	// Token: 0x02004BF7 RID: 19447
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkinItem : AutoAttachItem<RoleSkinData>, IStaticVariableResetter
	{
		// Token: 0x0603249F RID: 205983 RVA: 0x00BAF24A File Offset: 0x00BAD44A
		static RoleSkinItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinItem.CreateStaticDefaultValue), new Action(RoleSkinItem.ResetStaticDefaultValue));
		}

		// Token: 0x060324A0 RID: 205984 RVA: 0x00BAF269 File Offset: 0x00BAD469
		public static void CreateStaticDefaultValue()
		{
			RoleSkinItem.OffsetCurve = null;
			RoleSkinItem.ScaleCurve = null;
			RoleSkinItem.AlphaCurve = null;
		}

		// Token: 0x060324A1 RID: 205985 RVA: 0x00BAF27D File Offset: 0x00BAD47D
		public static void ResetStaticDefaultValue()
		{
			RoleSkinItem.OffsetCurve = null;
			RoleSkinItem.ScaleCurve = null;
			RoleSkinItem.AlphaCurve = null;
		}

		// Token: 0x060324A2 RID: 205986 RVA: 0x00BAF294 File Offset: 0x00BAD494
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

		// Token: 0x060324A3 RID: 205987 RVA: 0x00BAF438 File Offset: 0x00BAD638
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

		// Token: 0x060324A4 RID: 205988 RVA: 0x00BAF563 File Offset: 0x00BAD763
		private void RefreshEffectItem(bool hasSuit)
		{
			base.GetItem(14).SetUIActive(hasSuit);
			base.GetItem(13).SetUIActive(hasSuit);
		}

		// Token: 0x060324A5 RID: 205989 RVA: 0x00BAF581 File Offset: 0x00BAD781
		public override void OnSelect()
		{
			this.OnSelectedItem();
			base.GetItem(12).SetUIActive(true);
			base.GetItem(11).SetUIActive(false);
			base.GetItem(15).SetUIActive(false);
		}

		// Token: 0x060324A6 RID: 205990 RVA: 0x00BAF5B3 File Offset: 0x00BAD7B3
		protected override void OnUnSelect()
		{
			base.GetItem(12).SetUIActive(false);
			base.GetItem(11).SetUIActive(true);
		}

		// Token: 0x060324A7 RID: 205991 RVA: 0x00BAF5D1 File Offset: 0x00BAD7D1
		private void OnSelectedItem()
		{
			Action<int> buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction(this.CurrentShowItemIndex);
		}

		// Token: 0x060324A8 RID: 205992 RVA: 0x00BAF5EC File Offset: 0x00BAD7EC
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			this.RefreshScaleByCurve(currentMovePercentage);
			this.RefreshAlphaByCurve(currentMovePercentage);
			this.RefreshOffset(currentMovePercentage);
			this.RefreshHierarchyIndex(currentMovePercentage);
		}

		// Token: 0x060324A9 RID: 205993 RVA: 0x00BAF61C File Offset: 0x00BAD81C
		private void RefreshScaleByCurve(float percentage)
		{
			float floatValue = RoleSkinItem.ScaleCurve.GetFloatValue(percentage);
			FVector uiitemScale = new FVector(floatValue, floatValue, floatValue);
			this.RootItem.SetUIItemScale(uiitemScale);
		}

		// Token: 0x060324AA RID: 205994 RVA: 0x00BAF64C File Offset: 0x00BAD84C
		private void RefreshAlphaByCurve(float percentage)
		{
			float floatValue = RoleSkinItem.AlphaCurve.GetFloatValue(percentage);
			this.RootItem.SetUIItemAlpha(floatValue);
		}

		// Token: 0x060324AB RID: 205995 RVA: 0x00BAF674 File Offset: 0x00BAD874
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

		// Token: 0x060324AC RID: 205996 RVA: 0x00BAF6DC File Offset: 0x00BAD8DC
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

		// Token: 0x060324AD RID: 205997 RVA: 0x00BAF71B File Offset: 0x00BAD91B
		public RoleSkinItem() : base(null)
		{
		}

		// Token: 0x0401ABEE RID: 109550
		public Action<int> ButtonFunction;

		// Token: 0x0401ABEF RID: 109551
		public static UCurveFloat OffsetCurve;

		// Token: 0x0401ABF0 RID: 109552
		public static UCurveFloat ScaleCurve;

		// Token: 0x0401ABF1 RID: 109553
		public static UCurveFloat AlphaCurve;

		// Token: 0x0401ABF2 RID: 109554
		private const float INDEXQUARTER = 0.25f;

		// Token: 0x0401ABF3 RID: 109555
		private const float INDEXHALF = 0.5f;

		// Token: 0x0401ABF4 RID: 109556
		private const float INDEXTHREEQUARTER = 0.75f;

		// Token: 0x0401ABF5 RID: 109557
		private const int MAXHIERARCHYINDEX = 2;

		// Token: 0x0401ABF6 RID: 109558
		private const int MINHIERARCHYINDEX = 1;

		// Token: 0x0200ADEF RID: 44527
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034D3E RID: 216382
			Button,
			// Token: 0x04034D3F RID: 216383
			QualityTextureBg,
			// Token: 0x04034D40 RID: 216384
			RoleTexture,
			// Token: 0x04034D41 RID: 216385
			QualityTexture,
			// Token: 0x04034D42 RID: 216386
			WeaponRootItem,
			// Token: 0x04034D43 RID: 216387
			WeaponTexture,
			// Token: 0x04034D44 RID: 216388
			WearItem,
			// Token: 0x04034D45 RID: 216389
			LockItem,
			// Token: 0x04034D46 RID: 216390
			MaskLeft,
			// Token: 0x04034D47 RID: 216391
			MaskRight,
			// Token: 0x04034D48 RID: 216392
			WeaponQualityTexture,
			// Token: 0x04034D49 RID: 216393
			TextureMask,
			// Token: 0x04034D4A RID: 216394
			TextureRoleSelect,
			// Token: 0x04034D4B RID: 216395
			EffectBItem,
			// Token: 0x04034D4C RID: 216396
			EffectAItem,
			// Token: 0x04034D4D RID: 216397
			NewItem
		}
	}
}
