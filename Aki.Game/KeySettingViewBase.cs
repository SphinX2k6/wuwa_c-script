using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

// Token: 0x02002029 RID: 8233
[NullableContext(2)]
[Nullable(0)]
public class KeySettingViewBase : UiViewBase
{
	// Token: 0x0601023A RID: 66106 RVA: 0x003EE14B File Offset: 0x003EC34B
	[NullableContext(1)]
	public KeySettingViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601023B RID: 66107 RVA: 0x003EE154 File Offset: 0x003EC354
	protected override void OnStartImplementImplement()
	{
		KeySettingViewModel.OnViewStart();
		KeySettingViewModel.AddOnWaitKeySettingDelegate(new Action<KeySettingRowData, IKeySettingItem>(this.DelegateOnWaitKeySetting));
		KeySettingViewModel.AddOnBeforeBeginEditKeyDelegate(new Action(this.DelegateOnBeforeBeginEditKey));
		KeySettingViewModel.AddOnBeginEditKeyDelegate(new Action(this.DelegateOnBeginEditKey));
		KeySettingViewModel.AddOnFinishEditKeyDelegate(new Action(this.DelegateOnFinishEditKey));
		KeySettingViewModel.AddOnKeySelectedDelegate(new Action<KeySettingRowData>(this.DelegateOnKeySelected));
		KeySettingViewModel.AddOnKeyChangeDelegate(new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.DelegateOnKeyChange));
		KeySettingViewModel.AddOnKeyHoverDelegate(new Action<KeySettingRowData>(this.DelegateOnKeyHover));
		KeySettingViewModel.AddOnKeyUnHoverDelegate(new Action<KeySettingRowData>(this.DelegateOnKeyUnHover));
	}

	// Token: 0x0601023C RID: 66108 RVA: 0x003EE1F0 File Offset: 0x003EC3F0
	protected override void OnBeforeDestroyImplement()
	{
		KeySettingViewModel.RemoveOnWaitKeySettingDelegate(new Action<KeySettingRowData, IKeySettingItem>(this.DelegateOnWaitKeySetting));
		KeySettingViewModel.RemoveOnBeforeBeginEditKeyDelegate(new Action(this.DelegateOnBeforeBeginEditKey));
		KeySettingViewModel.RemoveOnBeginEditKeyDelegate(new Action(this.DelegateOnBeginEditKey));
		KeySettingViewModel.RemoveOnFinishEditKeyDelegate(new Action(this.DelegateOnFinishEditKey));
		KeySettingViewModel.RemoveOnKeySelectedDelegate(new Action<KeySettingRowData>(this.DelegateOnKeySelected));
		KeySettingViewModel.RemoveOnKeyChangeDelegate(new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(this.DelegateOnKeyChange));
		KeySettingViewModel.RemoveOnKeyHoverDelegate(new Action<KeySettingRowData>(this.DelegateOnKeyHover));
		KeySettingViewModel.RemoveOnKeyUnHoverDelegate(new Action<KeySettingRowData>(this.DelegateOnKeyUnHover));
		KeySettingViewModel.OnViewDestroy();
	}

	// Token: 0x0601023D RID: 66109 RVA: 0x003EE28A File Offset: 0x003EC48A
	protected virtual void OnWaitKeySetting()
	{
	}

	// Token: 0x0601023E RID: 66110 RVA: 0x003EE28C File Offset: 0x003EC48C
	protected virtual void OnBeforeBeginEditKey()
	{
	}

	// Token: 0x0601023F RID: 66111 RVA: 0x003EE28E File Offset: 0x003EC48E
	protected virtual void OnBeginEditKey()
	{
	}

	// Token: 0x06010240 RID: 66112 RVA: 0x003EE290 File Offset: 0x003EC490
	protected virtual void OnFinishEditKey()
	{
	}

	// Token: 0x06010241 RID: 66113 RVA: 0x003EE292 File Offset: 0x003EC492
	[NullableContext(1)]
	protected virtual void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x06010242 RID: 66114 RVA: 0x003EE294 File Offset: 0x003EC494
	protected virtual void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x06010243 RID: 66115 RVA: 0x003EE296 File Offset: 0x003EC496
	protected virtual void OnKeyHover(KeySettingRowData data)
	{
	}

	// Token: 0x06010244 RID: 66116 RVA: 0x003EE298 File Offset: 0x003EC498
	protected virtual void OnKeyUnHover(KeySettingRowData data)
	{
	}

	// Token: 0x06010245 RID: 66117 RVA: 0x003EE29A File Offset: 0x003EC49A
	[NullableContext(1)]
	private void DelegateOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		this.OnWaitKeySetting();
	}

	// Token: 0x06010246 RID: 66118 RVA: 0x003EE2A2 File Offset: 0x003EC4A2
	private void DelegateOnBeforeBeginEditKey()
	{
		this.OnBeforeBeginEditKey();
	}

	// Token: 0x06010247 RID: 66119 RVA: 0x003EE2AA File Offset: 0x003EC4AA
	private void DelegateOnBeginEditKey()
	{
		this.OnBeginEditKey();
	}

	// Token: 0x06010248 RID: 66120 RVA: 0x003EE2B2 File Offset: 0x003EC4B2
	private void DelegateOnFinishEditKey()
	{
		this.OnFinishEditKey();
	}

	// Token: 0x06010249 RID: 66121 RVA: 0x003EE2BA File Offset: 0x003EC4BA
	[NullableContext(1)]
	private void DelegateOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
		this.OnKeyChange(data, type);
	}

	// Token: 0x0601024A RID: 66122 RVA: 0x003EE2C4 File Offset: 0x003EC4C4
	private void DelegateOnKeySelected(KeySettingRowData data)
	{
		this.OnKeySelected(data);
	}

	// Token: 0x0601024B RID: 66123 RVA: 0x003EE2CD File Offset: 0x003EC4CD
	private void DelegateOnKeyHover(KeySettingRowData data)
	{
		this.OnKeyHover(data);
	}

	// Token: 0x0601024C RID: 66124 RVA: 0x003EE2D6 File Offset: 0x003EC4D6
	private void DelegateOnKeyUnHover(KeySettingRowData data)
	{
		this.OnKeyUnHover(data);
	}
}
