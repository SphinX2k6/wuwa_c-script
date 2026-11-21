using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079FD RID: 31229
	public static class ISubtitleStyleBase_UnionVerify
	{
		// Token: 0x06037071 RID: 225393 RVA: 0x0075AFFC File Offset: 0x007591FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubtitleStyleBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubtitleStyleLevelAVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubtitleStyleNewLevelBVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
