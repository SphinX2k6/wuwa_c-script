using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006855 RID: 26709
	public static class IBasePos2_UnionVerify
	{
		// Token: 0x0602DA7B RID: 187003 RVA: 0x0063EC1C File Offset: 0x0063CE1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBasePos2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerPos2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEffectPlayerPos2Verify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityPos2Verify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEffectEntityPos2Verify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IAbsolutePos2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
