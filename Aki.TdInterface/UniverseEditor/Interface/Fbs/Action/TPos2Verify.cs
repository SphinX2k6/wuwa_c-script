using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007758 RID: 30552
	public static class TPos2Verify
	{
		// Token: 0x06037801 RID: 227329 RVA: 0x00783120 File Offset: 0x00781320
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
