using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007844 RID: 30788
	public static class ISetSpineAnimationType_UnionVerify
	{
		// Token: 0x06036244 RID: 221764 RVA: 0x00740A78 File Offset: 0x0073EC78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlaySpineAnimationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetSpineAnimationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
