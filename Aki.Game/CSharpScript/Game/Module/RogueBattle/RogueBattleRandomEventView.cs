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
	// Token: 0x02004EF6 RID: 20214
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRandomEventView : UiViewBase
	{
		// Token: 0x06033DAD RID: 212397 RVA: 0x00C259F9 File Offset: 0x00C23BF9
		public RogueBattleRandomEventView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033DAE RID: 212398 RVA: 0x00C25A04 File Offset: 0x00C23C04
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

		// Token: 0x06033DAF RID: 212399 RVA: 0x00C25A74 File Offset: 0x00C23C74
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleRandomEventView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleRandomEventView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DB0 RID: 212400 RVA: 0x00C25AB7 File Offset: 0x00C23CB7
		private RogueBattleRandomEventItem CreateItem()
		{
			return new RogueBattleRandomEventItem();
		}

		// Token: 0x0401B8D7 RID: 112855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattleRandomEventItem, RogueResGainData> OptionLayout;
	}
}
