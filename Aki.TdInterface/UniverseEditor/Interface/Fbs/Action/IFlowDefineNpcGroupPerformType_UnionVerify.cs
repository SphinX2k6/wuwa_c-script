using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E86 RID: 28294
	public static class IFlowDefineNpcGroupPerformType_UnionVerify
	{
		// Token: 0x06030E37 RID: 200247 RVA: 0x006A1AE0 File Offset: 0x0069FCE0
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
