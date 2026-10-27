using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DA RID: 17114
	public static class TItemVariableVerify
	{
		// Token: 0x06019622 RID: 103970 RVA: 0x003A4258 File Offset: 0x003A2458
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IItemTypeVariableVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IItemIdVariableVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
