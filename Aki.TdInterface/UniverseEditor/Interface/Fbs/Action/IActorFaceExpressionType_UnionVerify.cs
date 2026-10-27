using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A9 RID: 24745
	public static class IActorFaceExpressionType_UnionVerify
	{
		// Token: 0x0602A3D3 RID: 173011 RVA: 0x005D29D4 File Offset: 0x005D0BD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorFaceExpressionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorFaceExpressionPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorFaceExpressionStopVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
