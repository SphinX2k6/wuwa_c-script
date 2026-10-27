using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200513D RID: 20797
	public static class IElementalRangeTypeBase_UnionVerify
	{
		// Token: 0x060218AF RID: 137391 RVA: 0x004A81B0 File Offset: 0x004A63B0
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
