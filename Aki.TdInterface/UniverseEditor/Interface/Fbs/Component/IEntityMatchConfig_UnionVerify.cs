using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FF RID: 22271
	public static class IEntityMatchConfig_UnionVerify
	{
		// Token: 0x06023C0A RID: 146442 RVA: 0x004EA1F0 File Offset: 0x004E83F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityMatchConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityMatchAllCharacterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityMatchPlayerVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityMatchDynamicVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
