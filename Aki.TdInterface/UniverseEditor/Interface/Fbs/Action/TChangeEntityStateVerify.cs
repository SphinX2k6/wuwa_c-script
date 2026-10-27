using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007664 RID: 30308
	public static class TChangeEntityStateVerify
	{
		// Token: 0x060372BD RID: 225981 RVA: 0x0077AB5C File Offset: 0x00778D5C
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
