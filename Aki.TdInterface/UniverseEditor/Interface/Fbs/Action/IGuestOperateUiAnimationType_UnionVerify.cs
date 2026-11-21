using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F58 RID: 28504
	public static class IGuestOperateUiAnimationType_UnionVerify
	{
		// Token: 0x06031551 RID: 202065 RVA: 0x006AE770 File Offset: 0x006AC970
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGuestOperateUiAnimationTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayGuestUiAnimationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStopGuestUiAnimationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
