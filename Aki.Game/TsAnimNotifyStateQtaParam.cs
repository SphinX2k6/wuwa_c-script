using System;
using System.Runtime.CompilerServices;

// Token: 0x02000156 RID: 342
internal class TsAnimNotifyStateQtaParam
{
	// Token: 0x060015A9 RID: 5545 RVA: 0x00079D6D File Offset: 0x00077F6D
	public TsAnimNotifyStateQtaParam(int qtaHandleId)
	{
		this.QtaHandleId = qtaHandleId;
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x00079D7C File Offset: 0x00077F7C
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

	// Token: 0x04000F3A RID: 3898
	public int QtaHandleId;
}
