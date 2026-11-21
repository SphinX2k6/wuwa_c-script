using System;

// Token: 0x02001561 RID: 5473
public class HeartbeatDefine
{
	// Token: 0x020077F7 RID: 30711
	public enum EBeginHeartbeat
	{
		// Token: 0x04026EEB RID: 159467
		GetLoginResponse,
		// Token: 0x04026EEC RID: 159468
		ReConnectSuccess
	}

	// Token: 0x020077F8 RID: 30712
	public enum EStopHeartbeat
	{
		// Token: 0x04026EEE RID: 159470
		LogoutNotify,
		// Token: 0x04026EEF RID: 159471
		BeforeGetToken,
		// Token: 0x04026EF0 RID: 159472
		LoginStatusInit,
		// Token: 0x04026EF1 RID: 159473
		BackLoginView,
		// Token: 0x04026EF2 RID: 159474
		ReconnectStart,
		// Token: 0x04026EF3 RID: 159475
		BackLoginAndEnterGame
	}

	// Token: 0x020077F9 RID: 30713
	public enum EHeartBeatType
	{
		// Token: 0x04026EF5 RID: 159477
		NormalHeartBeat,
		// Token: 0x04026EF6 RID: 159478
		BattleHeartBeat
	}

	// Token: 0x020077FA RID: 30714
	public class EHeartbeatConfig
	{
		// Token: 0x04026EF7 RID: 159479
		public const int NormalHeartbeatTimeoutMaxCount = 3;

		// Token: 0x04026EF8 RID: 159480
		public const int NormalHeartbeatInterval = 7000;

		// Token: 0x04026EF9 RID: 159481
		public const int NormalHeartbeatTimeout = 3000;

		// Token: 0x04026EFA RID: 159482
		public const int BattleHeartbeatTimeoutMaxCount = 3;

		// Token: 0x04026EFB RID: 159483
		public const int BattleHeartbeatInterval = 1000;

		// Token: 0x04026EFC RID: 159484
		public const int BattleHeartbeatTimeout = 900;
	}
}
