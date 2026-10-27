using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AD RID: 27053
	public static class IInteractType_UnionVerify
	{
		// Token: 0x0602F438 RID: 193592 RVA: 0x00670004 File Offset: 0x0066E204
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInteractFlowVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractActionsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
