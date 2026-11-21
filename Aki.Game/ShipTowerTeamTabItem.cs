using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F58 RID: 8024
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06013D4F RID: 81231 RVA: 0x005C8CA0 File Offset: 0x005C6EA0
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

	// Token: 0x06013D50 RID: 81232 RVA: 0x005C8D20 File Offset: 0x005C6F20
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamTabItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamTabItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D51 RID: 81233 RVA: 0x005C8D63 File Offset: 0x005C6F63
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06013D52 RID: 81234 RVA: 0x005C8D71 File Offset: 0x005C6F71
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06013D53 RID: 81235 RVA: 0x005C8D8A File Offset: 0x005C6F8A
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		this.GetTabToggle().SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x06013D54 RID: 81236 RVA: 0x005C8D9B File Offset: 0x005C6F9B
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? "");
		}
	}

	// Token: 0x06013D55 RID: 81237 RVA: 0x005C8DBF File Offset: 0x005C6FBF
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06013D56 RID: 81238 RVA: 0x005C8DC1 File Offset: 0x005C6FC1
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06013D57 RID: 81239 RVA: 0x005C8DCA File Offset: 0x005C6FCA
	public void UpdateName(string name)
	{
		base.GetText(1).ShowTextNew(name);
	}

	// Token: 0x06013D58 RID: 81240 RVA: 0x005C8DD9 File Offset: 0x005C6FD9
	public void UpdateNameText(string name)
	{
		base.GetText(1).SetText(name, true);
	}

	// Token: 0x06013D59 RID: 81241 RVA: 0x005C8DE9 File Offset: 0x005C6FE9
	public void UpdateRedDotVisible(bool visible)
	{
		this.GetRedDotItem().SetUIActive(visible);
	}

	// Token: 0x06013D5A RID: 81242 RVA: 0x005C8DF7 File Offset: 0x005C6FF7
	private UUIItem GetRedDotItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x06013D5B RID: 81243 RVA: 0x005C8E00 File Offset: 0x005C7000
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06013D5C RID: 81244 RVA: 0x005C8E3E File Offset: 0x005C703E
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, this.GetRedDotItem(), null, uId);
		}
	}

	// Token: 0x06013D5D RID: 81245 RVA: 0x005C8E76 File Offset: 0x005C7076
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, this.GetRedDotItem(), uId);
		}
	}

	// Token: 0x06013D5E RID: 81246 RVA: 0x005C8EA1 File Offset: 0x005C70A1
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06013D5F RID: 81247 RVA: 0x005C8ED1 File Offset: 0x005C70D1
	protected override void OnBeforeDestroy()
	{
		this.UnBindGivenUid(0);
	}

	// Token: 0x0400A935 RID: 43317
	private ERedDotName? RedDotName;

	// Token: 0x02008252 RID: 33362
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A133 RID: 172339
		public const int SwitchToggle = 0;

		// Token: 0x0402A134 RID: 172340
		public const int Name = 1;

		// Token: 0x0402A135 RID: 172341
		public const int RedDot = 2;
	}
}
