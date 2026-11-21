using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FBF RID: 24511
	public static class IStateRepPerfBase_UnionVerify
	{
		// Token: 0x060293D5 RID: 168917 RVA: 0x005A1020 File Offset: 0x0059F220
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
