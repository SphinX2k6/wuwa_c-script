using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EEA RID: 20202
	public class RogueBattleMapHelpView : UiViewBase
	{
		// Token: 0x06033D6A RID: 212330 RVA: 0x00C243B8 File Offset: 0x00C225B8
		[NullableContext(1)]
		public RogueBattleMapHelpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D6B RID: 212331 RVA: 0x00C243C1 File Offset: 0x00C225C1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033D6C RID: 212332 RVA: 0x00C243FC File Offset: 0x00C225FC
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapHelpView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapHelpView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B896 RID: 112790
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithTexture, IRogueBattleEnvironmentInfo> EventLayout;
	}
}
