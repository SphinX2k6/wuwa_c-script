using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A63 RID: 19043
	public static class TDangoBrawlObjectVerify
	{
		// Token: 0x0601CA13 RID: 117267 RVA: 0x0040A388 File Offset: 0x00408588
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDangoBrawlItemVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDangoBrawlBagVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
