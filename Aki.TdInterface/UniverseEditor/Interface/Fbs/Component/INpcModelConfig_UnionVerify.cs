using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562E RID: 22062
	public static class INpcModelConfig_UnionVerify
	{
		// Token: 0x06024A18 RID: 150040 RVA: 0x0050DA74 File Offset: 0x0050BC74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcModelConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMeshNpcModelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDaNpcModelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
