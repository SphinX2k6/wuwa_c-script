using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B9 RID: 22713
	public class SolarSchoolGoHomeAction : SolarSchoolActionBase
	{
		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x06037F09 RID: 229129 RVA: 0x00FA2D23 File Offset: 0x00FA0F23
		public override bool NeedPrepareFirstScreen
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037F0A RID: 229130 RVA: 0x00FA2D26 File Offset: 0x00FA0F26
		protected override void OnStart()
		{
			this.GoHomeAsync().Forget();
		}

		// Token: 0x06037F0B RID: 229131 RVA: 0x00FA2D34 File Offset: 0x00FA0F34
		private UniTask GoHomeAsync()
		{
			SolarSchoolGoHomeAction.<GoHomeAsync>d__3 <GoHomeAsync>d__;
			<GoHomeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GoHomeAsync>d__.<>4__this = this;
			<GoHomeAsync>d__.<>1__state = -1;
			<GoHomeAsync>d__.<>t__builder.Start<SolarSchoolGoHomeAction.<GoHomeAsync>d__3>(ref <GoHomeAsync>d__);
			return <GoHomeAsync>d__.<>t__builder.Task;
		}
	}
}
