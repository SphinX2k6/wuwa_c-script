using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D8E RID: 23950
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class StepControllerBase : UiPanelBase
	{
		// Token: 0x17008E64 RID: 36452
		// (get) Token: 0x0603CC8B RID: 248971
		public abstract bool Enable { get; }

		// Token: 0x0603CC8C RID: 248972 RVA: 0x00E9823F File Offset: 0x00E9643F
		public virtual bool CheckTextVisible()
		{
			return true;
		}

		// Token: 0x0603CC8D RID: 248973 RVA: 0x00E98242 File Offset: 0x00E96442
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x0603CC8E RID: 248974 RVA: 0x00E98244 File Offset: 0x00E96444
		public virtual UniTask OnConfigRefresh(IMissionItemViewShowData showData, MissionViewStepTextInfoBase config)
		{
			StepControllerBase.<OnConfigRefresh>d__6 <OnConfigRefresh>d__;
			<OnConfigRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnConfigRefresh>d__.<>4__this = this;
			<OnConfigRefresh>d__.showData = showData;
			<OnConfigRefresh>d__.config = config;
			<OnConfigRefresh>d__.<>1__state = -1;
			<OnConfigRefresh>d__.<>t__builder.Start<StepControllerBase.<OnConfigRefresh>d__6>(ref <OnConfigRefresh>d__);
			return <OnConfigRefresh>d__.<>t__builder.Task;
		}

		// Token: 0x0401FAA1 RID: 129697
		protected IMissionItemViewShowData ShowData;

		// Token: 0x0401FAA2 RID: 129698
		protected MissionViewStepTextInfoBase Config;
	}
}
