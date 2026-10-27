using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D6 RID: 30422
	public static class TFlowDefineNpcGroupPerformTypeVerify
	{
		// Token: 0x0603752B RID: 226603 RVA: 0x0077EA38 File Offset: 0x0077CC38
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFlowDefineNpcCancelMotorcycleSharingPerformVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFlowDefineNpcCancelSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFlowDefineNpcHandInHandPerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFlowDefineNpcMotorcycleSharingPerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFlowDefineNpcSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
