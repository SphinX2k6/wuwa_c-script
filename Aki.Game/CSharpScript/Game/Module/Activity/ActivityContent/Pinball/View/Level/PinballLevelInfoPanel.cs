using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level
{
	// Token: 0x0200633D RID: 25405
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLevelInfoPanel : UiPanelBase
	{
		// Token: 0x0603FEE3 RID: 261859 RVA: 0x00F77B44 File Offset: 0x00F75D44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnBtnEnemyDetailClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FEE4 RID: 261860 RVA: 0x00F77E90 File Offset: 0x00F76090
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLevelInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLevelInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FEE5 RID: 261861 RVA: 0x00F77ED4 File Offset: 0x00F760D4
		protected override void OnStart()
		{
			this.FirstRewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(10), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, null);
			this.StarLayout = new GenericLayout<PinballLevelInfoStarItem, IPinballLevelStarData>(base.GetVerticalLayout(14), new Func<PinballLevelInfoStarItem>(this.InitStarItem), base.GetItem(15).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603FEE6 RID: 261862 RVA: 0x00F77F36 File Offset: 0x00F76136
		private PinballLevelInfoStarItem InitStarItem()
		{
			return new PinballLevelInfoStarItem();
		}

		// Token: 0x0603FEE7 RID: 261863 RVA: 0x00F77F3D File Offset: 0x00F7613D
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = new Func<TItem, bool>(this.OnShowRewardReceivedCallBack)
			};
		}

		// Token: 0x0603FEE8 RID: 261864 RVA: 0x00F77F58 File Offset: 0x00F76158
		private void RefreshScoreInfo(int curScore, int scoreLevelRewardLength, Func<int, int> getScoreLevel, Func<int, int> getScoreLevelDropId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Pinball_Level_Score", new <>z__ReadOnlySingleElementList<object>(curScore));
			UUISprite[] array = new UUISprite[]
			{
				base.GetSprite(5),
				base.GetSprite(6)
			};
			for (int i = 0; i < scoreLevelRewardLength; i++)
			{
				int num = getScoreLevel(i);
				int configDropId = getScoreLevelDropId(i);
				PinballLevelScoreData data = new PinballLevelScoreData
				{
					CurScore = curScore,
					ConfigScore = num,
					ConfigDropId = configDropId
				};
				this.ScoreRewardItems[i].Refresh(data);
				if (i != 0)
				{
					int num2 = getScoreLevel(i - 1);
					int num3 = num - num2;
					float fillAmount = Math.Min(1f, Math.Max(0f, (float)(curScore - num2) / (float)num3));
					array[i - 1].SetFillAmount(fillAmount);
				}
			}
		}

		// Token: 0x0603FEE9 RID: 261865 RVA: 0x00F78034 File Offset: 0x00F76234
		private void RefreshStarInfo(int[] passedConditionIds, int starCondLength, Func<int, int> getStarCond)
		{
			List<IPinballLevelStarData> list = new List<IPinballLevelStarData>();
			for (int i = 0; i < starCondLength; i++)
			{
				int num = getStarCond(i);
				PinballLevelTarget? pinballLevelTargetConfigById = PinballConfig.Instance.GetPinballLevelTargetConfigById(num);
				PinballLevelStarData item = new PinballLevelStarData
				{
					ConditionId = num,
					Passed = (Array.IndexOf<int>(passedConditionIds, num) >= 0),
					ConfigConditionDesc = pinballLevelTargetConfigById.Value.CondDesc,
					ConfigTargetValue = new int?(pinballLevelTargetConfigById.Value.NeedNum)
				};
				list.Add(item);
			}
			this.StarLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603FEEA RID: 261866 RVA: 0x00F780D0 File Offset: 0x00F762D0
		private void RefreshFirstRewardInfo(int rewardDropId)
		{
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardDropId);
			this.FirstRewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
		}

		// Token: 0x0603FEEB RID: 261867 RVA: 0x00F780F8 File Offset: 0x00F762F8
		public void Refresh(IPinballLevelInfoData data)
		{
			this.Data = data;
			PinballLevelConfig? levelConfig = PinballConfig.Instance.GetPinballLevelConfigById(data.LevelId);
			if (levelConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), levelConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), levelConfig.Value.Desc, Array.Empty<object>());
			UUIText text = base.GetText(2);
			TWeakObjectPtr<UUIItem> rootUIComp = base.GetVerticalLayout(14).RootUIComp;
			UUIItem item = base.GetItem(16);
			UUIItem item2 = base.GetItem(3);
			UUIButtonComponent button = base.GetButton(13);
			UUIText text2 = base.GetText(18);
			UUIText text3 = base.GetText(19);
			UUITexture texture = base.GetTexture(20);
			text.SetUIActive(data.ShowDesc.GetValueOrDefault());
			if (data.ShowDesc.GetValueOrDefault() && !StringUtils.IsBlank(levelConfig.Value.ScoreDesc))
			{
				LguiUtil.Instance.SetLocalTextNew(text, levelConfig.Value.ScoreDesc, Array.Empty<object>());
			}
			rootUIComp.Get().SetUIActive(data.ShowStar.GetValueOrDefault());
			if (data.ShowStar.GetValueOrDefault() && data.LevelStarConditionIds != null)
			{
				this.RefreshStarInfo(data.LevelStarConditionIds, levelConfig.Value.StarCondLength, (int i) => levelConfig.Value.StarCond(i));
			}
			item.SetUIActive(data.ShowReward.GetValueOrDefault());
			if (data.ShowReward.GetValueOrDefault())
			{
				int rewardDropId = data.RewardDropId ?? levelConfig.Value.FirstClearDropId;
				this.RefreshFirstRewardInfo(rewardDropId);
			}
			item2.SetUIActive(data.ShowScore.GetValueOrDefault());
			if (data.ShowScore.GetValueOrDefault())
			{
				int valueOrDefault = this.Data.LevelScore.GetValueOrDefault();
				this.RefreshScoreInfo(valueOrDefault, levelConfig.Value.ScoreLevelRewardLength, (int i) => levelConfig.Value.ScoreLevelReward(i).Value.Key, (int i) => levelConfig.Value.ScoreLevelReward(i).Value.Value);
			}
			if (data.RewardClearTitle != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, data.RewardClearTitle, Array.Empty<object>());
			}
			text3.SetUIActive(false);
			texture.SetUIActive(false);
			bool valueOrDefault2 = data.LevelLock.GetValueOrDefault();
			button.RootUIComp.Get().SetUIActive(!valueOrDefault2);
			this.LockTipsItem.SetUiActive(valueOrDefault2);
			this.LockTipsItem.SetTextByText(data.LevelLockTexts ?? "");
		}

		// Token: 0x0603FEEC RID: 261868 RVA: 0x00F783EC File Offset: 0x00F765EC
		private bool OnShowRewardReceivedCallBack(TItem data)
		{
			return this.Data != null && this.Data.RewardReceived.GetValueOrDefault();
		}

		// Token: 0x0603FEED RID: 261869 RVA: 0x00F78416 File Offset: 0x00F76616
		private void OnBtnEnemyDetailClick()
		{
			PinballController.Instance.OpenMonsterDetailView(this.Data.RealLevelId).Forget<bool>();
		}

		// Token: 0x0603FEEE RID: 261870 RVA: 0x00F78434 File Offset: 0x00F76634
		private void OnBtnConfirmClick()
		{
			PinballFormationViewData param = new PinballFormationViewData
			{
				LevelId = this.Data.LevelId
			};
			UiManager.Instance.OpenView(EUiViewName.PinballFormationView, param, null);
		}

		// Token: 0x0603FEEF RID: 261871 RVA: 0x00F7846C File Offset: 0x00F7666C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			string a = configParams[0];
			UUIItem uuiitem = null;
			if (!(a == "BtnGo"))
			{
				if (!(a == "BtnDetail"))
				{
					if (!(a == "Reward"))
					{
						if (!(a == "Scroll"))
						{
							if (a == "RewardProgress")
							{
								uuiitem = base.GetItem(3);
							}
						}
						else
						{
							uuiitem = base.GetItem(21);
						}
					}
					else
					{
						uuiitem = base.GetScrollViewWithScrollbar(10).RootUIComp;
					}
				}
				else
				{
					uuiitem = base.GetButton(12).RootUIComp.Get();
				}
			}
			else
			{
				uuiitem = base.GetButton(13).RootUIComp.Get();
			}
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04021588 RID: 136584
		[Nullable(2)]
		private IPinballLevelInfoData Data;

		// Token: 0x04021589 RID: 136585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> FirstRewardScroll;

		// Token: 0x0402158A RID: 136586
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballLevelInfoStarItem, IPinballLevelStarData> StarLayout;

		// Token: 0x0402158B RID: 136587
		private readonly List<PinballLevelInfoScoreItem> ScoreRewardItems = new List<PinballLevelInfoScoreItem>();

		// Token: 0x0402158C RID: 136588
		[Nullable(2)]
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0402158D RID: 136589
		[Nullable(2)]
		private FunctionalPanelConditionActivate LockTipsItem;

		// Token: 0x0200C552 RID: 50514
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B8D5 RID: 243925
			TxtTitle,
			// Token: 0x0403B8D6 RID: 243926
			TxtDesc,
			// Token: 0x0403B8D7 RID: 243927
			TxtSpecialExplan,
			// Token: 0x0403B8D8 RID: 243928
			BgScoreProgress,
			// Token: 0x0403B8D9 RID: 243929
			TxtScore,
			// Token: 0x0403B8DA RID: 243930
			SprBar1,
			// Token: 0x0403B8DB RID: 243931
			SprBar2,
			// Token: 0x0403B8DC RID: 243932
			ScoreRewardItem1,
			// Token: 0x0403B8DD RID: 243933
			ScoreRewardItem2,
			// Token: 0x0403B8DE RID: 243934
			ScoreRewardItem3,
			// Token: 0x0403B8DF RID: 243935
			FirstRewardScorll,
			// Token: 0x0403B8E0 RID: 243936
			FirstRewardItem,
			// Token: 0x0403B8E1 RID: 243937
			BtnEnemyDetail,
			// Token: 0x0403B8E2 RID: 243938
			BtnConfirm,
			// Token: 0x0403B8E3 RID: 243939
			StarLayout,
			// Token: 0x0403B8E4 RID: 243940
			StarItem,
			// Token: 0x0403B8E5 RID: 243941
			BgFirstReward,
			// Token: 0x0403B8E6 RID: 243942
			BgLockTips,
			// Token: 0x0403B8E7 RID: 243943
			TxtRewardClearTitleName,
			// Token: 0x0403B8E8 RID: 243944
			TxtRewardClearDoing,
			// Token: 0x0403B8E9 RID: 243945
			TexRewardClearFinish,
			// Token: 0x0403B8EA RID: 243946
			ItemScrollView
		}
	}
}
