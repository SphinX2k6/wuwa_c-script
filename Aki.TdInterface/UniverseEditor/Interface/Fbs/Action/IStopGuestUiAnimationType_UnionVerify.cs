using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079AC RID: 31148
	public static class IStopGuestUiAnimationType_UnionVerify
	{
		// Token: 0x06036E20 RID: 224800 RVA: 0x007570D4 File Offset: 0x007552D4
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
