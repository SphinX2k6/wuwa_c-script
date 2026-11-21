using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EBA RID: 32442
	public static class TEffectPos2Verify
	{
		// Token: 0x0603A902 RID: 239874 RVA: 0x007E184C File Offset: 0x007DFA4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAbsolutePos2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEffectEntityPos2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEffectPlayerPos2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
