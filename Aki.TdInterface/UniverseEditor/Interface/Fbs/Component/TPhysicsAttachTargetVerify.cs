using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B7 RID: 25271
	public static class TPhysicsAttachTargetVerify
	{
		// Token: 0x0602AF80 RID: 176000 RVA: 0x005DC844 File Offset: 0x005DAA44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPointAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDynamicAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPlayerAttachTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
