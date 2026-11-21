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

// Token: 0x0200190E RID: 6414
[NullableContext(1)]
[Nullable(0)]
public class PhantomManagerConfigEditPopItem : UiViewBase
{
	// Token: 0x0600FDC4 RID: 64964 RVA: 0x004A095E File Offset: 0x0049EB5E
	public PhantomManagerConfigEditPopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FDC5 RID: 64965 RVA: 0x004A0988 File Offset: 0x0049EB88
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

	// Token: 0x0600FDC6 RID: 64966 RVA: 0x004A0BE8 File Offset: 0x0049EDE8
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigEditPopItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigEditPopItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FDC7 RID: 64967 RVA: 0x004A0C2C File Offset: 0x0049EE2C
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

	// Token: 0x0600FDC8 RID: 64968 RVA: 0x004A0C7C File Offset: 0x0049EE7C
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

	// Token: 0x0600FDC9 RID: 64969 RVA: 0x004A0D20 File Offset: 0x0049EF20
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

	// Token: 0x0600FDCA RID: 64970 RVA: 0x004A0D58 File Offset: 0x0049EF58
	private void ResetSinglePlan()
	{
		this.ConfigData.ResetFetterConfig(this.CurrentFetterId);
		foreach (PhantomManagerConfigNewSettingItem phantomManagerConfigNewSettingItem in this.ScrollSetting.GetScrollItemList())
		{
			phantomManagerConfigNewSettingItem.RefreshState(true, true);
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_OnePlanClean_Des_2", Array.Empty<object>());
	}

	// Token: 0x0600FDCB RID: 64971 RVA: 0x004A0DD4 File Offset: 0x0049EFD4
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

	// Token: 0x0600FDCC RID: 64972 RVA: 0x004A0EA0 File Offset: 0x0049F0A0
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

	// Token: 0x0600FDCD RID: 64973 RVA: 0x004A0F44 File Offset: 0x0049F144
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

	// Token: 0x0600FDCE RID: 64974 RVA: 0x004A0FF8 File Offset: 0x0049F1F8
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

	// Token: 0x0600FDCF RID: 64975 RVA: 0x004A10A0 File Offset: 0x0049F2A0
	private PhantomManagerConfigNewSettingItem CreateSettingTitleItem()
	{
		return new PhantomManagerConfigNewSettingItem();
	}

	// Token: 0x04008D35 RID: 36149
	private readonly Dictionary<EConfirmBoxConfigId, bool> ConfirmBoxLoginTmpMap = new Dictionary<EConfirmBoxConfigId, bool>();

	// Token: 0x04008D36 RID: 36150
	private PhantomManagerConfigData ConfigData = new PhantomManagerConfigData();

	// Token: 0x04008D37 RID: 36151
	private readonly List<IPhantomManagerConfigNewSettingInfo> CurData = new List<IPhantomManagerConfigNewSettingInfo>();

	// Token: 0x04008D38 RID: 36152
	private int CurrentFetterId;

	// Token: 0x04008D39 RID: 36153
	private int FetterCount;

	// Token: 0x04008D3A RID: 36154
	[Nullable(2)]
	private PhantomConfigEditToggle PhantomConfigEditToggle;

	// Token: 0x04008D3B RID: 36155
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PhantomManagerConfigNewSettingItem, IPhantomManagerConfigNewSettingInfo> ScrollSetting;

	// Token: 0x04008D3C RID: 36156
	[Nullable(2)]
	private PhantomManagerConfigNewFetterItem LeftInfoItem;

	// Token: 0x02007B2D RID: 31533
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027EBA RID: 163514
		ToggleItem,
		// Token: 0x04027EBB RID: 163515
		BtnBack,
		// Token: 0x04027EBC RID: 163516
		ItemEchoSetPlan,
		// Token: 0x04027EBD RID: 163517
		TexTitleBg,
		// Token: 0x04027EBE RID: 163518
		PanelActivation,
		// Token: 0x04027EBF RID: 163519
		TexEchoIcon,
		// Token: 0x04027EC0 RID: 163520
		TxtPlanName,
		// Token: 0x04027EC1 RID: 163521
		ScrollSetting,
		// Token: 0x04027EC2 RID: 163522
		ItemInfo,
		// Token: 0x04027EC3 RID: 163523
		BtnReset,
		// Token: 0x04027EC4 RID: 163524
		BtnRecommend,
		// Token: 0x04027EC5 RID: 163525
		BtnSave
	}
}
