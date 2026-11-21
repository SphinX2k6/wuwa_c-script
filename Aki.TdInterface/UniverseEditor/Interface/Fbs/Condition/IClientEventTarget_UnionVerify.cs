using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005066 RID: 20582
	public static class IClientEventTarget_UnionVerify
	{
		// Token: 0x060202DC RID: 131804 RVA: 0x004762D4 File Offset: 0x004744D4
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
