using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D5D RID: 15709
	public static class ICheckPlayerInputBase_UnionVerify
	{
		// Token: 0x06015BB6 RID: 89014 RVA: 0x0032270C File Offset: 0x0032090C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerPressButtonVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckPlayerInputBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
