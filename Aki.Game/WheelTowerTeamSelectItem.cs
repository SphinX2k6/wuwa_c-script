using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AB4 RID: 2740
internal class WheelTowerTeamSelectItem : GridProxyAbstract<int>
{
	// Token: 0x0600729E RID: 29342 RVA: 0x00234B14 File Offset: 0x00232D14
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

	// Token: 0x0600729F RID: 29343 RVA: 0x00234C20 File Offset: 0x00232E20
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerTeamSelectItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerTeamSelectItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072A0 RID: 29344 RVA: 0x00234C64 File Offset: 0x00232E64
	protected override void OnStart()
	{
		UUIExtendToggle toggle = base.GetExtendToggle(0);
		if (toggle != null)
		{
			toggle.CanExecuteChange.Bind(() => toggle.ToggleState == EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x060072A1 RID: 29345 RVA: 0x00234CA8 File Offset: 0x00232EA8
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

	// Token: 0x060072A2 RID: 29346 RVA: 0x00234DF4 File Offset: 0x00232FF4
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleForce(false, false);
	}

	// Token: 0x060072A3 RID: 29347 RVA: 0x00234DFE File Offset: 0x00232FFE
	private void OnToggleClick(EToggleState state)
	{
		Action<int, int> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(this.TeamId, base.GridIndex);
	}

	// Token: 0x060072A4 RID: 29348 RVA: 0x00234E1C File Offset: 0x0023301C
	public void SetToggleForce(bool selected, bool skipAnim = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, skipAnim);
	}

	// Token: 0x040047A9 RID: 18345
	[Nullable(2)]
	public Action<int, int> OnToggleClickCallback;

	// Token: 0x040047AA RID: 18346
	private int TeamId = -1;

	// Token: 0x040047AB RID: 18347
	[Nullable(1)]
	private readonly List<WheelTowerRoleGridItem> SlotList = new List<WheelTowerRoleGridItem>();
}
