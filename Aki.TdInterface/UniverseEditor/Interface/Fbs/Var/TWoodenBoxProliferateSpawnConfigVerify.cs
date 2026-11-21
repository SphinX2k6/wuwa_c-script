using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F72 RID: 16242
	public static class TWoodenBoxProliferateSpawnConfigVerify
	{
		// Token: 0x060161BA RID: 90554 RVA: 0x0032C074 File Offset: 0x0032A274
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWoodenBoxProliferateRandomInRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWoodenBoxProliferatePositionListVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
