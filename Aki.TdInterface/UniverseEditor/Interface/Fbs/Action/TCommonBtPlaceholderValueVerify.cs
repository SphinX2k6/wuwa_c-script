using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E99 RID: 32409
	public static class TCommonBtPlaceholderValueVerify
	{
		// Token: 0x0603A810 RID: 239632 RVA: 0x007DFBC0 File Offset: 0x007DDDC0
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
