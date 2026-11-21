using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC3 RID: 28099
	public static class IExploreConfig_UnionVerify
	{
		// Token: 0x060307F2 RID: 198642 RVA: 0x00696324 File Offset: 0x00694524
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITeleControlConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IExploreConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
