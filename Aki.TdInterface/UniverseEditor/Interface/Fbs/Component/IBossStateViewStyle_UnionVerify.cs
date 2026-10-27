using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F21 RID: 20257
	public static class IBossStateViewStyle_UnionVerify
	{
		// Token: 0x06020099 RID: 131225 RVA: 0x0047539C File Offset: 0x0047359C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDoubleViewBossStateViewStyleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBossStateViewStyleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
