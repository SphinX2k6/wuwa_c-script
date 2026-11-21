using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695A RID: 26970
	public static class IChangeEntityPrefabPerformance_UnionVerify
	{
		// Token: 0x0602E3A5 RID: 189349 RVA: 0x00650408 File Offset: 0x0064E608
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
