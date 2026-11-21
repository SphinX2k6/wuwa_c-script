using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200651D RID: 25885
	public static class TCommonBtDecoratorVerify
	{
		// Token: 0x0602C213 RID: 180755 RVA: 0x00602DA0 File Offset: 0x00600FA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtAlwaysFalseDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtAlwaysTrueDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonBtConditionDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonBtCoolDownDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonBtDoOnceDecoratorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
