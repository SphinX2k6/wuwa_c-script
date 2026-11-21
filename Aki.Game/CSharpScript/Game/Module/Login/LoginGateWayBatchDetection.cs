using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x02004682 RID: 18050
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayBatchDetection
	{
		// Token: 0x0602D63B RID: 185915 RVA: 0x00CB5300 File Offset: 0x00CB3500
		public LoginGateWayBatchDetection(List<LoginGateWayDetection> detections, int timeoutMs)
		{
			this.Detections = detections;
			this.TimeoutMs = timeoutMs;
		}

		// Token: 0x0602D63C RID: 185916 RVA: 0x00CB5324 File Offset: 0x00CB3524
		public UniTask Start()
		{
			LoginGateWayBatchDetection.<Start>d__5 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayBatchDetection.<Start>d__5>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x0602D63D RID: 185917 RVA: 0x00CB5368 File Offset: 0x00CB3568
		private unsafe void PrintResult()
		{
			List<LoginGateWayDetection> list = new List<LoginGateWayDetection>(this.Detections);
			list.Sort((LoginGateWayDetection a, LoginGateWayDetection b) => a.AvgLatencyMs.CompareTo(b.AvgLatencyMs));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (LoginGateWayDetection loginGateWayDetection in list)
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(24, 4, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("IP:");
				appendInterpolatedStringHandler.AppendFormatted(loginGateWayDetection.Host);
				appendInterpolatedStringHandler.AppendLiteral(":");
				appendInterpolatedStringHandler.AppendFormatted<int>(loginGateWayDetection.Port);
				appendInterpolatedStringHandler.AppendLiteral(" Latency:");
				appendInterpolatedStringHandler.AppendFormatted<double>(loginGateWayDetection.AvgLatencyMs);
				appendInterpolatedStringHandler.AppendLiteral(" IsSuccess:");
				appendInterpolatedStringHandler.AppendFormatted<bool>(loginGateWayDetection.IsSuccess);
				stringBuilder3.AppendLine(ref appendInterpolatedStringHandler);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[登录网关]->网关批量检测完成, 结果: ";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("测速结果", this.Result);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("测速详情:", stringBuilder);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602D63E RID: 185918 RVA: 0x00CB54C4 File Offset: 0x00CB36C4
		public void Stop()
		{
			foreach (LoginGateWayDetection loginGateWayDetection in this.Detections)
			{
				loginGateWayDetection.Stop();
			}
		}

		// Token: 0x0602D63F RID: 185919 RVA: 0x00CB5514 File Offset: 0x00CB3714
		private void CancelTimeoutHandle()
		{
			if (this.TimeoutHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
				this.TimeoutHandle = null;
			}
		}

		// Token: 0x0602D640 RID: 185920 RVA: 0x00CB5538 File Offset: 0x00CB3738
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public LoginGateWayDetection[] PickSuccessAndSortByLatency()
		{
			if (this.Result == ELoginGateWayBatchDetection.Fail)
			{
				return null;
			}
			if (this.Result == ELoginGateWayBatchDetection.Timeout)
			{
				return null;
			}
			List<LoginGateWayDetection> list = new List<LoginGateWayDetection>();
			foreach (LoginGateWayDetection loginGateWayDetection in this.Detections)
			{
				if (loginGateWayDetection.IsSuccess)
				{
					list.Add(loginGateWayDetection);
				}
			}
			list.Sort((LoginGateWayDetection a, LoginGateWayDetection b) => a.AvgLatencyMs.CompareTo(b.AvgLatencyMs));
			return list.ToArray();
		}

		// Token: 0x0602D641 RID: 185921 RVA: 0x00CB55DC File Offset: 0x00CB37DC
		public ELoginGateWayBatchDetection GetResult()
		{
			return this.Result;
		}

		// Token: 0x0602D642 RID: 185922 RVA: 0x00CB55E4 File Offset: 0x00CB37E4
		public bool IsTimeOut()
		{
			return this.Result == ELoginGateWayBatchDetection.Timeout;
		}

		// Token: 0x0602D643 RID: 185923 RVA: 0x00CB55F0 File Offset: 0x00CB37F0
		private bool HasSuccessDetection()
		{
			using (List<LoginGateWayDetection>.Enumerator enumerator = this.Detections.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsSuccess)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040184E2 RID: 99554
		private readonly int TimeoutMs;

		// Token: 0x040184E3 RID: 99555
		private readonly List<LoginGateWayDetection> Detections = new List<LoginGateWayDetection>();

		// Token: 0x040184E4 RID: 99556
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x040184E5 RID: 99557
		private ELoginGateWayBatchDetection Result;
	}
}
