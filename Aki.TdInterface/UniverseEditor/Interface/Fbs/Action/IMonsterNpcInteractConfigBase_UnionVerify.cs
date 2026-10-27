using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE7 RID: 27367
	public static class IMonsterNpcInteractConfigBase_UnionVerify
	{
		// Token: 0x0602FF7D RID: 196477 RVA: 0x00685C10 File Offset: 0x00683E10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMonsterNpcInteractTriggerHookVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMonsterNpcInteractConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
