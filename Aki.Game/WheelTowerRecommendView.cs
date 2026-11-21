using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000ADF RID: 2783
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerRecommendView : UiViewBase
{
	// Token: 0x06007381 RID: 29569 RVA: 0x0023AFFB File Offset: 0x002391FB
	public WheelTowerRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007382 RID: 29570 RVA: 0x0023B004 File Offset: 0x00239204
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007383 RID: 29571 RVA: 0x0023B070 File Offset: 0x00239270
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecommendView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecommendView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007384 RID: 29572 RVA: 0x0023B0B3 File Offset: 0x002392B3
	private WheelTowerRecommendTeam CreateTeamItem()
	{
		return new WheelTowerRecommendTeam
		{
			OnApplyBtnClick = new Action<NewTowerRecommendTeam>(this.OnApplyBtnClick)
		};
	}

	// Token: 0x06007385 RID: 29573 RVA: 0x0023B0CC File Offset: 0x002392CC
	private void OnApplyBtnClick(NewTowerRecommendTeam data)
	{
		List<int> list = new List<int>();
		foreach (int num in data.RoleIds)
		{
			MainRoleConfig? correctMainRoleConfig = RoleModel.Instance.GetCorrectMainRoleConfig(num);
			list.Add((correctMainRoleConfig != null) ? correctMainRoleConfig.Value.Id : num);
		}
		WheelTowerModel.Instance.SelectedRoleList = list;
		WheelTowerModel.Instance.SelectedBuff = ((data.BuffIds.Count > 0) ? data.BuffIds[0] : 0);
		int num2 = 0;
		while (num2 < data.SkillBranchIds.Count && num2 < list.Count)
		{
			RoleModel.Instance.SetRoleSkillBranchGamePlayCache(list[num2], data.SkillBranchIds[num2], ESkillBranchCacheType.WheelTower);
			num2++;
		}
		base.CloseMe(null);
	}

	// Token: 0x040048E6 RID: 18662
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRecommendTeam, NewTowerRecommendTeam> TeamScrollView;
}
