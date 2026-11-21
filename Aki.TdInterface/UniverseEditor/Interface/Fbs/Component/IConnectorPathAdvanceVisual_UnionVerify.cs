using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005579 RID: 21881
	public static class IConnectorPathAdvanceVisual_UnionVerify
	{
		// Token: 0x06022C24 RID: 142372 RVA: 0x004C96F0 File Offset: 0x004C78F0
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
