using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007682 RID: 30338
	public static class TClientSetSeasonStateVerify
	{
		// Token: 0x0603733F RID: 226111 RVA: 0x0077B6B4 File Offset: 0x007798B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISwitchSeasonVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILoopSeasonChangeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
