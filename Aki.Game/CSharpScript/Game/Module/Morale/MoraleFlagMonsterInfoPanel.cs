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
	// Token: 0x02004393 RID: 17299
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleFlagMonsterInfoPanel : UiPanelBase
	{
		// Token: 0x0602BB39 RID: 179001 RVA: 0x00C441CC File Offset: 0x00C423CC
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

		// Token: 0x0602BB3A RID: 179002 RVA: 0x00C44218 File Offset: 0x00C42418
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

		// Token: 0x0602BB3B RID: 179003 RVA: 0x00C44354 File Offset: 0x00C42554
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleFlagMonsterInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleFlagMonsterInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB3C RID: 179004 RVA: 0x00C44398 File Offset: 0x00C42598
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

		// Token: 0x0602BB3D RID: 179005 RVA: 0x00C44410 File Offset: 0x00C42610
		public void OnBtnTeleport()
		{
			WorldMapController.Instance.TryTeleport(this.FlagData.Config.MarkId, delegate
			{
				UiManager.Instance.ResetToBattleView(null);
			});
		}

		// Token: 0x0602BB3E RID: 179006 RVA: 0x00C4444C File Offset: 0x00C4264C
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

		// Token: 0x0602BB3F RID: 179007 RVA: 0x00C44578 File Offset: 0x00C42778
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

		// Token: 0x0602BB40 RID: 179008 RVA: 0x00C445E4 File Offset: 0x00C427E4
		public void SetLvDiffBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0602BB41 RID: 179009 RVA: 0x00C44618 File Offset: 0x00C42818
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

		// Token: 0x0602BB42 RID: 179010 RVA: 0x00C44684 File Offset: 0x00C42884
		public List<TItem> GetRewardItemList()
		{
			int boxRewardId = this.FlagData.Config.BoxRewardId;
			if (boxRewardId <= 0)
			{
				return new List<TItem>();
			}
			return RewardConfig.Instance.GetDropPackagePreviewItemList(boxRewardId);
		}

		// Token: 0x0602BB43 RID: 179011 RVA: 0x00C446B7 File Offset: 0x00C428B7
		private CommonItemSmallItemGrid InitCommonGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.ShowReceivedCallBack)
			};
		}

		// Token: 0x0602BB44 RID: 179012 RVA: 0x00C446D0 File Offset: 0x00C428D0
		private bool ShowReceivedCallBack(TItem data)
		{
			return this.FlagData.IsGetBox;
		}

		// Token: 0x0602BB45 RID: 179013 RVA: 0x00C446E0 File Offset: 0x00C428E0
		public void PlayEnter()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence == null)
			{
				return;
			}
			sequence.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0602BB46 RID: 179014 RVA: 0x00C44710 File Offset: 0x00C42910
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

		// Token: 0x0602BB47 RID: 179015 RVA: 0x00C44790 File Offset: 0x00C42990
		public bool FlagMarkIsCanTeleport()
		{
			int markId = this.FlagData.Config.MarkId;
			return MapModel.Instance.MapMarkIsCanTeleport(markId);
		}

		// Token: 0x04017904 RID: 96516
		public MoraleAreaFlagData FlagData;

		// Token: 0x04017905 RID: 96517
		public ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04017906 RID: 96518
		public ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04017907 RID: 96519
		public ButtonItem BtnTrackOrTeleportComponent;

		// Token: 0x04017908 RID: 96520
		[Nullable(2)]
		public LevelSequencePlayer Sequence;

		// Token: 0x0200A07F RID: 41087
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031DE0 RID: 204256
			public const int TextureDifficulty = 0;

			// Token: 0x04031DE1 RID: 204257
			public const int ArtTxtLv = 1;

			// Token: 0x04031DE2 RID: 204258
			public const int SpriteFinish = 2;

			// Token: 0x04031DE3 RID: 204259
			public const int ItemTipsHighDifficulty = 3;

			// Token: 0x04031DE4 RID: 204260
			public const int ItemDescPanel = 4;

			// Token: 0x04031DE5 RID: 204261
			public const int ItemRewardPanel = 5;

			// Token: 0x04031DE6 RID: 204262
			public const int ItemTipsRoot = 6;

			// Token: 0x04031DE7 RID: 204263
			public const int ItemTipsWarning = 7;

			// Token: 0x04031DE8 RID: 204264
			public const int ItemTipsCanReceived = 8;

			// Token: 0x04031DE9 RID: 204265
			public const int ItemButtonComponent = 9;

			// Token: 0x04031DEA RID: 204266
			public const int TextTipsWarning = 10;

			// Token: 0x04031DEB RID: 204267
			public const int TextTipsCanReceived = 11;

			// Token: 0x04031DEC RID: 204268
			public const int TextureIcon = 12;
		}
	}
}
