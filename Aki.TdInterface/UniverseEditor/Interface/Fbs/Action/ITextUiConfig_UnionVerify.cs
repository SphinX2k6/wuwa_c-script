using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BBF RID: 31679
	public static class ITextUiConfig_UnionVerify
	{
		// Token: 0x060391A7 RID: 233895 RVA: 0x007B7B24 File Offset: 0x007B5D24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAstrologyTextUiConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITextUiConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
