using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E2C RID: 24108
	public static class IRefreshContent_UnionVerify
	{
		// Token: 0x0602842D RID: 164909 RVA: 0x005813A8 File Offset: 0x0057F5A8
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
