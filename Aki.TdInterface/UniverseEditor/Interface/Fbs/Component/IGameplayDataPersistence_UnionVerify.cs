using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052ED RID: 21229
	public static class IGameplayDataPersistence_UnionVerify
	{
		// Token: 0x06022A87 RID: 141959 RVA: 0x004CDC2C File Offset: 0x004CBE2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGameplayDataPersistenceTetrisBoardGameVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGameplayDataPersistenceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
