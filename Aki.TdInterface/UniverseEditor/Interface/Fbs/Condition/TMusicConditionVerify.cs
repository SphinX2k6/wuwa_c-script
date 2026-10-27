using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D4A RID: 19786
	public static class TMusicConditionVerify
	{
		// Token: 0x0601F66D RID: 128621 RVA: 0x00460308 File Offset: 0x0045E508
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckHcMusicBeatsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckFlForestMusicBeatsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
