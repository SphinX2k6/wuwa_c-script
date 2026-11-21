using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DB7 RID: 7607
[NullableContext(2)]
[Nullable(0)]
public class RoleDevWeaponViewItem : UiPanelBase
{
	// Token: 0x06012DE2 RID: 77282 RVA: 0x00589714 File Offset: 0x00587914
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012DE3 RID: 77283 RVA: 0x00589750 File Offset: 0x00587950
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponViewItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponViewItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DE4 RID: 77284 RVA: 0x00589793 File Offset: 0x00587993
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06012DE5 RID: 77285 RVA: 0x005897AD File Offset: 0x005879AD
	[NullableContext(1)]
	public void RefreshByData(RoleDevWeaponViewItemDataBase data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x06012DE6 RID: 77286 RVA: 0x005897BC File Offset: 0x005879BC
	public void Refresh()
	{
		ERoleDevWeaponTabType tabType = this.Data.TabType;
		if (tabType == ERoleDevWeaponTabType.WeaponDev)
		{
			this.WeaponDevItem.Refresh(this.Data.DevItemData);
			base.GetItem(0).SetUIActive(true);
			base.GetItem(1).SetUIActive(false);
		}
		if (tabType == ERoleDevWeaponTabType.WeaponRecommend)
		{
			this.WeaponRecommendItem.Refresh(this.Data.RecommendItemData);
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
		}
	}

	// Token: 0x06012DE7 RID: 77287 RVA: 0x0058983B File Offset: 0x00587A3B
	public void SetType(ERoleDevWeaponTabType type)
	{
		this.Data.TabType = type;
		if (type == ERoleDevWeaponTabType.WeaponRecommend)
		{
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Weapon, ERoleDevSubPageButton.ViewRecommendedWeapons);
		}
		this.Refresh();
	}

	// Token: 0x0400A2A0 RID: 41632
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x0400A2A1 RID: 41633
	private RoleDevWeaponDevItem WeaponDevItem;

	// Token: 0x0400A2A2 RID: 41634
	private RoleDevWeaponRecommendItem WeaponRecommendItem;

	// Token: 0x0400A2A3 RID: 41635
	private RoleDevWeaponViewItemDataBase Data;

	// Token: 0x020080C7 RID: 32967
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A7F RID: 170623
		PlanWeaponDevelop,
		// Token: 0x04029A80 RID: 170624
		PlanWeaponRecommend
	}
}
