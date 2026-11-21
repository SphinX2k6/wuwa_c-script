using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006108 RID: 24840
	public static class ITurntableConnectorGameplayBase_UnionVerify
	{
		// Token: 0x0602A1AF RID: 172463 RVA: 0x005BF3AC File Offset: 0x005BD5AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICircuitConnectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITurntableConnectorGameplayBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
