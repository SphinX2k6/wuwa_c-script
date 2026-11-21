using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006969 RID: 26985
	public static class IChangeEntityState_UnionVerify
	{
		// Token: 0x0602E439 RID: 189497 RVA: 0x0065138C File Offset: 0x0064F58C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChangeEntityStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChangeEntityStateDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeEntityStateBatchDirectlyVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
