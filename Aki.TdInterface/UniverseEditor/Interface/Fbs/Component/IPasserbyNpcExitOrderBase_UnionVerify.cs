using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C71 RID: 23665
	public static class IPasserbyNpcExitOrderBase_UnionVerify
	{
		// Token: 0x06027420 RID: 160800 RVA: 0x00560918 File Offset: 0x0055EB18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcNearSplineStartFirstExitOrderVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcExitOrderBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
