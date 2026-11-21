using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using UnrealEngine;

// Token: 0x020001F1 RID: 497
[NullableContext(1)]
[Nullable(0)]
public class AudioModel : ModelBase
{
	// Token: 0x06001F30 RID: 7984 RVA: 0x0009FB74 File Offset: 0x0009DD74
	public AActor GetSpectrumActor()
	{
		if (this.SpectrumActor == null)
		{
			this.SpectrumActor = ActorSystem.Instance.Get(BP_Wwise_AudioSpectrum_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		}
		return this.SpectrumActor;
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x0009FBA5 File Offset: 0x0009DDA5
	public void DestroySpectrumActor()
	{
		if (this.SpectrumActor != null)
		{
			ActorSystem.Instance.Put("AudioModel.DestroySpectrumActor", this.SpectrumActor, null);
			this.SpectrumActor = null;
		}
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x0009FBD0 File Offset: 0x0009DDD0
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

	// Token: 0x06001F33 RID: 7987 RVA: 0x0009FC2A File Offset: 0x0009DE2A
	protected override bool OnClear()
	{
		this.AmbientAudioQueue = null;
		this.BGMAudioQueue = null;
		return true;
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x0009FC3C File Offset: 0x0009DE3C
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

	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06001F35 RID: 7989 RVA: 0x0009FD0A File Offset: 0x0009DF0A
	public static AudioModel Instance
	{
		get
		{
			return AudioModel._Instance;
		}
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x0009FD11 File Offset: 0x0009DF11
	public static AudioModel GetOrCreateInstance()
	{
		if (AudioModel._Instance == null)
		{
			AudioModel.CreateInstance();
		}
		return AudioModel._Instance;
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x0009FD25 File Offset: 0x0009DF25
	public static bool CreateInstance()
	{
		if (AudioModel._Instance != null)
		{
			return true;
		}
		AudioModel._Instance = new AudioModel();
		return true;
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x0009FD3B File Offset: 0x0009DF3B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x0009FD3D File Offset: 0x0009DF3D
	public static void ResetStaticDefaultValue()
	{
		AudioModel._Instance = null;
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x0009FD45 File Offset: 0x0009DF45
	static AudioModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AudioModel.CreateStaticDefaultValue), new Action(AudioModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400131D RID: 4893
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PriorityQueue<AudioBox> AmbientAudioQueue;

	// Token: 0x0400131E RID: 4894
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PriorityQueue<AudioBox> BGMAudioQueue;

	// Token: 0x0400131F RID: 4895
	[Nullable(2)]
	private AActor SpectrumActor;

	// Token: 0x04001320 RID: 4896
	[Nullable(2)]
	private static AudioModel _Instance;

	// Token: 0x02006552 RID: 25938
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040219C8 RID: 137672
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<AudioBox> <0>__Compare;
	}
}
