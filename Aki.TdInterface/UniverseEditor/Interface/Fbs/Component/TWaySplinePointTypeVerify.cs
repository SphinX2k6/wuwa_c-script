using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200630B RID: 25355
	public static class TWaySplinePointTypeVerify
	{
		// Token: 0x0602B112 RID: 176402 RVA: 0x005DED08 File Offset: 0x005DCF08
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWaySplineStartPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWaySplineCommonPointVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
