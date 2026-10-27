using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200615D RID: 24925
	public static class IAdjustFixedLookAtTargetBase_UnionVerify
	{
		// Token: 0x0602AD05 RID: 175365 RVA: 0x005E7094 File Offset: 0x005E5294
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAdjustFixedLookAtTargetRangeEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAdjustFixedLookAtTargetBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
