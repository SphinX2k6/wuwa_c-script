using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007733 RID: 30515
	public static class TMoveToPointTypeVerify
	{
		// Token: 0x0603773F RID: 227135 RVA: 0x00781EA0 File Offset: 0x007800A0
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
