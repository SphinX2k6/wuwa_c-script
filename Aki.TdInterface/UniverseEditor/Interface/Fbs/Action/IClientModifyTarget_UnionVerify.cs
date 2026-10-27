using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DE RID: 25566
	public static class IClientModifyTarget_UnionVerify
	{
		// Token: 0x0602C398 RID: 181144 RVA: 0x00612178 File Offset: 0x00610378
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientModifyTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientModifySelfTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientModifyPlayerTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
