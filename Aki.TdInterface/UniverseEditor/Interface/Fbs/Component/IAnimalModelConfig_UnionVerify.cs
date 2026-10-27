using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EB2 RID: 20146
	public static class IAnimalModelConfig_UnionVerify
	{
		// Token: 0x0601FB95 RID: 129941 RVA: 0x0046AA84 File Offset: 0x00468C84
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMeshAnimalModelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAnimalModelConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
