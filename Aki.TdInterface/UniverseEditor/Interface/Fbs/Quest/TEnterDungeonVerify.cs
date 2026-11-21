using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004730 RID: 18224
	public static class TEnterDungeonVerify
	{
		// Token: 0x0601AD7E RID: 109950 RVA: 0x003CF848 File Offset: 0x003CDA48
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnterDungeonSubTypeConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnterDungeonIdConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
