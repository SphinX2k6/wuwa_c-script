using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FDE RID: 32734
	public static class TSportStateVerify
	{
		// Token: 0x0603AEF0 RID: 241392 RVA: 0x007EA82C File Offset: 0x007E8A2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPetalFlyConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPetalGrabConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISlideConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
