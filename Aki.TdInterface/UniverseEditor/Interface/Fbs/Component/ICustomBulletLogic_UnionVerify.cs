using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BB RID: 21947
	public static class ICustomBulletLogic_UnionVerify
	{
		// Token: 0x06022E98 RID: 143000 RVA: 0x004CE87C File Offset: 0x004CCA7C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrafficBulletLogicVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICustomBulletLogicVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
