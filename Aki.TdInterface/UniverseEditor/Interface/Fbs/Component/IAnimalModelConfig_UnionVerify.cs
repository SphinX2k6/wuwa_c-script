using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053DB RID: 21467
	public static class IAnimalModelConfig_UnionVerify
	{
		// Token: 0x06021896 RID: 137366 RVA: 0x0049FF00 File Offset: 0x0049E100
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
