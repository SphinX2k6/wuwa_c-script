using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC6 RID: 32454
	public static class TEnterMovieModeDurationTypeVerify
	{
		// Token: 0x0603A936 RID: 239926 RVA: 0x007E1CEC File Offset: 0x007DFEEC
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
