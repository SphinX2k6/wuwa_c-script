using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

// Token: 0x020014FB RID: 5371
[NullableContext(2)]
[Nullable(0)]
public class KeySettingPanelBase : UiPanelBase
{
	// Token: 0x0600D68F RID: 54927 RVA: 0x003FA59C File Offset: 0x003F879C
	public KeySettingPanelBase(EKeySettingExclusiveType exclusiveType = EKeySettingExclusiveType.None)
	{
		this.ExclusiveType = exclusiveType;
	}

	// Token: 0x0600D690 RID: 54928 RVA: 0x003FA5AC File Offset: 0x003F87AC
	protected override void OnStartImplement()
	{
		KeySettingViewModel.InitData(this.ExclusiveType);
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

	// Token: 0x0600D691 RID: 54929 RVA: 0x003FA654 File Offset: 0x003F8854
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

	// Token: 0x0600D692 RID: 54930 RVA: 0x003FA6EE File Offset: 0x003F88EE
	protected virtual void OnWaitKeySetting()
	{
	}

	// Token: 0x0600D693 RID: 54931 RVA: 0x003FA6F0 File Offset: 0x003F88F0
	protected virtual void OnBeforeBeginEditKey()
	{
	}

	// Token: 0x0600D694 RID: 54932 RVA: 0x003FA6F2 File Offset: 0x003F88F2
	protected virtual void OnBeginEditKey()
	{
	}

	// Token: 0x0600D695 RID: 54933 RVA: 0x003FA6F4 File Offset: 0x003F88F4
	protected virtual void OnFinishEditKey()
	{
	}

	// Token: 0x0600D696 RID: 54934 RVA: 0x003FA6F6 File Offset: 0x003F88F6
	[NullableContext(1)]
	protected virtual void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x0600D697 RID: 54935 RVA: 0x003FA6F8 File Offset: 0x003F88F8
	protected virtual void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x0600D698 RID: 54936 RVA: 0x003FA6FA File Offset: 0x003F88FA
	protected virtual void OnKeyHover(KeySettingRowData data)
	{
	}

	// Token: 0x0600D699 RID: 54937 RVA: 0x003FA6FC File Offset: 0x003F88FC
	protected virtual void OnKeyUnHover(KeySettingRowData data)
	{
	}

	// Token: 0x0600D69A RID: 54938 RVA: 0x003FA6FE File Offset: 0x003F88FE
	[NullableContext(1)]
	private void DelegateOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		this.OnWaitKeySetting();
	}

	// Token: 0x0600D69B RID: 54939 RVA: 0x003FA706 File Offset: 0x003F8906
	private void DelegateOnBeforeBeginEditKey()
	{
		this.OnBeforeBeginEditKey();
	}

	// Token: 0x0600D69C RID: 54940 RVA: 0x003FA70E File Offset: 0x003F890E
	private void DelegateOnBeginEditKey()
	{
		this.OnBeginEditKey();
	}

	// Token: 0x0600D69D RID: 54941 RVA: 0x003FA716 File Offset: 0x003F8916
	private void DelegateOnFinishEditKey()
	{
		this.OnFinishEditKey();
	}

	// Token: 0x0600D69E RID: 54942 RVA: 0x003FA71E File Offset: 0x003F891E
	[NullableContext(1)]
	private void DelegateOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
		this.OnKeyChange(data, type);
	}

	// Token: 0x0600D69F RID: 54943 RVA: 0x003FA728 File Offset: 0x003F8928
	private void DelegateOnKeySelected(KeySettingRowData data)
	{
		this.OnKeySelected(data);
	}

	// Token: 0x0600D6A0 RID: 54944 RVA: 0x003FA731 File Offset: 0x003F8931
	private void DelegateOnKeyHover(KeySettingRowData data)
	{
		this.OnKeyHover(data);
	}

	// Token: 0x0600D6A1 RID: 54945 RVA: 0x003FA73A File Offset: 0x003F893A
	private void DelegateOnKeyUnHover(KeySettingRowData data)
	{
		this.OnKeyUnHover(data);
	}

	// Token: 0x04007850 RID: 30800
	private readonly EKeySettingExclusiveType ExclusiveType;
}
