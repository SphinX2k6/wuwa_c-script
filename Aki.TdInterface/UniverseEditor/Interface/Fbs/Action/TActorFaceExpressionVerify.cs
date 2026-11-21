using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E3C RID: 32316
	public static class TActorFaceExpressionVerify
	{
		// Token: 0x0603A652 RID: 239186 RVA: 0x007DD330 File Offset: 0x007DB530
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IActorFaceExpressionStopVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IActorFaceExpressionPlayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
