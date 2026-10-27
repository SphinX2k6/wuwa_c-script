using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C95 RID: 23701
	public static class TRefreshConditionVerify
	{
		// Token: 0x06028980 RID: 166272 RVA: 0x00594788 File Offset: 0x00592988
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRefreshOnHostInteractVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRefreshOnDeathVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
