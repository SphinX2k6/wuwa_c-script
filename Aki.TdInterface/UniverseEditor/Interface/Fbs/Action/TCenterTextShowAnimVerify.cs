using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765B RID: 30299
	public static class TCenterTextShowAnimVerify
	{
		// Token: 0x06037297 RID: 225943 RVA: 0x0077A81C File Offset: 0x00778A1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IICenterTextFadeOutVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IICenterTextShowAllVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
