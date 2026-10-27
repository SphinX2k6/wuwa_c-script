using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200658A RID: 25994
	public static class IDestroyDynamicEntitiesType_UnionVerify
	{
		// Token: 0x0602D166 RID: 184678 RVA: 0x0062F614 File Offset: 0x0062D814
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDestroyVisionDisplayVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDestroyDynamicEntitiesTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
