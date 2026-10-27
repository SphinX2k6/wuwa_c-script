using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A0 RID: 30368
	public static class TCustomScreenVerify
	{
		// Token: 0x0603741F RID: 226335 RVA: 0x0077D170 File Offset: 0x0077B370
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomScreenBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICustomScreenLoadingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomScreenSpineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
