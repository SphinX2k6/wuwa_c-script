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
	// Token: 0x02004EE4 RID: 20196
	public class RogueBattleEnvironmentBuffView : UiViewBase
	{
		// Token: 0x06033D59 RID: 212313 RVA: 0x00C23E33 File Offset: 0x00C22033
		[NullableContext(1)]
		public RogueBattleEnvironmentBuffView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033D5A RID: 212314 RVA: 0x00C23E3C File Offset: 0x00C2203C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
			};
		}

		// Token: 0x06033D5B RID: 212315 RVA: 0x00C23E78 File Offset: 0x00C22078
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleEnvironmentBuffView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleEnvironmentBuffView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D5C RID: 212316 RVA: 0x00C23EBC File Offset: 0x00C220BC
		protected UniTask RefreshView()
		{
			RogueBattleEnvironmentBuffView.<RefreshView>d__5 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<RogueBattleEnvironmentBuffView.<RefreshView>d__5>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x0401B882 RID: 112770
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithTexture, IRogueBattleEnvironmentInfo> EnvironmentBuffLayout;

		// Token: 0x0401B883 RID: 112771
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithSprite, IRogueBattleEnvironmentInfo> MonsterBuffLayout;
	}
}
