using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EDA RID: 24282
	public static class TCommonBtDecoratorVerify
	{
		// Token: 0x06029B5F RID: 170847 RVA: 0x005B98BC File Offset: 0x005B7ABC
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
