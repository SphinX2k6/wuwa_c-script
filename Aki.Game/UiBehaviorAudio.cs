using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200349C RID: 13468
[NullableContext(2)]
[Nullable(0)]
public class UiBehaviorAudio : IUiBehavior
{
	// Token: 0x0601D502 RID: 120066 RVA: 0x0082BE10 File Offset: 0x0082A010
	[NullableContext(1)]
	public UiBehaviorAudio(UiViewBase owner)
	{
		this.Owner = owner;
		if (this.Owner == null || this.Owner.ViewInfo == null)
		{
			Log.Instance.Error(ELogModule.Audio, ELogAuthor.WDX, "BehaviorAudio 缺少UiViewInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Info = this.Owner.ViewInfo;
		this.LoopAudioEvent = this.Owner.GetLoopAudioEvent();
	}

	// Token: 0x0601D503 RID: 120067 RVA: 0x0082BE7E File Offset: 0x0082A07E
	public UniTask OnUiCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0601D504 RID: 120068 RVA: 0x0082BE88 File Offset: 0x0082A088
	public void OnAfterUiStart()
	{
		this.AudioFilter = UiViewConfig.Instance.GetUiShowConfig(this.Info.Name).Value.AudioFilter;
		if (!string.IsNullOrEmpty(this.AudioFilter) && this.HandleFilter == 0)
		{
			this.HandleFilter = AudioFilterController.Instance.PushUiFilterState(this.AudioFilter, this.Info.Name);
		}
		if (this.EffectComponent == null)
		{
			this.EffectComponent = this.Owner.GetUiAudioComponent();
		}
		if (!string.IsNullOrEmpty(this.Info.OpenAudioEvent))
		{
			AudioSystem.Instance.PostEvent(this.Info.OpenAudioEvent);
		}
	}

	// Token: 0x0601D505 RID: 120069 RVA: 0x0082BF3C File Offset: 0x0082A13C
	public void OnAfterUiShow()
	{
		if (this.EffectComponent != null && this.EffectComponent.bAudioCoverEnable)
		{
			this.CreateAudioStateData();
			UiAudioModel.Instance.AddAudioStateData(this.StateData);
			UiAudioModel.Instance.SetRtpcLevelOpening(this.StateData.Level);
			UiAudioModel.Instance.CalculateRtpcValueAndApply();
		}
		if (!string.IsNullOrEmpty(this.LoopAudioEvent) && this.Owner.GetLoopAudioEventSwitch())
		{
			UiAudioModel.Instance.SetLoopAudioEventShow(this.Owner.GetViewId(), this.Owner.GetRootActor(), this.LoopAudioEvent);
			return;
		}
		if (this.Info.KeepLoopEvent)
		{
			UiAudioModel.Instance.KeepLoopAudioEventShow(this.Owner.GetViewId(), this.Owner.GetRootActor());
		}
	}

	// Token: 0x0601D506 RID: 120070 RVA: 0x0082C004 File Offset: 0x0082A204
	public void OnBeforeUiHide()
	{
		if (this.EffectComponent != null && this.EffectComponent.bAudioCoverEnable)
		{
			UiAudioModel.Instance.SetRtpcLevelClosing(this.StateData.Level);
			UiAudioModel.Instance.RemoveAudioStateData(this.StateData);
			UiAudioModel.Instance.CalculateRtpcValueAndApply();
		}
		if (!string.IsNullOrEmpty(this.LoopAudioEvent) && this.Owner.GetLoopAudioEventSwitch())
		{
			UiAudioModel.Instance.SetLoopAudioEventHide(this.Owner.GetViewId(), this.Owner.GetRootActor(), this.LoopAudioEvent);
			return;
		}
		if (this.Info.KeepLoopEvent)
		{
			UiAudioModel.Instance.KeepLoopAudioEventHide(this.Owner.GetViewId(), this.Owner.GetRootActor());
		}
	}

	// Token: 0x0601D507 RID: 120071 RVA: 0x0082C0C4 File Offset: 0x0082A2C4
	public void OnBeforeDestroy()
	{
		this.EffectComponent = null;
		if (!string.IsNullOrEmpty(this.LoopAudioEvent) && this.Owner.GetLoopAudioEventSwitch())
		{
			UiAudioModel.Instance.SetLoopAudioEventDestroy(this.Owner.GetViewId(), this.Owner.GetRootActor(), this.LoopAudioEvent);
		}
		else if (this.Info.KeepLoopEvent)
		{
			UiAudioModel.Instance.KeepLoopAudioEventDestroy(this.Owner.GetViewId(), this.Owner.GetRootActor());
		}
		if (!string.IsNullOrEmpty(this.Info.CloseAudioEvent))
		{
			AudioSystem.Instance.PostEvent(this.Info.CloseAudioEvent);
		}
		if (!string.IsNullOrEmpty(this.AudioFilter) && this.HandleFilter != 0)
		{
			AudioFilterController.Instance.RemoveUiFilterState(this.HandleFilter, this.Info.Name);
			this.HandleFilter = 0;
		}
	}

	// Token: 0x0601D508 RID: 120072 RVA: 0x0082C1AB File Offset: 0x0082A3AB
	private void CreateAudioStateData()
	{
		this.StateData = new AudioStateData();
		this.StateData.Level = this.EffectComponent.AudioUiCover;
		this.StateData.Alpha = this.EffectComponent.AudioUiAlpha;
	}

	// Token: 0x0400E6FA RID: 59130
	private int HandleFilter;

	// Token: 0x0400E6FB RID: 59131
	private UUIViewAudioEffectComponent EffectComponent;

	// Token: 0x0400E6FC RID: 59132
	private AudioStateData StateData;

	// Token: 0x0400E6FD RID: 59133
	private UiViewBase Owner;

	// Token: 0x0400E6FE RID: 59134
	private UiViewInfo Info;

	// Token: 0x0400E6FF RID: 59135
	[Nullable(1)]
	protected string AudioFilter;

	// Token: 0x0400E700 RID: 59136
	[Nullable(1)]
	protected string LoopAudioEvent;
}
