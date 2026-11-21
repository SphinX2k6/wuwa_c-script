using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x0200467F RID: 18047
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayPingTest
	{
		// Token: 0x0602D631 RID: 185905 RVA: 0x00CB5107 File Offset: 0x00CB3307
		public LoginGateWayPingTest(string host, int port, int timeoutMs)
		{
			this.Host = host;
			this.Port = port;
			this.TimeoutMs = timeoutMs;
		}

		// Token: 0x0602D632 RID: 185906 RVA: 0x00CB5130 File Offset: 0x00CB3330
		public UniTask Start()
		{
			LoginGateWayPingTest.<Start>d__6 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayPingTest.<Start>d__6>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x0602D633 RID: 185907 RVA: 0x00CB5173 File Offset: 0x00CB3373
		public void Stop()
		{
			this.Result = EGateWayPingResult.Stop;
		}

		// Token: 0x0602D634 RID: 185908 RVA: 0x00CB517C File Offset: 0x00CB337C
		public EGateWayPingResult GetResult()
		{
			return this.Result;
		}

		// Token: 0x040184D2 RID: 99538
		private readonly int TimeoutMs = 2000;

		// Token: 0x040184D3 RID: 99539
		public string Host;

		// Token: 0x040184D4 RID: 99540
		public int Port;

		// Token: 0x040184D5 RID: 99541
		public double PingCostMs;

		// Token: 0x040184D6 RID: 99542
		private EGateWayPingResult Result;
	}
}
