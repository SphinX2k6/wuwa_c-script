using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F44 RID: 32580
	public static class TMontageConfigVerify
	{
		// Token: 0x0603AC10 RID: 240656 RVA: 0x007E64E0 File Offset: 0x007E46E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMontageRegisteredVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMontageAssetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
