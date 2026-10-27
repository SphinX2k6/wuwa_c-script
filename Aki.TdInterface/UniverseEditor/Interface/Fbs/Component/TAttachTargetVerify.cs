using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEA RID: 23530
	public static class TAttachTargetVerify
	{
		// Token: 0x06028530 RID: 165168 RVA: 0x0058A3F4 File Offset: 0x005885F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDynamicAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPlayerAttachTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
