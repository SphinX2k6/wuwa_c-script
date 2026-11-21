using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006314 RID: 25364
	public static class TWuWaGoHintStepVerify
	{
		// Token: 0x0602B146 RID: 176454 RVA: 0x005DF214 File Offset: 0x005DD414
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
