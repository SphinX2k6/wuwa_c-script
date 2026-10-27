using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066BC RID: 26300
	public static class IEnterMovieModeDurationType_UnionVerify
	{
		// Token: 0x0602DB77 RID: 187255 RVA: 0x00641314 File Offset: 0x0063F514
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnterMovieModeDurationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWaitMovieModeBorderAnimFinishedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWaitMovieModeFixedTimeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
