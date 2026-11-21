using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF6 RID: 27382
	public static class ICommonTip2Type_UnionVerify
	{
		// Token: 0x0602F129 RID: 192809 RVA: 0x0066BE34 File Offset: 0x0066A034
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICommonTip2PrepareCountdownVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICommonTip2TypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
