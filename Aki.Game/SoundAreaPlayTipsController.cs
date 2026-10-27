using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002A7B RID: 10875
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SoundAreaPlayTipsController : UiControllerBase
{
	// Token: 0x06016A49 RID: 92745 RVA: 0x005BCC04 File Offset: 0x005BAE04
	[NullableContext(0)]
	public UniTask<bool> OpenSoundAreaPlayTips(int configId)
	{
		SoundAreaPlayTipsController.<OpenSoundAreaPlayTips>d__0 <OpenSoundAreaPlayTips>d__;
		<OpenSoundAreaPlayTips>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenSoundAreaPlayTips>d__.configId = configId;
		<OpenSoundAreaPlayTips>d__.<>1__state = -1;
		<OpenSoundAreaPlayTips>d__.<>t__builder.Start<SoundAreaPlayTipsController.<OpenSoundAreaPlayTips>d__0>(ref <OpenSoundAreaPlayTips>d__);
		return <OpenSoundAreaPlayTips>d__.<>t__builder.Task;
	}

	// Token: 0x17001E15 RID: 7701
	// (get) Token: 0x06016A4A RID: 92746 RVA: 0x005BCC47 File Offset: 0x005BAE47
	public static SoundAreaPlayTipsController Instance
	{
		get
		{
			return SoundAreaPlayTipsController._Instance;
		}
	}

	// Token: 0x06016A4B RID: 92747 RVA: 0x005BCC4E File Offset: 0x005BAE4E
	public static SoundAreaPlayTipsController GetOrCreateInstance()
	{
		if (SoundAreaPlayTipsController._Instance == null)
		{
			SoundAreaPlayTipsController.CreateInstance();
		}
		return SoundAreaPlayTipsController._Instance;
	}

	// Token: 0x06016A4C RID: 92748 RVA: 0x005BCC62 File Offset: 0x005BAE62
	public static bool CreateInstance()
	{
		if (SoundAreaPlayTipsController._Instance != null)
		{
			return true;
		}
		SoundAreaPlayTipsController._Instance = new SoundAreaPlayTipsController();
		return true;
	}

	// Token: 0x06016A4D RID: 92749 RVA: 0x005BCC78 File Offset: 0x005BAE78
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016A4E RID: 92750 RVA: 0x005BCC7A File Offset: 0x005BAE7A
	public static void ResetStaticDefaultValue()
	{
		SoundAreaPlayTipsController._Instance = null;
	}

	// Token: 0x06016A4F RID: 92751 RVA: 0x005BCC82 File Offset: 0x005BAE82
	static SoundAreaPlayTipsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoundAreaPlayTipsController.CreateStaticDefaultValue), new Action(SoundAreaPlayTipsController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A817 RID: 43031
	[Nullable(2)]
	private static SoundAreaPlayTipsController _Instance;
}
