using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FD RID: 29181
	public static class IModifyMediaConfig_UnionVerify
	{
		// Token: 0x06032C33 RID: 207923 RVA: 0x006DB42C File Offset: 0x006D962C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeMediaPlayDaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IModifyMediaConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
