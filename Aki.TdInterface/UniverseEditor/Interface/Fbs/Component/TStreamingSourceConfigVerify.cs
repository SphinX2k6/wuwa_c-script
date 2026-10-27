using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB3 RID: 23731
	public static class TStreamingSourceConfigVerify
	{
		// Token: 0x06028A18 RID: 166424 RVA: 0x005955B8 File Offset: 0x005937B8
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
