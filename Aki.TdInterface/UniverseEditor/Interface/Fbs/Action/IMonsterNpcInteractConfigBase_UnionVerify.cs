using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721E RID: 29214
	public static class IMonsterNpcInteractConfigBase_UnionVerify
	{
		// Token: 0x06032D51 RID: 208209 RVA: 0x006DD2C8 File Offset: 0x006DB4C8
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
