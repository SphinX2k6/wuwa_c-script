using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BC5 RID: 7109
public class DangoExtensionPanel : UiPanelBase
{
	// Token: 0x0600D401 RID: 54273 RVA: 0x0030C8E4 File Offset: 0x0030AAE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D402 RID: 54274 RVA: 0x0030C92D File Offset: 0x0030AB2D
	private void AddEventListeners()
	{
		EventSystem.Instance.Add(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
		EventSystem.Instance.Add(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
	}

	// Token: 0x0600D403 RID: 54275 RVA: 0x0030C967 File Offset: 0x0030AB67
	private void RemoveEventListeners()
	{
		EventSystem.Instance.Remove(EEventName.OnAbyssDangoLevelUp, new Action<int, int>(this.OnAbyssDangoLevelUp));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoleInfoUpdate, new Action(this.OnAbyssRoleInfoUpdate));
	}

	// Token: 0x0600D404 RID: 54276 RVA: 0x0030C9A1 File Offset: 0x0030ABA1
	private void OnAbyssDangoLevelUp(int dangoId, int level)
	{
		DangoItem_Tmp_E dangoItem = this.DangoItem;
		if (dangoItem == null)
		{
			return;
		}
		dangoItem.OnLevelUp(dangoId, level);
	}

	// Token: 0x0600D405 RID: 54277 RVA: 0x0030C9B5 File Offset: 0x0030ABB5
	private void OnAbyssRoleInfoUpdate()
	{
		DangoItem_Tmp_E dangoItem = this.DangoItem;
		if (dangoItem == null)
		{
			return;
		}
		dangoItem.OnDangoInfoUpdate();
	}

	// Token: 0x0600D406 RID: 54278 RVA: 0x0030C9C8 File Offset: 0x0030ABC8
	protected override UniTask OnBeforeStartAsync()
	{
		DangoExtensionPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoExtensionPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D407 RID: 54279 RVA: 0x0030CA0B File Offset: 0x0030AC0B
	protected override void OnStart()
	{
		this.AddEventListeners();
	}

	// Token: 0x0600D408 RID: 54280 RVA: 0x0030CA13 File Offset: 0x0030AC13
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListeners();
	}

	// Token: 0x0600D409 RID: 54281 RVA: 0x0030CA1B File Offset: 0x0030AC1B
	public void SetRelativeUiActive(bool active)
	{
		base.GetItem(26).SetUIActive(active);
	}

	// Token: 0x0600D40A RID: 54282 RVA: 0x0030CA2C File Offset: 0x0030AC2C
	public void Refresh(int index, int roleCfgId, int playerId)
	{
		DangoAbyssModel.Instance.RefreshOwnDataAfterChange(playerId);
		DangoItemData_Tmp dangoItemData_Tmp = new DangoItemData_Tmp();
		dangoItemData_Tmp.Index = index;
		DangoItemData_Tmp dangoItemData_Tmp2 = dangoItemData_Tmp;
		int? id = PlayerInfoModel.Instance.GetId();
		dangoItemData_Tmp2.IfSelf = (playerId == id.GetValueOrDefault() & id != null);
		AbyssDangoOwnerData roleOwnerData = DangoAbyssModel.Instance.GetRoleOwnerData(playerId, roleCfgId);
		dangoItemData_Tmp.DangoId = ((roleOwnerData != null) ? roleOwnerData.DangoId : 0);
		dangoItemData_Tmp.RoleConfigId = roleCfgId;
		dangoItemData_Tmp.Level = ((roleOwnerData != null) ? roleOwnerData.DangoLevel : 0);
		dangoItemData_Tmp.DangoEquipIds = (((roleOwnerData != null) ? roleOwnerData.DangoEquipIds : null) ?? new int[0]);
		this.DangoItem.Refresh(dangoItemData_Tmp);
	}

	// Token: 0x0600D40B RID: 54283 RVA: 0x0030CAD4 File Offset: 0x0030ACD4
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		DangoItem_Tmp_E dangoItem = this.DangoItem;
		UUIItem uuiitem = (dangoItem != null) ? dangoItem.GetRootItem() : null;
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

	// Token: 0x040060F2 RID: 24818
	[Nullable(2)]
	private DangoItem_Tmp_E DangoItem;

	// Token: 0x02008180 RID: 33152
	private enum EComponent
	{
		// Token: 0x0402A41B RID: 173083
		DangoNode = 26
	}
}
