using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EBF RID: 16063
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRandomEventView : UiViewBase
	{
		// Token: 0x06028C18 RID: 166936 RVA: 0x00B6EFA1 File Offset: 0x00B6D1A1
		public RogueBattleRandomEventView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028C19 RID: 166937 RVA: 0x00B6EFAC File Offset: 0x00B6D1AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06028C1A RID: 166938 RVA: 0x00B6F01C File Offset: 0x00B6D21C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRandomEventView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRandomEventView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028C1B RID: 166939 RVA: 0x00B6F05F File Offset: 0x00B6D25F
		private RogueBattleRandomEventItem CreateItem()
		{
			return new RogueBattleRandomEventItem();
		}

		// Token: 0x040162AA RID: 90794
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleRandomEventItem, RogueResGainData> OptionLayout;
	}
}
