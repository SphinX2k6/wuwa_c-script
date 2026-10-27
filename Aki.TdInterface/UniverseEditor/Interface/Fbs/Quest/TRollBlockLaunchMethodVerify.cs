using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004310 RID: 17168
	public static class TRollBlockLaunchMethodVerify
	{
		// Token: 0x06019760 RID: 104288 RVA: 0x003A61A8 File Offset: 0x003A43A8
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
