using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062BF RID: 25279
	public static class ICenterTextShowType_UnionVerify
	{
		// Token: 0x0602BAFE RID: 178942 RVA: 0x00603438 File Offset: 0x00601638
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICenterTextShowTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IICenterTextShowAllVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IICenterTextFadeOutVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IICenterTextTypeWriterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
