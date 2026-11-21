using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA2 RID: 32674
	public static class TSceneInteractionOperationVerify
	{
		// Token: 0x0603ADDE RID: 241118 RVA: 0x007E8FE0 File Offset: 0x007E71E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnableSceneInteractionOperationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisableSceneInteractionOperationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
