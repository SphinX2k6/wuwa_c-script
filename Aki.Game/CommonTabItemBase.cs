using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020019BA RID: 6586
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonTabItemBase : UiPanelBase, IGridProxy<CommonTabItemData>
{
	// Token: 0x0600C057 RID: 49239 RVA: 0x002B5D91 File Offset: 0x002B3F91
	public CommonTabItemBase()
	{
	}

	// Token: 0x17001019 RID: 4121
	// (get) Token: 0x0600C058 RID: 49240 RVA: 0x002B5D99 File Offset: 0x002B3F99
	// (set) Token: 0x0600C059 RID: 49241 RVA: 0x002B5DA1 File Offset: 0x002B3FA1
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<CommonTabItemData>, CommonTabItemData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x1700101A RID: 4122
	// (get) Token: 0x0600C05A RID: 49242 RVA: 0x002B5DAA File Offset: 0x002B3FAA
	// (set) Token: 0x0600C05B RID: 49243 RVA: 0x002B5DB2 File Offset: 0x002B3FB2
	public int GridIndex { get; set; }

	// Token: 0x1700101B RID: 4123
	// (get) Token: 0x0600C05C RID: 49244 RVA: 0x002B5DBB File Offset: 0x002B3FBB
	// (set) Token: 0x0600C05D RID: 49245 RVA: 0x002B5DC3 File Offset: 0x002B3FC3
	public int DisplayIndex { get; set; }

	// Token: 0x0600C05E RID: 49246 RVA: 0x002B5DCC File Offset: 0x002B3FCC
	public virtual void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
	}

	// Token: 0x0600C05F RID: 49247 RVA: 0x002B5DDE File Offset: 0x002B3FDE
	protected virtual void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600C060 RID: 49248 RVA: 0x002B5DE0 File Offset: 0x002B3FE0
	public virtual void Clear()
	{
		this.OnClear();
	}

	// Token: 0x0600C061 RID: 49249 RVA: 0x002B5DE8 File Offset: 0x002B3FE8
	protected virtual void OnClear()
	{
	}

	// Token: 0x0600C062 RID: 49250 RVA: 0x002B5DEA File Offset: 0x002B3FEA
	public virtual void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C063 RID: 49251 RVA: 0x002B5DEC File Offset: 0x002B3FEC
	public virtual void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C064 RID: 49252 RVA: 0x002B5DEE File Offset: 0x002B3FEE
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x0600C065 RID: 49253 RVA: 0x002B5DF8 File Offset: 0x002B3FF8
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		return base.CreateThenShowByActorAsync(actor, null, false);
	}

	// Token: 0x0600C066 RID: 49254 RVA: 0x002B5E03 File Offset: 0x002B4003
	public UniTask CreateByActorAsync(AActor actor)
	{
		return base.CreateByActorAsync(actor, null, false);
	}

	// Token: 0x0600C067 RID: 49255 RVA: 0x002B5E0E File Offset: 0x002B400E
	public virtual object GetKey(CommonTabItemData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0600C068 RID: 49256 RVA: 0x002B5E1B File Offset: 0x002B401B
	public virtual void InitTabItem()
	{
	}

	// Token: 0x0600C069 RID: 49257 RVA: 0x002B5E1D File Offset: 0x002B401D
	protected override void OnStart()
	{
		this.GetTabToggle().CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600C06A RID: 49258 RVA: 0x002B5E3B File Offset: 0x002B403B
	private bool CanExecuteChange()
	{
		if (this.CanExecuteChangeFunction != null)
		{
			bool result = this.CanExecuteChangeFunction(this.GridIndex, this.AllowForceSwitch);
			this.AllowForceSwitch = false;
			return result;
		}
		return true;
	}

	// Token: 0x0600C06B RID: 49259 RVA: 0x002B5E65 File Offset: 0x002B4065
	public void SetSelectedCallBack(Action<int> callback)
	{
		this.SelectedCallBack = callback;
	}

	// Token: 0x0600C06C RID: 49260 RVA: 0x002B5E6E File Offset: 0x002B406E
	public void SetCanExecuteChange(Func<int, bool, bool> callback)
	{
		this.CanExecuteChangeFunction = callback;
	}

	// Token: 0x0600C06D RID: 49261 RVA: 0x002B5E77 File Offset: 0x002B4077
	public void UpdateTabIcon(string iconPath)
	{
		this.OnUpdateTabIcon(iconPath);
	}

	// Token: 0x0600C06E RID: 49262 RVA: 0x002B5E80 File Offset: 0x002B4080
	public void SetForceSwitch(EToggleState state, bool bFire = false)
	{
		this.AllowForceSwitch = true;
		this.SetToggleState(state, bFire);
	}

	// Token: 0x0600C06F RID: 49263 RVA: 0x002B5E91 File Offset: 0x002B4091
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		this.OnSetToggleState(state, bFire);
	}

	// Token: 0x0600C070 RID: 49264
	protected abstract void OnUpdateTabIcon(string iconPath);

	// Token: 0x0600C071 RID: 49265
	protected abstract void OnSetToggleState(EToggleState state, bool bFire);

	// Token: 0x0600C072 RID: 49266
	protected abstract UUIExtendToggle GetTabToggle();

	// Token: 0x04005668 RID: 22120
	[Nullable(2)]
	protected CommonTabItemData CurrentData;

	// Token: 0x0400566C RID: 22124
	private bool AllowForceSwitch;

	// Token: 0x0400566D RID: 22125
	[Nullable(2)]
	protected Action<int> SelectedCallBack;

	// Token: 0x0400566E RID: 22126
	[Nullable(2)]
	private Func<int, bool, bool> CanExecuteChangeFunction;
}
