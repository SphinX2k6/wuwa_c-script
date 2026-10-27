using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D4 RID: 17108
	public static class TFastReturnPosVerify
	{
		// Token: 0x06019608 RID: 103944 RVA: 0x003A4014 File Offset: 0x003A2214
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
