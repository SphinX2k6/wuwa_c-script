using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547B RID: 21627
	public static class IInteractStyleBase_UnionVerify
	{
		// Token: 0x06023934 RID: 145716 RVA: 0x004EB568 File Offset: 0x004E9768
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
