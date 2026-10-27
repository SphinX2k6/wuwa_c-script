using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FCF RID: 20431
	public static class ICommonRotationConfig_UnionVerify
	{
		// Token: 0x06020896 RID: 133270 RVA: 0x004864C8 File Offset: 0x004846C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonRotationConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRotationConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IKeyRotatorConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
