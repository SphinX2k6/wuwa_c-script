using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006254 RID: 25172
	public static class TGroupFinishConfigVerify
	{
		// Token: 0x0602AD7A RID: 175482 RVA: 0x005D9774 File Offset: 0x005D7974
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
