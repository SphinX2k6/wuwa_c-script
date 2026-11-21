using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765C RID: 30300
	public static class IRoadNetworkNavigationTarget_UnionVerify
	{
		// Token: 0x06035296 RID: 217750 RVA: 0x0072304C File Offset: 0x0072124C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneItemRoadNetworkNavigationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoadNetworkNavigationTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
