using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B00 RID: 23296
	public static class IMonsterChooseType_UnionVerify
	{
		// Token: 0x06026481 RID: 156801 RVA: 0x0053EACC File Offset: 0x0053CCCC
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
