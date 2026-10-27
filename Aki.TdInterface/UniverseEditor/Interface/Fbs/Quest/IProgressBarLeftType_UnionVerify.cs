using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC1 RID: 16321
	public static class IProgressBarLeftType_UnionVerify
	{
		// Token: 0x06017567 RID: 95591 RVA: 0x0035D108 File Offset: 0x0035B308
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
