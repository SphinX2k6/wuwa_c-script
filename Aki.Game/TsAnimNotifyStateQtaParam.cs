using System;
using System.Runtime.CompilerServices;

// Token: 0x02000152 RID: 338
internal class TsAnimNotifyStateQtaParam
{
	// Token: 0x0600150C RID: 5388 RVA: 0x00074851 File Offset: 0x00072A51
	public TsAnimNotifyStateQtaParam(int qtaHandleId)
	{
		this.QtaHandleId = qtaHandleId;
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00074860 File Offset: 0x00072A60
	[NullableContext(1)]
	public static string GetKey(int entityId, int notifyId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendLiteral("$");
		defaultInterpolatedStringHandler.AppendFormatted<int>(entityId);
		defaultInterpolatedStringHandler.AppendLiteral("_$");
		defaultInterpolatedStringHandler.AppendFormatted<int>(notifyId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04000EF7 RID: 3831
	public int QtaHandleId;
}
