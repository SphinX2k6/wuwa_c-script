using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200523A RID: 21050
	public static class TCheckTargetVerify
	{
		// Token: 0x06021280 RID: 135808 RVA: 0x00493E10 File Offset: 0x00492010
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckTargetEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckOnlinePlayerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
