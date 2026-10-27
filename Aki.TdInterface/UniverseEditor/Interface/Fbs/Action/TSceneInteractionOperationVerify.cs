using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007776 RID: 30582
	public static class TSceneInteractionOperationVerify
	{
		// Token: 0x06037895 RID: 227477 RVA: 0x00783F10 File Offset: 0x00782110
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
