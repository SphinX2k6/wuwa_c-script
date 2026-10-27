using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE0 RID: 23776
	public static class TWuWaGoHintStepVerify
	{
		// Token: 0x06028AF2 RID: 166642 RVA: 0x005969A4 File Offset: 0x00594BA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWuWaGoHintStepMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWuWaGoHintStepInteractVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
