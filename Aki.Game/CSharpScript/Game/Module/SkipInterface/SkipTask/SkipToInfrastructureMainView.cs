using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Infrastructure;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BCE RID: 19406
	public class SkipToInfrastructureMainView : SkipTask
	{
		// Token: 0x0603232B RID: 205611 RVA: 0x00BAA4A4 File Offset: 0x00BA86A4
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
			base.Finish();
		}
	}
}
