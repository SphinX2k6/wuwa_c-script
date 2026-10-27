using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200283C RID: 10300
[NullableContext(2)]
[Nullable(0)]
public class RoleDevWeaponViewItem : UiPanelBase
{
	// Token: 0x060153E4 RID: 87012 RVA: 0x0055E9B8 File Offset: 0x0055CBB8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060153E5 RID: 87013 RVA: 0x0055E9F4 File Offset: 0x0055CBF4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevWeaponViewItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevWeaponViewItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060153E6 RID: 87014 RVA: 0x0055EA37 File Offset: 0x0055CC37
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x060153E7 RID: 87015 RVA: 0x0055EA51 File Offset: 0x0055CC51
	[NullableContext(1)]
	public void RefreshByData(RoleDevWeaponViewItemDataBase data)
	{
		this.Data = data;
		this.Refresh();
	}

	// Token: 0x060153E8 RID: 87016 RVA: 0x0055EA60 File Offset: 0x0055CC60
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

	// Token: 0x060153E9 RID: 87017 RVA: 0x0055EADF File Offset: 0x0055CCDF
	public void SetType(ERoleDevWeaponTabType type)
	{
		this.Data.TabType = type;
		if (type == ERoleDevWeaponTabType.WeaponRecommend)
		{
			RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Weapon, ERoleDevSubPageButton.ViewRecommendedWeapons);
		}
		this.Refresh();
	}

	// Token: 0x04009EB7 RID: 40631
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04009EB8 RID: 40632
	private RoleDevWeaponDevItem WeaponDevItem;

	// Token: 0x04009EB9 RID: 40633
	private RoleDevWeaponRecommendItem WeaponRecommendItem;

	// Token: 0x04009EBA RID: 40634
	private RoleDevWeaponViewItemDataBase Data;

	// Token: 0x02008E81 RID: 36481
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E385 RID: 189317
		PlanWeaponDevelop,
		// Token: 0x0402E386 RID: 189318
		PlanWeaponRecommend
	}
}
