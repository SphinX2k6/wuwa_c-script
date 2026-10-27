using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BCD RID: 19405
	public class SkipToGachaView : SkipToMoonChasingBase
	{
		// Token: 0x06032329 RID: 205609 RVA: 0x00BAA48B File Offset: 0x00BA868B
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
		}
	}
}
