using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA1 RID: 27809
	public static class IPhoneBoardTypeBase_UnionVerify
	{
		// Token: 0x0603101C RID: 200732 RVA: 0x006A7040 File Offset: 0x006A5240
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
