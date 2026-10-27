using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712F RID: 28975
	public static class ISkillBtnEffectBase_UnionVerify
	{
		// Token: 0x060335F2 RID: 210418 RVA: 0x006EC920 File Offset: 0x006EAB20
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
