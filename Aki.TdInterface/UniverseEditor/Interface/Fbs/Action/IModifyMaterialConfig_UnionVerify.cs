using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC3 RID: 27331
	public static class IModifyMaterialConfig_UnionVerify
	{
		// Token: 0x0602FE5F RID: 196191 RVA: 0x00683F00 File Offset: 0x00682100
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
