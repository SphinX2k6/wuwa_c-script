using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007718 RID: 30488
	public static class TModifyActorMaterialTypeVerify
	{
		// Token: 0x060376CF RID: 227023 RVA: 0x00781534 File Offset: 0x0077F734
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeActorMPCVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IChangeActorMaterialDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
