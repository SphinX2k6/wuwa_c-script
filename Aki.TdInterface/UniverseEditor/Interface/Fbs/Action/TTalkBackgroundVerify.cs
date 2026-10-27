using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C1 RID: 30657
	public static class TTalkBackgroundVerify
	{
		// Token: 0x060379ED RID: 227821 RVA: 0x00785DC4 File Offset: 0x00783FC4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkBackgroundCleanVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkBackgroundIconVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkBackgroundImageByMcGenderVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkBackgroundSpineImageVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
