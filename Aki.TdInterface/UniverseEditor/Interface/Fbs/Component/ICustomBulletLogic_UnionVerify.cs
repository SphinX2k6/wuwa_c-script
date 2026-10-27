using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005059 RID: 20569
	public static class ICustomBulletLogic_UnionVerify
	{
		// Token: 0x06020F5E RID: 135006 RVA: 0x00494BC8 File Offset: 0x00492DC8
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
