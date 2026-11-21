using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005246 RID: 21062
	public static class TMusicConditionVerify
	{
		// Token: 0x060212B6 RID: 135862 RVA: 0x004942DC File Offset: 0x004924DC
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
