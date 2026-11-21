using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006409 RID: 25609
	public static class IGiantResponseType_UnionVerify
	{
		// Token: 0x0602B819 RID: 178201 RVA: 0x005ECEAC File Offset: 0x005EB0AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGiantResponseTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGiantResponsePlayAnimationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGiantResponsePlayFlowVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
