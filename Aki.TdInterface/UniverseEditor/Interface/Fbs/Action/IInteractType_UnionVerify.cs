using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007060 RID: 28768
	public static class IInteractType_UnionVerify
	{
		// Token: 0x06031E14 RID: 204308 RVA: 0x006C0708 File Offset: 0x006BE908
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
