using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056AA RID: 22186
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayDetection
	{
		// Token: 0x1700878F RID: 34703
		// (get) Token: 0x06038738 RID: 231224 RVA: 0x00D67028 File Offset: 0x00D65228
		public bool IsSuccess
		{
			get
			{
				return this.IsSuccessInner;
			}
		}

		// Token: 0x17008790 RID: 34704
		// (get) Token: 0x06038739 RID: 231225 RVA: 0x00D67030 File Offset: 0x00D65230
		public double AvgLatencyMs
		{
			get
			{
				return this.AvgLatencyMsInner;
			}
		}

		// Token: 0x0603873A RID: 231226 RVA: 0x00D67038 File Offset: 0x00D65238
		public LoginGateWayDetection(string host, int port, int detectCount, int timeOutMs)
		{
			this.Host = host;
			this.Port = port;
			this.DetectCount = detectCount;
			for (int i = 0; i < this.DetectCount; i++)
			{
				LoginGateWayPingTest item = new LoginGateWayPingTest(host, port, timeOutMs);
				this.PingTests.Add(item);
			}
		}

		// Token: 0x0603873B RID: 231227 RVA: 0x00D6709C File Offset: 0x00D6529C
		public UniTask Start()
		{
			LoginGateWayDetection.<Start>d__11 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayDetection.<Start>d__11>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x0603873C RID: 231228 RVA: 0x00D670E0 File Offset: 0x00D652E0
		public void Stop()
		{
			foreach (LoginGateWayPingTest loginGateWayPingTest in this.PingTests)
			{
				loginGateWayPingTest.Stop();
			}
			this.IsSuccessInner = false;
		}

		// Token: 0x0603873D RID: 231229 RVA: 0x00D67138 File Offset: 0x00D65338
		public List<double> GetPingCosts()
		{
			return (from pt in this.PingTests
			select pt.PingCostMs).ToList<double>();
		}

		// Token: 0x0401DA4C RID: 121420
		private readonly int DetectCount = 1;

		// Token: 0x0401DA4D RID: 121421
		public string Host;

		// Token: 0x0401DA4E RID: 121422
		public int Port;

		// Token: 0x0401DA4F RID: 121423
		private readonly List<LoginGateWayPingTest> PingTests = new List<LoginGateWayPingTest>();

		// Token: 0x0401DA50 RID: 121424
		private bool IsSuccessInner;

		// Token: 0x0401DA51 RID: 121425
		private double AvgLatencyMsInner;
	}
}
