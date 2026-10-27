using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD3 RID: 19411
	public class SkipToMotorcycleView : SkipTask
	{
		// Token: 0x06032336 RID: 205622 RVA: 0x00BAA6D0 File Offset: 0x00BA88D0
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.MotorDevelop);
		}
	}
}
