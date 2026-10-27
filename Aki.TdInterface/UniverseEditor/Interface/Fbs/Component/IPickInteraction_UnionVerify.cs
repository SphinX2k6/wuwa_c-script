using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573E RID: 22334
	public static class IPickInteraction_UnionVerify
	{
		// Token: 0x0602565E RID: 153182 RVA: 0x0052905C File Offset: 0x0052725C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChessmanPickInteractionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPickInteractionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
