using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200243F RID: 9279
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigNewView : UiTabViewBase
{
	// Token: 0x060129A8 RID: 76200 RVA: 0x00496E68 File Offset: 0x00495068
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedToggleDiscard));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedApplyPlan));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedRecommendAll));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickedEdit));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedDelete));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060129A9 RID: 76201 RVA: 0x00497171 File Offset: 0x00495371
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnPhantomConfigManagerDataUpdate, new Action<bool>(this.OnEmitUpdate));
	}

	// Token: 0x060129AA RID: 76202 RVA: 0x0049718F File Offset: 0x0049538F
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnPhantomConfigManagerDataUpdate, new Action<bool>(this.OnEmitUpdate));
	}

	// Token: 0x060129AB RID: 76203 RVA: 0x004971B0 File Offset: 0x004953B0
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigNewView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigNewView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060129AC RID: 76204 RVA: 0x004971F4 File Offset: 0x004953F4
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(base.GetItem(14));
		this.ScrollConfig = new LoopScrollView<PhantomManagerConfigNewFetterItem, IPhantomManagerFetterInfo>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<PhantomManagerConfigNewFetterItem>(this.CreateConfigItem), true);
		this.ScrollSetting = new GenericScrollViewNew<PhantomManagerConfigNewSettingItem, IPhantomManagerConfigNewSettingInfo>(base.GetScrollViewWithScrollbar(10), new Func<PhantomManagerConfigNewSettingItem>(this.CreateSettingTitleItem), null, false, null);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(this.ConfigData.DownFiveStarSwitch ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		this.InitElementList();
		this.RefreshNormalState(true);
	}

	// Token: 0x060129AD RID: 76205 RVA: 0x0049729C File Offset: 0x0049549C
	protected override void OnBeforeShow()
	{
		this.FetterGroupInfoDataList.Clear();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (PhantomItemData phantomItemData in InventoryModel.Instance.GetPhantomItemDataList())
		{
			int id = phantomItemData.GetFetterGroupConfig().Value.Id;
			dictionary[id] = dictionary.GetValueOrDefault(id, 0) + 1;
		}
		foreach (int num in this.FetterGroupDataList)
		{
			this.FetterGroupInfoDataList.Add(new PhantomManagerFetterInfo
			{
				FetterId = num,
				Count = dictionary.GetValueOrDefault(num, 0)
			});
		}
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, true);
	}

	// Token: 0x060129AE RID: 76206 RVA: 0x0049739C File Offset: 0x0049559C
	protected void InitElementList()
	{
		Dictionary<int, PhantomFetterGroup> tmpMap = new Dictionary<int, PhantomFetterGroup>();
		foreach (PhantomFetterGroup value in PhantomBattleConfig.Instance.GetPhantomFetterGroupList())
		{
			this.FetterGroupDataList.Add(value.Id);
			tmpMap[value.Id] = value;
		}
		this.FetterGroupDataList.Sort((int a, int b) => tmpMap[b].SortId - tmpMap[a].SortId);
		if (this.FetterGroupDataList.Count > 0)
		{
			this.CurrentSelectId = this.FetterGroupDataList[0];
		}
	}

	// Token: 0x060129AF RID: 76207 RVA: 0x00497454 File Offset: 0x00495654
	protected void RefreshNormalState(bool isSelectOther = false)
	{
		if (this.CurrentSelectId < 0)
		{
			return;
		}
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentSelectId);
		base.SetTextureByPath(fetterGroupById.FetterElementPath, base.GetTexture(6), null, null);
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(fetterGroupById.FetterGroupName);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "PhantomProject_PlanName", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
		this.ScrollSetting.RefreshByData(this.GetDetailDataList(false), null, true);
		bool fetterConfigIsOpen = this.ConfigData.GetFetterConfigIsOpen(this.CurrentSelectId);
		UUITexture texture = base.GetTexture(8);
		if (texture != null)
		{
			texture.SetUIActive(!fetterConfigIsOpen);
		}
		this.SetActivatePanelState(fetterConfigIsOpen, isSelectOther);
		ButtonItem fetterUseBtn = this.FetterUseBtn;
		if (fetterUseBtn == null)
		{
			return;
		}
		fetterUseBtn.SetLocalTextNew(fetterConfigIsOpen ? "PhantomProject_ClosePlan_Title" : "PhantomProject_StartPlan_Title", Array.Empty<object>());
	}

	// Token: 0x060129B0 RID: 76208 RVA: 0x00497544 File Offset: 0x00495744
	protected List<IPhantomManagerConfigNewSettingInfo> GetDetailDataList(bool needRefresh = false)
	{
		List<IPhantomManagerConfigNewSettingInfo> result;
		if (this.FetterDataMap.TryGetValue(this.CurrentSelectId, out result) && !needRefresh)
		{
			return result;
		}
		List<IPhantomManagerConfigNewSettingInfo> list = new List<IPhantomManagerConfigNewSettingInfo>();
		int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(this.CurrentSelectId);
		HashSet<int> hashSet = new HashSet<int>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (int monsterId in fetterGroupMonsterIdArray)
		{
			PhantomItem phantomItem = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId)[0];
			int cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(phantomItem.Rarity).Value.Cost;
			hashSet.Add(cost);
			dictionary[cost] = 0;
			if (!dictionary2.ContainsKey(cost))
			{
				dictionary2[cost] = phantomItem.ItemId;
			}
		}
		foreach (PhantomItemData phantomItemData in InventoryModel.Instance.GetPhantomItemDataList())
		{
			if (phantomItemData.GetFetterGroupConfig().Value.Id == this.CurrentSelectId)
			{
				int cost2 = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.GetUniqueId()).GetCost();
				dictionary[cost2] = dictionary.GetValueOrDefault(cost2, 0) + 1;
			}
		}
		foreach (int num in from o in hashSet
		orderby o descending
		select o)
		{
			list.Add(new PhantomManagerConfigNewSettingInfo
			{
				FetterId = this.CurrentSelectId,
				Cost = num,
				Count = dictionary.GetValueOrDefault(num, 0),
				ItemId = dictionary2[num],
				IsEdit = false
			});
		}
		this.FetterDataMap[this.CurrentSelectId] = list;
		return list;
	}

	// Token: 0x060129B1 RID: 76209 RVA: 0x00497758 File Offset: 0x00495958
	private void SetActivatePanelState(bool isVisible, bool noAnim)
	{
		if (isVisible)
		{
			if (this.LevelSequence.IsPlayingSequence("Off"))
			{
				this.LevelSequence.StopSequenceByKey("Off", false, false);
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (!noAnim)
				{
					UUIItem item = this.GetItem(15);
					if (item != null)
					{
						item.SetUIActive(false);
					}
					this.LevelSequence.PlayOrReplaySequenceByName("Press", false, null);
					return;
				}
				UUIItem item2 = this.GetItem(9);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = this.GetItem(15);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(true);
			}, null, null);
			return;
		}
		if (this.LevelSequence.IsPlayingSequence("Press"))
		{
			this.LevelSequence.StopSequenceByKey("Press", false, false);
		}
		TimerSystem.Instance.Next(delegate(float _)
		{
			if (!noAnim)
			{
				UUIItem item = this.GetItem(15);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.LevelSequence.PlayOrReplaySequenceByName("Off", false, null);
				return;
			}
			UUIItem item2 = this.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = this.GetItem(15);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}, null, null);
	}

	// Token: 0x060129B2 RID: 76210 RVA: 0x004977F8 File Offset: 0x004959F8
	private void OnClickedToggleDiscard(EToggleState state)
	{
		bool downFiveStarSwitch = this.ConfigData.DownFiveStarSwitch;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(downFiveStarSwitch ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, true);
		}
		PhantomDiscardPlanAutoDiscardFiveReport logData = new PhantomDiscardPlanAutoDiscardFiveReport();
		logData.i_type = (downFiveStarSwitch ? 2 : 1);
		if (!downFiveStarSwitch)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomConfigAutoDiscardNot5Confirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				UUIExtendToggle extendToggle2 = this.GetExtendToggle(0);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.UpdateDiscardToggleState();
				LogReportController.Instance.LogReport(logData);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.UpdateDiscardToggleState();
		LogReportController.Instance.LogReport(logData);
	}

	// Token: 0x060129B3 RID: 76211 RVA: 0x004978B9 File Offset: 0x00495AB9
	private void UpdateDiscardToggleState()
	{
		PhantomBattleController.Instance.RequestPhBaPlanSetFiveStarSwitch().ContinueWith(delegate(bool value)
		{
			if (value)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(this.ConfigData.DownFiveStarSwitch ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}).Forget();
	}

	// Token: 0x060129B4 RID: 76212 RVA: 0x004978DB File Offset: 0x00495ADB
	private PhantomManagerConfigNewFetterItem CreateConfigItem()
	{
		return new PhantomManagerConfigNewFetterItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
		};
	}

	// Token: 0x060129B5 RID: 76213 RVA: 0x00497906 File Offset: 0x00495B06
	private PhantomManagerConfigNewSettingItem CreateSettingTitleItem()
	{
		return new PhantomManagerConfigNewSettingItem();
	}

	// Token: 0x060129B6 RID: 76214 RVA: 0x0049790D File Offset: 0x00495B0D
	private bool GetToggleStateSelected(int awardId)
	{
		return this.CurrentSelectId == awardId;
	}

	// Token: 0x060129B7 RID: 76215 RVA: 0x00497918 File Offset: 0x00495B18
	private void OnToggleStateChange(int id)
	{
		this.CurrentSelectId = id;
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, false);
		this.RefreshNormalState(true);
	}

	// Token: 0x060129B8 RID: 76216 RVA: 0x0049793C File Offset: 0x00495B3C
	private void OnClickedEdit()
	{
		base.GetLoopScrollViewComponent(1).StopMovement();
		this.ScrollConfig.ScrollToGridIndex(this.FetterGroupDataList.IndexOf(this.CurrentSelectId), true);
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		IPhantomManagerFetterInfo phantomManagerFetterInfo = this.FetterGroupInfoDataList.FirstOrDefault((IPhantomManagerFetterInfo o) => o.FetterId == this.CurrentSelectId);
		int count = (phantomManagerFetterInfo != null) ? phantomManagerFetterInfo.Count : 0;
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigEditPopItem, new PhantomManagerEditPopInfo
		{
			FetterId = this.CurrentSelectId,
			Count = count,
			DataList = this.GetDetailDataList(false),
			CloseCb = new Action(this.OnClosedEdit)
		}, null);
	}

	// Token: 0x060129B9 RID: 76217 RVA: 0x004979F1 File Offset: 0x00495BF1
	private void OnEmitUpdate(bool needScroll)
	{
		if (needScroll)
		{
			this.CurrentSelectId = this.FetterGroupDataList[0];
			this.ScrollConfig.ScrollToGridIndex(0, true);
		}
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, false);
		this.RefreshNormalState(false);
	}

	// Token: 0x060129BA RID: 76218 RVA: 0x00497A30 File Offset: 0x00495C30
	private void OnClickedDelete()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigResetPopItem, new Action(this.OnDeleteSuccess), null);
	}

	// Token: 0x060129BB RID: 76219 RVA: 0x00497A4E File Offset: 0x00495C4E
	private void OnDeleteSuccess()
	{
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, true);
		this.RefreshNormalState(false);
	}

	// Token: 0x060129BC RID: 76220 RVA: 0x00497A6C File Offset: 0x00495C6C
	private void OnClickedApplyPlan()
	{
		IPhantomManagerApplySettingDetailInfo phantomPlanMatchApplyData = this.ConfigData.GetPhantomPlanMatchApplyData();
		if (phantomPlanMatchApplyData.DiscardList.Count == 0 && phantomPlanMatchApplyData.LockList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_Reorganize_Des_5", Array.Empty<object>());
		}
		else
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigRemovePopItem, phantomPlanMatchApplyData, null);
		}
		this.ConfigData.DoLogReport(new List<int>
		{
			this.CurrentSelectId
		}, false);
	}

	// Token: 0x060129BD RID: 76221 RVA: 0x00497AE4 File Offset: 0x00495CE4
	private void OnClickedRecommendAll()
	{
		bool flag = false;
		foreach (int num in this.FetterGroupDataList)
		{
			flag = (this.ConfigData.SetFetterConfigRecommend(num) || flag);
			flag = (!this.ConfigData.GetFetterConfigIsOpen(num) || flag);
		}
		if (!flag)
		{
			this.ConfigData.DoCacheDataUpdate(false);
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_UsePreparatoryPlan_Des_1", Array.Empty<object>());
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomConfigApplyPreRecommendConfirm);
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleText = PublicUtil.Instance.GetConfigTextByKey("PhantomProject_UsePreparatoryPlan_Des_3");
		this.ConfirmBoxRecommendApplyPlan = false;
		confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnRecommendAllToggle));
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			this.ConfigData.DoCacheDataUpdate(false);
		};
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			PhantomBattleController.Instance.RequestPhBaPlanSaveUsePlan(false, this.FetterGroupDataList.ToHashSet<int>()).ContinueWith(delegate(bool value)
			{
				if (!value)
				{
					this.ConfigData.DoCacheDataUpdate(false);
				}
				else if (this.ConfirmBoxRecommendApplyPlan)
				{
					IPhantomManagerApplySettingDetailInfo phantomPlanMatchApplyData = this.ConfigData.GetPhantomPlanMatchApplyData();
					this.ConfigData.DoApplyOpera(phantomPlanMatchApplyData).Forget<bool>();
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_UsePreparatoryPlan_Des_4", Array.Empty<object>());
				PhantomBattleController.Instance.RequestPhBaPlanSetPlanStatus(this.FetterGroupDataList, true).ContinueWith(delegate(bool _)
				{
					this.RefreshNormalState(false);
					this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, false);
					this.ConfigData.DoLogReport(this.FetterGroupDataList, true);
				}).Forget();
			}).Forget();
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060129BE RID: 76222 RVA: 0x00497BF4 File Offset: 0x00495DF4
	private void OnRecommendAllToggle(bool toggleState)
	{
		this.ConfirmBoxRecommendApplyPlan = toggleState;
	}

	// Token: 0x060129BF RID: 76223 RVA: 0x00497BFD File Offset: 0x00495DFD
	private void OnClosedEdit()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x060129C0 RID: 76224 RVA: 0x00497C14 File Offset: 0x00495E14
	private void OnClickedFetterUsed(int _)
	{
		int curFetter = this.CurrentSelectId;
		bool fetterConfigIsOpen = this.ConfigData.GetFetterConfigIsOpen(curFetter);
		PhantomBattleController.Instance.RequestPhBaPlanSetPlanStatus(new List<int>
		{
			curFetter
		}, !fetterConfigIsOpen).ContinueWith(delegate(bool value)
		{
			if (!value)
			{
				return;
			}
			bool fetterConfigIsOpen2 = this.ConfigData.GetFetterConfigIsOpen(curFetter);
			if (curFetter == this.CurrentSelectId)
			{
				this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, false);
				UUITexture texture = this.GetTexture(8);
				if (texture != null)
				{
					texture.SetUIActive(!fetterConfigIsOpen2);
				}
				this.SetActivatePanelState(fetterConfigIsOpen2, false);
				ButtonItem fetterUseBtn = this.FetterUseBtn;
				if (fetterUseBtn != null)
				{
					fetterUseBtn.SetLocalTextNew(fetterConfigIsOpen2 ? "PhantomProject_ClosePlan_Title" : "PhantomProject_StartPlan_Title", Array.Empty<object>());
				}
				ScrollingTipsController.Instance.ShowTipsByTextId(fetterConfigIsOpen2 ? "PhantomProject_StartPlan_Des_1" : "PhantomProject_ClosePlan_Des_1", Array.Empty<object>());
			}
		}).Forget();
	}

	// Token: 0x04008C44 RID: 35908
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomManagerConfigNewFetterItem, IPhantomManagerFetterInfo> ScrollConfig;

	// Token: 0x04008C45 RID: 35909
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PhantomManagerConfigNewSettingItem, IPhantomManagerConfigNewSettingInfo> ScrollSetting;

	// Token: 0x04008C46 RID: 35910
	private readonly Dictionary<int, List<IPhantomManagerConfigNewSettingInfo>> FetterDataMap = new Dictionary<int, List<IPhantomManagerConfigNewSettingInfo>>();

	// Token: 0x04008C47 RID: 35911
	private readonly List<int> FetterGroupDataList = new List<int>();

	// Token: 0x04008C48 RID: 35912
	private readonly List<IPhantomManagerFetterInfo> FetterGroupInfoDataList = new List<IPhantomManagerFetterInfo>();

	// Token: 0x04008C49 RID: 35913
	private int CurrentSelectId = -1;

	// Token: 0x04008C4A RID: 35914
	protected PhantomManagerConfigData ConfigData = new PhantomManagerConfigData();

	// Token: 0x04008C4B RID: 35915
	[Nullable(2)]
	protected ButtonItem FetterUseBtn;

	// Token: 0x04008C4C RID: 35916
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008C4D RID: 35917
	private bool ConfirmBoxRecommendApplyPlan;

	// Token: 0x020089C5 RID: 35269
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402CC26 RID: 183334
		ToggleAutoDiscard,
		// Token: 0x0402CC27 RID: 183335
		LoopScrollElement,
		// Token: 0x0402CC28 RID: 183336
		ElementItem,
		// Token: 0x0402CC29 RID: 183337
		BtnLeft1,
		// Token: 0x0402CC2A RID: 183338
		BtnLeft2,
		// Token: 0x0402CC2B RID: 183339
		BtnDelete,
		// Token: 0x0402CC2C RID: 183340
		TexEchoIcon,
		// Token: 0x0402CC2D RID: 183341
		TxtPlanName,
		// Token: 0x0402CC2E RID: 183342
		TexTitleBg,
		// Token: 0x0402CC2F RID: 183343
		PanelActivation,
		// Token: 0x0402CC30 RID: 183344
		ScrollSetting,
		// Token: 0x0402CC31 RID: 183345
		CostGroupItem,
		// Token: 0x0402CC32 RID: 183346
		PanelBtnOverview,
		// Token: 0x0402CC33 RID: 183347
		BtnEdit,
		// Token: 0x0402CC34 RID: 183348
		BtnActivate,
		// Token: 0x0402CC35 RID: 183349
		PanelActivationStatic
	}
}
