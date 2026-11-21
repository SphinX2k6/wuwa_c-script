using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005870 RID: 22640
	public static class IGameplayDataPersistence_UnionVerify
	{
		// Token: 0x06024B21 RID: 150305 RVA: 0x0050A758 File Offset: 0x00508958
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
