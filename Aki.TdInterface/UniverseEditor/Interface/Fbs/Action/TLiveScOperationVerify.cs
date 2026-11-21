using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F2C RID: 32556
	public static class TLiveScOperationVerify
	{
		// Token: 0x0603AB9C RID: 240540 RVA: 0x007E5A48 File Offset: 0x007E3C48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILiveSendScConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILiveClearScConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
