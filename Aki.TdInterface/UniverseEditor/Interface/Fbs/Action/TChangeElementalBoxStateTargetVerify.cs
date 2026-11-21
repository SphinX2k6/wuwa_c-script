using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E6C RID: 32364
	public static class TChangeElementalBoxStateTargetVerify
	{
		// Token: 0x0603A748 RID: 239432 RVA: 0x007DEA28 File Offset: 0x007DCC28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeElementalBoxStateTargetBoxIdVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IChangeElementalBoxStatePlayerTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
