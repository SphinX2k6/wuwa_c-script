using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EC9 RID: 32457
	public static class TEntityDecorationConfigVerify
	{
		// Token: 0x0603A942 RID: 239938 RVA: 0x007E1DE8 File Offset: 0x007DFFE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRemoveEntityDecorationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAddEntityDecorationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
