using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004402 RID: 17410
	public static class IProgressBarLeftType_UnionVerify
	{
		// Token: 0x06018BF6 RID: 101366 RVA: 0x00386D20 File Offset: 0x00384F20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IProgressBarLeftTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUseCountVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUseVarVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
