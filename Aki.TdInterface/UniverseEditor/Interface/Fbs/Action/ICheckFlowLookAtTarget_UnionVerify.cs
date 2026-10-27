using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200636C RID: 25452
	public static class ICheckFlowLookAtTarget_UnionVerify
	{
		// Token: 0x0602C07E RID: 180350 RVA: 0x0060CBD8 File Offset: 0x0060ADD8
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
