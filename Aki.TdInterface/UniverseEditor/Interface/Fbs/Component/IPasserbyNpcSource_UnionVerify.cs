using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D3 RID: 22227
	public static class IPasserbyNpcSource_UnionVerify
	{
		// Token: 0x0602520F RID: 152079 RVA: 0x00520130 File Offset: 0x0051E330
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
