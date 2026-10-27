using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200648B RID: 25739
	public static class ICommonTip2Type_UnionVerify
	{
		// Token: 0x0602C9AF RID: 182703 RVA: 0x00620260 File Offset: 0x0061E460
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
