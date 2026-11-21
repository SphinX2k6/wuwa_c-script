using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062C6 RID: 25286
	public static class TRefreshConditionVerify
	{
		// Token: 0x0602AFC6 RID: 176070 RVA: 0x005DCEC0 File Offset: 0x005DB0C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRefreshOnHostInteractVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRefreshOnDeathVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
