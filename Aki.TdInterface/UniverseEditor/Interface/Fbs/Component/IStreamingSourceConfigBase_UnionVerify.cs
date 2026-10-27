using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DC RID: 23004
	public static class IStreamingSourceConfigBase_UnionVerify
	{
		// Token: 0x06027065 RID: 159845 RVA: 0x0055E9DC File Offset: 0x0055CBDC
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
