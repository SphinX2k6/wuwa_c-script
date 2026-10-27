using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FA RID: 22266
	public static class IPathDrivenActorSpawnBase_UnionVerify
	{
		// Token: 0x06025353 RID: 152403 RVA: 0x005226C8 File Offset: 0x005208C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IIntervalSplineSpawnVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPathDrivenActorSpawnBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
