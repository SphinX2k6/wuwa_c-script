using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECC RID: 28364
	public static class IResumeSystemRewardPopupType_UnionVerify
	{
		// Token: 0x06032204 RID: 205316 RVA: 0x006C6B8C File Offset: 0x006C4D8C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResumeGiantDeliveryRewardPopupVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IResumeSystemRewardPopupTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
