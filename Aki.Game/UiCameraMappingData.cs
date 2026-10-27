using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;

// Token: 0x02002C36 RID: 11318
[NullableContext(1)]
[Nullable(0)]
public class UiCameraMappingData
{
	// Token: 0x060179CB RID: 96715 RVA: 0x006027E9 File Offset: 0x006009E9
	public UiCameraMappingData(UiCameraMapping config)
	{
		this.Config = new UiCameraAnimationDefine.IUiCameraMapping(config);
		this.ViewName = config.ViewName;
		this.IsChildView = false;
	}

	// Token: 0x060179CC RID: 96716 RVA: 0x00602811 File Offset: 0x00600A11
	public UiCameraMappingData(ChildUiCameraMapping config)
	{
		this.Config = new UiCameraAnimationDefine.IUiCameraMapping(config);
		this.ViewName = config.ViewName;
		this.IsChildView = true;
	}

	// Token: 0x060179CD RID: 96717 RVA: 0x00602839 File Offset: 0x00600A39
	public UiCameraAnimationDefine.IUiCameraMapping GetUiCameraMappingConfig()
	{
		return this.Config;
	}

	// Token: 0x060179CE RID: 96718 RVA: 0x00602844 File Offset: 0x00600A44
	public string GetSourceHandleName()
	{
		EUiCameraAnimationTargetType euiCameraAnimationTargetType = (EUiCameraAnimationTargetType)this.Config.BodyTargetType;
		string defaultUiCameraSettingsName = this.Config.DefaultUiCameraSettingsName;
		if (euiCameraAnimationTargetType == EUiCameraAnimationTargetType.None)
		{
			return defaultUiCameraSettingsName;
		}
		string targetBodyKey = UiCameraAnimationManager.Instance.GetTargetBodyKey(euiCameraAnimationTargetType);
		if (string.IsNullOrEmpty(targetBodyKey))
		{
			return defaultUiCameraSettingsName;
		}
		Dictionary<string, string> bodyCameraSettingsNameMap = this.Config.BodyCameraSettingsNameMap;
		if (bodyCameraSettingsNameMap == null)
		{
			return defaultUiCameraSettingsName;
		}
		string text;
		bodyCameraSettingsNameMap.TryGetValue(targetBodyKey, out text);
		if (string.IsNullOrEmpty(text))
		{
			return defaultUiCameraSettingsName;
		}
		return text;
	}

	// Token: 0x060179CF RID: 96719 RVA: 0x006028B0 File Offset: 0x00600AB0
	[NullableContext(2)]
	public string GetTargetBodyKey()
	{
		int bodyTargetType = this.Config.BodyTargetType;
		string targetBodyKey = UiCameraAnimationManager.Instance.GetTargetBodyKey((EUiCameraAnimationTargetType)bodyTargetType);
		if (string.IsNullOrEmpty(targetBodyKey))
		{
			return null;
		}
		return targetBodyKey;
	}

	// Token: 0x060179D0 RID: 96720 RVA: 0x006028E4 File Offset: 0x00600AE4
	public bool CanPushCameraHandle()
	{
		string defaultUiCameraSettingsName = this.Config.DefaultUiCameraSettingsName;
		return !(defaultUiCameraSettingsName == "None") && !string.IsNullOrEmpty(defaultUiCameraSettingsName);
	}

	// Token: 0x060179D1 RID: 96721 RVA: 0x00602918 File Offset: 0x00600B18
	public string GetToBlendName(string toViewName)
	{
		Dictionary<string, string> uiCameraBlendNameMap = this.Config.UiCameraBlendNameMap;
		if (uiCameraBlendNameMap == null)
		{
			return this.Config.DefaultCameraBlendName;
		}
		if (string.IsNullOrEmpty(toViewName))
		{
			return this.Config.DefaultCameraBlendName;
		}
		string text;
		if (!uiCameraBlendNameMap.TryGetValue(toViewName, out text) || string.IsNullOrEmpty(text))
		{
			return this.Config.DefaultCameraBlendName;
		}
		return text;
	}

	// Token: 0x060179D2 RID: 96722 RVA: 0x00602974 File Offset: 0x00600B74
	public float GetUiCameraDelayTime()
	{
		return this.Config.UiCameraDelayTime;
	}

	// Token: 0x060179D3 RID: 96723 RVA: 0x00602981 File Offset: 0x00600B81
	public string GetViewName()
	{
		return this.ViewName;
	}

	// Token: 0x0400B00C RID: 45068
	private readonly UiCameraAnimationDefine.IUiCameraMapping Config;

	// Token: 0x0400B00D RID: 45069
	private readonly string ViewName;

	// Token: 0x0400B00E RID: 45070
	public readonly bool IsChildView;
}
