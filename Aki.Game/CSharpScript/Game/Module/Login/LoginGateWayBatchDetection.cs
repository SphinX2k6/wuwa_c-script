using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056AC RID: 22188
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginGateWayBatchDetection
	{
		// Token: 0x0603873E RID: 231230 RVA: 0x00D67169 File Offset: 0x00D65369
		public LoginGateWayBatchDetection(List<LoginGateWayDetection> detections, int timeoutMs)
		{
			this.Detections = detections;
			this.TimeoutMs = timeoutMs;
		}

		// Token: 0x0603873F RID: 231231 RVA: 0x00D6718C File Offset: 0x00D6538C
		public UniTask Start()
		{
			LoginGateWayBatchDetection.<Start>d__5 <Start>d__;
			<Start>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Start>d__.<>4__this = this;
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<LoginGateWayBatchDetection.<Start>d__5>(ref <Start>d__);
			return <Start>d__.<>t__builder.Task;
		}

		// Token: 0x06038740 RID: 231232 RVA: 0x00D671D0 File Offset: 0x00D653D0
		private unsafe void PrintResult()
		{
			List<LoginGateWayDetection> list = (from x in this.Detections
			orderby x.AvgLatencyMs
			select x).ToList<LoginGateWayDetection>();
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

		// Token: 0x06038741 RID: 231233 RVA: 0x00D6732C File Offset: 0x00D6552C
		public void Stop()
		{
			foreach (LoginGateWayDetection loginGateWayDetection in this.Detections)
			{
				loginGateWayDetection.Stop();
			}
		}

		// Token: 0x06038742 RID: 231234 RVA: 0x00D6737C File Offset: 0x00D6557C
		private void CancelTimeoutHandle()
		{
			if (this.TimeoutHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimeoutHandle);
				this.TimeoutHandle = null;
			}
		}

		// Token: 0x06038743 RID: 231235 RVA: 0x00D673A0 File Offset: 0x00D655A0
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
			return (from detection in this.Detections
			where detection.IsSuccess
			orderby detection.AvgLatencyMs
			select detection).ToArray<LoginGateWayDetection>();
		}

		// Token: 0x06038744 RID: 231236 RVA: 0x00D67416 File Offset: 0x00D65616
		public ELoginGateWayBatchDetection GetResult()
		{
			return this.Result;
		}

		// Token: 0x06038745 RID: 231237 RVA: 0x00D6741E File Offset: 0x00D6561E
		public bool IsTimeOut()
		{
			return this.Result == ELoginGateWayBatchDetection.Timeout;
		}

		// Token: 0x06038746 RID: 231238 RVA: 0x00D6742C File Offset: 0x00D6562C
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

		// Token: 0x0401DA57 RID: 121431
		private readonly int TimeoutMs;

		// Token: 0x0401DA58 RID: 121432
		private readonly List<LoginGateWayDetection> Detections = new List<LoginGateWayDetection>();

		// Token: 0x0401DA59 RID: 121433
		[Nullable(2)]
		private TimerHandle TimeoutHandle;

		// Token: 0x0401DA5A RID: 121434
		private ELoginGateWayBatchDetection Result;
	}
}
