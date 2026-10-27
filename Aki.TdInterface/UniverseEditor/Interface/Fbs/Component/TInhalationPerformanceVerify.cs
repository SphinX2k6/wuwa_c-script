using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3E RID: 23614
	public static class TInhalationPerformanceVerify
	{
		// Token: 0x060287E0 RID: 165856 RVA: 0x005921B4 File Offset: 0x005903B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneItemInhalationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoleInhalationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
