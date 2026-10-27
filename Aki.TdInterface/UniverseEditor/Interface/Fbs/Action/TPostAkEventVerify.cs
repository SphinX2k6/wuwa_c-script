using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200775B RID: 30555
	public static class TPostAkEventVerify
	{
		// Token: 0x06037811 RID: 227345 RVA: 0x007832BC File Offset: 0x007814BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPostAkEventGlobalVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPostAkEventMapVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPostAkEventMusicSubtitleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPostAkEventTargetedVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
