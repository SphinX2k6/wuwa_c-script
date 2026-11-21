using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200622A RID: 25130
	public static class TElementalRangeVerify
	{
		// Token: 0x0602ACAA RID: 175274 RVA: 0x005D843C File Offset: 0x005D663C
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
