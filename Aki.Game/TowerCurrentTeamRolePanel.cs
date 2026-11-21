using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200215F RID: 8543
public class TowerCurrentTeamRolePanel : UiPanelBase
{
	// Token: 0x06014FA2 RID: 85922 RVA: 0x0061C87C File Offset: 0x0061AA7C
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

	// Token: 0x06014FA3 RID: 85923 RVA: 0x0061C8C8 File Offset: 0x0061AAC8
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

	// Token: 0x06014FA4 RID: 85924 RVA: 0x0061C98F File Offset: 0x0061AB8F
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<TowerCurrentTeamRoleItem, int>(base.GetHorizontalLayout(0), new Func<TowerCurrentTeamRoleItem>(this.InitRoleItem), null, false, true);
		this.Refresh();
	}

	// Token: 0x06014FA5 RID: 85925 RVA: 0x0061C9B8 File Offset: 0x0061ABB8
	public void Refresh()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		int[] array = new int[3];
		foreach (int num in roleIndexMap.Keys)
		{
			if (num >= 1 && num <= 3)
			{
				array[num - 1] = roleIndexMap[num].GetDataId();
			}
		}
		this.RoleLayout.RefreshByData(array, null, false);
	}

	// Token: 0x06014FA6 RID: 85926 RVA: 0x0061CA40 File Offset: 0x0061AC40
	[NullableContext(1)]
	private TowerCurrentTeamRoleItem InitRoleItem()
	{
		return new TowerCurrentTeamRoleItem();
	}

	// Token: 0x06014FA7 RID: 85927 RVA: 0x0061CA47 File Offset: 0x0061AC47
	private void OnClickRecommendBtn()
	{
		TowerController.Instance.TowerFormationRecommendRequest(TowerModel.Instance.CurrentSelectFloor).Finally(delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TowerRecommendView, null, null);
		}).Forget();
	}

	// Token: 0x06014FA8 RID: 85928 RVA: 0x0061CA86 File Offset: 0x0061AC86
	protected override void OnBeforeDestroy()
	{
		this.RoleLayout = null;
	}

	// Token: 0x0400B2BF RID: 45759
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerCurrentTeamRoleItem, int> RoleLayout;

	// Token: 0x020083E3 RID: 33763
	private enum EChildType
	{
		// Token: 0x0402A8F2 RID: 174322
		RoleLayout,
		// Token: 0x0402A8F3 RID: 174323
		RoleItem,
		// Token: 0x0402A8F4 RID: 174324
		RecommendBtn
	}
}
