using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758A RID: 30090
	public static class IRangeCheck_UnionVerify
	{
		// Token: 0x06034C81 RID: 216193 RVA: 0x00718EC4 File Offset: 0x007170C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IConeRangeCheckVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRangeCheckVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
