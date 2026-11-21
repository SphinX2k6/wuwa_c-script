using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC9 RID: 32713
	public static class TSkiConfigVerify
	{
		// Token: 0x0603AE8A RID: 241290 RVA: 0x007E9ED4 File Offset: 0x007E80D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAccelerateSkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICloseSkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenSkiConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
