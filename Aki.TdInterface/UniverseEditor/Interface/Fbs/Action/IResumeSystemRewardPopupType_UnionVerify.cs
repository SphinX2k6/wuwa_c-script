using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007650 RID: 30288
	public static class IResumeSystemRewardPopupType_UnionVerify
	{
		// Token: 0x06035244 RID: 217668 RVA: 0x007228C0 File Offset: 0x00720AC0
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
