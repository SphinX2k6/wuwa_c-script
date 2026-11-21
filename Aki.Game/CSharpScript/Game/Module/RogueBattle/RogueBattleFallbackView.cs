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
	// Token: 0x02003EAF RID: 16047
	public class RogueBattleFallbackView : UiViewBase
	{
		// Token: 0x06028BC8 RID: 166856 RVA: 0x00B6D4A7 File Offset: 0x00B6B6A7
		[NullableContext(1)]
		public RogueBattleFallbackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BC9 RID: 166857 RVA: 0x00B6D4B0 File Offset: 0x00B6B6B0
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

		// Token: 0x06028BCA RID: 166858 RVA: 0x00B6D589 File Offset: 0x00B6B789
		private void OnBtnHelp()
		{
		}

		// Token: 0x06028BCB RID: 166859 RVA: 0x00B6D58B File Offset: 0x00B6B78B
		private void OnBtnExit()
		{
			((MapRogueOpFallback)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).OpExecuteClientId = 0;
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
			base.CloseMe(null);
		}

		// Token: 0x06028BCC RID: 166860 RVA: 0x00B6D5CA File Offset: 0x00B6B7CA
		private void OnBtnBackToMap()
		{
			((MapRogueOpFallback)MapRogueModel.Instance.GetOpData((int)this.OpenParam)).OpExecuteClientId = 1;
			MapRogueModel.Instance.ExecuteOpData((int)this.OpenParam, null);
		}

		// Token: 0x06028BCD RID: 166861 RVA: 0x00B6D604 File Offset: 0x00B6B804
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
