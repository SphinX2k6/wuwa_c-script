using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Net
{
	// Token: 0x0200003E RID: 62
	public class GatewayLatencyConfigVo
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000B48C File Offset: 0x0000968C
		[NullableContext(1)]
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(54, 3);
			defaultInterpolatedStringHandler.AppendLiteral("GatewayLatencyConfigVo(Enabled=");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.enabled);
			defaultInterpolatedStringHandler.AppendLiteral(", Count=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.count);
			defaultInterpolatedStringHandler.AppendLiteral(", TimeoutMs=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.timeoutMs);
			defaultInterpolatedStringHandler.AppendLiteral("ms)");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040000ED RID: 237
		public bool enabled = true;

		// Token: 0x040000EE RID: 238
		public int count;

		// Token: 0x040000EF RID: 239
		public int timeoutMs;
	}
}
