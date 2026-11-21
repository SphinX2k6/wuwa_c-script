using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB9 RID: 23737
	public static class IPasserbyNpcSource_UnionVerify
	{
		// Token: 0x06027630 RID: 161328 RVA: 0x005641FC File Offset: 0x005623FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcTemplateSourceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcSourceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
