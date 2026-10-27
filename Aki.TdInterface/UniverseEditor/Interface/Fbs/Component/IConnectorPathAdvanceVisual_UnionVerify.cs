using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501A RID: 20506
	public static class IConnectorPathAdvanceVisual_UnionVerify
	{
		// Token: 0x06020D04 RID: 134404 RVA: 0x0048FCA0 File Offset: 0x0048DEA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IConnectorPathAdvanceVasePlantVisualVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConnectorPathAdvanceVisualVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
