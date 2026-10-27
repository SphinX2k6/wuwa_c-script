using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A6 RID: 30630
	public static class TSportStateVerify
	{
		// Token: 0x0603796F RID: 227695 RVA: 0x00785268 File Offset: 0x00783468
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPetalGrabConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
