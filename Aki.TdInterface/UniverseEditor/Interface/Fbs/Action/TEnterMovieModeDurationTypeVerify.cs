using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BB RID: 30395
	public static class TEnterMovieModeDurationTypeVerify
	{
		// Token: 0x06037493 RID: 226451 RVA: 0x0077DB98 File Offset: 0x0077BD98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWaitMovieModeFixedTimeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWaitMovieModeBorderAnimFinishedVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
