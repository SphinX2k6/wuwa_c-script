using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x020032B7 RID: 12983
public class BattleSetting : IStaticVariableResetter
{
	// Token: 0x0601C20C RID: 115212 RVA: 0x007D4916 File Offset: 0x007D2B16
	static BattleSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleSetting.CreateStaticDefaultValue), new Action(BattleSetting.ResetStaticDefaultValue));
	}

	// Token: 0x170026D9 RID: 9945
	// (get) Token: 0x0601C20D RID: 115213 RVA: 0x007D4935 File Offset: 0x007D2B35
	[Nullable(1)]
	private static Dictionary<BattleModule, bool> moduleNetworkState
	{
		[NullableContext(1)]
		get
		{
			return BattleSetting._moduleNetworkState;
		}
	}

	// Token: 0x0601C20E RID: 115214 RVA: 0x007D493C File Offset: 0x007D2B3C
	public static void RequestSetModuleNetworkState(BattleModule module, bool isClientControl)
	{
		SwitchBattleModeRequest switchBattleModeRequest = SwitchBattleModeRequest.Create();
		switchBattleModeRequest.ClientControllerModule = module;
		switchBattleModeRequest.Client = isClientControl;
		Net.Instance.Call(ERequestMessageId.SwitchBattleModeRequest, switchBattleModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SwitchBattleModeResponse switchBattleModeResponse = (SwitchBattleModeResponse)msg;
			BattleSetting.ReceiveSetModuleNetworkState(module, switchBattleModeResponse.Client);
		}, 0);
	}

	// Token: 0x0601C20F RID: 115215 RVA: 0x007D498C File Offset: 0x007D2B8C
	public static bool IsModuleClientControl(BattleModule module)
	{
		bool flag;
		return !BattleSetting.moduleNetworkState.TryGetValue(module, out flag) || flag;
	}

	// Token: 0x0601C210 RID: 115216 RVA: 0x007D49AB File Offset: 0x007D2BAB
	public static void ReceiveSetModuleNetworkState(BattleModule module, bool isClientControl)
	{
		BattleSetting.moduleNetworkState[module] = isClientControl;
	}

	// Token: 0x0601C211 RID: 115217 RVA: 0x007D49B9 File Offset: 0x007D2BB9
	public static void CreateStaticDefaultValue()
	{
		BattleSetting._moduleNetworkState = new Dictionary<BattleModule, bool>();
	}

	// Token: 0x0601C212 RID: 115218 RVA: 0x007D49C5 File Offset: 0x007D2BC5
	public static void ResetStaticDefaultValue()
	{
		BattleSetting._moduleNetworkState = null;
	}

	// Token: 0x0400DE94 RID: 56980
	[Nullable(2)]
	private static Dictionary<BattleModule, bool> _moduleNetworkState;
}
