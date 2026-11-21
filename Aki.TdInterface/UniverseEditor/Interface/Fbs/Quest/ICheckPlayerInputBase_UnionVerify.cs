using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004174 RID: 16756
	public static class ICheckPlayerInputBase_UnionVerify
	{
		// Token: 0x060170EE RID: 94446 RVA: 0x00349984 File Offset: 0x00347B84
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
