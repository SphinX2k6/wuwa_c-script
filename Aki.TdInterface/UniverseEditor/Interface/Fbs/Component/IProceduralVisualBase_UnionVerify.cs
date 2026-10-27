using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005795 RID: 22421
	public static class IProceduralVisualBase_UnionVerify
	{
		// Token: 0x06025968 RID: 153960 RVA: 0x0052F250 File Offset: 0x0052D450
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IProceduralVisualBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IProceduralVisualLookAtVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISearchlightRotateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
