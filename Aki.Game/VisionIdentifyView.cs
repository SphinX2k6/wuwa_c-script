using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B1 RID: 6577
[NullableContext(1)]
[Nullable(0)]
public class VisionIdentifyView : UiTabViewBase
{
	// Token: 0x06010356 RID: 66390 RVA: 0x004BAEC8 File Offset: 0x004B90C8
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

	// Token: 0x06010357 RID: 66391 RVA: 0x004BAFA0 File Offset: 0x004B91A0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionIdentifyView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionIdentifyView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010358 RID: 66392 RVA: 0x004BAFE4 File Offset: 0x004B91E4
	protected override void OnStart()
	{
		this.VisionIdentifyCostItem = new VisionIdentifyCostItem(base.GetItem(1));
		this.VisionIdentifyCostItem.Init();
		this.VisionIdentifyCostItem.SetOnChangeValueCallBack(new Action(this.OnChangeSelectNumber));
		this.VisionNameText = new VisionNameText(base.GetText(3));
	}

	// Token: 0x06010359 RID: 66393 RVA: 0x004BB037 File Offset: 0x004B9237
	private void OnChangeSelectNumber()
	{
		this.RefreshAttributePreview();
	}

	// Token: 0x0601035A RID: 66394 RVA: 0x004BB03F File Offset: 0x004B923F
	protected override void OnBeforeShow()
	{
		this.AddEvent();
		this.CurrentVisionUniqueId = (int)(this.ExtraParams ?? 0);
		this.CacheCurrentSlotState();
		this.RefreshView();
	}

	// Token: 0x0601035B RID: 66395 RVA: 0x004BB070 File Offset: 0x004B9270
	private void AddEvent()
	{
		EventSystem.Instance.Add(EEventName.OnVisionIdentify, new Action(this.OnVisionIdentify));
		EventSystem.Instance.Add<int, IReadOnlyList<Aki.Protocol.PhantomPropInfo>>(EEventName.OnVisionIdentifyDoAnimation, new Action<int, IReadOnlyList<Aki.Protocol.PhantomPropInfo>>(this.OnVisionIdentifyDoAnimation));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		this.EventRegistState = true;
	}

	// Token: 0x0601035C RID: 66396 RVA: 0x004BB0F4 File Offset: 0x004B92F4
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

	// Token: 0x0601035D RID: 66397 RVA: 0x004BB180 File Offset: 0x004B9380
	private void RefreshView()
	{
		this.RefreshMainAttribute();
		this.RefreshCostItem();
		this.RefreshName();
		this.RefreshToggleState();
	}

	// Token: 0x0601035E RID: 66398 RVA: 0x004BB19C File Offset: 0x004B939C
	private void RefreshName()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionNameText.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x0601035F RID: 66399 RVA: 0x004BB1CA File Offset: 0x004B93CA
	private void OnVisionIdentifyDoAnimation(int uniqueId, IReadOnlyList<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PlayGridAnimation(uniqueId, new List<Aki.Protocol.PhantomPropInfo>(data)).Forget();
	}

	// Token: 0x06010360 RID: 66400 RVA: 0x004BB1E0 File Offset: 0x004B93E0
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

	// Token: 0x06010361 RID: 66401 RVA: 0x004BB234 File Offset: 0x004B9434
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

	// Token: 0x06010362 RID: 66402 RVA: 0x004BB2CE File Offset: 0x004B94CE
	private void OnVisionIdentify()
	{
		this.CacheCurrentSlotState();
	}

	// Token: 0x06010363 RID: 66403 RVA: 0x004BB2D8 File Offset: 0x004B94D8
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

	// Token: 0x06010364 RID: 66404 RVA: 0x004BB3F8 File Offset: 0x004B95F8
	private void OnItemFuncValueChange(int uniqueId)
	{
		if (uniqueId != this.CurrentVisionUniqueId)
		{
			return;
		}
		this.RefreshToggleState();
	}

	// Token: 0x06010365 RID: 66405 RVA: 0x004BB40A File Offset: 0x004B960A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.RefreshView();
	}

	// Token: 0x06010366 RID: 66406 RVA: 0x004BB414 File Offset: 0x004B9614
	private void RefreshCostItem()
	{
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentVisionUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.VisionIdentifyCostItem.Update(phantomItemDataByUniqueId);
	}

	// Token: 0x06010367 RID: 66407 RVA: 0x004BB444 File Offset: 0x004B9644
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

	// Token: 0x06010368 RID: 66408 RVA: 0x004BB484 File Offset: 0x004B9684
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

	// Token: 0x06010369 RID: 66409 RVA: 0x004BB524 File Offset: 0x004B9724
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

	// Token: 0x0601036A RID: 66410 RVA: 0x004BB582 File Offset: 0x004B9782
	protected override void OnBeforeHide()
	{
		this.RemoveEvent();
		UiLayer.Instance.SetShowMaskLayer("PhantomLevelUp", false);
	}

	// Token: 0x0601036B RID: 66411 RVA: 0x004BB59A File Offset: 0x004B979A
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvent();
		this.LevelUpIdentifyComponent.Destroy(null);
		this.VisionMainAttributeComponent.Destroy(null);
		this.VisionIdentifyCostItem.Destroy(null);
	}

	// Token: 0x0601036C RID: 66412 RVA: 0x004BB5C8 File Offset: 0x004B97C8
	protected void OnClickLockToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsLock());
	}

	// Token: 0x0601036D RID: 66413 RVA: 0x004BB604 File Offset: 0x004B9804
	protected void OnClickDeprecateToggle(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.CurrentVisionUniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.CurrentVisionUniqueId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x04008FD3 RID: 36819
	[Nullable(2)]
	private LevelUpIdentifyComponent LevelUpIdentifyComponent;

	// Token: 0x04008FD4 RID: 36820
	[Nullable(2)]
	private VisionMainAttributeComponent VisionMainAttributeComponent;

	// Token: 0x04008FD5 RID: 36821
	private int CurrentVisionUniqueId;

	// Token: 0x04008FD6 RID: 36822
	[Nullable(2)]
	private VisionIdentifyCostItem VisionIdentifyCostItem;

	// Token: 0x04008FD7 RID: 36823
	private bool EventRegistState;

	// Token: 0x04008FD8 RID: 36824
	[Nullable(2)]
	private VisionNameText VisionNameText;

	// Token: 0x04008FD9 RID: 36825
	private readonly Dictionary<int, int> CurrentCacheSubPropSlotData = new Dictionary<int, int>();

	// Token: 0x04008FDA RID: 36826
	private List<int> CurrentNeedAnimationIndex = new List<int>();

	// Token: 0x02007BD9 RID: 31705
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040281AD RID: 164269
		AttributeItem,
		// Token: 0x040281AE RID: 164270
		CostItem,
		// Token: 0x040281AF RID: 164271
		IdentifyItem,
		// Token: 0x040281B0 RID: 164272
		VisionName,
		// Token: 0x040281B1 RID: 164273
		LockToggle,
		// Token: 0x040281B2 RID: 164274
		DeprecateToggle
	}
}
