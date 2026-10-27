using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F1C RID: 16156
	public static class ILogicProgramSpecialProcessOperation_UnionVerify
	{
		// Token: 0x06016EF7 RID: 93943 RVA: 0x0034F48C File Offset: 0x0034D68C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDisableUroVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILogicProgramSpecialProcessOperationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
