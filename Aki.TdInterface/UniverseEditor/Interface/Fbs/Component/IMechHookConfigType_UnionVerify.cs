using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005547 RID: 21831
	public static class IMechHookConfigType_UnionVerify
	{
		// Token: 0x06024142 RID: 147778 RVA: 0x004FBF4C File Offset: 0x004FA14C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMechHookConfigTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBurrowHookVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechFixedPointHookVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
