using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BF RID: 30399
	public static class ISceneInteractionOperationType_UnionVerify
	{
		// Token: 0x06035536 RID: 218422 RVA: 0x00727448 File Offset: 0x00725648
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneInteractionOperationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnableSceneInteractionOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDisableSceneInteractionOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
