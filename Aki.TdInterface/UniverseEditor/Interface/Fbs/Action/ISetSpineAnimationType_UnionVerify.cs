using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007078 RID: 28792
	public static class ISetSpineAnimationType_UnionVerify
	{
		// Token: 0x06032FA3 RID: 208803 RVA: 0x006E04C4 File Offset: 0x006DE6C4
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
