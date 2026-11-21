using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x0200267D RID: 9853
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PerformController : ControllerBase
{
	// Token: 0x06018AD0 RID: 101072 RVA: 0x0077C34D File Offset: 0x0077A54D
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.CharacterLookAtNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCharacterLookAtNotify));
		return true;
	}

	// Token: 0x06018AD1 RID: 101073 RVA: 0x0077C36C File Offset: 0x0077A56C
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CharacterLookAtNotify);
		return true;
	}

	// Token: 0x06018AD2 RID: 101074 RVA: 0x0077C380 File Offset: 0x0077A580
	[NullableContext(2)]
	private void OnCharacterLookAtNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (CharacterLookAtInfo sightTarget in ((CharacterLookAtNotify)msg).CharacterLookAtInfos)
		{
			PerformModel.Instance.SetSightTarget(sightTarget);
		}
	}

	// Token: 0x06018AD3 RID: 101075 RVA: 0x0077C3D8 File Offset: 0x0077A5D8
	public void RecoverTreeInfo(IList<CharacterLookAtInfo> data)
	{
		foreach (CharacterLookAtInfo sightTarget in data)
		{
			PerformModel.Instance.SetSightTarget(sightTarget);
		}
	}

	// Token: 0x06018AD4 RID: 101076 RVA: 0x0077C424 File Offset: 0x0077A624
	protected override bool OnLeaveLevel()
	{
		PerformActionPool.Clear();
		return true;
	}

	// Token: 0x17002718 RID: 10008
	// (get) Token: 0x06018AD5 RID: 101077 RVA: 0x0077C42C File Offset: 0x0077A62C
	public static PerformController Instance
	{
		get
		{
			return PerformController._Instance;
		}
	}

	// Token: 0x06018AD6 RID: 101078 RVA: 0x0077C433 File Offset: 0x0077A633
	public static PerformController GetOrCreateInstance()
	{
		if (PerformController._Instance == null)
		{
			PerformController.CreateInstance();
		}
		return PerformController._Instance;
	}

	// Token: 0x06018AD7 RID: 101079 RVA: 0x0077C447 File Offset: 0x0077A647
	public static bool CreateInstance()
	{
		if (PerformController._Instance != null)
		{
			return true;
		}
		PerformController._Instance = new PerformController();
		return true;
	}

	// Token: 0x06018AD8 RID: 101080 RVA: 0x0077C45D File Offset: 0x0077A65D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018AD9 RID: 101081 RVA: 0x0077C45F File Offset: 0x0077A65F
	public static void ResetStaticDefaultValue()
	{
		PerformController._Instance = null;
	}

	// Token: 0x06018ADA RID: 101082 RVA: 0x0077C467 File Offset: 0x0077A667
	static PerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformController.CreateStaticDefaultValue), new Action(PerformController.ResetStaticDefaultValue));
	}

	// Token: 0x0400D650 RID: 54864
	[Nullable(2)]
	private static PerformController _Instance;
}
