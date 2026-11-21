using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078FB RID: 30971
	public static class ISkillBtnEffectBase_UnionVerify
	{
		// Token: 0x06036894 RID: 223380 RVA: 0x0074CF2C File Offset: 0x0074B12C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMusicBattleBtnEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISkillBtnEffectBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
