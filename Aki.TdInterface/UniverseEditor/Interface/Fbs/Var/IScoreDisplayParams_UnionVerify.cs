using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ACE RID: 15054
	public static class IScoreDisplayParams_UnionVerify
	{
		// Token: 0x060147A8 RID: 83880 RVA: 0x002FBBF8 File Offset: 0x002F9DF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IScoreDisplayParamsVarVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IScoreDisplayParamsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
