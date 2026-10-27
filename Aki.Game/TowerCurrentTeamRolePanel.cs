using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BE4 RID: 11236
public class TowerCurrentTeamRolePanel : UiPanelBase
{
	// Token: 0x06017571 RID: 95601 RVA: 0x005EFD00 File Offset: 0x005EDF00
	[NullableContext(1)]
	public UniTask Init(UUIItem item)
	{
		TowerCurrentTeamRolePanel.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TowerCurrentTeamRolePanel.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06017572 RID: 95602 RVA: 0x005EFD4C File Offset: 0x005EDF4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRecommendBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017573 RID: 95603 RVA: 0x005EFE13 File Offset: 0x005EE013
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<TowerCurrentTeamRoleItem, int>(base.GetHorizontalLayout(0), new Func<TowerCurrentTeamRoleItem>(this.InitRoleItem), null, false, true);
		this.Refresh();
	}

	// Token: 0x06017574 RID: 95604 RVA: 0x005EFE3C File Offset: 0x005EE03C
	public void Refresh()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		int[] array = new int[3];
		foreach (int num in from k in roleIndexMap.Keys
		orderby k
		select k)
		{
			if (num >= 1 && num <= 3)
			{
				array[num - 1] = roleIndexMap[num].GetDataId();
			}
		}
		this.RoleLayout.RefreshByData(array, null, false);
	}

	// Token: 0x06017575 RID: 95605 RVA: 0x005EFEE0 File Offset: 0x005EE0E0
	[NullableContext(1)]
	private TowerCurrentTeamRoleItem InitRoleItem()
	{
		return new TowerCurrentTeamRoleItem();
	}

	// Token: 0x06017576 RID: 95606 RVA: 0x005EFEE7 File Offset: 0x005EE0E7
	private void OnClickRecommendBtn()
	{
		TowerController.Instance.TowerFormationRecommendRequest(TowerModel.Instance.CurrentSelectFloor).Finally(delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TowerRecommendView, null, null);
		}).Forget();
	}

	// Token: 0x06017577 RID: 95607 RVA: 0x005EFF26 File Offset: 0x005EE126
	protected override void OnBeforeDestroy()
	{
		this.RoleLayout = null;
	}

	// Token: 0x0400AEBA RID: 44730
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerCurrentTeamRoleItem, int> RoleLayout;

	// Token: 0x020091A0 RID: 37280
	private enum EChildType
	{
		// Token: 0x0402F1F0 RID: 193008
		RoleLayout,
		// Token: 0x0402F1F1 RID: 193009
		RoleItem,
		// Token: 0x0402F1F2 RID: 193010
		RecommendBtn
	}
}
