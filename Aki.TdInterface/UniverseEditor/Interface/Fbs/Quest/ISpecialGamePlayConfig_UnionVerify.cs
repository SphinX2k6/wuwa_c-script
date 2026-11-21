using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200457C RID: 17788
	public static class ISpecialGamePlayConfig_UnionVerify
	{
		// Token: 0x06019E84 RID: 106116 RVA: 0x003B1D3C File Offset: 0x003AFF3C
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
