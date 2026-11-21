using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E69 RID: 32361
	public static class TCenterTextShowAnimVerify
	{
		// Token: 0x0603A73C RID: 239420 RVA: 0x007DE918 File Offset: 0x007DCB18
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
