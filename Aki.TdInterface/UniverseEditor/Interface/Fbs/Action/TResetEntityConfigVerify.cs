using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F96 RID: 32662
	public static class TResetEntityConfigVerify
	{
		// Token: 0x0603ADAC RID: 241068 RVA: 0x007E8BA4 File Offset: 0x007E6DA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IResetTeleControlEntityVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IJigsawItemEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
