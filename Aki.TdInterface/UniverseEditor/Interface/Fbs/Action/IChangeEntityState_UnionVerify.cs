using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F8 RID: 25336
	public static class IChangeEntityState_UnionVerify
	{
		// Token: 0x0602BCD0 RID: 179408 RVA: 0x00606380 File Offset: 0x00604580
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
