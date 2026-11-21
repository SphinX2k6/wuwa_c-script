using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005378 RID: 21368
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourMainView : UiTickViewBase
	{
		// Token: 0x060352A1 RID: 217761 RVA: 0x00ED8C23 File Offset: 0x00ED6E23
		public MotorParkourMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060352A2 RID: 217762 RVA: 0x00ED8C2C File Offset: 0x00ED6E2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnRewardBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnGotoBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060352A3 RID: 217763 RVA: 0x00ED8ECC File Offset: 0x00ED70CC
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060352A4 RID: 217764 RVA: 0x00ED8F10 File Offset: 0x00ED7110
		protected override void OnBeforeShow()
		{
			this.LevelScrollLayout.RefreshByData(this.ActivityData.GetLevelDataList(), delegate
			{
				this.RefreshView(this.CurLevelData);
				this.LevelScrollLayout.LateScrollTo(this.LevelScrollLayout.GetItemByKey(this.CurLevelData.Id), null, false);
			}, true);
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
			string resourceId = flag ? "T_LevelSelectBgFemale" : "T_LevelSelectBgMale";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			string resourceId2 = flag ? "T_RoleFemale" : "T_RoleMale";
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
			base.SetTextureByPath(resourcePath2, base.GetTexture(16), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "MotorParkour_RewardProgress_1", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.ActivityData.GetFinishedTaskNum(),
				this.ActivityData.GetAllTaskNum()
			}));
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ActivityData.RewardHasRedDot());
		}

		// Token: 0x060352A5 RID: 217765 RVA: 0x00ED901C File Offset: 0x00ED721C
		private void RefreshView(MotorParkourLevelData levelData)
		{
			this.CurLevelData = levelData;
			MotorParkourLevelItem scrollItemByKey = this.LevelScrollLayout.GetScrollItemByKey(levelData.Id);
			int? num = (scrollItemByKey != null) ? new int?(scrollItemByKey.GridIndex) : null;
			if (num != null)
			{
				this.LevelScrollLayout.SelectGridProxy(num.Value, false);
			}
			else
			{
				this.LevelScrollLayout.SelectGridProxy(-1, false);
			}
			UUITexture texture = base.GetTexture(8);
			base.SetTextureByPath(levelData.RaceTrackTexture, texture, null, null);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				FRotator frotator = new FRotator(0f, (float)levelData.RouteTextureRotation, 0f);
				uuiitem.SetUIRelativeRotation(frotator);
			}
			this.RankLayout.RefreshByData(levelData.HistoryRankList, null, true);
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(levelData.BestRecordTime != 0);
			}
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)levelData.BestRecordTime * TimeUtil.Instance.Millisecond);
			UUIText text = base.GetText(12);
			if (text != null)
			{
				text.SetText(remainTimeDataFormat, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), levelData.RouteName, Array.Empty<object>());
		}

		// Token: 0x060352A6 RID: 217766 RVA: 0x00ED914C File Offset: 0x00ED734C
		protected override void OnTick(float delta)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, localTextNew);
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x060352A7 RID: 217767 RVA: 0x00ED9190 File Offset: 0x00ED7390
		private void OnToggleCallback(MotorParkourLevelData levelData)
		{
			if (levelData.IsUnLock)
			{
				this.RefreshView(levelData);
				base.PlaySequence("Switch", null, false);
				return;
			}
			if (!levelData.IsReachUnlockTime())
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("GuideTips_96101_Content", null);
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText(levelData.UnlockTime, localTextNew);
				ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorParkour_GuideText_1", Array.Empty<object>());
		}

		// Token: 0x060352A8 RID: 217768 RVA: 0x00ED9200 File Offset: 0x00ED7400
		private MotorParkourLevelItem CreateLevelItem()
		{
			return new MotorParkourLevelItem
			{
				OnToggleCallback = new Action<MotorParkourLevelData>(this.OnToggleCallback)
			};
		}

		// Token: 0x060352A9 RID: 217769 RVA: 0x00ED9219 File Offset: 0x00ED7419
		private MotorParkourRankItem CreateRankItem()
		{
			return new MotorParkourRankItem();
		}

		// Token: 0x060352AA RID: 217770 RVA: 0x00ED9220 File Offset: 0x00ED7420
		private void OnRewardBtnClick()
		{
			MotorParkourLevelData selectedLevelDataInRewardView = this.ActivityData.GetSelectedLevelDataInRewardView();
			MotorParkourRewardView.IMotorParkourRewardViewData param = new MotorParkourRewardView.MotorParkourRewardViewData
			{
				ActivityData = this.ActivityData,
				SelectLevelData = selectedLevelDataInRewardView
			};
			UiManager.Instance.OpenView(EUiViewName.MotorParkourRewardView, param, null);
		}

		// Token: 0x060352AB RID: 217771 RVA: 0x00ED9263 File Offset: 0x00ED7463
		private void OnGotoBtnClick()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
				return;
			}
			MotorParkourController.Instance.EnterMotorParkourDungeonDirectly(this.CurLevelData.Id);
		}

		// Token: 0x060352AC RID: 217772 RVA: 0x00ED929B File Offset: 0x00ED749B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C0D9 RID: 114905
		[Nullable(2)]
		private MotorParkourActivityData ActivityData;

		// Token: 0x0401C0DA RID: 114906
		private MotorParkourLevelData CurLevelData;

		// Token: 0x0401C0DB RID: 114907
		private GenericScrollViewNew<MotorParkourLevelItem, MotorParkourLevelData> LevelScrollLayout;

		// Token: 0x0401C0DC RID: 114908
		private GenericLayout<MotorParkourRankItem, MotorParkourRankData> RankLayout;

		// Token: 0x0401C0DD RID: 114909
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200B000 RID: 45056
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036643 RID: 222787
			public const int TextureBg = 0;

			// Token: 0x04036644 RID: 222788
			public const int ItemCaption = 1;

			// Token: 0x04036645 RID: 222789
			public const int ScrollLayoutLevel = 2;

			// Token: 0x04036646 RID: 222790
			public const int ItemLevel = 3;

			// Token: 0x04036647 RID: 222791
			public const int BtnReward = 4;

			// Token: 0x04036648 RID: 222792
			public const int TextRewardProgress = 5;

			// Token: 0x04036649 RID: 222793
			public const int TextRewardTime = 6;

			// Token: 0x0403664A RID: 222794
			public const int TextRaceTrackTitle = 7;

			// Token: 0x0403664B RID: 222795
			public const int TextureRaceTrack = 8;

			// Token: 0x0403664C RID: 222796
			public const int TextRankTitle = 9;

			// Token: 0x0403664D RID: 222797
			public const int LayoutRank = 10;

			// Token: 0x0403664E RID: 222798
			public const int ItemRank = 11;

			// Token: 0x0403664F RID: 222799
			public const int TextBestRecordTime = 12;

			// Token: 0x04036650 RID: 222800
			public const int BtnGoto = 13;

			// Token: 0x04036651 RID: 222801
			public const int ItemBestRecordPanel = 14;

			// Token: 0x04036652 RID: 222802
			public const int ItemRewardRedDot = 15;

			// Token: 0x04036653 RID: 222803
			public const int TextureCharacterBg = 16;
		}
	}
}
