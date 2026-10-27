using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024CA RID: 9418
[NullableContext(1)]
[Nullable(0)]
public class VisionIdentifyView : UiTabViewBase
{
	// Token: 0x06012E97 RID: 77463 RVA: 0x004AD2C8 File Offset: 0x004AB4C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickLockToggle)),
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickDeprecateToggle))
		};
	}

	// Token: 0x06012E98 RID: 77464 RVA: 0x004AD3A0 File Offset: 0x004AB5A0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionIdentifyView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionIdentifyView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012E99 RID: 77465 RVA: 0x004AD3E4 File Offset: 0x004AB5E4
	protected override void OnStart()
	{
		this.VisionIdentifyCostItem = new VisionIdentifyCostItem(base.GetItem(1));
		this.VisionIdentifyCostItem.Init();
		this.VisionIdentifyCostItem.SetOnChangeValueCallBack(new Action(this.OnChangeSelectNumber));
		this.VisionNameText = new VisionNameText(base.GetText(3));
	}

	// Token: 0x06012E9A RID: 77466 RVA: 0x004AD437 File Offset: 0x004AB637
	private void OnChangeSelectNumber()
	{
		this.RefreshAttributePreview();
	}

	// Token: 0x06012E9B RID: 77467 RVA: 0x004AD43F File Offset: 0x004AB63F
	protected override void OnBeforeShow()
	{
		this.AddEvent();
		this.CurrentVisionUniqueId = (int)(this.ExtraParams ?? 0);
		this.CacheCurrentSlotState();
		this.RefreshView();
	}

	// Token: 0x06012E9C RID: 77468 RVA: 0x004AD470 File Offset: 0x004AB670
	private void AddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionIdentify, new Action(this.OnVisionIdentify));
		EventSystem.Instance.Add<int, IReadOnlyList<Aki.Protocol.PhantomPropInfo>>(EEventName.OnVisionIdentifyDoAnimation, new Action<int, IReadOnlyList<Aki.Protocol.PhantomPropInfo>>(this.OnVisionIdentifyDoAnimation));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		this.EventRegistState = true;
	}

	// Token: 0x06012E9D RID: 77469 RVA: 0x004AD4F4 File Offset: 0x004AB6F4
	private void RemoveEvent()
	{
		if (this.EventRegistState)
		{
			this.EventRegistState = false;
			EventSystem.Instance.Remove(EEventName.OnVisionIdentify, new Action(this.OnVisionIdentify));
			EventSystem.Instance.Remove(EEventName.OnVisionIdentifyDoAnimation, new Action<int, IReadOnlyList<Aki.Protocol.PhantomPropInfo>>(this.OnVisionIdentifyDoAnimation));
			EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}
	}

	// Token: 0x06012E9E RID: 77470 RVA: 0x004AD580 File Offset: 0x004AB780
	private void RefreshView()
	{
		this.RefreshMainAttribute();
		this.RefreshCostItem();
		this.RefreshName();
		this.RefreshToggleState();
	}

	// Token: 0x06012E9F RID: 77471 RVA: 0x004AD59C File Offset: 0x004AB79C
	private void RefreshName()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionNameText.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x06012EA0 RID: 77472 RVA: 0x004AD5CA File Offset: 0x004AB7CA
	private void OnVisionIdentifyDoAnimation(int uniqueId, IReadOnlyList<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PlayGridAnimation(uniqueId, data.ToList<Aki.Protocol.PhantomPropInfo>()).Forget();
	}

	// Token: 0x06012EA1 RID: 77473 RVA: 0x004AD5E0 File Offset: 0x004AB7E0
	private UniTask PlayGridAnimation(int uniqueId, List<Aki.Protocol.PhantomPropInfo> data)
	{
		VisionIdentifyView.<PlayGridAnimation>d__19 <PlayGridAnimation>d__;
		<PlayGridAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayGridAnimation>d__.<>4__this = this;
		<PlayGridAnimation>d__.uniqueId = uniqueId;
		<PlayGridAnimation>d__.data = data;
		<PlayGridAnimation>d__.<>1__state = -1;
		<PlayGridAnimation>d__.<>t__builder.Start<VisionIdentifyView.<PlayGridAnimation>d__19>(ref <PlayGridAnimation>d__);
		return <PlayGridAnimation>d__.<>t__builder.Task;
	}

	// Token: 0x06012EA2 RID: 77474 RVA: 0x004AD634 File Offset: 0x004AB834
	private void OnlyRefreshNewAttribute()
	{
		if (this.CurrentNeedAnimationIndex.Count > 0)
		{
			PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
			if (phantomItemDataByUniqueId == null)
			{
				return;
			}
			int currentCanIdentifyCount = phantomItemDataByUniqueId.GetCurrentCanIdentifyCount();
			List<VisionSubPropData> subPropIdentifyPreviewData = phantomItemDataByUniqueId.GetSubPropIdentifyPreviewData(phantomItemDataByUniqueId.GetPhantomLevel(), (currentCanIdentifyCount == 0) ? 0 : this.VisionIdentifyCostItem.CurrentConsumeSelectNum());
			if (subPropIdentifyPreviewData.Count > 0)
			{
				VisionSubPropData[] array = new VisionSubPropData[subPropIdentifyPreviewData.Count];
				for (int i = 0; i < subPropIdentifyPreviewData.Count; i++)
				{
					array[i] = subPropIdentifyPreviewData[i];
				}
				this.LevelUpIdentifyComponent.Update(array, true);
			}
		}
	}

	// Token: 0x06012EA3 RID: 77475 RVA: 0x004AD6CE File Offset: 0x004AB8CE
	private void OnVisionIdentify()
	{
		this.CacheCurrentSlotState();
	}

	// Token: 0x06012EA4 RID: 77476 RVA: 0x004AD6D8 File Offset: 0x004AB8D8
	private void CacheCurrentSlotState()
	{
		this.CurrentNeedAnimationIndex = new List<int>();
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		int currentCanIdentifyCount = phantomItemDataByUniqueId.GetCurrentCanIdentifyCount();
		List<VisionSubPropData> subPropIdentifyPreviewData = phantomItemDataByUniqueId.GetSubPropIdentifyPreviewData(phantomItemDataByUniqueId.GetPhantomLevel(), (currentCanIdentifyCount == 0) ? 0 : this.VisionIdentifyCostItem.CurrentConsumeSelectNum());
		int count = subPropIdentifyPreviewData.Count;
		if (count > 0)
		{
			for (int i = 0; i < count; i++)
			{
				int? num = null;
				int value;
				this.CurrentCacheSubPropSlotData.TryGetValue(i, out value);
				num = new int?(value);
				if (num.GetValueOrDefault() == 5 || num.GetValueOrDefault() == 1)
				{
					int? num2 = num;
					int slotState = (int)subPropIdentifyPreviewData[i].SlotState;
					if (!(num2.GetValueOrDefault() == slotState & num2 != null) && subPropIdentifyPreviewData[i].SlotState == EVisionSlotState.UnlockAndHaveProp)
					{
						this.CurrentNeedAnimationIndex.Add(i);
					}
				}
			}
		}
		for (int j = 0; j < count; j++)
		{
			int slotState2 = (int)subPropIdentifyPreviewData[j].SlotState;
			this.CurrentCacheSubPropSlotData[j] = slotState2;
		}
	}

	// Token: 0x06012EA5 RID: 77477 RVA: 0x004AD7F8 File Offset: 0x004AB9F8
	private void OnItemFuncValueChange(int uniqueId)
	{
		if (uniqueId != this.CurrentVisionUniqueId)
		{
			return;
		}
		this.RefreshToggleState();
	}

	// Token: 0x06012EA6 RID: 77478 RVA: 0x004AD80A File Offset: 0x004ABA0A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.RefreshView();
	}

	// Token: 0x06012EA7 RID: 77479 RVA: 0x004AD814 File Offset: 0x004ABA14
	private void RefreshCostItem()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionIdentifyCostItem.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x06012EA8 RID: 77480 RVA: 0x004AD844 File Offset: 0x004ABA44
	private void RefreshMainAttribute()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		List<AttrListScrollData> levelUpPreviewData = phantomItemDataByUniqueId.GetLevelUpPreviewData(phantomItemDataByUniqueId.GetPhantomLevel());
		this.VisionMainAttributeComponent.Update(levelUpPreviewData.ToArray());
	}

	// Token: 0x06012EA9 RID: 77481 RVA: 0x004AD884 File Offset: 0x004ABA84
	private void RefreshAttributePreview()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		int currentCanIdentifyCount = phantomItemDataByUniqueId.GetCurrentCanIdentifyCount();
		List<VisionSubPropData> subPropIdentifyPreviewData = phantomItemDataByUniqueId.GetSubPropIdentifyPreviewData(phantomItemDataByUniqueId.GetPhantomLevel(), (currentCanIdentifyCount == 0) ? 0 : this.VisionIdentifyCostItem.CurrentConsumeSelectNum());
		bool flag = subPropIdentifyPreviewData.Count > 0;
		if (flag)
		{
			VisionSubPropData[] array = new VisionSubPropData[subPropIdentifyPreviewData.Count];
			for (int i = 0; i < subPropIdentifyPreviewData.Count; i++)
			{
				array[i] = subPropIdentifyPreviewData[i];
			}
			this.LevelUpIdentifyComponent.Update(array, false);
		}
		this.LevelUpIdentifyComponent.SetActive(flag);
	}

	// Token: 0x06012EAA RID: 77482 RVA: 0x004AD924 File Offset: 0x004ABB24
	private void RefreshToggleState()
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		EToggleState state = attributeItemData.GetIsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(4).SetToggleState(state, false, false, false);
		EToggleState state2 = attributeItemData.GetIsDeprecated() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(5).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06012EAB RID: 77483 RVA: 0x004AD982 File Offset: 0x004ABB82
	protected override void OnBeforeHide()
	{
		this.RemoveEvent();
		UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", false);
	}

	// Token: 0x06012EAC RID: 77484 RVA: 0x004AD99A File Offset: 0x004ABB9A
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvent();
		this.LevelUpIdentifyComponent.Destroy(null);
		this.VisionMainAttributeComponent.Destroy(null);
		this.VisionIdentifyCostItem.Destroy(null);
	}

	// Token: 0x06012EAD RID: 77485 RVA: 0x004AD9C8 File Offset: 0x004ABBC8
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsLock());
	}

	// Token: 0x06012EAE RID: 77486 RVA: 0x004ADA04 File Offset: 0x004ABC04
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x04008E89 RID: 36489
	[Nullable(2)]
	private LevelUpIdentifyComponent LevelUpIdentifyComponent;

	// Token: 0x04008E8A RID: 36490
	[Nullable(2)]
	private VisionMainAttributeComponent VisionMainAttributeComponent;

	// Token: 0x04008E8B RID: 36491
	private int CurrentVisionUniqueId;

	// Token: 0x04008E8C RID: 36492
	[Nullable(2)]
	private VisionIdentifyCostItem VisionIdentifyCostItem;

	// Token: 0x04008E8D RID: 36493
	private bool EventRegistState;

	// Token: 0x04008E8E RID: 36494
	[Nullable(2)]
	private VisionNameText VisionNameText;

	// Token: 0x04008E8F RID: 36495
	private readonly Dictionary<int, int> CurrentCacheSubPropSlotData = new Dictionary<int, int>();

	// Token: 0x04008E90 RID: 36496
	private List<int> CurrentNeedAnimationIndex = new List<int>();

	// Token: 0x02008A50 RID: 35408
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CE8F RID: 183951
		AttributeItem,
		// Token: 0x0402CE90 RID: 183952
		CostItem,
		// Token: 0x0402CE91 RID: 183953
		IdentifyItem,
		// Token: 0x0402CE92 RID: 183954
		VisionName,
		// Token: 0x0402CE93 RID: 183955
		LockToggle,
		// Token: 0x0402CE94 RID: 183956
		DeprecateToggle
	}
}
