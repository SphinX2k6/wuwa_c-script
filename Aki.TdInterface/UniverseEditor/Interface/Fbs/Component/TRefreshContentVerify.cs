using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C98 RID: 23704
	public static class TRefreshContentVerify
	{
		// Token: 0x0602898C RID: 166284 RVA: 0x00594884 File Offset: 0x00592A84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRandomEntityRefreshContentVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAllRefreshContentVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
