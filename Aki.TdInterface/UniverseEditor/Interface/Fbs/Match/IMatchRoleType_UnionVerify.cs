using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004405 RID: 17413
	public static class IMatchRoleType_UnionVerify
	{
		// Token: 0x06019ECB RID: 106187 RVA: 0x003B54DC File Offset: 0x003B36DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMatchRoleTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMatchPlayerRoleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMatchPhantomRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
