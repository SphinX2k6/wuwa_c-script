using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005514 RID: 21780
	public static class ILookAtTargetBase_UnionVerify
	{
		// Token: 0x06023F94 RID: 147348 RVA: 0x004F8DB0 File Offset: 0x004F6FB0
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
