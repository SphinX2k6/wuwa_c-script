using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DD RID: 27101
	public static class ICheckFlowLookAtTarget_UnionVerify
	{
		// Token: 0x0602E7E8 RID: 190440 RVA: 0x00657D2C File Offset: 0x00655F2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckFlowLookAtTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckFlowLookAtEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckFlowLookAtPlayerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
