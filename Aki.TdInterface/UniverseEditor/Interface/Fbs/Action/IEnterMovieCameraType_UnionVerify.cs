using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2D RID: 27949
	public static class IEnterMovieCameraType_UnionVerify
	{
		// Token: 0x0603034A RID: 197450 RVA: 0x0068DC1C File Offset: 0x0068BE1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnterMovieCameraTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnterCommonMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnterSpecMovieCameraVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEnterRandomMovieCameraVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
