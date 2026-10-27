using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762E RID: 30254
	public static class TActorFaceExpressionVerify
	{
		// Token: 0x060371AD RID: 225709 RVA: 0x00779234 File Offset: 0x00777434
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
