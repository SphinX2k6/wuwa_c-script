using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF6 RID: 27382
	public static class IMontageConfig_UnionVerify
	{
		// Token: 0x0602FFEF RID: 196591 RVA: 0x006866DC File Offset: 0x006848DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMontageConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMontageAssetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMontageRegisteredVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
