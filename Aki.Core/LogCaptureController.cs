using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200003A RID: 58
[NullableContext(1)]
[Nullable(0)]
public class LogCaptureController
{
	// Token: 0x0600014B RID: 331 RVA: 0x00008D30 File Offset: 0x00006F30
	public int AddCaptureCallback(ILogCaptureParam param)
	{
		if (param.Callback == null)
		{
			return 0;
		}
		this.Uid++;
		int logLevel = (int)param.LogLevel;
		while (this.RegisterCapture.Count <= logLevel)
		{
			this.RegisterCapture.Add(false);
		}
		this.RegisterCapture[logLevel] = true;
		this.CaptureParamMap[this.Uid] = param;
		if (!this.LogLevelMap.ContainsKey(param.LogLevel))
		{
			this.LogLevelMap[param.LogLevel] = new HashSet<int>();
		}
		this.LogLevelMap[param.LogLevel].Add(this.Uid);
		return this.Uid;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00008DE4 File Offset: 0x00006FE4
	public void RemoveCaptureCallback(int handle)
	{
		if (this.CaptureParamMap.ContainsKey(handle))
		{
			ELogLevel logLevel = this.CaptureParamMap[handle].LogLevel;
			this.LogLevelMap[logLevel].Remove(handle);
			this.CaptureParamMap.Remove(handle);
			int num = (int)logLevel;
			while (this.RegisterCapture.Count <= num)
			{
				this.RegisterCapture.Add(false);
			}
			this.RegisterCapture[num] = (this.CaptureParamMap.Count != 0);
		}
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00008E6C File Offset: 0x0000706C
	public void LogCapture(ELogLevel level, ELogModule module, ELogAuthor author, string message, string stack)
	{
		if (level < (ELogLevel)this.RegisterCapture.Count)
		{
			bool flag = this.RegisterCapture[(int)level];
		}
	}

	// Token: 0x04000163 RID: 355
	private int Uid;

	// Token: 0x04000164 RID: 356
	public List<bool> RegisterCapture = new List<bool>();

	// Token: 0x04000165 RID: 357
	private readonly Dictionary<int, ILogCaptureParam> CaptureParamMap = new Dictionary<int, ILogCaptureParam>();

	// Token: 0x04000166 RID: 358
	private readonly Dictionary<ELogLevel, HashSet<int>> LogLevelMap = new Dictionary<ELogLevel, HashSet<int>>();
}
