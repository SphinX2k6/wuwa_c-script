using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCA RID: 27850
	public static class IEnableClientFunction_UnionVerify
	{
		// Token: 0x0602FFF5 RID: 196597 RVA: 0x006880B4 File Offset: 0x006862B4
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
