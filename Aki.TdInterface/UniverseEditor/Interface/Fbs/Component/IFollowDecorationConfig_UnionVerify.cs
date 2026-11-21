using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FE RID: 22526
	public static class IFollowDecorationConfig_UnionVerify
	{
		// Token: 0x060246D7 RID: 149207 RVA: 0x005016C4 File Offset: 0x004FF8C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFollowDecorationChairConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFollowDecorationConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
