using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F87 RID: 32647
	public static class TPostAkEventVerify
	{
		// Token: 0x0603AD5A RID: 240986 RVA: 0x007E838C File Offset: 0x007E658C
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
