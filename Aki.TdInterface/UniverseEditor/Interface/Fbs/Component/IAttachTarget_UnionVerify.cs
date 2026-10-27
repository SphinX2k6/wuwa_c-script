using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC1 RID: 20161
	public static class IAttachTarget_UnionVerify
	{
		// Token: 0x0601FC1E RID: 130078 RVA: 0x0046BB94 File Offset: 0x00469D94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDynamicAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPlayerAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPointAttachTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
