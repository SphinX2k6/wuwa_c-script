using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E7E RID: 32382
	public static class TClientEventVerify
	{
		// Token: 0x0603A79A RID: 239514 RVA: 0x007DF17C File Offset: 0x007DD37C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISelfClientEventVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientUiEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
