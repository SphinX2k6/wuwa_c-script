using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006111 RID: 24849
	public static class ITurntableControlType_UnionVerify
	{
		// Token: 0x0602A1F1 RID: 172529 RVA: 0x005BFAF0 File Offset: 0x005BDCF0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITurntableControlTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFreeAngleTurntableVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFixedAngleTurntableVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
