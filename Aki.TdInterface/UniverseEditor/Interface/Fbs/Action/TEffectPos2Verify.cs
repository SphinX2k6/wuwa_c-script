using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AF RID: 30383
	public static class TEffectPos2Verify
	{
		// Token: 0x0603745F RID: 226399 RVA: 0x0077D6F8 File Offset: 0x0077B8F8
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
