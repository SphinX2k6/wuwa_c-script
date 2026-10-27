using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F8 RID: 17144
	public static class TProgressBarLeftTypeVerify
	{
		// Token: 0x060196D0 RID: 104144 RVA: 0x003A5364 File Offset: 0x003A3564
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
