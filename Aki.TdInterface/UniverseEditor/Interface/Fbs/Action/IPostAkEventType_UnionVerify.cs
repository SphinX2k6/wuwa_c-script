using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D82 RID: 28034
	public static class IPostAkEventType_UnionVerify
	{
		// Token: 0x06031859 RID: 202841 RVA: 0x006B6784 File Offset: 0x006B4984
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPostAkEventTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPostAkEventTargetedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPostAkEventGlobalVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPostAkEventMapVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPostAkEventMusicSubtitleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
