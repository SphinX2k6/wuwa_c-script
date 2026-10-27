using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C5 RID: 22469
	public static class IQteType_UnionVerify
	{
		// Token: 0x06025B61 RID: 154465 RVA: 0x005335F4 File Offset: 0x005317F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISingleBtnQteVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IQteTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
