using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C6 RID: 25798
	public static class TGiantResponseFunctionVerify
	{
		// Token: 0x0602BDBF RID: 179647 RVA: 0x005F6DF8 File Offset: 0x005F4FF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGiantResponsePlayFlowVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGiantResponsePlayAnimationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
