using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AF RID: 17071
	public static class IWordArtResourceType_UnionVerify
	{
		// Token: 0x060194B2 RID: 103602 RVA: 0x003A19F4 File Offset: 0x0039FBF4
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
