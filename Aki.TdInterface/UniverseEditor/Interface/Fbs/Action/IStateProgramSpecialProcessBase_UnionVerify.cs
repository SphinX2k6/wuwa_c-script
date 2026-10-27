using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C5 RID: 29125
	public static class IStateProgramSpecialProcessBase_UnionVerify
	{
		// Token: 0x06033AB1 RID: 211633 RVA: 0x006F5380 File Offset: 0x006F3580
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IStateProgramSpecialProcessChangeTeamOptimizationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IStateProgramSpecialProcessBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
