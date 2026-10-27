using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006659 RID: 26201
	public static class IEnableClientFunction_UnionVerify
	{
		// Token: 0x0602D824 RID: 186404 RVA: 0x0063B54C File Offset: 0x0063974C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHealthBarDisplayClientFunctionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnableClientFunctionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
