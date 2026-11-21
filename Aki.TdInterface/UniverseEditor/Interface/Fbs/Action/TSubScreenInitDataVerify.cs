using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE7 RID: 32743
	public static class TSubScreenInitDataVerify
	{
		// Token: 0x0603AF1A RID: 241434 RVA: 0x007EAC24 File Offset: 0x007E8E24
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
