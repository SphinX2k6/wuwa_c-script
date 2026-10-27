using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200454D RID: 17741
	[NullableContext(1)]
	[Nullable(0)]
	public class FrequencyMonitor
	{
		// Token: 0x0602DD85 RID: 187781 RVA: 0x00A8A4A6 File Offset: 0x00A886A6
		public FrequencyMonitor(int time, int count, string msg, [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] params ValueTuple<string, object>[] parameters)
		{
			this.Time = time;
			this.Count = count;
			this.Msg = msg;
			this.Params = parameters;
		}

		// Token: 0x0602DD86 RID: 187782 RVA: 0x00A8A4D8 File Offset: 0x00A886D8
		public unsafe void Execute()
		{
			if (!Info.Instance.IsBuildDevelopmentOrDebug)
			{
				return;
			}
			this.ExecuteTimes.Push(global::Time.Instance.NowSeconds);
			while (!this.ExecuteTimes.Empty && global::Time.Instance.NowSeconds - this.ExecuteTimes.Front > (double)this.Time)
			{
				this.ExecuteTimes.Pop();
			}
			if (this.ExecuteTimes.Size > this.Count)
			{
				ValueTuple<string, object>[] @params = this.Params;
				int i = 0;
				ValueTuple<string, object>[] array = new ValueTuple<string, object>[5 + @params.Length];
				ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = new ReadOnlySpan<ValueTuple<string, object>>(@params);
				readOnlySpan.CopyTo(new Span<ValueTuple<string, object>>(array).Slice(i, readOnlySpan.Length));
				i += readOnlySpan.Length;
				array[i] = new ValueTuple<string, object>("msg", this.Msg);
				i++;
				array[i] = new ValueTuple<string, object>("检查时间", this.Time);
				i++;
				array[i] = new ValueTuple<string, object>("检查次数", this.Count);
				i++;
				array[i] = new ValueTuple<string, object>("当前次数", this.ExecuteTimes.Size);
				i++;
				array[i] = new ValueTuple<string, object>("联机", GameModeModel.Instance.IsMulti);
				ReadOnlySpan<ValueTuple<string, object>> readOnlySpan2 = new ReadOnlySpan<ValueTuple<string, object>>(array);
				Log.Instance.Warn(ELogModule.FrequencyMonitor, ELogAuthor.WCL, "业务逻辑执行频率过高", readOnlySpan2);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				readOnlySpan = readOnlySpan2;
				for (i = 0; i < readOnlySpan.Length; i++)
				{
					ValueTuple<string, object> valueTuple = *readOnlySpan[i];
					string item = valueTuple.Item1;
					object item2 = valueTuple.Item2;
					dictionary[item] = item2;
				}
				string data = Json.Encode(dictionary, null);
				CombatDebugController.Instance.DataReport("FREQUENCY_MONITOR", data);
			}
		}

		// Token: 0x040187A4 RID: 100260
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		private readonly ValueTuple<string, object>[] Params;

		// Token: 0x040187A5 RID: 100261
		private readonly Queue<double> ExecuteTimes = new Queue<double>(4);

		// Token: 0x040187A6 RID: 100262
		private readonly int Time;

		// Token: 0x040187A7 RID: 100263
		private readonly int Count;

		// Token: 0x040187A8 RID: 100264
		private readonly string Msg;
	}
}
