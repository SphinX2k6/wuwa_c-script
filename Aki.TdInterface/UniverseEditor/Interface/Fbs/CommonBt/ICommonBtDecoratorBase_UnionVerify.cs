using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB9 RID: 24249
	public static class ICommonBtDecoratorBase_UnionVerify
	{
		// Token: 0x0602994C RID: 170316 RVA: 0x005B4278 File Offset: 0x005B2478
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtDecoratorBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtConditionDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonBtAlwaysFalseDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonBtAlwaysTrueDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonBtDoOnceDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICommonBtCoolDownDecoratorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
