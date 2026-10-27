using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E9 RID: 25321
	public static class IChangeEntityPrefabPerformance_UnionVerify
	{
		// Token: 0x0602BC3C RID: 179260 RVA: 0x006053FC File Offset: 0x006035FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChangeEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChangeTargetEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeSelfEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
