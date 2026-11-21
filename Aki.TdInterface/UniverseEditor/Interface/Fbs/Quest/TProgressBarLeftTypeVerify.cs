using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004757 RID: 18263
	public static class TProgressBarLeftTypeVerify
	{
		// Token: 0x0601AE52 RID: 110162 RVA: 0x003D0C94 File Offset: 0x003CEE94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IUseVarVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUseCountVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
