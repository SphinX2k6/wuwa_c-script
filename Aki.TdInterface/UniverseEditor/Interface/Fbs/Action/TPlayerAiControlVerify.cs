using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F80 RID: 32640
	public static class TPlayerAiControlVerify
	{
		// Token: 0x0603AD38 RID: 240952 RVA: 0x007E8054 File Offset: 0x007E6254
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnablePlayerAiControlVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisablePlayerAiControlVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
