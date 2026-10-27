using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E0 RID: 25312
	public static class IChangeElementalBoxStateTarget_UnionVerify
	{
		// Token: 0x0602BC06 RID: 179206 RVA: 0x00604F3C File Offset: 0x0060313C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IChangeElementalBoxStateTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChangeElementalBoxStatePlayerTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChangeElementalBoxStateTargetBoxIdVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
