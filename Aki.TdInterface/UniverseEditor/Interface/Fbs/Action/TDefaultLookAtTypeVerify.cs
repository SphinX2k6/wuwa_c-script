using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A6 RID: 30374
	public static class TDefaultLookAtTypeVerify
	{
		// Token: 0x06037439 RID: 226361 RVA: 0x0077D3CC File Offset: 0x0077B5CC
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
