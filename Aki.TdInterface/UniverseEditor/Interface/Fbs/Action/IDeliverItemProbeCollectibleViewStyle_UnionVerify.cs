using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE3 RID: 27619
	public static class IDeliverItemProbeCollectibleViewStyle_UnionVerify
	{
		// Token: 0x0602F897 RID: 194711 RVA: 0x0067B07C File Offset: 0x0067927C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHandInItemViewStyleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDeliverItemProbeCollectibleViewStyleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
