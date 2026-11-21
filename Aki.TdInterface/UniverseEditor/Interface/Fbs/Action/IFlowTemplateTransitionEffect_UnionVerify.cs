using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB6 RID: 28342
	public static class IFlowTemplateTransitionEffect_UnionVerify
	{
		// Token: 0x0603107A RID: 200826 RVA: 0x006A64D8 File Offset: 0x006A46D8
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
