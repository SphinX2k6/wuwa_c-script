using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F11 RID: 32529
	public static class TInteractOptionVerify
	{
		// Token: 0x0603AAAC RID: 240300 RVA: 0x007E3FA0 File Offset: 0x007E21A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractFlowVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractActionsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
