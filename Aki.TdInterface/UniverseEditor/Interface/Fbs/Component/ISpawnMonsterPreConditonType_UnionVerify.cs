using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595E RID: 22878
	public static class ISpawnMonsterPreConditonType_UnionVerify
	{
		// Token: 0x06026B98 RID: 158616 RVA: 0x005550C8 File Offset: 0x005532C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpawnMonsterPreDependOnPrecedingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpawnMonsterPreConditonTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
