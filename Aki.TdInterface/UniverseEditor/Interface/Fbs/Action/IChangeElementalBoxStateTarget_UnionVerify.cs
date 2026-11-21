using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006951 RID: 26961
	public static class IChangeElementalBoxStateTarget_UnionVerify
	{
		// Token: 0x0602E36F RID: 189295 RVA: 0x0064FF48 File Offset: 0x0064E148
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
