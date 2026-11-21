using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E6F RID: 32367
	public static class TChangeEntityPrefabPerformanceVerify
	{
		// Token: 0x0603A754 RID: 239444 RVA: 0x007DEB24 File Offset: 0x007DCD24
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
