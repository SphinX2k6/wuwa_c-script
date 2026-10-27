using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200517A RID: 20858
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MasterLevelItem : AutoAttachItem<MasterLevelData>, IStaticVariableResetter
	{
		// Token: 0x06035564 RID: 218468 RVA: 0x00CA2698 File Offset: 0x00CA0898
		static MasterLevelItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MasterLevelItem.CreateStaticDefaultValue), new Action(MasterLevelItem.ResetStaticDefaultValue));
		}

		// Token: 0x06035565 RID: 218469 RVA: 0x00CA26B7 File Offset: 0x00CA08B7
		public static void CreateStaticDefaultValue()
		{
			MasterLevelItem.ScaleCurve = null;
			MasterLevelItem.AlphaCurve = null;
		}

		// Token: 0x06035566 RID: 218470 RVA: 0x00CA26C5 File Offset: 0x00CA08C5
		public static void ResetStaticDefaultValue()
		{
			MasterLevelItem.ScaleCurve = null;
			MasterLevelItem.AlphaCurve = null;
		}

		// Token: 0x06035567 RID: 218471 RVA: 0x00CA26D4 File Offset: 0x00CA08D4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUITexture)),
				new ValueTuple<int, Type>(13, typeof(UUITexture)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUITexture)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.SelectItem))
			};
		}

		// Token: 0x06035568 RID: 218472 RVA: 0x00CA288D File Offset: 0x00CA0A8D
		protected override void OnRefreshItem(MasterLevelData data)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			if (this.LevelSequencePlayer == null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
			this.Refresh(data);
		}

		// Token: 0x06035569 RID: 218473 RVA: 0x00CA28BC File Offset: 0x00CA0ABC
		[NullableContext(1)]
		private void Refresh(MasterLevelData data)
		{
			int level = data.Level;
			int masterLevelMax = PhantomArenaModel.Instance.GetMasterLevelMax(this.ActivityId);
			base.GetText(10).SetText(level.ToString(), true);
			base.GetText(11).SetText(level.ToString(), true);
			bool flag = PhantomArenaModel.Instance.GetMasterLevel(this.ActivityId) < level;
			base.GetSprite(3).SetUIActive(!flag);
			base.GetText(10).SetUIActive(!flag);
			base.GetText(11).SetUIActive(flag);
			base.GetTexture(15).SetUIActive(!flag);
			base.GetTexture(8).SetUIActive(!flag);
			base.GetTexture(7).SetIsGray(flag);
			base.GetItem(14).SetUIActive(!flag);
			bool flag2 = PhantomArenaModel.Instance.GetMasterLevelRewardList(level, this.ActivityId).Count == 0;
			bool masterLevelRewardIfTaken = PhantomArenaModel.Instance.GetMasterLevelRewardIfTaken(level, this.ActivityId);
			bool masterLevelRewardCanTake = PhantomArenaModel.Instance.GetMasterLevelRewardCanTake(level, this.ActivityId);
			base.GetItem(16).SetUIActive(!masterLevelRewardIfTaken && masterLevelRewardCanTake && !flag2);
			base.GetSprite(1).SetUIActive(level < masterLevelMax);
			base.GetSprite(2).SetUIActive(level < masterLevelMax);
			if (!data.IsMax)
			{
				int masterExpNow = PhantomArenaModel.Instance.GetMasterExpNow(this.ActivityId, null);
				base.GetSprite(2).SetFillAmount((float)(masterExpNow - data.ExpLevel) / (float)data.ExpNext);
			}
		}

		// Token: 0x0603556A RID: 218474 RVA: 0x00CA2A4D File Offset: 0x00CA0C4D
		private void SelectItem()
		{
			if (this.CallbackOnSelect != null && this.Data != null)
			{
				this.CallbackOnSelect(this.Data.Level, this);
			}
		}

		// Token: 0x0603556B RID: 218475 RVA: 0x00CA2A76 File Offset: 0x00CA0C76
		public override void OnSelect()
		{
			this.SelectItem();
		}

		// Token: 0x0603556C RID: 218476 RVA: 0x00CA2A7E File Offset: 0x00CA0C7E
		protected override void OnUnSelect()
		{
		}

		// Token: 0x0603556D RID: 218477 RVA: 0x00CA2A80 File Offset: 0x00CA0C80
		protected override void OnMoveItem()
		{
			float currentMovePercentage = base.GetCurrentMovePercentage();
			float floatValue = MasterLevelItem.ScaleCurve.GetFloatValue(currentMovePercentage);
			base.GetItem(0).SetUIItemScale(new FVector(floatValue, floatValue, 1f));
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIItemScale(new FVector(1f / floatValue, 1f / floatValue, 1f));
			}
			float floatValue2 = MasterLevelItem.AlphaCurve.GetFloatValue(currentMovePercentage);
			base.GetItem(14).SetAlpha(floatValue2);
		}

		// Token: 0x0603556E RID: 218478 RVA: 0x00CA2AFD File Offset: 0x00CA0CFD
		public MasterLevelItem() : base(null)
		{
		}

		// Token: 0x0401C5B0 RID: 116144
		private MasterLevelData Data;

		// Token: 0x0401C5B1 RID: 116145
		public int ActivityId;

		// Token: 0x0401C5B2 RID: 116146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, MasterLevelItem> CallbackOnSelect;

		// Token: 0x0401C5B3 RID: 116147
		public static UCurveFloat ScaleCurve;

		// Token: 0x0401C5B4 RID: 116148
		public static UCurveFloat AlphaCurve;

		// Token: 0x0401C5B5 RID: 116149
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B2EC RID: 45804
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036375 RID: 222069
			public const int PanelAnchor = 0;

			// Token: 0x04036376 RID: 222070
			public const int SpriteBarBg = 1;

			// Token: 0x04036377 RID: 222071
			public const int SpriteBar = 2;

			// Token: 0x04036378 RID: 222072
			public const int SpriteStar = 3;

			// Token: 0x04036379 RID: 222073
			public const int SpriteStarBg = 4;

			// Token: 0x0403637A RID: 222074
			public const int BtnMain = 5;

			// Token: 0x0403637B RID: 222075
			public const int IconBg1 = 6;

			// Token: 0x0403637C RID: 222076
			public const int IconBg2 = 7;

			// Token: 0x0403637D RID: 222077
			public const int IconBg4 = 8;

			// Token: 0x0403637E RID: 222078
			public const int TextLv = 9;

			// Token: 0x0403637F RID: 222079
			public const int TextLevel = 10;

			// Token: 0x04036380 RID: 222080
			public const int TextLevelGray = 11;

			// Token: 0x04036381 RID: 222081
			public const int IconNormal = 12;

			// Token: 0x04036382 RID: 222082
			public const int IconSelect = 13;

			// Token: 0x04036383 RID: 222083
			public const int PanelSelect = 14;

			// Token: 0x04036384 RID: 222084
			public const int IconBg3 = 15;

			// Token: 0x04036385 RID: 222085
			public const int ItemRedDot = 16;
		}
	}
}
