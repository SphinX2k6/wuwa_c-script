using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005296 RID: 21142
	public static class IFollowDecorationConfig_UnionVerify
	{
		// Token: 0x0602273D RID: 141117 RVA: 0x004C6B54 File Offset: 0x004C4D54
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
