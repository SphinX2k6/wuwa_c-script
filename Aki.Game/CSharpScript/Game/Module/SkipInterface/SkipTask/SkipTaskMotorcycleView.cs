using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B5A RID: 15194
	public class SkipTaskMotorcycleView : SkipTask
	{
		// Token: 0x0602707F RID: 159871 RVA: 0x00AED4FF File Offset: 0x00AEB6FF
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
