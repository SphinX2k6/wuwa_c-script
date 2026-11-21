using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200472A RID: 18218
	public static class TDungeonConditionTypeVerify
	{
		// Token: 0x0601AD4C RID: 109900 RVA: 0x003CF2E4 File Offset: 0x003CD4E4
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
