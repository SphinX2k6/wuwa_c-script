using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A01 RID: 23041
	public static class IInteractStyleBase_UnionVerify
	{
		// Token: 0x060259EC RID: 154092 RVA: 0x005285DC File Offset: 0x005267DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractStyleBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInteractStylePanoramaVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractStyleEntityPartVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
