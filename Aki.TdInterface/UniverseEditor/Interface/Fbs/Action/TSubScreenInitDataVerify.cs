using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AF RID: 30639
	public static class TSubScreenInitDataVerify
	{
		// Token: 0x06037999 RID: 227737 RVA: 0x00785654 File Offset: 0x00783854
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubScreenPresetInitDataVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISubScreenCustomInitDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
