using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D45 RID: 23877
	public static class IPickInteraction_UnionVerify
	{
		// Token: 0x06027B7E RID: 162686 RVA: 0x0056F1E8 File Offset: 0x0056D3E8
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
