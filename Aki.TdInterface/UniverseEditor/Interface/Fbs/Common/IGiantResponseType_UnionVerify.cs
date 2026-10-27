using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DCC RID: 24012
	public static class IGiantResponseType_UnionVerify
	{
		// Token: 0x0602918F RID: 168335 RVA: 0x005A417C File Offset: 0x005A237C
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
