using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007530 RID: 30000
	public static class IProgramSpecialConfigBase_UnionVerify
	{
		// Token: 0x060349B0 RID: 215472 RVA: 0x007142CC File Offset: 0x007124CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMp4UiReplaceMaterialVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IProgramSpecialConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
