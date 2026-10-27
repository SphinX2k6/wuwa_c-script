using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C14 RID: 23572
	public static class TEntityMatchVerify
	{
		// Token: 0x060286E4 RID: 165604 RVA: 0x005908A0 File Offset: 0x0058EAA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityMatchAllCharacterVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityMatchDynamicVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityMatchPlayerVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityMatchSpecificBpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
