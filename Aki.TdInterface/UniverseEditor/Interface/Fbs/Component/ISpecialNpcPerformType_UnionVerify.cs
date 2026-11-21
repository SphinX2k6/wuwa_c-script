using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F83 RID: 24451
	public static class ISpecialNpcPerformType_UnionVerify
	{
		// Token: 0x060291A8 RID: 168360 RVA: 0x0059CE70 File Offset: 0x0059B070
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
