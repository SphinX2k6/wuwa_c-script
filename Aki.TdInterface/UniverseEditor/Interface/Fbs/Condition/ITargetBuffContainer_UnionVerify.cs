using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CEA RID: 19690
	public static class ITargetBuffContainer_UnionVerify
	{
		// Token: 0x0601F3FF RID: 127999 RVA: 0x0045C6E0 File Offset: 0x0045A8E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMonsterBuffContainerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITargetBuffContainerVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
