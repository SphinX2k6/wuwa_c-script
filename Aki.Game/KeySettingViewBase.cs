using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

// Token: 0x020014FC RID: 5372
[NullableContext(2)]
[Nullable(0)]
public class KeySettingViewBase : UiViewBase
{
	// Token: 0x0600D6A2 RID: 54946 RVA: 0x003FA743 File Offset: 0x003F8943
	[NullableContext(1)]
	public KeySettingViewBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D6A3 RID: 54947 RVA: 0x003FA74C File Offset: 0x003F894C
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

	// Token: 0x0600D6A4 RID: 54948 RVA: 0x003FA7E8 File Offset: 0x003F89E8
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

	// Token: 0x0600D6A5 RID: 54949 RVA: 0x003FA882 File Offset: 0x003F8A82
	protected virtual void OnWaitKeySetting()
	{
	}

	// Token: 0x0600D6A6 RID: 54950 RVA: 0x003FA884 File Offset: 0x003F8A84
	protected virtual void OnBeforeBeginEditKey()
	{
	}

	// Token: 0x0600D6A7 RID: 54951 RVA: 0x003FA886 File Offset: 0x003F8A86
	protected virtual void OnBeginEditKey()
	{
	}

	// Token: 0x0600D6A8 RID: 54952 RVA: 0x003FA888 File Offset: 0x003F8A88
	protected virtual void OnFinishEditKey()
	{
	}

	// Token: 0x0600D6A9 RID: 54953 RVA: 0x003FA88A File Offset: 0x003F8A8A
	[NullableContext(1)]
	protected virtual void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x0600D6AA RID: 54954 RVA: 0x003FA88C File Offset: 0x003F8A8C
	protected virtual void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x0600D6AB RID: 54955 RVA: 0x003FA88E File Offset: 0x003F8A8E
	protected virtual void OnKeyHover(KeySettingRowData data)
	{
	}

	// Token: 0x0600D6AC RID: 54956 RVA: 0x003FA890 File Offset: 0x003F8A90
	protected virtual void OnKeyUnHover(KeySettingRowData data)
	{
	}

	// Token: 0x0600D6AD RID: 54957 RVA: 0x003FA892 File Offset: 0x003F8A92
	[NullableContext(1)]
	private void DelegateOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		this.OnWaitKeySetting();
	}

	// Token: 0x0600D6AE RID: 54958 RVA: 0x003FA89A File Offset: 0x003F8A9A
	private void DelegateOnBeforeBeginEditKey()
	{
		this.OnBeforeBeginEditKey();
	}

	// Token: 0x0600D6AF RID: 54959 RVA: 0x003FA8A2 File Offset: 0x003F8AA2
	private void DelegateOnBeginEditKey()
	{
		this.OnBeginEditKey();
	}

	// Token: 0x0600D6B0 RID: 54960 RVA: 0x003FA8AA File Offset: 0x003F8AAA
	private void DelegateOnFinishEditKey()
	{
		this.OnFinishEditKey();
	}

	// Token: 0x0600D6B1 RID: 54961 RVA: 0x003FA8B2 File Offset: 0x003F8AB2
	[NullableContext(1)]
	private void DelegateOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
		this.OnKeyChange(data, type);
	}

	// Token: 0x0600D6B2 RID: 54962 RVA: 0x003FA8BC File Offset: 0x003F8ABC
	private void DelegateOnKeySelected(KeySettingRowData data)
	{
		this.OnKeySelected(data);
	}

	// Token: 0x0600D6B3 RID: 54963 RVA: 0x003FA8C5 File Offset: 0x003F8AC5
	private void DelegateOnKeyHover(KeySettingRowData data)
	{
		this.OnKeyHover(data);
	}

	// Token: 0x0600D6B4 RID: 54964 RVA: 0x003FA8CE File Offset: 0x003F8ACE
	private void DelegateOnKeyUnHover(KeySettingRowData data)
	{
		this.OnKeyUnHover(data);
	}
}
