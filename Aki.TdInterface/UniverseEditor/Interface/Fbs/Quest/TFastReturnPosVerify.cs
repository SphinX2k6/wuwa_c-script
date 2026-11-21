using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004733 RID: 18227
	public static class TFastReturnPosVerify
	{
		// Token: 0x0601AD8A RID: 109962 RVA: 0x003CF944 File Offset: 0x003CDB44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFastReturnGravityEntityPosVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFastReturnEntityPosVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
