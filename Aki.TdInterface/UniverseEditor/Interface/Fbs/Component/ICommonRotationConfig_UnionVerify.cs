using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552E RID: 21806
	public static class ICommonRotationConfig_UnionVerify
	{
		// Token: 0x060227B2 RID: 141234 RVA: 0x004BFE78 File Offset: 0x004BE078
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
			case 4:
				result = IAxisAngleMethodConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
