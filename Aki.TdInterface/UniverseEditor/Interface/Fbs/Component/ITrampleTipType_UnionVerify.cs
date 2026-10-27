using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD4 RID: 23252
	public static class ITrampleTipType_UnionVerify
	{
		// Token: 0x06027A6B RID: 162411 RVA: 0x00574400 File Offset: 0x00572600
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICountDownTextTipVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITrampleTipTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
