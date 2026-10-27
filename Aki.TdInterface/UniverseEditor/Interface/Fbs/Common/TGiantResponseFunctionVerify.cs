using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E83 RID: 24195
	public static class TGiantResponseFunctionVerify
	{
		// Token: 0x06029717 RID: 169751 RVA: 0x005ADE54 File Offset: 0x005AC054
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
