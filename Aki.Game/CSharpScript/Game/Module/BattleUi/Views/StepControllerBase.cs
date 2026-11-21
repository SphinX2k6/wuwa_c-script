using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D70 RID: 19824
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class StepControllerBase : UiPanelBase
	{
		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x06031BE7 RID: 203751
		public abstract bool Enable { get; }

		// Token: 0x06031BE8 RID: 203752 RVA: 0x00DE8A87 File Offset: 0x00DE6C87
		public virtual bool CheckTextVisible()
		{
			return true;
		}

		// Token: 0x06031BE9 RID: 203753 RVA: 0x00DE8A8A File Offset: 0x00DE6C8A
		public virtual void OnTick(float delta)
		{
		}

		// Token: 0x06031BEA RID: 203754 RVA: 0x00DE8A8C File Offset: 0x00DE6C8C
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

		// Token: 0x0401A559 RID: 107865
		protected IMissionItemViewShowData ShowData;

		// Token: 0x0401A55A RID: 107866
		protected MissionViewStepTextInfoBase Config;
	}
}
