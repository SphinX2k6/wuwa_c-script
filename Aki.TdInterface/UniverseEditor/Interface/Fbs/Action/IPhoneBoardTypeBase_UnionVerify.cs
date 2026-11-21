using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007417 RID: 29719
	public static class IPhoneBoardTypeBase_UnionVerify
	{
		// Token: 0x06033FF3 RID: 212979 RVA: 0x00702274 File Offset: 0x00700474
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMessageBoardVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhoneBoardTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
