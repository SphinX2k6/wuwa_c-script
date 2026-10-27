using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766D RID: 30317
	public static class TCheckFlowLookAtTargetVerify
	{
		// Token: 0x060372E9 RID: 226025 RVA: 0x0077AF84 File Offset: 0x00779184
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
