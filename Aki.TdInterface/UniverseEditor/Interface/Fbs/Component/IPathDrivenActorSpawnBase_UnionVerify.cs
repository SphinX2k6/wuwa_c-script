using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE9 RID: 23785
	public static class IPathDrivenActorSpawnBase_UnionVerify
	{
		// Token: 0x060277BA RID: 161722 RVA: 0x00567114 File Offset: 0x00565314
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
