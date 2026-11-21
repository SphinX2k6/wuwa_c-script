using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E7B RID: 32379
	public static class TCheckFlowLookAtTargetVerify
	{
		// Token: 0x0603A78E RID: 239502 RVA: 0x007DF080 File Offset: 0x007DD280
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckFlowLookAtPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckFlowLookAtEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
