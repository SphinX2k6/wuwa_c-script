using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765E RID: 30302
	public static class TChangeElementalBoxStateTargetVerify
	{
		// Token: 0x060372A3 RID: 225955 RVA: 0x0077A92C File Offset: 0x00778B2C
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
