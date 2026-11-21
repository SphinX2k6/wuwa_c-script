using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001924 RID: 6436
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigNewView : UiTabViewBase
{
	// Token: 0x0600FE5E RID: 65118 RVA: 0x004A4434 File Offset: 0x004A2634
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

	// Token: 0x0600FE5F RID: 65119 RVA: 0x004A473D File Offset: 0x004A293D
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnPhantomConfigManagerDataUpdate, new Action<bool>(this.OnEmitUpdate));
	}

	// Token: 0x0600FE60 RID: 65120 RVA: 0x004A475B File Offset: 0x004A295B
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnPhantomConfigManagerDataUpdate, new Action<bool>(this.OnEmitUpdate));
	}

	// Token: 0x0600FE61 RID: 65121 RVA: 0x004A477C File Offset: 0x004A297C
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigNewView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigNewView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE62 RID: 65122 RVA: 0x004A47C0 File Offset: 0x004A29C0
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

	// Token: 0x0600FE63 RID: 65123 RVA: 0x004A4868 File Offset: 0x004A2A68
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

	// Token: 0x0600FE64 RID: 65124 RVA: 0x004A4968 File Offset: 0x004A2B68
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

	// Token: 0x0600FE65 RID: 65125 RVA: 0x004A4A20 File Offset: 0x004A2C20
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

	// Token: 0x0600FE66 RID: 65126 RVA: 0x004A4B10 File Offset: 0x004A2D10
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
		List<int> list2 = new List<int>(hashSet);
		list2.Sort((int a, int b) => b.CompareTo(a));
		foreach (int num in list2)
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

	// Token: 0x0600FE67 RID: 65127 RVA: 0x004A4D2C File Offset: 0x004A2F2C
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

	// Token: 0x0600FE68 RID: 65128 RVA: 0x004A4DCC File Offset: 0x004A2FCC
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

	// Token: 0x0600FE69 RID: 65129 RVA: 0x004A4E8D File Offset: 0x004A308D
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

	// Token: 0x0600FE6A RID: 65130 RVA: 0x004A4EAF File Offset: 0x004A30AF
	private PhantomManagerConfigNewFetterItem CreateConfigItem()
	{
		return new PhantomManagerConfigNewFetterItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnToggleStateChange)
		};
	}

	// Token: 0x0600FE6B RID: 65131 RVA: 0x004A4EDA File Offset: 0x004A30DA
	private PhantomManagerConfigNewSettingItem CreateSettingTitleItem()
	{
		return new PhantomManagerConfigNewSettingItem();
	}

	// Token: 0x0600FE6C RID: 65132 RVA: 0x004A4EE1 File Offset: 0x004A30E1
	private bool GetToggleStateSelected(int awardId)
	{
		return this.CurrentSelectId == awardId;
	}

	// Token: 0x0600FE6D RID: 65133 RVA: 0x004A4EEC File Offset: 0x004A30EC
	private void OnToggleStateChange(int id)
	{
		this.CurrentSelectId = id;
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, false);
		this.RefreshNormalState(true);
	}

	// Token: 0x0600FE6E RID: 65134 RVA: 0x004A4F10 File Offset: 0x004A3110
	private void OnClickedEdit()
	{
		base.GetLoopScrollViewComponent(1).StopMovement();
		this.ScrollConfig.ScrollToGridIndex(this.FetterGroupDataList.IndexOf(this.CurrentSelectId), true);
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		IPhantomManagerFetterInfo phantomManagerFetterInfo = this.FetterGroupInfoDataList.Find((IPhantomManagerFetterInfo o) => o.FetterId == this.CurrentSelectId);
		int count = (phantomManagerFetterInfo != null) ? phantomManagerFetterInfo.Count : 0;
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigEditPopItem, new PhantomManagerEditPopInfo
		{
			FetterId = this.CurrentSelectId,
			Count = count,
			DataList = this.GetDetailDataList(false),
			CloseCb = new Action(this.OnClosedEdit)
		}, null);
	}

	// Token: 0x0600FE6F RID: 65135 RVA: 0x004A4FC5 File Offset: 0x004A31C5
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

	// Token: 0x0600FE70 RID: 65136 RVA: 0x004A5004 File Offset: 0x004A3204
	private void OnClickedDelete()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManagerConfigResetPopItem, new Action(this.OnDeleteSuccess), null);
	}

	// Token: 0x0600FE71 RID: 65137 RVA: 0x004A5022 File Offset: 0x004A3222
	private void OnDeleteSuccess()
	{
		this.ScrollConfig.RefreshByData(this.FetterGroupInfoDataList, false, null, true);
		this.RefreshNormalState(false);
	}

	// Token: 0x0600FE72 RID: 65138 RVA: 0x004A5040 File Offset: 0x004A3240
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

	// Token: 0x0600FE73 RID: 65139 RVA: 0x004A50B8 File Offset: 0x004A32B8
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
			PhantomBattleController.Instance.RequestPhBaPlanSaveUsePlan(false, new HashSet<int>(this.FetterGroupDataList)).ContinueWith(delegate(bool value)
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

	// Token: 0x0600FE74 RID: 65140 RVA: 0x004A51C8 File Offset: 0x004A33C8
	private void OnRecommendAllToggle(bool toggleState)
	{
		this.ConfirmBoxRecommendApplyPlan = toggleState;
	}

	// Token: 0x0600FE75 RID: 65141 RVA: 0x004A51D1 File Offset: 0x004A33D1
	private void OnClosedEdit()
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x0600FE76 RID: 65142 RVA: 0x004A51E8 File Offset: 0x004A33E8
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

	// Token: 0x04008D8B RID: 36235
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhantomManagerConfigNewFetterItem, IPhantomManagerFetterInfo> ScrollConfig;

	// Token: 0x04008D8C RID: 36236
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PhantomManagerConfigNewSettingItem, IPhantomManagerConfigNewSettingInfo> ScrollSetting;

	// Token: 0x04008D8D RID: 36237
	private readonly Dictionary<int, List<IPhantomManagerConfigNewSettingInfo>> FetterDataMap = new Dictionary<int, List<IPhantomManagerConfigNewSettingInfo>>();

	// Token: 0x04008D8E RID: 36238
	private readonly List<int> FetterGroupDataList = new List<int>();

	// Token: 0x04008D8F RID: 36239
	private readonly List<IPhantomManagerFetterInfo> FetterGroupInfoDataList = new List<IPhantomManagerFetterInfo>();

	// Token: 0x04008D90 RID: 36240
	private int CurrentSelectId = -1;

	// Token: 0x04008D91 RID: 36241
	protected PhantomManagerConfigData ConfigData = new PhantomManagerConfigData();

	// Token: 0x04008D92 RID: 36242
	[Nullable(2)]
	protected ButtonItem FetterUseBtn;

	// Token: 0x04008D93 RID: 36243
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008D94 RID: 36244
	private bool ConfirmBoxRecommendApplyPlan;

	// Token: 0x02007B4C RID: 31564
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027F3C RID: 163644
		ToggleAutoDiscard,
		// Token: 0x04027F3D RID: 163645
		LoopScrollElement,
		// Token: 0x04027F3E RID: 163646
		ElementItem,
		// Token: 0x04027F3F RID: 163647
		BtnLeft1,
		// Token: 0x04027F40 RID: 163648
		BtnLeft2,
		// Token: 0x04027F41 RID: 163649
		BtnDelete,
		// Token: 0x04027F42 RID: 163650
		TexEchoIcon,
		// Token: 0x04027F43 RID: 163651
		TxtPlanName,
		// Token: 0x04027F44 RID: 163652
		TexTitleBg,
		// Token: 0x04027F45 RID: 163653
		PanelActivation,
		// Token: 0x04027F46 RID: 163654
		ScrollSetting,
		// Token: 0x04027F47 RID: 163655
		CostGroupItem,
		// Token: 0x04027F48 RID: 163656
		PanelBtnOverview,
		// Token: 0x04027F49 RID: 163657
		BtnEdit,
		// Token: 0x04027F4A RID: 163658
		BtnActivate,
		// Token: 0x04027F4B RID: 163659
		PanelActivationStatic
	}
}
