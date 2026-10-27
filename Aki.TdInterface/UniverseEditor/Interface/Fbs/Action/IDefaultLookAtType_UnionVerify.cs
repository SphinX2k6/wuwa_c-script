using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200655D RID: 25949
	public static class IDefaultLookAtType_UnionVerify
	{
		// Token: 0x0602D05D RID: 184413 RVA: 0x0062DD24 File Offset: 0x0062BF24
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
