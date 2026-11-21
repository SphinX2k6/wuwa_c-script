using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006930 RID: 26928
	public static class ICenterTextShowType_UnionVerify
	{
		// Token: 0x0602E267 RID: 189031 RVA: 0x0064E444 File Offset: 0x0064C644
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
