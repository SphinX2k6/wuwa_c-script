using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200414A RID: 16714
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MasterLevelItem : AutoAttachItem<MasterLevelData>, IStaticVariableResetter
	{
		// Token: 0x0602A45F RID: 173151 RVA: 0x00BEFC50 File Offset: 0x00BEDE50
		static MasterLevelItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MasterLevelItem.CreateStaticDefaultValue), new Action(MasterLevelItem.ResetStaticDefaultValue));
		}

		// Token: 0x0602A460 RID: 173152 RVA: 0x00BEFC6F File Offset: 0x00BEDE6F
		public static void CreateStaticDefaultValue()
		{
			MasterLevelItem.ScaleCurve = null;
			MasterLevelItem.AlphaCurve = null;
		}

		// Token: 0x0602A461 RID: 173153 RVA: 0x00BEFC7D File Offset: 0x00BEDE7D
		public static void ResetStaticDefaultValue()
		{
			MasterLevelItem.ScaleCurve = null;
			MasterLevelItem.AlphaCurve = null;
		}

		// Token: 0x0602A462 RID: 173154 RVA: 0x00BEFC8C File Offset: 0x00BEDE8C
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

		// Token: 0x0602A463 RID: 173155 RVA: 0x00BEFE45 File Offset: 0x00BEE045
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

		// Token: 0x0602A464 RID: 173156 RVA: 0x00BEFE74 File Offset: 0x00BEE074
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

		// Token: 0x0602A465 RID: 173157 RVA: 0x00BF0005 File Offset: 0x00BEE205
		private void SelectItem()
		{
			if (this.CallbackOnSelect != null && this.Data != null)
			{
				this.CallbackOnSelect(this.Data.Level, this);
			}
		}

		// Token: 0x0602A466 RID: 173158 RVA: 0x00BF002E File Offset: 0x00BEE22E
		public override void OnSelect()
		{
			this.SelectItem();
		}

		// Token: 0x0602A467 RID: 173159 RVA: 0x00BF0036 File Offset: 0x00BEE236
		protected override void OnUnSelect()
		{
		}

		// Token: 0x0602A468 RID: 173160 RVA: 0x00BF0038 File Offset: 0x00BEE238
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

		// Token: 0x0602A469 RID: 173161 RVA: 0x00BF00B5 File Offset: 0x00BEE2B5
		public MasterLevelItem() : base(null)
		{
		}

		// Token: 0x04016FE5 RID: 94181
		private MasterLevelData Data;

		// Token: 0x04016FE6 RID: 94182
		public int ActivityId;

		// Token: 0x04016FE7 RID: 94183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, MasterLevelItem> CallbackOnSelect;

		// Token: 0x04016FE8 RID: 94184
		public static UCurveFloat ScaleCurve;

		// Token: 0x04016FE9 RID: 94185
		public static UCurveFloat AlphaCurve;

		// Token: 0x04016FEA RID: 94186
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009D25 RID: 40229
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030DCA RID: 200138
			public const int PanelAnchor = 0;

			// Token: 0x04030DCB RID: 200139
			public const int SpriteBarBg = 1;

			// Token: 0x04030DCC RID: 200140
			public const int SpriteBar = 2;

			// Token: 0x04030DCD RID: 200141
			public const int SpriteStar = 3;

			// Token: 0x04030DCE RID: 200142
			public const int SpriteStarBg = 4;

			// Token: 0x04030DCF RID: 200143
			public const int BtnMain = 5;

			// Token: 0x04030DD0 RID: 200144
			public const int IconBg1 = 6;

			// Token: 0x04030DD1 RID: 200145
			public const int IconBg2 = 7;

			// Token: 0x04030DD2 RID: 200146
			public const int IconBg4 = 8;

			// Token: 0x04030DD3 RID: 200147
			public const int TextLv = 9;

			// Token: 0x04030DD4 RID: 200148
			public const int TextLevel = 10;

			// Token: 0x04030DD5 RID: 200149
			public const int TextLevelGray = 11;

			// Token: 0x04030DD6 RID: 200150
			public const int IconNormal = 12;

			// Token: 0x04030DD7 RID: 200151
			public const int IconSelect = 13;

			// Token: 0x04030DD8 RID: 200152
			public const int PanelSelect = 14;

			// Token: 0x04030DD9 RID: 200153
			public const int IconBg3 = 15;

			// Token: 0x04030DDA RID: 200154
			public const int ItemRedDot = 16;
		}
	}
}
