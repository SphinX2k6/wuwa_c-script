using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B5 RID: 30645
	public static class TSubtitleStyleVerify
	{
		// Token: 0x060379B3 RID: 227763 RVA: 0x00785898 File Offset: 0x00783A98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubtitleStyleNewLevelBVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISubtitleStyleLevelAVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
