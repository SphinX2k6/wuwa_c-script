using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C3 RID: 25795
	public static class TGiantAnimDataVerify
	{
		// Token: 0x0602BDB3 RID: 179635 RVA: 0x005F6CFC File Offset: 0x005F4EFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGiantSpecialAnimDataVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGiantIdleAnimDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
