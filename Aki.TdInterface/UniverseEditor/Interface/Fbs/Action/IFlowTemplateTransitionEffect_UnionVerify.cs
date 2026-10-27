using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006830 RID: 26672
	public static class IFlowTemplateTransitionEffect_UnionVerify
	{
		// Token: 0x0602E7F2 RID: 190450 RVA: 0x00658598 File Offset: 0x00656798
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFlowTemplateBlurTransitionEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFlowTemplateTransitionEffectVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
