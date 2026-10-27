using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556E RID: 21870
	public static class IMonsterChooseType_UnionVerify
	{
		// Token: 0x060242DC RID: 148188 RVA: 0x004FF208 File Offset: 0x004FD408
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRandomPoolChooseVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMonsterChooseTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
