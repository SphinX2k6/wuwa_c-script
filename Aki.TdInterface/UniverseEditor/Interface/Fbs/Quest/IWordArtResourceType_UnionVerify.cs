using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200470B RID: 18187
	public static class IWordArtResourceType_UnionVerify
	{
		// Token: 0x0601AC1E RID: 109598 RVA: 0x003CD0CC File Offset: 0x003CB2CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWordArtDefaultResourceTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWordArtResourceTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
