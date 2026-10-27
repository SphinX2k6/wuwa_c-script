using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B7F RID: 19327
	public static class IClientEventTarget_UnionVerify
	{
		// Token: 0x0601E74E RID: 124750 RVA: 0x00443A88 File Offset: 0x00441C88
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISelfClientEventVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientEventTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
