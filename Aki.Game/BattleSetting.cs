using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf;

// Token: 0x02002828 RID: 10280
public class BattleSetting : IStaticVariableResetter
{
	// Token: 0x06019E4D RID: 106061 RVA: 0x007FBA12 File Offset: 0x007F9C12
	static BattleSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleSetting.CreateStaticDefaultValue), new Action(BattleSetting.ResetStaticDefaultValue));
	}

	// Token: 0x170029C6 RID: 10694
	// (get) Token: 0x06019E4E RID: 106062 RVA: 0x007FBA31 File Offset: 0x007F9C31
	[Nullable(1)]
	private static Dictionary<BattleModule, bool> moduleNetworkState
	{
		[NullableContext(1)]
		get
		{
			return BattleSetting._moduleNetworkState;
		}
	}

	// Token: 0x06019E4F RID: 106063 RVA: 0x007FBA38 File Offset: 0x007F9C38
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

	// Token: 0x06019E50 RID: 106064 RVA: 0x007FBA88 File Offset: 0x007F9C88
	public static bool IsModuleClientControl(BattleModule module)
	{
		bool flag;
		return !BattleSetting.moduleNetworkState.TryGetValue(module, out flag) || flag;
	}

	// Token: 0x06019E51 RID: 106065 RVA: 0x007FBAA7 File Offset: 0x007F9CA7
	public static void ReceiveSetModuleNetworkState(BattleModule module, bool isClientControl)
	{
		BattleSetting.moduleNetworkState[module] = isClientControl;
	}

	// Token: 0x06019E52 RID: 106066 RVA: 0x007FBAB5 File Offset: 0x007F9CB5
	public static void CreateStaticDefaultValue()
	{
		BattleSetting._moduleNetworkState = new Dictionary<BattleModule, bool>();
	}

	// Token: 0x06019E53 RID: 106067 RVA: 0x007FBAC1 File Offset: 0x007F9CC1
	public static void ResetStaticDefaultValue()
	{
		BattleSetting._moduleNetworkState = null;
	}

	// Token: 0x0400E33A RID: 58170
	[Nullable(2)]
	private static Dictionary<BattleModule, bool> _moduleNetworkState;
}
