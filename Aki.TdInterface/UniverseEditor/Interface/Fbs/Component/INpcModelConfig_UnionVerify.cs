using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCC RID: 23500
	public static class INpcModelConfig_UnionVerify
	{
		// Token: 0x06026C2B RID: 158763 RVA: 0x0054E124 File Offset: 0x0054C324
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
			case 4:
				result = ICombineDaNpcModelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
