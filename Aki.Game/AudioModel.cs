using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using UnrealEngine;

// Token: 0x020001ED RID: 493
[NullableContext(1)]
[Nullable(0)]
public class AudioModel : ModelBase
{
	// Token: 0x06001E93 RID: 7827 RVA: 0x000989F8 File Offset: 0x00096BF8
	public AActor GetSpectrumActor()
	{
		if (this.SpectrumActor == null)
		{
			this.SpectrumActor = ActorSystem.Instance.Get(BP_Wwise_AudioSpectrum_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		}
		return this.SpectrumActor;
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x00098A29 File Offset: 0x00096C29
	public void DestroySpectrumActor()
	{
		if (this.SpectrumActor != null)
		{
			ActorSystem.Instance.Put("AudioModel.DestroySpectrumActor", this.SpectrumActor, null);
			this.SpectrumActor = null;
		}
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x00098A54 File Offset: 0x00096C54
	protected override bool OnInit()
	{
		Comparison<AudioBox> compare;
		if ((compare = AudioModel.<>O.<0>__Compare) == null)
		{
			compare = (AudioModel.<>O.<0>__Compare = new Comparison<AudioBox>(AudioBox.Compare));
		}
		this.AmbientAudioQueue = new PriorityQueue<AudioBox>(compare);
		Comparison<AudioBox> compare2;
		if ((compare2 = AudioModel.<>O.<0>__Compare) == null)
		{
			compare2 = (AudioModel.<>O.<0>__Compare = new Comparison<AudioBox>(AudioBox.Compare));
		}
		this.BGMAudioQueue = new PriorityQueue<AudioBox>(compare2);
		return true;
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x00098AAE File Offset: 0x00096CAE
	protected override bool OnClear()
	{
		this.AmbientAudioQueue = null;
		this.BGMAudioQueue = null;
		return true;
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x00098AC0 File Offset: 0x00096CC0
	[return: Nullable(2)]
	public AudioBox UpdateAudioBoxQueue(AudioBox item, EAudioUpdateType type)
	{
		AudioBox audioBox = null;
		EAudioBoxType boxType = item.BoxType;
		PriorityQueue<AudioBox> priorityQueue;
		if (boxType != EAudioBoxType.AMB)
		{
			if (boxType != EAudioBoxType.BGM)
			{
				return null;
			}
			if (this.BGMAudioQueue != null && !this.BGMAudioQueue.Empty)
			{
				audioBox = this.BGMAudioQueue.Top;
			}
			priorityQueue = this.BGMAudioQueue;
		}
		else
		{
			if (this.AmbientAudioQueue != null && !this.AmbientAudioQueue.Empty)
			{
				audioBox = this.AmbientAudioQueue.Top;
			}
			priorityQueue = this.AmbientAudioQueue;
		}
		bool flag = audioBox == item;
		switch (type)
		{
		case EAudioUpdateType.Enter:
			priorityQueue.Push(item);
			if (priorityQueue.Top == item)
			{
				return priorityQueue.Top;
			}
			break;
		case EAudioUpdateType.Leave:
			priorityQueue.Remove(item);
			if (flag && !priorityQueue.Empty)
			{
				return priorityQueue.Top;
			}
			break;
		case EAudioUpdateType.StateUpdate:
			if (flag)
			{
				return priorityQueue.Top;
			}
			break;
		default:
			return null;
		}
		return null;
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00098B8E File Offset: 0x00096D8E
	public static AudioModel Instance
	{
		get
		{
			return AudioModel._Instance;
		}
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x00098B95 File Offset: 0x00096D95
	public static AudioModel GetOrCreateInstance()
	{
		if (AudioModel._Instance == null)
		{
			AudioModel.CreateInstance();
		}
		return AudioModel._Instance;
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x00098BA9 File Offset: 0x00096DA9
	public static bool CreateInstance()
	{
		if (AudioModel._Instance != null)
		{
			return true;
		}
		AudioModel._Instance = new AudioModel();
		return true;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x00098BBF File Offset: 0x00096DBF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00098BC1 File Offset: 0x00096DC1
	public static void ResetStaticDefaultValue()
	{
		AudioModel._Instance = null;
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00098BC9 File Offset: 0x00096DC9
	static AudioModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AudioModel.CreateStaticDefaultValue), new Action(AudioModel.ResetStaticDefaultValue));
	}

	// Token: 0x040012DA RID: 4826
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PriorityQueue<AudioBox> AmbientAudioQueue;

	// Token: 0x040012DB RID: 4827
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PriorityQueue<AudioBox> BGMAudioQueue;

	// Token: 0x040012DC RID: 4828
	[Nullable(2)]
	private AActor SpectrumActor;

	// Token: 0x040012DD RID: 4829
	[Nullable(2)]
	private static AudioModel _Instance;

	// Token: 0x020073CA RID: 29642
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040266A7 RID: 157351
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<AudioBox> <0>__Compare;
	}
}
