using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006515 RID: 25877
	public static class ICustomScreenTypeBase_UnionVerify
	{
		// Token: 0x0602CE34 RID: 183860 RVA: 0x0062A2E4 File Offset: 0x006284E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomScreenTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICustomScreenSpineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomScreenBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICustomScreenLoadingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
