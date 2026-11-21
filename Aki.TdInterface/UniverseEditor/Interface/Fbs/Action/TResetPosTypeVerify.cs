using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F9C RID: 32668
	public static class TResetPosTypeVerify
	{
		// Token: 0x0603ADC4 RID: 241092 RVA: 0x007E8D9C File Offset: 0x007E6F9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetPosByResetPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IResetPosByPosEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
