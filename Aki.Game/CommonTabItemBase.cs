using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E78 RID: 3704
[NullableContext(1)]
[Nullable(0)]
public abstract class CommonTabItemBase : UiPanelBase, IGridProxy<CommonTabItemData>
{
	// Token: 0x06009461 RID: 37985 RVA: 0x002C0D21 File Offset: 0x002BEF21
	public CommonTabItemBase()
	{
	}

	// Token: 0x1700103E RID: 4158
	// (get) Token: 0x06009462 RID: 37986 RVA: 0x002C0D29 File Offset: 0x002BEF29
	// (set) Token: 0x06009463 RID: 37987 RVA: 0x002C0D31 File Offset: 0x002BEF31
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

	// Token: 0x1700103F RID: 4159
	// (get) Token: 0x06009464 RID: 37988 RVA: 0x002C0D3A File Offset: 0x002BEF3A
	// (set) Token: 0x06009465 RID: 37989 RVA: 0x002C0D42 File Offset: 0x002BEF42
	public int GridIndex { get; set; }

	// Token: 0x17001040 RID: 4160
	// (get) Token: 0x06009466 RID: 37990 RVA: 0x002C0D4B File Offset: 0x002BEF4B
	// (set) Token: 0x06009467 RID: 37991 RVA: 0x002C0D53 File Offset: 0x002BEF53
	public int DisplayIndex { get; set; }

	// Token: 0x06009468 RID: 37992 RVA: 0x002C0D5C File Offset: 0x002BEF5C
	public virtual void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
	}

	// Token: 0x06009469 RID: 37993 RVA: 0x002C0D6E File Offset: 0x002BEF6E
	protected virtual void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600946A RID: 37994 RVA: 0x002C0D70 File Offset: 0x002BEF70
	public virtual void Clear()
	{
		this.OnClear();
	}

	// Token: 0x0600946B RID: 37995 RVA: 0x002C0D78 File Offset: 0x002BEF78
	protected virtual void OnClear()
	{
	}

	// Token: 0x0600946C RID: 37996 RVA: 0x002C0D7A File Offset: 0x002BEF7A
	public virtual void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600946D RID: 37997 RVA: 0x002C0D7C File Offset: 0x002BEF7C
	public virtual void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600946E RID: 37998 RVA: 0x002C0D7E File Offset: 0x002BEF7E
	public void CreateThenShowByActor(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x0600946F RID: 37999 RVA: 0x002C0D88 File Offset: 0x002BEF88
	public UniTask CreateThenShowByActorAsync(AActor actor)
	{
		return base.CreateThenShowByActorAsync(actor, null, false);
	}

	// Token: 0x06009470 RID: 38000 RVA: 0x002C0D93 File Offset: 0x002BEF93
	public UniTask CreateByActorAsync(AActor actor)
	{
		return base.CreateByActorAsync(actor, null, false);
	}

	// Token: 0x06009471 RID: 38001 RVA: 0x002C0D9E File Offset: 0x002BEF9E
	public virtual object GetKey(CommonTabItemData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x06009472 RID: 38002 RVA: 0x002C0DAB File Offset: 0x002BEFAB
	public virtual void InitTabItem()
	{
	}

	// Token: 0x06009473 RID: 38003 RVA: 0x002C0DAD File Offset: 0x002BEFAD
	protected override void OnStart()
	{
		this.GetTabToggle().CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06009474 RID: 38004 RVA: 0x002C0DCB File Offset: 0x002BEFCB
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

	// Token: 0x06009475 RID: 38005 RVA: 0x002C0DF5 File Offset: 0x002BEFF5
	public void SetSelectedCallBack(Action<int> callback)
	{
		this.SelectedCallBack = callback;
	}

	// Token: 0x06009476 RID: 38006 RVA: 0x002C0DFE File Offset: 0x002BEFFE
	public void SetCanExecuteChange(Func<int, bool, bool> callback)
	{
		this.CanExecuteChangeFunction = callback;
	}

	// Token: 0x06009477 RID: 38007 RVA: 0x002C0E07 File Offset: 0x002BF007
	public void UpdateTabIcon(string iconPath)
	{
		this.OnUpdateTabIcon(iconPath);
	}

	// Token: 0x06009478 RID: 38008 RVA: 0x002C0E10 File Offset: 0x002BF010
	public void SetForceSwitch(EToggleState state, bool bFire = false)
	{
		this.AllowForceSwitch = true;
		this.SetToggleState(state, bFire);
	}

	// Token: 0x06009479 RID: 38009 RVA: 0x002C0E21 File Offset: 0x002BF021
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		this.OnSetToggleState(state, bFire);
	}

	// Token: 0x0600947A RID: 38010
	protected abstract void OnUpdateTabIcon(string iconPath);

	// Token: 0x0600947B RID: 38011
	protected abstract void OnSetToggleState(EToggleState state, bool bFire);

	// Token: 0x0600947C RID: 38012
	protected abstract UUIExtendToggle GetTabToggle();

	// Token: 0x0400571A RID: 22298
	[Nullable(2)]
	protected CommonTabItemData CurrentData;

	// Token: 0x0400571E RID: 22302
	private bool AllowForceSwitch;

	// Token: 0x0400571F RID: 22303
	[Nullable(2)]
	protected Action<int> SelectedCallBack;

	// Token: 0x04005720 RID: 22304
	[Nullable(2)]
	private Func<int, bool, bool> CanExecuteChangeFunction;
}
