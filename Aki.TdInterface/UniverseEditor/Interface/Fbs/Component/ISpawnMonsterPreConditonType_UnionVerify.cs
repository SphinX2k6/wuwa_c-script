using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F6B RID: 24427
	public static class ISpawnMonsterPreConditonType_UnionVerify
	{
		// Token: 0x06029102 RID: 168194 RVA: 0x0059BD34 File Offset: 0x00599F34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpawnMonsterPreDependOnPrecedingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpawnMonsterPreConditonTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
