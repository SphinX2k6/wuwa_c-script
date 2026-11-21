using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FDB RID: 32731
	public static class TSplineMoveTargetVerify
	{
		// Token: 0x0603AEE0 RID: 241376 RVA: 0x007EA6AC File Offset: 0x007E88AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAssistCharacterSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntitySplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayerSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
