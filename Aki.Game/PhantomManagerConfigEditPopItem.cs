using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002429 RID: 9257
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigEditPopItem : UiViewBase
{
	// Token: 0x0601290E RID: 76046 RVA: 0x00493391 File Offset: 0x00491591
	public PhantomManagerConfigEditPopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601290F RID: 76047 RVA: 0x004933BC File Offset: 0x004915BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedEditClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickedSave));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickedReset));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedRecommend));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012910 RID: 76048 RVA: 0x0049361C File Offset: 0x0049181C
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigEditPopItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigEditPopItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012911 RID: 76049 RVA: 0x00493660 File Offset: 0x00491860
	protected override void OnStart()
	{
		this.LeftInfoItem.Refresh(new PhantomManagerFetterInfo
		{
			FetterId = this.CurrentFetterId,
			Count = this.FetterCount
		}, false, 0);
		this.ScrollSetting.RefreshByData(this.CurData, null, true);
		this.RefreshState();
	}

	// Token: 0x06012912 RID: 76050 RVA: 0x004936B0 File Offset: 0x004918B0
	protected void RefreshState()
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.CurrentFetterId);
		base.SetTextureByPath(fetterGroupById.FetterElementPath, base.GetTexture(5), null, null);
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(fetterGroupById.FetterGroupName);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "PhantomProject_PlanName", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
		bool fetterConfigIsOpen = this.ConfigData.GetFetterConfigIsOpen(this.CurrentFetterId);
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(!fetterConfigIsOpen);
		}
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(fetterConfigIsOpen);
	}

	// Token: 0x06012913 RID: 76051 RVA: 0x00493754 File Offset: 0x00491954
	private void OnCloseMask(bool needApply)
	{
		this.ConfigData.DoCacheDataUpdate(needApply);
		IPhantomManagerEditPopInfo phantomManagerEditPopInfo = this.OpenParam as IPhantomManagerEditPopInfo;
		if (phantomManagerEditPopInfo != null)
		{
			Action closeCb = phantomManagerEditPopInfo.CloseCb;
			if (closeCb != null)
			{
				closeCb();
			}
		}
		base.CloseMe(null);
	}

	// Token: 0x06012914 RID: 76052 RVA: 0x0049378C File Offset: 0x0049198C
	private void ResetSinglePlan()
	{
		this.ConfigData.ResetFetterConfig(this.CurrentFetterId);
		foreach (PhantomManagerConfigNewSettingItem phantomManagerConfigNewSettingItem in this.ScrollSetting.GetScrollItemList())
		{
			phantomManagerConfigNewSettingItem.RefreshState(true, true);
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_OnePlanClean_Des_2", Array.Empty<object>());
	}

	// Token: 0x06012915 RID: 76053 RVA: 0x00493808 File Offset: 0x00491A08
	private void OnClickedEditClose()
	{
		if (!this.ConfigData.CheckDirty())
		{
			this.OnCloseMask(false);
			return;
		}
		if (this.ConfigData.ConfigViewEditCloseSelect == EPhantomManagerEditCloseState.Left)
		{
			this.OnCloseMask(false);
			return;
		}
		if (this.ConfigData.ConfigViewEditCloseSelect == EPhantomManagerEditCloseState.Right)
		{
			this.OnClickedSave();
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm);
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleText = PublicUtil.Instance.GetConfigTextByKey("PhantomProject_CommonText");
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.SetToggleFunction(delegate(bool value)
		{
			this.ConfirmBoxLoginTmpMap[EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm] = value;
		});
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
			this.OnCloseMask(false);
			bool? valueOrNull = this.ConfirmBoxLoginTmpMap.GetValueOrNull(EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm);
			if (valueOrNull != null && valueOrNull.Value)
			{
				this.ConfigData.ConfirmBoxLoginSet.Add(EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm);
				this.ConfigData.ConfigViewEditCloseSelect = EPhantomManagerEditCloseState.Left;
			}
		};
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.OnClickedSave();
			bool? valueOrNull = this.ConfirmBoxLoginTmpMap.GetValueOrNull(EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm);
			if (valueOrNull != null && valueOrNull.Value)
			{
				this.ConfigData.ConfirmBoxLoginSet.Add(EConfirmBoxConfigId.PhantomConfigSaveCloseEditConfirm);
				this.ConfigData.ConfigViewEditCloseSelect = EPhantomManagerEditCloseState.Right;
			}
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012916 RID: 76054 RVA: 0x004938D4 File Offset: 0x00491AD4
	private void OnClickedSave()
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhantomBattleConfigApplyPlanWhenSaved) as ServerStorageBoolean;
		bool needOpen = ((serverStorageBoolean != null) ? serverStorageBoolean.Get() : null).GetValueOrDefault();
		this.ConfigData.GetFetterConfigIsOpen(this.CurrentFetterId);
		PhantomBattleController instance = PhantomBattleController.Instance;
		bool isReset = false;
		HashSet<int> openIdSet;
		if (!needOpen)
		{
			openIdSet = new HashSet<int>();
		}
		else
		{
			(openIdSet = new HashSet<int>()).Add(this.CurrentFetterId);
		}
		instance.RequestPhBaPlanSaveUsePlan(isReset, openIdSet).ContinueWith(delegate(bool value)
		{
			if (value)
			{
				this.ConfigData.DoCacheDataUpdate(true);
				ScrollingTipsController.Instance.ShowTipsByTextId(needOpen ? "PhantomProject_OnePlanPreparatory_Des_4" : "PhantomProject_OnePlanPreparatory_Des_3", Array.Empty<object>());
				this.ConfigData.DoLogReport(new List<int>
				{
					this.CurrentFetterId
				}, false);
				EventSystem.Instance.Emit<bool>(EEventName.OnPhantomConfigManagerDataUpdate, false);
			}
			this.CloseMe(null);
			IPhantomManagerEditPopInfo phantomManagerEditPopInfo = this.OpenParam as IPhantomManagerEditPopInfo;
			if (phantomManagerEditPopInfo == null)
			{
				return;
			}
			Action closeCb = phantomManagerEditPopInfo.CloseCb;
			if (closeCb == null)
			{
				return;
			}
			closeCb();
		}).Forget();
	}

	// Token: 0x06012917 RID: 76055 RVA: 0x00493978 File Offset: 0x00491B78
	private void OnClickedReset()
	{
		EConfirmBoxConfigId confirmId = EConfirmBoxConfigId.PhantomConfigApplyClearPlanConfirm;
		if (this.ConfigData.ConfirmBoxLoginSet.Contains(confirmId))
		{
			this.ResetSinglePlan();
			return;
		}
		this.ConfirmBoxLoginTmpMap[confirmId] = false;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(confirmId);
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleText = PublicUtil.Instance.GetConfigTextByKey("PhantomProject_CommonText");
		confirmBoxDataNew.SetToggleFunction(delegate(bool value)
		{
			this.ConfirmBoxLoginTmpMap[confirmId] = value;
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.ResetSinglePlan();
			if (this.ConfirmBoxLoginTmpMap.GetValueOrNull(confirmId).Value)
			{
				this.ConfigData.ConfirmBoxLoginSet.Add(confirmId);
			}
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06012918 RID: 76056 RVA: 0x00493A2C File Offset: 0x00491C2C
	private void OnClickedRecommend()
	{
		if (!this.ConfigData.CheckEditFetterConfigRecommendDirty(this.CurrentFetterId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_UsePreparatoryPlan_Des_1", Array.Empty<object>());
			return;
		}
		this.ConfigData.SetFetterConfigRecommend(this.CurrentFetterId);
		foreach (PhantomManagerConfigNewSettingItem phantomManagerConfigNewSettingItem in this.ScrollSetting.GetScrollItemList())
		{
			phantomManagerConfigNewSettingItem.RefreshState(true, true);
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_OnePlanPreparatory_Des_2", Array.Empty<object>());
	}

	// Token: 0x06012919 RID: 76057 RVA: 0x00493AD4 File Offset: 0x00491CD4
	private PhantomManagerConfigNewSettingItem CreateSettingTitleItem()
	{
		return new PhantomManagerConfigNewSettingItem();
	}

	// Token: 0x04008BEE RID: 35822
	private readonly Dictionary<EConfirmBoxConfigId, bool> ConfirmBoxLoginTmpMap = new Dictionary<EConfirmBoxConfigId, bool>();

	// Token: 0x04008BEF RID: 35823
	private PhantomManagerConfigData ConfigData = new PhantomManagerConfigData();

	// Token: 0x04008BF0 RID: 35824
	private readonly List<IPhantomManagerConfigNewSettingInfo> CurData = new List<IPhantomManagerConfigNewSettingInfo>();

	// Token: 0x04008BF1 RID: 35825
	private int CurrentFetterId;

	// Token: 0x04008BF2 RID: 35826
	private int FetterCount;

	// Token: 0x04008BF3 RID: 35827
	[Nullable(2)]
	private PhantomConfigEditToggle PhantomConfigEditToggle;

	// Token: 0x04008BF4 RID: 35828
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PhantomManagerConfigNewSettingItem, IPhantomManagerConfigNewSettingInfo> ScrollSetting;

	// Token: 0x04008BF5 RID: 35829
	[Nullable(2)]
	private PhantomManagerConfigNewFetterItem LeftInfoItem;

	// Token: 0x020089A6 RID: 35238
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402CBA4 RID: 183204
		ToggleItem,
		// Token: 0x0402CBA5 RID: 183205
		BtnBack,
		// Token: 0x0402CBA6 RID: 183206
		ItemEchoSetPlan,
		// Token: 0x0402CBA7 RID: 183207
		TexTitleBg,
		// Token: 0x0402CBA8 RID: 183208
		PanelActivation,
		// Token: 0x0402CBA9 RID: 183209
		TexEchoIcon,
		// Token: 0x0402CBAA RID: 183210
		TxtPlanName,
		// Token: 0x0402CBAB RID: 183211
		ScrollSetting,
		// Token: 0x0402CBAC RID: 183212
		ItemInfo,
		// Token: 0x0402CBAD RID: 183213
		BtnReset,
		// Token: 0x0402CBAE RID: 183214
		BtnRecommend,
		// Token: 0x0402CBAF RID: 183215
		BtnSave
	}
}
