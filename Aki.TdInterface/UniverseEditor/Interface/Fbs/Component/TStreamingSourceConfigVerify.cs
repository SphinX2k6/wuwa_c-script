using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E4 RID: 25316
	public static class TStreamingSourceConfigVerify
	{
		// Token: 0x0602B060 RID: 176224 RVA: 0x005DDD2C File Offset: 0x005DBF2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFixedStreamingSourceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IConditionalStreamingSourceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
