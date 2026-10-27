using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B53 RID: 27475
	public static class IMoveOperationType_UnionVerify
	{
		// Token: 0x06030398 RID: 197528 RVA: 0x0068D7F4 File Offset: 0x0068B9F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMoveOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableMoveOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableMoveOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
