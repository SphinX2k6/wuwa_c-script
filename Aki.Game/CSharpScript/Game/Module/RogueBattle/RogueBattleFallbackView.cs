using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EE6 RID: 20198
	public class RogueBattleFallbackView : UiViewBase
	{
		// Token: 0x06033D5D RID: 212317 RVA: 0x00C23EFF File Offset: 0x00C220FF
		[NullableContext(1)]
		public RogueBattleFallbackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D5E RID: 212318 RVA: 0x00C23F08 File Offset: 0x00C22108
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnHelp)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnExit)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnBtnBackToMap))
			};
		}

		// Token: 0x06033D5F RID: 212319 RVA: 0x00C23FE1 File Offset: 0x00C221E1
		private void OnBtnHelp()
		{
		}

		// Token: 0x06033D60 RID: 212320 RVA: 0x00C23FE3 File Offset: 0x00C221E3
		private void OnBtnExit()
		{
			((MapRogueOpFallback)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).OpExecuteClientId = 0;
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
			base.CloseMe(null);
		}

		// Token: 0x06033D61 RID: 212321 RVA: 0x00C24022 File Offset: 0x00C22222
		private void OnBtnBackToMap()
		{
			((MapRogueOpFallback)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).OpExecuteClientId = 1;
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
		}

		// Token: 0x06033D62 RID: 212322 RVA: 0x00C2405C File Offset: 0x00C2225C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleFallbackView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleFallbackView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}
	}
}
