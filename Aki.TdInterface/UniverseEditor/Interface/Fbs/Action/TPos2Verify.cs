using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F84 RID: 32644
	public static class TPos2Verify
	{
		// Token: 0x0603AD4A RID: 240970 RVA: 0x007E81F0 File Offset: 0x007E63F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAbsolutePos2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityPos2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayerPos2Verify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEffectPlayerPos2Verify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEffectEntityPos2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
