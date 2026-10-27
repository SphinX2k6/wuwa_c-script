using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B0 RID: 21424
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleFlagMonsterInfoPanel : UiPanelBase
	{
		// Token: 0x06036BF3 RID: 224243 RVA: 0x00CF5124 File Offset: 0x00CF3324
		public UniTask Init(UUIItem item)
		{
			MoraleFlagMonsterInfoPanel.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleFlagMonsterInfoPanel.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036BF4 RID: 224244 RVA: 0x00CF5170 File Offset: 0x00CF3370
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUITexture))
			};
		}

		// Token: 0x06036BF5 RID: 224245 RVA: 0x00CF52AC File Offset: 0x00CF34AC
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleFlagMonsterInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleFlagMonsterInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036BF6 RID: 224246 RVA: 0x00CF52F0 File Offset: 0x00CF34F0
		public void OnBtnTrack()
		{
			int markId = this.FlagData.Config.MarkId;
			if (markId <= 0)
			{
				return;
			}
			if (MoraleConfig.Instance.GetMoraleMarkIsAutoTrack() && !MapModel.Instance.IsMarkTracking(markId))
			{
				MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
				{
					MarkType = EMarkType.CommonGamePlay,
					MarkId = markId,
					Track = true
				}, null);
			}
			SkipTaskManager.Run(ESkipName.SkipToMapTempMark, new object[]
			{
				markId
			});
		}

		// Token: 0x06036BF7 RID: 224247 RVA: 0x00CF5368 File Offset: 0x00CF3568
		public void OnBtnTeleport()
		{
			WorldMapController.Instance.TryTeleport(this.FlagData.Config.MarkId, delegate
			{
				UiManager.Instance.ResetToBattleView(null);
			});
		}

		// Token: 0x06036BF8 RID: 224248 RVA: 0x00CF53A4 File Offset: 0x00CF35A4
		public void UpdateData(MoraleAreaFlagData flagData)
		{
			this.FlagData = flagData;
			UUITexture texture = base.GetTexture(12);
			string monsterIconPath = this.FlagData.Config.MonsterIconPath;
			base.SetTextureByPath(monsterIconPath, texture, null, null);
			base.GetArtText(1).SetText(this.FlagData.Config.MaxMonsterLv.ToString());
			this.UpdateLvDiffBg();
			UUIItem sprite = base.GetSprite(2);
			bool isActive = this.FlagData.IsActive;
			sprite.SetUIActive(isActive);
			this.DescriptionComponent.SetContentByTextId(this.FlagData.Config.MonsterDesc, Array.Empty<string>());
			this.UpdateRewardList();
			bool flag = this.FlagData.HasBoxCanGet();
			base.GetItem(8).SetUIActive(flag);
			if (flag)
			{
				base.GetText(11).ShowTextNew("Morale_title_9");
			}
			bool flag2 = this.FlagData.IsLowMoraleLv();
			base.GetItem(7).SetUIActive(flag2);
			if (flag2)
			{
				base.GetText(10).ShowTextNew("Morale_title_7");
			}
			bool uiactive = this.FlagData.IsHighDifficultyChallenge();
			base.GetItem(3).SetUIActive(uiactive);
			this.UpdateTrackOrTeleport();
		}

		// Token: 0x06036BF9 RID: 224249 RVA: 0x00CF54D0 File Offset: 0x00CF36D0
		public void UpdateLvDiffBg()
		{
			int maxMonsterLv = this.FlagData.Config.MaxMonsterLv;
			switch (MoraleBattleModel.Instance.GetMoraleLevelDiffType(maxMonsterLv, null))
			{
			case EMoraleLevelDiffType.Easy:
				this.SetLvDiffBg("T_EnemyMoraleLevelGrayBg");
				return;
			case EMoraleLevelDiffType.Normal:
				this.SetLvDiffBg("T_EnemyMoraleLevelYellowBg");
				return;
			case EMoraleLevelDiffType.Hard:
				this.SetLvDiffBg("T_EnemyMoraleLevelRedBg");
				return;
			default:
				return;
			}
		}

		// Token: 0x06036BFA RID: 224250 RVA: 0x00CF553C File Offset: 0x00CF373C
		public void SetLvDiffBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06036BFB RID: 224251 RVA: 0x00CF5570 File Offset: 0x00CF3770
		public void UpdateRewardList()
		{
			List<TItem> rewardItemList = this.GetRewardItemList();
			if (rewardItemList.Count <= 0)
			{
				this.RewardListComponent.SetActive(false);
				return;
			}
			this.RewardListComponent.SetActive(true);
			this.RewardListComponent.SetTitleByTextId("Morale_title_18");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(rewardItemList, null);
		}

		// Token: 0x06036BFC RID: 224252 RVA: 0x00CF55DC File Offset: 0x00CF37DC
		public List<TItem> GetRewardItemList()
		{
			int boxRewardId = this.FlagData.Config.BoxRewardId;
			if (boxRewardId <= 0)
			{
				return new List<TItem>();
			}
			return RewardConfig.Instance.GetDropPackagePreviewItemList(boxRewardId);
		}

		// Token: 0x06036BFD RID: 224253 RVA: 0x00CF560F File Offset: 0x00CF380F
		private CommonItemSmallItemGrid InitCommonGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.ShowReceivedCallBack)
			};
		}

		// Token: 0x06036BFE RID: 224254 RVA: 0x00CF5628 File Offset: 0x00CF3828
		private bool ShowReceivedCallBack(TItem data)
		{
			return this.FlagData.IsGetBox;
		}

		// Token: 0x06036BFF RID: 224255 RVA: 0x00CF5638 File Offset: 0x00CF3838
		public void PlayEnter()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence == null)
			{
				return;
			}
			sequence.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06036C00 RID: 224256 RVA: 0x00CF5668 File Offset: 0x00CF3868
		public void UpdateTrackOrTeleport()
		{
			bool flag = MoraleModel.Instance.IsMoraleGameOver();
			bool isGetBox = this.FlagData.IsGetBox;
			bool active = !flag || !isGetBox;
			this.BtnTrackOrTeleportComponent.SetActive(active);
			bool flag2 = this.FlagMarkIsCanTeleport();
			this.BtnTrackOrTeleportComponent.SetFunction(flag2 ? delegate(int _)
			{
				this.OnBtnTeleport();
			} : delegate(int _)
			{
				this.OnBtnTrack();
			});
			this.BtnTrackOrTeleportComponent.SetShowText(flag2 ? "Text_TeleportFastMove_Text" : "Morale_title_6");
		}

		// Token: 0x06036C01 RID: 224257 RVA: 0x00CF56E8 File Offset: 0x00CF38E8
		public bool FlagMarkIsCanTeleport()
		{
			int markId = this.FlagData.Config.MarkId;
			return MapModel.Instance.MapMarkIsCanTeleport(markId);
		}

		// Token: 0x0401CE6C RID: 118380
		public MoraleAreaFlagData FlagData;

		// Token: 0x0401CE6D RID: 118381
		public ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401CE6E RID: 118382
		public ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401CE6F RID: 118383
		public ButtonItem BtnTrackOrTeleportComponent;

		// Token: 0x0401CE70 RID: 118384
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200B647 RID: 46663
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403738B RID: 226187
			public const int TextureDifficulty = 0;

			// Token: 0x0403738C RID: 226188
			public const int ArtTxtLv = 1;

			// Token: 0x0403738D RID: 226189
			public const int SpriteFinish = 2;

			// Token: 0x0403738E RID: 226190
			public const int ItemTipsHighDifficulty = 3;

			// Token: 0x0403738F RID: 226191
			public const int ItemDescPanel = 4;

			// Token: 0x04037390 RID: 226192
			public const int ItemRewardPanel = 5;

			// Token: 0x04037391 RID: 226193
			public const int ItemTipsRoot = 6;

			// Token: 0x04037392 RID: 226194
			public const int ItemTipsWarning = 7;

			// Token: 0x04037393 RID: 226195
			public const int ItemTipsCanReceived = 8;

			// Token: 0x04037394 RID: 226196
			public const int ItemButtonComponent = 9;

			// Token: 0x04037395 RID: 226197
			public const int TextTipsWarning = 10;

			// Token: 0x04037396 RID: 226198
			public const int TextTipsCanReceived = 11;

			// Token: 0x04037397 RID: 226199
			public const int TextureIcon = 12;
		}
	}
}
