using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x02004680 RID: 18048
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayDetection
	{
		// Token: 0x17005B56 RID: 23382
		// (get) Token: 0x0602D635 RID: 185909 RVA: 0x00CB5184 File Offset: 0x00CB3384
		public bool IsSuccess
		{
			get
			{
				return this.IsSuccessInner;
			}
		}

		// Token: 0x17005B57 RID: 23383
		// (get) Token: 0x0602D636 RID: 185910 RVA: 0x00CB518C File Offset: 0x00CB338C
		public double AvgLatencyMs
		{
			get
			{
				return this.AvgLatencyMsInner;
			}
		}

		// Token: 0x0602D637 RID: 185911 RVA: 0x00CB5194 File Offset: 0x00CB3394
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

		// Token: 0x0602D638 RID: 185912 RVA: 0x00CB51F8 File Offset: 0x00CB33F8
		public UniTask Start()
		{
			LoginGateWayDetection.<Start>d__11 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayDetection.<Start>d__11>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x0602D639 RID: 185913 RVA: 0x00CB523C File Offset: 0x00CB343C
		public void Stop()
		{
			foreach (LoginGateWayPingTest loginGateWayPingTest in this.PingTests)
			{
				loginGateWayPingTest.Stop();
			}
			this.IsSuccessInner = false;
		}

		// Token: 0x0602D63A RID: 185914 RVA: 0x00CB5294 File Offset: 0x00CB3494
		public List<double> GetPingCosts()
		{
			List<double> list = new List<double>(this.PingTests.Count);
			foreach (LoginGateWayPingTest loginGateWayPingTest in this.PingTests)
			{
				list.Add(loginGateWayPingTest.PingCostMs);
			}
			return list;
		}

		// Token: 0x040184D7 RID: 99543
		private readonly int DetectCount = 1;

		// Token: 0x040184D8 RID: 99544
		public string Host;

		// Token: 0x040184D9 RID: 99545
		public int Port;

		// Token: 0x040184DA RID: 99546
		private readonly List<LoginGateWayPingTest> PingTests = new List<LoginGateWayPingTest>();

		// Token: 0x040184DB RID: 99547
		private bool IsSuccessInner;

		// Token: 0x040184DC RID: 99548
		private double AvgLatencyMsInner;
	}
}
