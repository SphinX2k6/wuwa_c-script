using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006263 RID: 25187
	public static class TInhalationPerformanceVerify
	{
		// Token: 0x0602ADEE RID: 175598 RVA: 0x005DA3CC File Offset: 0x005D85CC
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
