using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B7 RID: 26807
	public static class IGuestOperateUiAnimationType_UnionVerify
	{
		// Token: 0x0602EC17 RID: 191511 RVA: 0x0065F6F0 File Offset: 0x0065D8F0
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
