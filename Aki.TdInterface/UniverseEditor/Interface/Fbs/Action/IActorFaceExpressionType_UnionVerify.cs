using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670B RID: 26379
	public static class IActorFaceExpressionType_UnionVerify
	{
		// Token: 0x0602CAB4 RID: 182964 RVA: 0x0061C97C File Offset: 0x0061AB7C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorFaceExpressionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorFaceExpressionPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorFaceExpressionStopVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
