using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200171B RID: 5915
[NullableContext(1)]
[Nullable(0)]
public class UseBuffItemView : UiTickViewBase
{
	// Token: 0x0600AAB8 RID: 43704 RVA: 0x00265B19 File Offset: 0x00263D19
	public UseBuffItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AAB9 RID: 43705 RVA: 0x00265B30 File Offset: 0x00263D30
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

	// Token: 0x0600AABA RID: 43706 RVA: 0x00265C20 File Offset: 0x00263E20
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

	// Token: 0x0600AABB RID: 43707 RVA: 0x00265DAA File Offset: 0x00263FAA
	private void OnClickedCancelButton()
	{
		this.CloseUseBuffItemView();
	}

	// Token: 0x0600AABC RID: 43708 RVA: 0x00265DB4 File Offset: 0x00263FB4
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

	// Token: 0x0600AABD RID: 43709 RVA: 0x00265E54 File Offset: 0x00264054
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ItemUseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600AABE RID: 43710 RVA: 0x00265E75 File Offset: 0x00264075
	private void ValueChangeFunction(int selectValue)
	{
		this.SelectedUseBuffItemRoleData.SetUseItemCount(selectValue);
		this.RefreshAttributePreview();
	}

	// Token: 0x0600AABF RID: 43711 RVA: 0x00265E8C File Offset: 0x0026408C
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

	// Token: 0x0600AAC0 RID: 43712 RVA: 0x00265ED0 File Offset: 0x002640D0
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

	// Token: 0x0600AAC1 RID: 43713 RVA: 0x00265F3C File Offset: 0x0026413C
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

	// Token: 0x0600AAC2 RID: 43714 RVA: 0x00265F77 File Offset: 0x00264177
	protected override void OnBeforeDestroy()
	{
		this.ResetUseBuffItemView();
		this.NumberSelect.Destroy(null);
		this.NumberSelectData = null;
		this.NumberSelect = null;
		ConfirmBoxController.Instance.CloseConfirmBoxView();
	}

	// Token: 0x0600AAC3 RID: 43715 RVA: 0x00265FA3 File Offset: 0x002641A3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, long, int>(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
	}

	// Token: 0x0600AAC4 RID: 43716 RVA: 0x00265FC1 File Offset: 0x002641C1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
	}

	// Token: 0x0600AAC5 RID: 43717 RVA: 0x00265FE0 File Offset: 0x002641E0
	protected override void OnTick(float delta)
	{
		foreach (BuffTargetRoleItem buffTargetRoleItem in this.BuffTargetRoleItemList)
		{
			buffTargetRoleItem.Tick(delta);
		}
	}

	// Token: 0x0600AAC6 RID: 43718 RVA: 0x00266034 File Offset: 0x00264234
	private void OnUseBuffItem(int itemConfigId, long endCdTimeStamp, int useCount)
	{
		if (this.SelectedBuffTargetRoleItem == null)
		{
			return;
		}
		this.FinishUseBuffItem();
	}

	// Token: 0x0600AAC7 RID: 43719 RVA: 0x00266045 File Offset: 0x00264245
	private void CloseUseBuffItemView()
	{
		UiManager.Instance.CloseView(EUiViewName.UseBuffItemView, null);
	}

	// Token: 0x0600AAC8 RID: 43720 RVA: 0x00266058 File Offset: 0x00264258
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

	// Token: 0x0600AAC9 RID: 43721 RVA: 0x002660CC File Offset: 0x002642CC
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

	// Token: 0x0600AACA RID: 43722 RVA: 0x00266180 File Offset: 0x00264380
	private void OnClickedBuffTargetRoleItem(BuffTargetRoleItem buffTargetRoleItem)
	{
		this.SelectedUseBuffTargetRoleItem(buffTargetRoleItem);
	}

	// Token: 0x0600AACB RID: 43723 RVA: 0x0026618C File Offset: 0x0026438C
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

	// Token: 0x0600AACC RID: 43724 RVA: 0x0026622F File Offset: 0x0026442F
	private void OnUseItemAnimationFinished()
	{
		this.FinishUseBuffItem();
	}

	// Token: 0x0600AACD RID: 43725 RVA: 0x00266238 File Offset: 0x00264438
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

	// Token: 0x0600AACE RID: 43726 RVA: 0x00266288 File Offset: 0x00264488
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

	// Token: 0x0600AACF RID: 43727 RVA: 0x0026633C File Offset: 0x0026453C
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

	// Token: 0x0600AAD0 RID: 43728 RVA: 0x00266390 File Offset: 0x00264590
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

	// Token: 0x0600AAD1 RID: 43729 RVA: 0x002663D0 File Offset: 0x002645D0
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

	// Token: 0x04004D7F RID: 19839
	private readonly List<BuffTargetRoleItem> BuffTargetRoleItemList = new List<BuffTargetRoleItem>();

	// Token: 0x04004D80 RID: 19840
	[Nullable(2)]
	private BuffTargetRoleItem SelectedBuffTargetRoleItem;

	// Token: 0x04004D81 RID: 19841
	[Nullable(2)]
	private UseBuffItemRoleData SelectedUseBuffItemRoleData;

	// Token: 0x04004D82 RID: 19842
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04004D83 RID: 19843
	[Nullable(2)]
	private INumberSelectData NumberSelectData;

	// Token: 0x02007D1A RID: 32026
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028F8E RID: 167822
		TitleText,
		// Token: 0x04028F8F RID: 167823
		TargetRoleItem1,
		// Token: 0x04028F90 RID: 167824
		TargetRoleItem2,
		// Token: 0x04028F91 RID: 167825
		TargetRoleItem3,
		// Token: 0x04028F92 RID: 167826
		EnsureButton,
		// Token: 0x04028F93 RID: 167827
		CancelButton,
		// Token: 0x04028F94 RID: 167828
		NumberSelect
	}
}
