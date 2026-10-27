using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006575 RID: 25973
	public static class IDeliverItemProbeCollectibleViewStyle_UnionVerify
	{
		// Token: 0x0602D0F5 RID: 184565 RVA: 0x0062EC44 File Offset: 0x0062CE44
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
