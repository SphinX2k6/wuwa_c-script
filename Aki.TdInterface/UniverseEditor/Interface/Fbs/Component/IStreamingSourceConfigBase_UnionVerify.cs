using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE9 RID: 24553
	public static class IStreamingSourceConfigBase_UnionVerify
	{
		// Token: 0x060295DD RID: 169437 RVA: 0x005A59A0 File Offset: 0x005A3BA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IStreamingSourceConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedStreamingSourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IConditionalStreamingSourceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
