using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004739 RID: 18233
	public static class TItemVariableVerify
	{
		// Token: 0x0601ADA4 RID: 109988 RVA: 0x003CFB88 File Offset: 0x003CDD88
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
