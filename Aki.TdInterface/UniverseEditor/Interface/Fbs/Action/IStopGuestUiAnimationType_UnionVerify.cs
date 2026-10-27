using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D7 RID: 29143
	public static class IStopGuestUiAnimationType_UnionVerify
	{
		// Token: 0x06033B1E RID: 211742 RVA: 0x006F5D74 File Offset: 0x006F3F74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStopGuestCartethyiaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IStopGuestUiAnimationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
