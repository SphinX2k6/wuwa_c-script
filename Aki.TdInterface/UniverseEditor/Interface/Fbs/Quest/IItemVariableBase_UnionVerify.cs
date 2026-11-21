using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004303 RID: 17155
	public static class IItemVariableBase_UnionVerify
	{
		// Token: 0x060181AC RID: 98732 RVA: 0x003705AC File Offset: 0x0036E7AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IItemVariableBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IItemIdVariableVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IItemTypeVariableVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
