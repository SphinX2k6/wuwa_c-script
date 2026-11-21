using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB1 RID: 32433
	public static class TDefaultLookAtTypeVerify
	{
		// Token: 0x0603A8DC RID: 239836 RVA: 0x007E1520 File Offset: 0x007DF720
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILookAtTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILookAtBubbleEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
