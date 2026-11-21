using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200799A RID: 31130
	public static class IStateProgramSpecialProcessBase_UnionVerify
	{
		// Token: 0x06036DB3 RID: 224691 RVA: 0x007566E0 File Offset: 0x007548E0
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
