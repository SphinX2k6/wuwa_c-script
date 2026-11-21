using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED0 RID: 16080
	public static class IScoreDisplayParams_UnionVerify
	{
		// Token: 0x06015C52 RID: 89170 RVA: 0x00321E88 File Offset: 0x00320088
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
