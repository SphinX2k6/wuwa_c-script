using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E80 RID: 24192
	public static class TGiantAnimDataVerify
	{
		// Token: 0x0602970B RID: 169739 RVA: 0x005ADD58 File Offset: 0x005ABF58
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
