using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005976 RID: 22902
	public static class ISpecialNpcPerformType_UnionVerify
	{
		// Token: 0x06026C3E RID: 158782 RVA: 0x00556204 File Offset: 0x00554404
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IBaseRoleNpcPerformVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpecialNpcPerformTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
