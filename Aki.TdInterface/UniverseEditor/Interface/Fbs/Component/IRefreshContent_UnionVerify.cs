using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005825 RID: 22565
	public static class IRefreshContent_UnionVerify
	{
		// Token: 0x06025F0D RID: 155405 RVA: 0x0053B21C File Offset: 0x0053941C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRefreshContentVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAllRefreshContentVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRandomEntityRefreshContentVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
