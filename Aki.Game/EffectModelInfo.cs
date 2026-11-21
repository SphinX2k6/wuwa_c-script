using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000265 RID: 613
[NullableContext(2)]
[Nullable(0)]
public class EffectModelInfo : IAudioInfo
{
	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x0600260B RID: 9739 RVA: 0x000E733E File Offset: 0x000E553E
	// (set) Token: 0x0600260C RID: 9740 RVA: 0x000E7346 File Offset: 0x000E5546
	public bool Start { get; set; }

	// Token: 0x0600260D RID: 9741 RVA: 0x000E734F File Offset: 0x000E554F
	[NullableContext(1)]
	public EffectModelInfo(EffectModelAudio model)
	{
		this.Model = model;
		this.Start = false;
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x000E7365 File Offset: 0x000E5565
	public string GetName()
	{
		EffectModelAudio model = this.Model;
		if (model == null)
		{
			return null;
		}
		return model.GetName();
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x000E7378 File Offset: 0x000E5578
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

	// Token: 0x06002610 RID: 9744 RVA: 0x000E7396 File Offset: 0x000E5596
	public bool IsValid()
	{
		EffectModelAudio model = this.Model;
		return model != null && model.IsValid();
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x000E73AC File Offset: 0x000E55AC
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

	// Token: 0x06002612 RID: 9746 RVA: 0x000E73F4 File Offset: 0x000E55F4
	[NullableContext(1)]
	public object GetCompare()
	{
		return this.Model;
	}

	// Token: 0x040024B1 RID: 9393
	public EffectModelAudio Model;
}
