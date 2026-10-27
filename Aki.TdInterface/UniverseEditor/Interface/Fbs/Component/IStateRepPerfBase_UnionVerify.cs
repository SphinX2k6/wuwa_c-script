using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B2 RID: 22962
	public static class IStateRepPerfBase_UnionVerify
	{
		// Token: 0x06026E6B RID: 159339 RVA: 0x0055A3B4 File Offset: 0x005585B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IStateRepPerfBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStateRepPerfSkillIdVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStateRepPerfMontagePathVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStateRepPerfEffectsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
