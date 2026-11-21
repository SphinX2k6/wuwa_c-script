using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000BD3 RID: 3027
[NullableContext(1)]
[Nullable(0)]
public class UseBuffItemView : UiTickViewBase
{
	// Token: 0x06007E9B RID: 32411 RVA: 0x00270069 File Offset: 0x0026E269
	public UseBuffItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007E9C RID: 32412 RVA: 0x00270080 File Offset: 0x0026E280
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickedEnsureButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickedCancelButton))
		};
	}

	// Token: 0x06007E9D RID: 32413 RVA: 0x00270170 File Offset: 0x0026E370
	private void OnClickedEnsureButton()
	{
		if (this.SelectedUseBuffItemRoleData == null)
		{
			this.CloseUseBuffItemView();
			return;
		}
		int useItemConfigId = this.SelectedUseBuffItemRoleData.UseItemConfigId;
		if ((float)BuffItemModel.Instance.GetBuffItemRemainCdTime(useItemConfigId) > 0f)
		{
			ScrollingTipsController.Instance.ShowTipsById("UseBuffCdText", Array.Empty<object>());
			return;
		}
		if (this.SelectedUseBuffItemRoleData.CurrentAttribute <= 0f)
		{
			if (!BuffItemConfig.Instance.IsResurrectionItem(useItemConfigId))
			{
				ScrollingTipsController.Instance.ShowTipsById("UseBuffToDeadRole", Array.Empty<object>());
				return;
			}
		}
		else if (BuffItemConfig.Instance.IsResurrectionItem(useItemConfigId))
		{
			ScrollingTipsController.Instance.ShowTipsById("UseBuffToAliveRole", Array.Empty<object>());
			return;
		}
		float currentAttribute = this.SelectedUseBuffItemRoleData.CurrentAttribute;
		float num = this.SelectedUseBuffItemRoleData.GetAddAttribute();
		float maxAttribute = this.SelectedUseBuffItemRoleData.MaxAttribute;
		if (currentAttribute + num > maxAttribute)
		{
			string roleName = this.SelectedUseBuffItemRoleData.RoleName;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((currentAttribute >= maxAttribute) ? EConfirmBoxConfigId.UseBuffItemToMaxLifeRoleTips : EConfirmBoxConfigId.UseBuffItemOverflow);
			Action value = delegate()
			{
				this.UiViewSequence.StopSequenceByKey("Popup", false, false);
				this.UiViewSequence.SequencePlayReverseByKey("Popup", false);
				this.EnsureUseItem();
			};
			Action value2 = delegate()
			{
				this.UiViewSequence.StopSequenceByKey("Popup", false, false);
				this.UiViewSequence.SequencePlayReverseByKey("Popup", false);
			};
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				roleName
			});
			confirmBoxDataNew.FunctionMap.Add(2, value);
			confirmBoxDataNew.FunctionMap.Add(1, value2);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			this.UiViewSequence.StopSequenceByKey("Popup", false, false);
			this.UiViewSequence.PlaySequence("Popup", false, null);
			return;
		}
		this.EnsureUseItem();
	}

	// Token: 0x06007E9E RID: 32414 RVA: 0x002702FA File Offset: 0x0026E4FA
	private void OnClickedCancelButton()
	{
		this.CloseUseBuffItemView();
	}

	// Token: 0x06007E9F RID: 32415 RVA: 0x00270304 File Offset: 0x0026E504
	private void InitializeUseBuffItemView(int useItemConfigId)
	{
		this.CreateAllBuffTargetRoleItems();
		this.RefreshAllBuffTargetRoleItems();
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		bool flag = false;
		foreach (BuffTargetRoleItem buffTargetRoleItem in this.BuffTargetRoleItemList)
		{
			UseBuffItemRoleData useBuffItemRoleData = buffTargetRoleItem.GetUseBuffItemRoleData();
			if (useBuffItemRoleData != null && useBuffItemRoleData.GetEntityId() == getCurrentEntity.Id)
			{
				this.SelectedUseBuffTargetRoleItem(buffTargetRoleItem);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.SelectedUseBuffTargetRoleItem(this.BuffTargetRoleItemList[0]);
		}
	}

	// Token: 0x06007EA0 RID: 32416 RVA: 0x002703A4 File Offset: 0x0026E5A4
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ItemUseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06007EA1 RID: 32417 RVA: 0x002703C5 File Offset: 0x0026E5C5
	private void ValueChangeFunction(int selectValue)
	{
		this.SelectedUseBuffItemRoleData.SetUseItemCount(selectValue);
		this.RefreshAttributePreview();
	}

	// Token: 0x06007EA2 RID: 32418 RVA: 0x002703DC File Offset: 0x0026E5DC
	private int GetUseBuffItemMaxNumber()
	{
		int useItemConfigId = this.SelectedUseBuffItemRoleData.UseItemConfigId;
		if (BuffItemConfig.Instance.IsResurrectionItem(useItemConfigId))
		{
			return 1;
		}
		if (BuffItemConfig.Instance.GetBuffItemTotalCdTime(useItemConfigId) > 0)
		{
			return 1;
		}
		return this.SelectedUseBuffItemRoleData.GetUseItemMaxCount();
	}

	// Token: 0x06007EA3 RID: 32419 RVA: 0x00270420 File Offset: 0x0026E620
	private void InitNumberSelect()
	{
		this.NumberSelect = new NumberSelectComponent(base.GetItem(6));
		this.NumberSelectData = new INumberSelectData
		{
			MaxNumber = this.GetUseBuffItemMaxNumber(),
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(this.NumberSelectData);
	}

	// Token: 0x06007EA4 RID: 32420 RVA: 0x0027048C File Offset: 0x0026E68C
	protected override void OnStart()
	{
		int? num = this.OpenParam as int?;
		if (num == null)
		{
			return;
		}
		this.InitializeUseBuffItemView(num.Value);
		this.InitNumberSelect();
	}

	// Token: 0x06007EA5 RID: 32421 RVA: 0x002704C7 File Offset: 0x0026E6C7
	protected override void OnBeforeDestroy()
	{
		this.ResetUseBuffItemView();
		this.NumberSelect.Destroy(null);
		this.NumberSelectData = null;
		this.NumberSelect = null;
		ConfirmBoxController.Instance.CloseConfirmBoxView();
	}

	// Token: 0x06007EA6 RID: 32422 RVA: 0x002704F3 File Offset: 0x0026E6F3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, long, int>(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
	}

	// Token: 0x06007EA7 RID: 32423 RVA: 0x00270511 File Offset: 0x0026E711
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
	}

	// Token: 0x06007EA8 RID: 32424 RVA: 0x00270530 File Offset: 0x0026E730
	protected override void OnTick(float delta)
	{
		foreach (BuffTargetRoleItem buffTargetRoleItem in this.BuffTargetRoleItemList)
		{
			buffTargetRoleItem.Tick(delta);
		}
	}

	// Token: 0x06007EA9 RID: 32425 RVA: 0x00270584 File Offset: 0x0026E784
	private void OnUseBuffItem(int itemConfigId, long endCdTimeStamp, int useCount)
	{
		if (this.SelectedBuffTargetRoleItem == null)
		{
			return;
		}
		this.FinishUseBuffItem();
	}

	// Token: 0x06007EAA RID: 32426 RVA: 0x00270595 File Offset: 0x0026E795
	private void CloseUseBuffItemView()
	{
		UiManager.Instance.CloseView(EUiViewName.UseBuffItemView, null);
	}

	// Token: 0x06007EAB RID: 32427 RVA: 0x002705A8 File Offset: 0x0026E7A8
	public void ResetUseBuffItemView()
	{
		foreach (BuffTargetRoleItem buffTargetRoleItem in this.BuffTargetRoleItemList)
		{
			buffTargetRoleItem.ResetBuffTargetRoleItem();
		}
		this.BuffTargetRoleItemList.Clear();
		this.SelectedUseBuffItemRoleData = null;
		this.SelectedBuffTargetRoleItem = null;
		BuffItemModel.Instance.ClearAllUseBuffItemRoleData();
	}

	// Token: 0x06007EAC RID: 32428 RVA: 0x0027061C File Offset: 0x0026E81C
	private void CreateAllBuffTargetRoleItems()
	{
		foreach (UUIItem uuiitem in new List<UUIItem>
		{
			base.GetItem(1),
			base.GetItem(2),
			base.GetItem(3)
		})
		{
			AActor owner = uuiitem.GetOwner();
			BuffTargetRoleItem buffTargetRoleItem = new BuffTargetRoleItem();
			buffTargetRoleItem.Initialize(owner);
			buffTargetRoleItem.BindOnClickedBuffTargetRoleItem(new Action<BuffTargetRoleItem>(this.OnClickedBuffTargetRoleItem));
			buffTargetRoleItem.BindOnUseItemAnimationFinished(new Action(this.OnUseItemAnimationFinished));
			this.BuffTargetRoleItemList.Add(buffTargetRoleItem);
		}
	}

	// Token: 0x06007EAD RID: 32429 RVA: 0x002706D0 File Offset: 0x0026E8D0
	private void OnClickedBuffTargetRoleItem(BuffTargetRoleItem buffTargetRoleItem)
	{
		this.SelectedUseBuffTargetRoleItem(buffTargetRoleItem);
	}

	// Token: 0x06007EAE RID: 32430 RVA: 0x002706DC File Offset: 0x0026E8DC
	private void SelectedUseBuffTargetRoleItem(BuffTargetRoleItem buffTargetRoleItem)
	{
		UseBuffItemRoleData useBuffItemRoleData = buffTargetRoleItem.GetUseBuffItemRoleData();
		if (useBuffItemRoleData == null)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoneRole", Array.Empty<object>());
			return;
		}
		if (buffTargetRoleItem.IsSelected())
		{
			return;
		}
		buffTargetRoleItem.SetSelected(true);
		if (this.SelectedUseBuffItemRoleData != null)
		{
			this.SelectedUseBuffItemRoleData.SetUseItemCount(0);
		}
		if (this.SelectedBuffTargetRoleItem != null)
		{
			this.SelectedBuffTargetRoleItem.SetSelected(false);
		}
		this.SelectedUseBuffItemRoleData = useBuffItemRoleData;
		this.SelectedBuffTargetRoleItem = buffTargetRoleItem;
		useBuffItemRoleData.SetUseItemCount(1);
		this.RefreshAttributePreview();
		this.RefreshTitleText();
		if (this.NumberSelectData != null)
		{
			NumberSelectComponent numberSelect = this.NumberSelect;
			if (numberSelect == null)
			{
				return;
			}
			numberSelect.Init(this.NumberSelectData);
		}
	}

	// Token: 0x06007EAF RID: 32431 RVA: 0x0027077F File Offset: 0x0026E97F
	private void OnUseItemAnimationFinished()
	{
		this.FinishUseBuffItem();
	}

	// Token: 0x06007EB0 RID: 32432 RVA: 0x00270788 File Offset: 0x0026E988
	private void FinishUseBuffItem()
	{
		InventoryModel instance = InventoryModel.Instance;
		int useItemConfigId = this.SelectedUseBuffItemRoleData.UseItemConfigId;
		if (instance.GetItemCountByConfigId(useItemConfigId, 0) < 1)
		{
			this.CloseUseBuffItemView();
			return;
		}
		int useBuffItemMaxNumber = this.GetUseBuffItemMaxNumber();
		this.NumberSelect.SetLimitMaxValue(useBuffItemMaxNumber);
		this.NumberSelect.Refresh(useBuffItemMaxNumber);
	}

	// Token: 0x06007EB1 RID: 32433 RVA: 0x002707D8 File Offset: 0x0026E9D8
	private void RefreshAllBuffTargetRoleItems()
	{
		IReadOnlyDictionary<int, UseBuffItemRoleData> allUseBuffItemRole = BuffItemModel.Instance.GetAllUseBuffItemRole();
		foreach (BuffTargetRoleItem buffTargetRoleItem in this.BuffTargetRoleItemList)
		{
			buffTargetRoleItem.SetActive(false);
		}
		int num = 0;
		for (int i = 0; i < this.BuffTargetRoleItemList.Count; i++)
		{
			int key = i + 1;
			UseBuffItemRoleData useBuffItemRoleData;
			allUseBuffItemRole.TryGetValue(key, out useBuffItemRoleData);
			BuffTargetRoleItem buffTargetRoleItem2 = this.BuffTargetRoleItemList[num];
			if (useBuffItemRoleData != null)
			{
				buffTargetRoleItem2.RefreshBuffTargetRoleItem(useBuffItemRoleData);
				buffTargetRoleItem2.SetActive(true);
				num++;
			}
			else
			{
				buffTargetRoleItem2.RemoveRole();
			}
		}
	}

	// Token: 0x06007EB2 RID: 32434 RVA: 0x0027088C File Offset: 0x0026EA8C
	private void RefreshAttributePreview()
	{
		if (this.SelectedUseBuffItemRoleData == null)
		{
			return;
		}
		if (this.SelectedBuffTargetRoleItem == null)
		{
			return;
		}
		float currentAttribute = this.SelectedUseBuffItemRoleData.CurrentAttribute;
		float maxAttribute = this.SelectedUseBuffItemRoleData.MaxAttribute;
		float addAttribute = this.SelectedUseBuffItemRoleData.GetAddAttribute();
		this.SelectedBuffTargetRoleItem.RefreshPreviewUseItem(currentAttribute, maxAttribute, addAttribute);
	}

	// Token: 0x06007EB3 RID: 32435 RVA: 0x002708E0 File Offset: 0x0026EAE0
	private void RefreshTitleText()
	{
		if (this.SelectedUseBuffItemRoleData == null)
		{
			return;
		}
		string roleName = this.SelectedUseBuffItemRoleData.RoleName;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalText(text, "UseBuffTitle", new <>z__ReadOnlySingleElementList<object>(roleName));
	}

	// Token: 0x06007EB4 RID: 32436 RVA: 0x00270920 File Offset: 0x0026EB20
	private void EnsureUseItem()
	{
		if (this.SelectedUseBuffItemRoleData == null)
		{
			this.CloseUseBuffItemView();
			return;
		}
		int useItemConfigId = this.SelectedUseBuffItemRoleData.UseItemConfigId;
		int useItemCount = this.SelectedUseBuffItemRoleData.UseItemCount;
		int roleConfigId = this.SelectedUseBuffItemRoleData.RoleConfigId;
		BuffItemControl.Instance.RequestUseBuffItem(useItemConfigId, useItemCount, roleConfigId);
	}

	// Token: 0x04004E27 RID: 20007
	private readonly List<BuffTargetRoleItem> BuffTargetRoleItemList = new List<BuffTargetRoleItem>();

	// Token: 0x04004E28 RID: 20008
	[Nullable(2)]
	private BuffTargetRoleItem SelectedBuffTargetRoleItem;

	// Token: 0x04004E29 RID: 20009
	[Nullable(2)]
	private UseBuffItemRoleData SelectedUseBuffItemRoleData;

	// Token: 0x04004E2A RID: 20010
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04004E2B RID: 20011
	[Nullable(2)]
	private INumberSelectData NumberSelectData;

	// Token: 0x02006E9F RID: 28319
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040242B7 RID: 148151
		TitleText,
		// Token: 0x040242B8 RID: 148152
		TargetRoleItem1,
		// Token: 0x040242B9 RID: 148153
		TargetRoleItem2,
		// Token: 0x040242BA RID: 148154
		TargetRoleItem3,
		// Token: 0x040242BB RID: 148155
		EnsureButton,
		// Token: 0x040242BC RID: 148156
		CancelButton,
		// Token: 0x040242BD RID: 148157
		NumberSelect
	}
}
