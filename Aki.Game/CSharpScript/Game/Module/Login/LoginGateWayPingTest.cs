using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056A9 RID: 22185
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayPingTest
	{
		// Token: 0x06038734 RID: 231220 RVA: 0x00D66FAB File Offset: 0x00D651AB
		public LoginGateWayPingTest(string host, int port, int timeoutMs)
		{
			this.Host = host;
			this.Port = port;
			this.TimeoutMs = timeoutMs;
		}

		// Token: 0x06038735 RID: 231221 RVA: 0x00D66FD4 File Offset: 0x00D651D4
		public UniTask Start()
		{
			LoginGateWayPingTest.<Start>d__6 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayPingTest.<Start>d__6>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x06038736 RID: 231222 RVA: 0x00D67017 File Offset: 0x00D65217
		public void Stop()
		{
			this.Result = EGateWayPingResult.Stop;
		}

		// Token: 0x06038737 RID: 231223 RVA: 0x00D67020 File Offset: 0x00D65220
		public EGateWayPingResult GetResult()
		{
			return this.Result;
		}

		// Token: 0x0401DA47 RID: 121415
		private readonly int TimeoutMs = 2000;

		// Token: 0x0401DA48 RID: 121416
		public string Host;

		// Token: 0x0401DA49 RID: 121417
		public int Port;

		// Token: 0x0401DA4A RID: 121418
		public double PingCostMs;

		// Token: 0x0401DA4B RID: 121419
		private EGateWayPingResult Result;
	}
}
