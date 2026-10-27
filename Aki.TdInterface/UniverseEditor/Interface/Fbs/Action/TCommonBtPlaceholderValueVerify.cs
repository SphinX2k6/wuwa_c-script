using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768E RID: 30350
	public static class TCommonBtPlaceholderValueVerify
	{
		// Token: 0x06037377 RID: 226167 RVA: 0x0077BBC4 File Offset: 0x00779DC4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICommonBtOverrideConditionInfoVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICommonBtOverrideActionInfoVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
