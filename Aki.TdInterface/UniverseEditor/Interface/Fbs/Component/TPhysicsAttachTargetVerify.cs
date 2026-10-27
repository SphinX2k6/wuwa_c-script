using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C86 RID: 23686
	public static class TPhysicsAttachTargetVerify
	{
		// Token: 0x0602893A RID: 166202 RVA: 0x0059410C File Offset: 0x0059230C
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
