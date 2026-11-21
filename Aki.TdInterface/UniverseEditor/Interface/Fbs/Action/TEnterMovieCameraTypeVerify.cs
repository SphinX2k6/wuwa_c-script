using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC3 RID: 32451
	public static class TEnterMovieCameraTypeVerify
	{
		// Token: 0x0603A92A RID: 239914 RVA: 0x007E1BDC File Offset: 0x007DFDDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnterCommonMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnterRandomMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnterSpecMovieCameraVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
