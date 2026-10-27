using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004408 RID: 17416
	public static class TMatchRoleOptionVerify
	{
		// Token: 0x06019ED7 RID: 106199 RVA: 0x003B55EC File Offset: 0x003B37EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMatchPlayerRoleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMatchPhantomRoleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
