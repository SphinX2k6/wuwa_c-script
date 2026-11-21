using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EEE RID: 16110
	public static class ITargetType_UnionVerify
	{
		// Token: 0x06015D7D RID: 89469 RVA: 0x00324430 File Offset: 0x00322630
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITargetPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITargetLevelEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
