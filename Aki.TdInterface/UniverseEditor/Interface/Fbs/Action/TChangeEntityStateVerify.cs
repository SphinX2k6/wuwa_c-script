using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E72 RID: 32370
	public static class TChangeEntityStateVerify
	{
		// Token: 0x0603A762 RID: 239458 RVA: 0x007DEC58 File Offset: 0x007DCE58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChangeEntityStateBatchDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChangeEntityStateDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeEntityStateLoopVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
