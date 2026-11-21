using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796A RID: 31082
	public static class ISplineMoveTargetType_UnionVerify
	{
		// Token: 0x06036BD3 RID: 224211 RVA: 0x00752A4C File Offset: 0x00750C4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveTargetTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntitySplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPlayerSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAssistCharacterSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
