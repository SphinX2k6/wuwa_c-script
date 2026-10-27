using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B3 RID: 26291
	public static class IEnterMovieCameraType_UnionVerify
	{
		// Token: 0x0602DB2D RID: 187181 RVA: 0x00640968 File Offset: 0x0063EB68
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
