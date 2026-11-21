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
	// Token: 0x02003EAD RID: 16045
	public class RogueBattleEnvironmentBuffView : UiViewBase
	{
		// Token: 0x06028BC4 RID: 166852 RVA: 0x00B6D3DB File Offset: 0x00B6B5DB
		[NullableContext(1)]
		public RogueBattleEnvironmentBuffView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028BC5 RID: 166853 RVA: 0x00B6D3E4 File Offset: 0x00B6B5E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
			};
		}

		// Token: 0x06028BC6 RID: 166854 RVA: 0x00B6D420 File Offset: 0x00B6B620
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleEnvironmentBuffView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleEnvironmentBuffView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028BC7 RID: 166855 RVA: 0x00B6D464 File Offset: 0x00B6B664
		protected UniTask RefreshView()
		{
			RogueBattleEnvironmentBuffView.<RefreshView>d__5 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<RogueBattleEnvironmentBuffView.<RefreshView>d__5>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x04016255 RID: 90709
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithTexture, IRogueBattleEnvironmentInfo> EnvironmentBuffLayout;

		// Token: 0x04016256 RID: 90710
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleEnvironmentBuffItemWithSprite, IRogueBattleEnvironmentInfo> MonsterBuffLayout;
	}
}
