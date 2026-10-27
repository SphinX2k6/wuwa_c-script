using System;

// Token: 0x0200208E RID: 8334
public class HeartbeatDefine
{
	// Token: 0x0200866F RID: 34415
	public enum EBeginHeartbeat
	{
		// Token: 0x0402BBD8 RID: 179160
		GetLoginResponse,
		// Token: 0x0402BBD9 RID: 179161
		ReConnectSuccess
	}

	// Token: 0x02008670 RID: 34416
	public enum EStopHeartbeat
	{
		// Token: 0x0402BBDB RID: 179163
		LogoutNotify,
		// Token: 0x0402BBDC RID: 179164
		BeforeGetToken,
		// Token: 0x0402BBDD RID: 179165
		LoginStatusInit,
		// Token: 0x0402BBDE RID: 179166
		BackLoginView,
		// Token: 0x0402BBDF RID: 179167
		ReconnectStart,
		// Token: 0x0402BBE0 RID: 179168
		BackLoginAndEnterGame
	}

	// Token: 0x02008671 RID: 34417
	public enum EHeartBeatType
	{
		// Token: 0x0402BBE2 RID: 179170
		NormalHeartBeat,
		// Token: 0x0402BBE3 RID: 179171
		BattleHeartBeat
	}

	// Token: 0x02008672 RID: 34418
	public class EHeartbeatConfig
	{
		// Token: 0x0402BBE4 RID: 179172
		public const int NormalHeartbeatTimeoutMaxCount = 3;

		// Token: 0x0402BBE5 RID: 179173
		public const int NormalHeartbeatInterval = 7000;

		// Token: 0x0402BBE6 RID: 179174
		public const int NormalHeartbeatTimeout = 3000;

		// Token: 0x0402BBE7 RID: 179175
		public const int BattleHeartbeatTimeoutMaxCount = 3;

		// Token: 0x0402BBE8 RID: 179176
		public const int BattleHeartbeatInterval = 1000;

		// Token: 0x0402BBE9 RID: 179177
		public const int BattleHeartbeatTimeout = 900;
	}
}
