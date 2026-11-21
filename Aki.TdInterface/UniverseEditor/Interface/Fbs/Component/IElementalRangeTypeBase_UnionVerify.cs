using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A2 RID: 22178
	public static class IElementalRangeTypeBase_UnionVerify
	{
		// Token: 0x06023803 RID: 145411 RVA: 0x004E213C File Offset: 0x004E033C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalRangeTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBaseShapeElementalRangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITransportBoxElementalRangeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
