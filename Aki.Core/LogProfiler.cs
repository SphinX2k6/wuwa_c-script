using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200003B RID: 59
[NullableContext(1)]
[Nullable(0)]
public class LogProfiler
{
	// Token: 0x0600014D RID: 333 RVA: 0x000091DC File Offset: 0x000073DC
	public LogProfiler(string name, bool isDynamic = false)
	{
		this._Children = null;
		this._Name = name;
		this._Level = 0;
		this._Timestamp = -1L;
		this.Time = 0L;
		this._Count = 0;
		this._IsDynamic = isDynamic;
		this._Describe = string.Empty;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0000922D File Offset: 0x0000742D
	public static LogProfiler Create(string name)
	{
		return new LogProfiler(name, false);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00009236 File Offset: 0x00007436
	public void SetDescribe(string describe)
	{
		this._Describe = describe;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00009240 File Offset: 0x00007440
	public LogProfiler CreateChild(string name, bool isDynamic = false)
	{
		if (this._Children == null)
		{
			this._Children = new List<LogProfiler>();
		}
		LogProfiler logProfiler = new LogProfiler(name, isDynamic)
		{
			_Level = this._Level + 1
		};
		this._Children.Add(logProfiler);
		return logProfiler;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00009284 File Offset: 0x00007484
	public void Reset()
	{
		this._Timestamp = -1L;
		this.Time = 0L;
		this._Count = 0;
		if (this._Children == null)
		{
			return;
		}
		for (int i = this._Children.Count - 1; i >= 0; i--)
		{
			if (this._Children[i]._IsDynamic)
			{
				this._Children[i].Reset();
				this._Children.RemoveAt(i);
			}
		}
		foreach (LogProfiler logProfiler in this._Children)
		{
			logProfiler.Reset();
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000933C File Offset: 0x0000753C
	public void Start()
	{
		if (this._Timestamp != -1L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[LogProfiler.Start] error, repeat start, name: ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this._Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this._Timestamp = Stopwatch.GetTimestamp();
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00009388 File Offset: 0x00007588
	public void Restart()
	{
		this.Reset();
		this.Start();
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00009398 File Offset: 0x00007598
	public void Stop()
	{
		if (this._Timestamp == -1L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Log;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[LogProfiler.Stop] error, repeat stop, name: ";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", this._Name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.Time += Stopwatch.GetTimestamp() - this._Timestamp;
		this._Count++;
		this._Timestamp = -1L;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00009408 File Offset: 0x00007608
	private void Format(StringBuilder sb)
	{
		sb.AppendLine();
		for (int i = 0; i < this._Level; i++)
		{
			sb.Append((i < this._Level - 1) ? "|  " : "  ");
		}
		sb.Append(this._Name);
		if (this._Count <= 0)
		{
			return;
		}
		sb.Append(" [");
		sb.Append("_Count");
		sb.Append(": ");
		sb.Append(this._Count);
		sb.Append(", ");
		sb.Append("Time");
		sb.Append(": ");
		long ticks = Stopwatch.GetElapsedTime(0L, this.Time).Ticks;
		if (ticks < 100000L)
		{
			sb.Append(ticks);
			sb.Append(" tick");
		}
		else if (ticks < 10000000L)
		{
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
			appendInterpolatedStringHandler.AppendFormatted<float>((float)ticks / 10000f, "F2");
			sb.Append(ref appendInterpolatedStringHandler);
			sb.Append(" ms");
		}
		else if (ticks < 600000000L)
		{
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
			appendInterpolatedStringHandler.AppendFormatted<float>((float)ticks / 10000000f, "F2");
			sb.Append(ref appendInterpolatedStringHandler);
			sb.Append(" s");
		}
		else
		{
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
			appendInterpolatedStringHandler.AppendFormatted<float>((float)ticks / 600000000f, "F2");
			sb.Append(ref appendInterpolatedStringHandler);
			sb.Append(" m");
		}
		if (this._Count > 1)
		{
			sb.Append(", Average: ");
			float num = (float)ticks / (float)this._Count;
			if (num < 100000f)
			{
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
				appendInterpolatedStringHandler.AppendFormatted<float>(num, "F2");
				sb.Append(ref appendInterpolatedStringHandler);
				sb.Append(" tick");
			}
			else if (num < 10000000f)
			{
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
				appendInterpolatedStringHandler.AppendFormatted<float>(num / 10000f, "F2");
				sb.Append(ref appendInterpolatedStringHandler);
				sb.Append(" ms");
			}
			else if (num < 600000000f)
			{
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
				appendInterpolatedStringHandler.AppendFormatted<float>(num / 10000000f, "F2");
				sb.Append(ref appendInterpolatedStringHandler);
				sb.Append(" s");
			}
			else
			{
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(0, 1, sb);
				appendInterpolatedStringHandler.AppendFormatted<float>(num / 600000000f, "F2");
				sb.Append(ref appendInterpolatedStringHandler);
				sb.Append(" m");
			}
		}
		sb.Append("]");
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000096C8 File Offset: 0x000078C8
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		System.Collections.Generic.Stack<LogProfiler> stack = new System.Collections.Generic.Stack<LogProfiler>();
		stack.Push(this);
		LogProfiler logProfiler;
		while (stack.TryPop(out logProfiler))
		{
			logProfiler.Format(stringBuilder);
			List<LogProfiler> children = logProfiler._Children;
			if (children != null)
			{
				for (int i = children.Count - 1; i >= 0; i--)
				{
					stack.Push(children[i]);
				}
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000166 RID: 358
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LogProfiler> _Children;

	// Token: 0x04000167 RID: 359
	private readonly string _Name;

	// Token: 0x04000168 RID: 360
	private string _Describe;

	// Token: 0x04000169 RID: 361
	private int _Level;

	// Token: 0x0400016A RID: 362
	private long _Timestamp;

	// Token: 0x0400016B RID: 363
	private int _Count;

	// Token: 0x0400016C RID: 364
	private readonly bool _IsDynamic;

	// Token: 0x0400016D RID: 365
	public long Time;
}
