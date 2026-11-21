using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F5C RID: 32604
	public static class TMoveToPointTypeVerify
	{
		// Token: 0x0603AC7A RID: 240762 RVA: 0x007E6E30 File Offset: 0x007E5030
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVariableMotionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUniformMotionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
