using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001FF7 RID: 8183
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SoundAreaPlayTipsController : UiControllerBase
{
	// Token: 0x0601446E RID: 83054 RVA: 0x005E8E34 File Offset: 0x005E7034
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

	// Token: 0x17001E6D RID: 7789
	// (get) Token: 0x0601446F RID: 83055 RVA: 0x005E8E77 File Offset: 0x005E7077
	public static SoundAreaPlayTipsController Instance
	{
		get
		{
			return SoundAreaPlayTipsController._Instance;
		}
	}

	// Token: 0x06014470 RID: 83056 RVA: 0x005E8E7E File Offset: 0x005E707E
	public static SoundAreaPlayTipsController GetOrCreateInstance()
	{
		if (SoundAreaPlayTipsController._Instance == null)
		{
			SoundAreaPlayTipsController.CreateInstance();
		}
		return SoundAreaPlayTipsController._Instance;
	}

	// Token: 0x06014471 RID: 83057 RVA: 0x005E8E92 File Offset: 0x005E7092
	public static bool CreateInstance()
	{
		if (SoundAreaPlayTipsController._Instance != null)
		{
			return true;
		}
		SoundAreaPlayTipsController._Instance = new SoundAreaPlayTipsController();
		return true;
	}

	// Token: 0x06014472 RID: 83058 RVA: 0x005E8EA8 File Offset: 0x005E70A8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014473 RID: 83059 RVA: 0x005E8EAA File Offset: 0x005E70AA
	public static void ResetStaticDefaultValue()
	{
		SoundAreaPlayTipsController._Instance = null;
	}

	// Token: 0x06014474 RID: 83060 RVA: 0x005E8EB2 File Offset: 0x005E70B2
	static SoundAreaPlayTipsController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SoundAreaPlayTipsController.CreateStaticDefaultValue), new Action(SoundAreaPlayTipsController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC1C RID: 44060
	[Nullable(2)]
	private static SoundAreaPlayTipsController _Instance;
}
