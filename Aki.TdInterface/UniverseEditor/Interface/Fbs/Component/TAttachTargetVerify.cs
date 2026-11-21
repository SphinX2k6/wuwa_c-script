using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006203 RID: 25091
	public static class TAttachTargetVerify
	{
		// Token: 0x0602AB00 RID: 174848 RVA: 0x005D1F80 File Offset: 0x005D0180
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
