using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006806 RID: 26630
	public static class IFlowDefineNpcGroupPerformType_UnionVerify
	{
		// Token: 0x0602E5F1 RID: 189937 RVA: 0x0065439C File Offset: 0x0065259C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFlowDefineNpcGroupPerformTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFlowDefineNpcHandInHandPerformVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFlowDefineNpcMotorcycleSharingPerformVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFlowDefineNpcCancelMotorcycleSharingPerformVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFlowDefineNpcSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFlowDefineNpcCancelSupportedWalkingPerformVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
