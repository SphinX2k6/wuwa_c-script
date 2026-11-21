using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCE RID: 27598
	public static class IDefaultLookAtType_UnionVerify
	{
		// Token: 0x0602F819 RID: 194585 RVA: 0x0067A4E8 File Offset: 0x006786E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDefaultLookAtTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILookAtBubbleEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILookAtTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
