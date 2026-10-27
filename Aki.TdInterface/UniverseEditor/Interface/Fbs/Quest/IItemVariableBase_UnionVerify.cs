using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC5 RID: 16069
	public static class IItemVariableBase_UnionVerify
	{
		// Token: 0x06016B5F RID: 93023 RVA: 0x00347624 File Offset: 0x00345824
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
