using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D36 RID: 27958
	public static class IEnterMovieModeDurationType_UnionVerify
	{
		// Token: 0x06030394 RID: 197524 RVA: 0x0068E5C8 File Offset: 0x0068C7C8
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
