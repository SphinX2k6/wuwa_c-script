using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767C RID: 30332
	public static class TClientModifyTargetVerify
	{
		// Token: 0x06037325 RID: 226085 RVA: 0x0077B470 File Offset: 0x00779670
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientModifySelfTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientModifyPlayerTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
