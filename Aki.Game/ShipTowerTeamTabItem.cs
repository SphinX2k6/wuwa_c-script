using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029DD RID: 10717
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06016349 RID: 90953 RVA: 0x0059DCE8 File Offset: 0x0059BEE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleToggle))
		};
	}

	// Token: 0x0601634A RID: 90954 RVA: 0x0059DD68 File Offset: 0x0059BF68
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamTabItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamTabItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601634B RID: 90955 RVA: 0x0059DDAB File Offset: 0x0059BFAB
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0601634C RID: 90956 RVA: 0x0059DDB9 File Offset: 0x0059BFB9
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0601634D RID: 90957 RVA: 0x0059DDD2 File Offset: 0x0059BFD2
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		this.GetTabToggle().SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0601634E RID: 90958 RVA: 0x0059DDE3 File Offset: 0x0059BFE3
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? "");
		}
	}

	// Token: 0x0601634F RID: 90959 RVA: 0x0059DE07 File Offset: 0x0059C007
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06016350 RID: 90960 RVA: 0x0059DE09 File Offset: 0x0059C009
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06016351 RID: 90961 RVA: 0x0059DE12 File Offset: 0x0059C012
	public void UpdateName(string name)
	{
		base.GetText(1).ShowTextNew(name);
	}

	// Token: 0x06016352 RID: 90962 RVA: 0x0059DE21 File Offset: 0x0059C021
	public void UpdateNameText(string name)
	{
		base.GetText(1).SetText(name, true);
	}

	// Token: 0x06016353 RID: 90963 RVA: 0x0059DE31 File Offset: 0x0059C031
	public void UpdateRedDotVisible(bool visible)
	{
		this.GetRedDotItem().SetUIActive(visible);
	}

	// Token: 0x06016354 RID: 90964 RVA: 0x0059DE3F File Offset: 0x0059C03F
	private UUIItem GetRedDotItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x06016355 RID: 90965 RVA: 0x0059DE48 File Offset: 0x0059C048
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06016356 RID: 90966 RVA: 0x0059DE86 File Offset: 0x0059C086
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06016357 RID: 90967 RVA: 0x0059DEBE File Offset: 0x0059C0BE
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, this.GetRedDotItem(), uId);
		}
	}

	// Token: 0x06016358 RID: 90968 RVA: 0x0059DEE9 File Offset: 0x0059C0E9
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06016359 RID: 90969 RVA: 0x0059DF19 File Offset: 0x0059C119
	protected override void OnBeforeDestroy()
	{
		this.UnBindGivenUid(0);
	}

	// Token: 0x0400A54B RID: 42315
	private ERedDotName? RedDotName;

	// Token: 0x0200900B RID: 36875
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA3B RID: 191035
		public const int SwitchToggle = 0;

		// Token: 0x0402EA3C RID: 191036
		public const int Name = 1;

		// Token: 0x0402EA3D RID: 191037
		public const int RedDot = 2;
	}
}
