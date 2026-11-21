using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EA RID: 21482
	public static class IAttachTarget_UnionVerify
	{
		// Token: 0x06021920 RID: 137504 RVA: 0x004A1070 File Offset: 0x0049F270
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
