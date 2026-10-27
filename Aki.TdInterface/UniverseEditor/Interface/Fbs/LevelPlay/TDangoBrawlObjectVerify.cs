using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045FB RID: 17915
	public static class TDangoBrawlObjectVerify
	{
		// Token: 0x0601B23E RID: 111166 RVA: 0x003DE0EC File Offset: 0x003DC2EC
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
