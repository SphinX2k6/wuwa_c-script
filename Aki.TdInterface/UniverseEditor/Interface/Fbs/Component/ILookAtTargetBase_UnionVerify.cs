using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9A RID: 23194
	public static class ILookAtTargetBase_UnionVerify
	{
		// Token: 0x0602604E RID: 155726 RVA: 0x00535ED4 File Offset: 0x005340D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILookAtTargetBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILookAtTargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILookAtTargetPlayerVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
