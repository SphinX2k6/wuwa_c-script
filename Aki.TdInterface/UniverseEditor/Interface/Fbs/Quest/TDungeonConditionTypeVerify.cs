using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CB RID: 17099
	public static class TDungeonConditionTypeVerify
	{
		// Token: 0x060195CC RID: 103884 RVA: 0x003A39FC File Offset: 0x003A1BFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDungeonSubTypeConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDungeonIdConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
