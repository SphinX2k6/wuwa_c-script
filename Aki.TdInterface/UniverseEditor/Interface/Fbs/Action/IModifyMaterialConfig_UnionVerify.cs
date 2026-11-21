using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F7 RID: 29175
	public static class IModifyMaterialConfig_UnionVerify
	{
		// Token: 0x06032C15 RID: 207893 RVA: 0x006DB1A4 File Offset: 0x006D93A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IModifyMaterialConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChangeActorMaterialDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeActorMPCVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
