using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C9 RID: 25289
	public static class TRefreshContentVerify
	{
		// Token: 0x0602AFD2 RID: 176082 RVA: 0x005DCFBC File Offset: 0x005DB1BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRandomEntityRefreshContentVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAllRefreshContentVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
