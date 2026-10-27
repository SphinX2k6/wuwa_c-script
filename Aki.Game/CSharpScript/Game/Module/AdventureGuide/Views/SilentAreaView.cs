using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005EE9 RID: 24297
	[NullableContext(2)]
	[Nullable(0)]
	public class SilentAreaView : UiTabViewBase
	{
		// Token: 0x0603DBE8 RID: 252904 RVA: 0x00EEC3E4 File Offset: 0x00EEA5E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnDetectClickFunction));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnBoPianMapLinkClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DBE9 RID: 252905 RVA: 0x00EEC72E File Offset: 0x00EEA92E
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, 18);
		}

		// Token: 0x0603DBEA RID: 252906 RVA: 0x00EEC744 File Offset: 0x00EEA944
		protected override UniTask OnBeforeStartAsync()
		{
			SilentAreaView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SilentAreaView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DBEB RID: 252907 RVA: 0x00EEC788 File Offset: 0x00EEA988
		protected override void OnStart()
		{
			this.DetectLoopScroll = new LoopScrollView<SilentAreaItem, ISilentAreaDetectionDynamicData>(base.GetLoopScrollViewComponent(10), base.GetItem(20).GetOwner() as AUIBaseActor, delegate()
			{
				SilentAreaItem silentAreaItem = new SilentAreaItem();
				silentAreaItem.BindCallback(new Action<int, UUIExtendToggle>(this.RefreshByDetectingId));
				return silentAreaItem;
			}, false);
			this.RewardLayout = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(11), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null);
			if (this.InteractionComp == null)
			{
				this.InteractionComp = (base.GetButton(0).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
			}
			this.BoPianViewerItem.RefreshTemp(ConfigCommonParamById.GetIntConfig("BoPianId").Value, null);
			this.BoPianViewerItem.SetButtonActive(false);
			AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
			int? num = (adventureGuideViewOpenData.OpenTabViewName == EUiTabViewName.DisposableChallengeView) ? adventureGuideViewOpenData.OpenParam : null;
			if (!AdventureGuideModel.Instance.GetSilentAreaConfVaild(num.GetValueOrDefault()))
			{
				num = null;
			}
			List<ISilentAreaDetectionDynamicData> list;
			if (num != null)
			{
				AdventureGuideModel.Instance.SetCurDetectingSilentAreaConfId(num.Value);
				list = AdventureGuideController.Instance.GetShowSilentAreasList(null, new int?(num.Value)).ToList<ISilentAreaDetectionDynamicData>();
			}
			else
			{
				list = AdventureGuideController.Instance.GetShowSilentAreasList(new int?(0), null).ToList<ISilentAreaDetectionDynamicData>();
			}
			list.Sort((ISilentAreaDetectionDynamicData a, ISilentAreaDetectionDynamicData b) => a.SilentAreaDetectionData.Conf.Id - b.SilentAreaDetectionData.Conf.Id);
			AdventureGuideModel.Instance.CurrentSilentId = (num ?? list[0].SilentAreaDetectionData.Conf.Id);
			this.DetectItemList = list;
			this.DetectLoopScroll.ReloadData(list, false);
			this.JumpToTarget(AdventureGuideModel.Instance.CurrentSilentId);
		}

		// Token: 0x0603DBEC RID: 252908 RVA: 0x00EEC988 File Offset: 0x00EEAB88
		[NullableContext(1)]
		private ILayoutItem<CommonItemSmallItemGrid> OnRewardLayoutUpdater(object tempData, UUIItem uiItem, int index)
		{
			RewardTuple rewardTuple = (RewardTuple)tempData;
			CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
			commonItemSmallItemGrid.Initialize(uiItem.GetOwner());
			commonItemSmallItemGrid.RefreshByConfigId(rewardTuple.Id, rewardTuple.Num, rewardTuple, false, false);
			commonItemSmallItemGrid.SetReceivedVisible(rewardTuple.Received);
			return new LayoutItem<CommonItemSmallItemGrid>
			{
				Key = index,
				Value = commonItemSmallItemGrid
			};
		}

		// Token: 0x0603DBED RID: 252909 RVA: 0x00EEC9E8 File Offset: 0x00EEABE8
		protected override void OnBeforeDestroy()
		{
			if (this.RewardLayout != null)
			{
				this.RewardLayout.ClearChildren();
				this.RewardLayout = null;
			}
			if (this.DetectLoopScroll != null)
			{
				this.DetectLoopScroll.ClearGridProxies();
				this.DetectLoopScroll = null;
			}
			if (this.BoPianViewerItem != null)
			{
				this.BoPianViewerItem.Destroy(null);
				this.BoPianViewerItem = null;
			}
		}

		// Token: 0x0603DBEE RID: 252910 RVA: 0x00EECA44 File Offset: 0x00EEAC44
		[NullableContext(1)]
		private unsafe void RefreshByDetectingId(int id, UUIExtendToggle toggle)
		{
			if (this.CurrentResultToggle != null && this.CurrentResultToggle != toggle)
			{
				this.CurrentResultToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentResultToggle = toggle;
			AdventureGuideModel.Instance.CurrentSilentId = id;
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(id);
			this.CurShowingSilentAreaId = id;
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(1);
			string name = silentAreaDetectData.Conf.Name;
			UUIText text3 = base.GetText(17);
			text3.SetUIActive(silentAreaDetectData.IsLock);
			base.GetButton(0).RootUIComp.Get().SetUIActive(!silentAreaDetectData.IsLock);
			if (silentAreaDetectData.IsLock)
			{
				LguiUtil.Instance.SetLocalText(text2, "Unknown", Array.Empty<object>());
				int lockCon = silentAreaDetectData.Conf.LockCon;
				if (lockCon != 0)
				{
					ConditionGroup? config = ConfigConditionGroupById.GetConfig(lockCon, true);
					LguiUtil.Instance.SetLocalTextNew(text3, config.Value.HintText, Array.Empty<object>());
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text2, name, Array.Empty<object>());
				int num = 0;
				Span<int> levelPlayListBytes = silentAreaDetectData.Conf.GetLevelPlayListBytes();
				for (int i = 0; i < levelPlayListBytes.Length; i++)
				{
					int id2 = *levelPlayListBytes[i];
					int levelOfLevelPlay = AdventureGuideModel.Instance.GetLevelOfLevelPlay(id2);
					if (levelOfLevelPlay > num)
					{
						num = levelOfLevelPlay;
					}
				}
			}
			string markAreaText = AdventureGuideController.Instance.GetMarkAreaText(silentAreaDetectData.Conf.MarkId);
			if (markAreaText == "")
			{
				text.SetUIActive(false);
			}
			else
			{
				text.SetUIActive(true);
				text.SetText(markAreaText, true);
			}
			UUIItem item = base.GetItem(7);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), AdventureGuideConfig.Instance.GetSecondaryGuideDataTextById(3), Array.Empty<object>());
			UUIItem item2 = base.GetItem(6);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), AdventureGuideConfig.Instance.GetSecondaryGuideDataTextById(2), Array.Empty<object>());
			UUIItem item3 = base.GetItem(5);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), AdventureGuideConfig.Instance.GetSecondaryGuideDataTextById(1), Array.Empty<object>());
			switch (silentAreaDetectData.Conf.DangerType)
			{
			case 1:
				item.SetUIActive(true);
				item2.SetUIActive(false);
				item3.SetUIActive(false);
				break;
			case 2:
				item.SetUIActive(false);
				item2.SetUIActive(true);
				item3.SetUIActive(false);
				break;
			case 3:
				item.SetUIActive(false);
				item2.SetUIActive(false);
				item3.SetUIActive(true);
				break;
			}
			UUITexture texture = base.GetTexture(4);
			UUIItem item4 = base.GetItem(12);
			UUIText text4 = base.GetText(13);
			string textStringId;
			if (silentAreaDetectData.IsLock)
			{
				textStringId = silentAreaDetectData.Conf.AttributesDescriptionLock;
				texture.SetUIActive(false);
				item4.SetUIActive(true);
				this.InteractionComp.SetInteractable(false);
				LguiUtil.Instance.SetLocalText(text4, "UnDiscovered", Array.Empty<object>());
			}
			else
			{
				textStringId = silentAreaDetectData.Conf.AttributesDescriptionUnlock;
				item4.SetUIActive(false);
				texture.SetUIActive(true);
				this.InteractionComp.SetInteractable(true);
				LguiUtil.Instance.SetLocalText(text4, "Detect", Array.Empty<object>());
				base.SetTextureByPath(silentAreaDetectData.Conf.TemporaryIconUnLock, texture, null, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
			UUIText text5 = base.GetText(8);
			text5.SetUIActive(!silentAreaDetectData.IsLock);
			if (!silentAreaDetectData.IsLock)
			{
				text5.SetText(AdventureGuideModel.Instance.GetCostOfLevelPlay(silentAreaDetectData.Conf.LevelPlayList(0)).ToString(), true);
			}
			UUIText text6 = base.GetText(9);
			text6.SetUIActive(false);
			LguiUtil.Instance.SetLocalText(text6, "ReceivedCount", new <>z__ReadOnlySingleElementList<object>(""));
			this.BuildRewardList(silentAreaDetectData.Conf.ShowReward);
		}

		// Token: 0x0603DBEF RID: 252911 RVA: 0x00EECE68 File Offset: 0x00EEB068
		public void BuildRewardList(int dropId)
		{
			Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(dropId);
			List<RewardTuple> list = new List<RewardTuple>();
			foreach (int num in dropShowInfo.Keys)
			{
				RewardTuple item = new RewardTuple
				{
					Id = num,
					Num = new int?(dropShowInfo[num]),
					Received = false
				};
				list.Add(item);
			}
			this.RewardLayout.RefreshByData<RewardTuple>(list, null);
		}

		// Token: 0x0603DBF0 RID: 252912 RVA: 0x00EECF0C File Offset: 0x00EEB10C
		private void OnBoPianMapLinkClick()
		{
			UiManager.Instance.ResetToBattleView(delegate(bool _)
			{
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkId = new int?(ConfigCommonParamById.GetIntConfig("BoPianExchangeMarkId").Value),
					MarkType = EMarkType.NPC,
					OpenFogId = new int?(0)
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			});
		}

		// Token: 0x0603DBF1 RID: 252913 RVA: 0x00EECF38 File Offset: 0x00EEB138
		private void OnDetectClickFunction()
		{
			Log.Instance.Info(ELogModule.AdventureGuide, ELogAuthor.LJQ, "点击无音区探测按钮 SilentAreaView", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.CurShowingSilentAreaId);
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), this.CurShowingSilentAreaId);
		}

		// Token: 0x0603DBF2 RID: 252914 RVA: 0x00EECFC0 File Offset: 0x00EEB1C0
		public void JumpToTarget(int target)
		{
			int num = 0;
			foreach (ISilentAreaDetectionDynamicData silentAreaDetectionDynamicData in this.DetectItemList)
			{
				if (target == silentAreaDetectionDynamicData.SilentAreaDetectionData.Conf.Id)
				{
					this.DetectLoopScroll.DeselectCurrentGridProxy(false);
					this.DetectLoopScroll.ScrollToGridIndex(num, true);
					this.DetectLoopScroll.SelectGridProxy(num, false);
					break;
				}
				num++;
			}
		}

		// Token: 0x0402043F RID: 132159
		private const int SILENT_HELP = 18;

		// Token: 0x04020440 RID: 132160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<CommonItemSmallItemGrid> RewardLayout;

		// Token: 0x04020441 RID: 132161
		private CommonCurrencyItem BoPianViewerItem;

		// Token: 0x04020442 RID: 132162
		private int CurShowingSilentAreaId;

		// Token: 0x04020443 RID: 132163
		private UUIInteractionGroup InteractionComp;

		// Token: 0x04020444 RID: 132164
		private UUIExtendToggle CurrentResultToggle;

		// Token: 0x04020445 RID: 132165
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SilentAreaItem, ISilentAreaDetectionDynamicData> DetectLoopScroll;

		// Token: 0x04020446 RID: 132166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ISilentAreaDetectionDynamicData> DetectItemList;
	}
}
