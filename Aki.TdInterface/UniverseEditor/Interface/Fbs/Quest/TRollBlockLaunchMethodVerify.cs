using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200476F RID: 18287
	public static class TRollBlockLaunchMethodVerify
	{
		// Token: 0x0601AEE2 RID: 110306 RVA: 0x003D1AD8 File Offset: 0x003CFCD8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRollBlockLaunchMethodRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRollBlockLaunchMethodInteractVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
