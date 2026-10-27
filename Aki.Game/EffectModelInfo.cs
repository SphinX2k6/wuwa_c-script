using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000261 RID: 609
[NullableContext(2)]
[Nullable(0)]
public class EffectModelInfo : IAudioInfo
{
	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x06002554 RID: 9556 RVA: 0x000E0FA2 File Offset: 0x000DF1A2
	// (set) Token: 0x06002555 RID: 9557 RVA: 0x000E0FAA File Offset: 0x000DF1AA
	public bool Start { get; set; }

	// Token: 0x06002556 RID: 9558 RVA: 0x000E0FB3 File Offset: 0x000DF1B3
	[NullableContext(1)]
	public EffectModelInfo(EffectModelAudio model)
	{
		this.Model = model;
		this.Start = false;
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x000E0FC9 File Offset: 0x000DF1C9
	public string GetName()
	{
		EffectModelAudio model = this.Model;
		if (model == null)
		{
			return null;
		}
		return model.GetName();
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000E0FDC File Offset: 0x000DF1DC
	public string GetAudioEvent()
	{
		EffectModelAudio model = this.Model;
		if (model == null)
		{
			return null;
		}
		UAkAudioEvent audioEvent = model.AudioEvent;
		if (audioEvent == null)
		{
			return null;
		}
		return audioEvent.GetName();
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000E0FFA File Offset: 0x000DF1FA
	public bool IsValid()
	{
		EffectModelAudio model = this.Model;
		return model != null && model.IsValid();
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x000E1010 File Offset: 0x000DF210
	public bool IsAudioEventValid()
	{
		EffectModelAudio model = this.Model;
		bool? flag;
		if (model == null)
		{
			flag = null;
		}
		else
		{
			UAkAudioEvent audioEvent = model.AudioEvent;
			flag = ((audioEvent != null) ? new bool?(audioEvent.IsValid()) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000E1058 File Offset: 0x000DF258
	[NullableContext(1)]
	public object GetCompare()
	{
		return this.Model;
	}

	// Token: 0x04002433 RID: 9267
	public EffectModelAudio Model;
}
