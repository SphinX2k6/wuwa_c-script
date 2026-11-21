using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007299 RID: 29337
	public static class IMoveOperationType_UnionVerify
	{
		// Token: 0x060331EF RID: 209391 RVA: 0x006E5DB0 File Offset: 0x006E3FB0
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
