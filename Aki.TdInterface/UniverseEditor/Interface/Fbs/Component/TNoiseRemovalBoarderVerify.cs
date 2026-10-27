using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6E RID: 23662
	public static class TNoiseRemovalBoarderVerify
	{
		// Token: 0x060288BC RID: 166076 RVA: 0x00593558 File Offset: 0x00591758
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INoiseRemovalSphereBoarderVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INoiseRemovalBoxBoarderVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
