using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413B RID: 16699
	public static class ISpecialGamePlayConfig_UnionVerify
	{
		// Token: 0x060187E1 RID: 100321 RVA: 0x00387D34 File Offset: 0x00385F34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISpecialGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStalkingGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFreezeOnSightGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFirstPersonTurretGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEavesdropGamePlayConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
