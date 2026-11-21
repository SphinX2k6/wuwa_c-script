using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002A10 RID: 10768
[NullableContext(1)]
[Nullable(0)]
public class UiBehaviorAudio : IUiBehavior
{
	// Token: 0x0601B1FE RID: 111102 RVA: 0x00853071 File Offset: 0x00851271
	public UiBehaviorAudio(UiViewBase owner)
	{
		this.Owner = owner;
		this.Info = owner.ViewInfo;
	}

	// Token: 0x0601B1FF RID: 111103 RVA: 0x00853097 File Offset: 0x00851297
	public UniTask OnUiCreateAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0601B200 RID: 111104 RVA: 0x008530A0 File Offset: 0x008512A0
	public void OnUiStart()
	{
		this.AudioFilter = UiViewConfig.Instance.GetUiShowConfig(this.Info.Name).Value.AudioFilter;
		if (!string.IsNullOrEmpty(this.AudioFilter) && this.FilterHandle == 0)
		{
			this.FilterHandle = AudioFilterController.Instance.PushUiFilterState(this.AudioFilter, this.Info.Name);
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

	// Token: 0x0601B201 RID: 111105 RVA: 0x00853154 File Offset: 0x00851354
	public void OnUiShow()
	{
		UiAudioSystem.Instance.ActivateViewBgm(this.Owner);
		if (this.EffectComponent != null && this.EffectComponent.bAudioCoverEnable)
		{
			UiAudioCoverState uiAudioCoverState = this.CreateAudioCoverState();
			this.CoverState = uiAudioCoverState;
			UiAudioSystem.Instance.AddAudioCover(uiAudioCoverState);
		}
	}

	// Token: 0x0601B202 RID: 111106 RVA: 0x0085319F File Offset: 0x0085139F
	public void OnUiHide()
	{
		UiAudioSystem.Instance.DeactivateViewBgm(this.Owner);
		this.RemoveAudioCover();
	}

	// Token: 0x0601B203 RID: 111107 RVA: 0x008531B8 File Offset: 0x008513B8
	public void OnDestroy()
	{
		UiAudioSystem.Instance.ReleaseViewBgm(this.Owner);
		this.RemoveAudioCover();
		if (!string.IsNullOrEmpty(this.Info.CloseAudioEvent))
		{
			AudioSystem.Instance.PostEvent(this.Info.CloseAudioEvent);
		}
		if (!string.IsNullOrEmpty(this.AudioFilter) && this.FilterHandle != 0)
		{
			AudioFilterController.Instance.RemoveUiFilterState(this.FilterHandle, this.Info.Name);
			this.FilterHandle = 0;
		}
		this.EffectComponent = null;
	}

	// Token: 0x0601B204 RID: 111108 RVA: 0x00853246 File Offset: 0x00851446
	private UiAudioCoverState CreateAudioCoverState()
	{
		return new UiAudioCoverState
		{
			Level = this.EffectComponent.AudioUiCover,
			Alpha = this.EffectComponent.AudioUiAlpha
		};
	}

	// Token: 0x0601B205 RID: 111109 RVA: 0x0085326F File Offset: 0x0085146F
	private void RemoveAudioCover()
	{
		if (this.CoverState == null)
		{
			return;
		}
		UiAudioSystem.Instance.RemoveAudioCover(this.CoverState);
		this.CoverState = null;
	}

	// Token: 0x0400EBAF RID: 60335
	private readonly UiViewBase Owner;

	// Token: 0x0400EBB0 RID: 60336
	private readonly UiViewInfo Info;

	// Token: 0x0400EBB1 RID: 60337
	private int FilterHandle;

	// Token: 0x0400EBB2 RID: 60338
	private string AudioFilter = string.Empty;

	// Token: 0x0400EBB3 RID: 60339
	[Nullable(2)]
	private UUIViewAudioEffectComponent EffectComponent;

	// Token: 0x0400EBB4 RID: 60340
	[Nullable(2)]
	private UiAudioCoverState CoverState;
}
