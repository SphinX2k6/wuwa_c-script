using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B85 RID: 23429
	public static class IWindSourceBase_UnionVerify
	{
		// Token: 0x060281B4 RID: 164276 RVA: 0x00583430 File Offset: 0x00581630
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWindDirectionalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWindSourceBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
