using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5F RID: 23647
	public static class TMechHookConfigVerify
	{
		// Token: 0x06028874 RID: 166004 RVA: 0x00592EBC File Offset: 0x005910BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMechFixedPointHookVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBurrowHookVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
