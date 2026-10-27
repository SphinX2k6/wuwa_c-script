using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007661 RID: 30305
	public static class TChangeEntityPrefabPerformanceVerify
	{
		// Token: 0x060372AF RID: 225967 RVA: 0x0077AA28 File Offset: 0x00778C28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeTargetEntityPrefabPerformanceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IChangeSelfEntityPrefabPerformanceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
