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

// Token: 0x02001627 RID: 5671
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerRecommendView : UiViewBase
{
	// Token: 0x06009FA3 RID: 40867 RVA: 0x002311AF File Offset: 0x0022F3AF
	public WheelTowerRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FA4 RID: 40868 RVA: 0x002311B8 File Offset: 0x0022F3B8
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

	// Token: 0x06009FA5 RID: 40869 RVA: 0x00231224 File Offset: 0x0022F424
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerRecommendView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerRecommendView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FA6 RID: 40870 RVA: 0x00231267 File Offset: 0x0022F467
	private WheelTowerRecommendTeam CreateTeamItem()
	{
		return new WheelTowerRecommendTeam
		{
			OnApplyBtnClick = new Action<NewTowerRecommendTeam>(this.OnApplyBtnClick)
		};
	}

	// Token: 0x06009FA7 RID: 40871 RVA: 0x00231280 File Offset: 0x0022F480
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

	// Token: 0x04004840 RID: 18496
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerRecommendTeam, NewTowerRecommendTeam> TeamScrollView;
}
