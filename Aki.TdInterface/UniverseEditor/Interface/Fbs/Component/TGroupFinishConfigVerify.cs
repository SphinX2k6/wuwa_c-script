using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2F RID: 23599
	public static class TGroupFinishConfigVerify
	{
		// Token: 0x0602876C RID: 165740 RVA: 0x0059155C File Offset: 0x0058F75C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGroupFinishSilenceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGroupFinishDestroyVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
