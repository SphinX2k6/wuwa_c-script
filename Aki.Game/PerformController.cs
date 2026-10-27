using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02003122 RID: 12578
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PerformController : ControllerBase
{
	// Token: 0x0601B075 RID: 110709 RVA: 0x007562E1 File Offset: 0x007544E1
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.CharacterLookAtNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCharacterLookAtNotify));
		return true;
	}

	// Token: 0x0601B076 RID: 110710 RVA: 0x00756300 File Offset: 0x00754500
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CharacterLookAtNotify);
		return true;
	}

	// Token: 0x0601B077 RID: 110711 RVA: 0x00756314 File Offset: 0x00754514
	[NullableContext(2)]
	private void OnCharacterLookAtNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (CharacterLookAtInfo sightTarget in ((CharacterLookAtNotify)msg).CharacterLookAtInfos)
		{
			PerformModel.Instance.SetSightTarget(sightTarget);
		}
	}

	// Token: 0x0601B078 RID: 110712 RVA: 0x0075636C File Offset: 0x0075456C
	public void RecoverTreeInfo(IList<CharacterLookAtInfo> data)
	{
		foreach (CharacterLookAtInfo sightTarget in data)
		{
			PerformModel.Instance.SetSightTarget(sightTarget);
		}
	}

	// Token: 0x0601B079 RID: 110713 RVA: 0x007563B8 File Offset: 0x007545B8
	protected override bool OnLeaveLevel()
	{
		PerformActionPool.Clear();
		return true;
	}

	// Token: 0x1700256D RID: 9581
	// (get) Token: 0x0601B07A RID: 110714 RVA: 0x007563C0 File Offset: 0x007545C0
	public static PerformController Instance
	{
		get
		{
			return PerformController._Instance;
		}
	}

	// Token: 0x0601B07B RID: 110715 RVA: 0x007563C7 File Offset: 0x007545C7
	public static PerformController GetOrCreateInstance()
	{
		if (PerformController._Instance == null)
		{
			PerformController.CreateInstance();
		}
		return PerformController._Instance;
	}

	// Token: 0x0601B07C RID: 110716 RVA: 0x007563DB File Offset: 0x007545DB
	public static bool CreateInstance()
	{
		if (PerformController._Instance != null)
		{
			return true;
		}
		PerformController._Instance = new PerformController();
		return true;
	}

	// Token: 0x0601B07D RID: 110717 RVA: 0x007563F1 File Offset: 0x007545F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B07E RID: 110718 RVA: 0x007563F3 File Offset: 0x007545F3
	public static void ResetStaticDefaultValue()
	{
		PerformController._Instance = null;
	}

	// Token: 0x0601B07F RID: 110719 RVA: 0x007563FB File Offset: 0x007545FB
	static PerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformController.CreateStaticDefaultValue), new Action(PerformController.ResetStaticDefaultValue));
	}

	// Token: 0x0400D22E RID: 53806
	[Nullable(2)]
	private static PerformController _Instance;
}
