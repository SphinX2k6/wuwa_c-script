using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED8 RID: 28376
	public static class IRoadNetworkNavigationTarget_UnionVerify
	{
		// Token: 0x06032256 RID: 205398 RVA: 0x006C7318 File Offset: 0x006C5518
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
