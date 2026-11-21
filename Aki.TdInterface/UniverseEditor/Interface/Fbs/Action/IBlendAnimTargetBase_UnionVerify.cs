using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687C RID: 26748
	public static class IBlendAnimTargetBase_UnionVerify
	{
		// Token: 0x0602DB9B RID: 187291 RVA: 0x00640860 File Offset: 0x0063EA60
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerBlendAnimTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBlendAnimTargetBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
