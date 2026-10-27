using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0B RID: 23563
	public static class TElementalRangeVerify
	{
		// Token: 0x060286BA RID: 165562 RVA: 0x005904F4 File Offset: 0x0058E6F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITransportBoxElementalRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBaseShapeElementalRangeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
