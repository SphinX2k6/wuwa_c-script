using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771E RID: 30494
	public static class TMontageConfigVerify
	{
		// Token: 0x060376E7 RID: 227047 RVA: 0x0078172C File Offset: 0x0077F92C
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
