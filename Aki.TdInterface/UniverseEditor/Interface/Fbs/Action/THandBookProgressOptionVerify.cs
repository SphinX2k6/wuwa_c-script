using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF6 RID: 32502
	public static class THandBookProgressOptionVerify
	{
		// Token: 0x0603AA2C RID: 240172 RVA: 0x007E33F4 File Offset: 0x007E15F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHandBookRollbackEmojiOptionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IHandBookGrantEmojiOptionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
