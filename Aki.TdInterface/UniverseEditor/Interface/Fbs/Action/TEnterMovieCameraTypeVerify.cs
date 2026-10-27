using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B8 RID: 30392
	public static class TEnterMovieCameraTypeVerify
	{
		// Token: 0x06037487 RID: 226439 RVA: 0x0077DA88 File Offset: 0x0077BC88
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
