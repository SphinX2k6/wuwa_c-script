using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5E RID: 27230
	public static class IClientModifyTarget_UnionVerify
	{
		// Token: 0x0602EB6E RID: 191342 RVA: 0x0065E004 File Offset: 0x0065C204
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
