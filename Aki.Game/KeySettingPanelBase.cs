using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

// Token: 0x02002028 RID: 8232
[NullableContext(2)]
[Nullable(0)]
public class KeySettingPanelBase : UiPanelBase
{
	// Token: 0x06010227 RID: 66087 RVA: 0x003EDFA4 File Offset: 0x003EC1A4
	public KeySettingPanelBase(EKeySettingExclusiveType exclusiveType = EKeySettingExclusiveType.None)
	{
		this.ExclusiveType = exclusiveType;
	}

	// Token: 0x06010228 RID: 66088 RVA: 0x003EDFB4 File Offset: 0x003EC1B4
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

	// Token: 0x06010229 RID: 66089 RVA: 0x003EE05C File Offset: 0x003EC25C
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

	// Token: 0x0601022A RID: 66090 RVA: 0x003EE0F6 File Offset: 0x003EC2F6
	protected virtual void OnWaitKeySetting()
	{
	}

	// Token: 0x0601022B RID: 66091 RVA: 0x003EE0F8 File Offset: 0x003EC2F8
	protected virtual void OnBeforeBeginEditKey()
	{
	}

	// Token: 0x0601022C RID: 66092 RVA: 0x003EE0FA File Offset: 0x003EC2FA
	protected virtual void OnBeginEditKey()
	{
	}

	// Token: 0x0601022D RID: 66093 RVA: 0x003EE0FC File Offset: 0x003EC2FC
	protected virtual void OnFinishEditKey()
	{
	}

	// Token: 0x0601022E RID: 66094 RVA: 0x003EE0FE File Offset: 0x003EC2FE
	[NullableContext(1)]
	protected virtual void OnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
	}

	// Token: 0x0601022F RID: 66095 RVA: 0x003EE100 File Offset: 0x003EC300
	protected virtual void OnKeySelected(KeySettingRowData data)
	{
	}

	// Token: 0x06010230 RID: 66096 RVA: 0x003EE102 File Offset: 0x003EC302
	protected virtual void OnKeyHover(KeySettingRowData data)
	{
	}

	// Token: 0x06010231 RID: 66097 RVA: 0x003EE104 File Offset: 0x003EC304
	protected virtual void OnKeyUnHover(KeySettingRowData data)
	{
	}

	// Token: 0x06010232 RID: 66098 RVA: 0x003EE106 File Offset: 0x003EC306
	[NullableContext(1)]
	private void DelegateOnWaitKeySetting(KeySettingRowData data, IKeySettingItem item)
	{
		this.OnWaitKeySetting();
	}

	// Token: 0x06010233 RID: 66099 RVA: 0x003EE10E File Offset: 0x003EC30E
	private void DelegateOnBeforeBeginEditKey()
	{
		this.OnBeforeBeginEditKey();
	}

	// Token: 0x06010234 RID: 66100 RVA: 0x003EE116 File Offset: 0x003EC316
	private void DelegateOnBeginEditKey()
	{
		this.OnBeginEditKey();
	}

	// Token: 0x06010235 RID: 66101 RVA: 0x003EE11E File Offset: 0x003EC31E
	private void DelegateOnFinishEditKey()
	{
		this.OnFinishEditKey();
	}

	// Token: 0x06010236 RID: 66102 RVA: 0x003EE126 File Offset: 0x003EC326
	[NullableContext(1)]
	private void DelegateOnKeyChange(KeySettingRowData data, CSharpScript.Game.Module.Menu.EInputControllerType type)
	{
		this.OnKeyChange(data, type);
	}

	// Token: 0x06010237 RID: 66103 RVA: 0x003EE130 File Offset: 0x003EC330
	private void DelegateOnKeySelected(KeySettingRowData data)
	{
		this.OnKeySelected(data);
	}

	// Token: 0x06010238 RID: 66104 RVA: 0x003EE139 File Offset: 0x003EC339
	private void DelegateOnKeyHover(KeySettingRowData data)
	{
		this.OnKeyHover(data);
	}

	// Token: 0x06010239 RID: 66105 RVA: 0x003EE142 File Offset: 0x003EC342
	private void DelegateOnKeyUnHover(KeySettingRowData data)
	{
		this.OnKeyUnHover(data);
	}

	// Token: 0x04007767 RID: 30567
	private readonly EKeySettingExclusiveType ExclusiveType;
}
