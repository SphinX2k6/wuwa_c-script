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
	// Token: 0x02003EB3 RID: 16051
	public class RogueBattleMapHelpView : UiViewBase
	{
		// Token: 0x06028BD5 RID: 166869 RVA: 0x00B6D960 File Offset: 0x00B6BB60
		[NullableContext(1)]
		public RogueBattleMapHelpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BD6 RID: 166870 RVA: 0x00B6D969 File Offset: 0x00B6BB69
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06028BD7 RID: 166871 RVA: 0x00B6D9A4 File Offset: 0x00B6BBA4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleMapHelpView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleMapHelpView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016269 RID: 90729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithTexture, IRogueBattleEnvironmentInfo> EventLayout;
	}
}
