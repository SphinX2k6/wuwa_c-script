using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200589A RID: 22682
	public static class IGraph3dEffectBase_UnionVerify
	{
		// Token: 0x06024C97 RID: 150679 RVA: 0x0050D324 File Offset: 0x0050B524
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFireBoxFishEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGraph3dEffectBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
