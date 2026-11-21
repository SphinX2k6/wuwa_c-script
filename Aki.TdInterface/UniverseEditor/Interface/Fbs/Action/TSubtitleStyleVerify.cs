using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FED RID: 32749
	public static class TSubtitleStyleVerify
	{
		// Token: 0x0603AF34 RID: 241460 RVA: 0x007EAE68 File Offset: 0x007E9068
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubtitleStyleNewLevelBVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISubtitleStyleLevelAVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
