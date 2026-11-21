using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D9C RID: 23964
	public static class IProceduralVisualBase_UnionVerify
	{
		// Token: 0x06027E88 RID: 163464 RVA: 0x005753DC File Offset: 0x005735DC
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
