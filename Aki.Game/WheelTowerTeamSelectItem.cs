using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020015FC RID: 5628
internal class WheelTowerTeamSelectItem : GridProxyAbstract<int>
{
	// Token: 0x06009EC0 RID: 40640 RVA: 0x0022AD3C File Offset: 0x00228F3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EC1 RID: 40641 RVA: 0x0022AE48 File Offset: 0x00229048
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTeamSelectItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTeamSelectItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009EC2 RID: 40642 RVA: 0x0022AE8C File Offset: 0x0022908C
	protected override void OnStart()
	{
		UUIExtendToggle toggle = base.GetExtendToggle(0);
		if (toggle != null)
		{
			toggle.CanExecuteChange.Bind(() => toggle.ToggleState == EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x06009EC3 RID: 40643 RVA: 0x0022AED0 File Offset: 0x002290D0
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TeamId = data;
		List<RoleDataWithBranch> list = new List<RoleDataWithBranch>();
		for (int i = 0; i < WheelTowerModel.Instance.GetTeamMaxRoleCount(); i++)
		{
			list.Add(new RoleDataWithBranch(0, 0));
		}
		FormationData formationData = FormationModel.Instance.GetFormationData(data);
		Dictionary<int, FormationRoleData> dictionary = (formationData != null) ? formationData.GetRoleDataMapWithTrial(false) : null;
		if (dictionary != null)
		{
			int num = 0;
			foreach (KeyValuePair<int, FormationRoleData> keyValuePair in dictionary)
			{
				int configId = keyValuePair.Value.ConfigId;
				int roleCurrentBranchId = RoleModel.Instance.GetRoleCurrentBranchId(configId);
				list[num] = new RoleDataWithBranch(configId, roleCurrentBranchId);
				num++;
			}
		}
		int num2 = 0;
		while (num2 < list.Count && num2 < this.SlotList.Count)
		{
			this.SlotList[num2].Refresh(list[num2], false, num2);
			num2++;
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		string newText;
		if (data <= 9)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data);
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			newText = data.ToString();
		}
		text.SetText(newText, true);
	}

	// Token: 0x06009EC4 RID: 40644 RVA: 0x0022B01C File Offset: 0x0022921C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleForce(false, false);
	}

	// Token: 0x06009EC5 RID: 40645 RVA: 0x0022B026 File Offset: 0x00229226
	private void OnToggleClick(EToggleState state)
	{
		Action<int, int> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(this.TeamId, base.GridIndex);
	}

	// Token: 0x06009EC6 RID: 40646 RVA: 0x0022B044 File Offset: 0x00229244
	public void SetToggleForce(bool selected, bool skipAnim = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, skipAnim);
	}

	// Token: 0x04004703 RID: 18179
	[Nullable(2)]
	public Action<int, int> OnToggleClickCallback;

	// Token: 0x04004704 RID: 18180
	private int TeamId = -1;

	// Token: 0x04004705 RID: 18181
	[Nullable(1)]
	private readonly List<WheelTowerRoleGridItem> SlotList = new List<WheelTowerRoleGridItem>();
}
