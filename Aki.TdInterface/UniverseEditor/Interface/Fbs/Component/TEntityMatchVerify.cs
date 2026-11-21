using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006233 RID: 25139
	public static class TEntityMatchVerify
	{
		// Token: 0x0602ACD4 RID: 175316 RVA: 0x005D87E8 File Offset: 0x005D69E8
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
