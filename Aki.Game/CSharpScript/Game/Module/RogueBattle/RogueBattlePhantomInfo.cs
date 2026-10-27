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
	// Token: 0x02004E82 RID: 20098
	public class RogueBattlePhantomInfo : UiPanelBase
	{
		// Token: 0x06033B50 RID: 211792 RVA: 0x00C1C58C File Offset: 0x00C1A78C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUITexture))
			};
		}

		// Token: 0x06033B51 RID: 211793 RVA: 0x00C1C63E File Offset: 0x00C1A83E
		[NullableContext(1)]
		private RogueBattlePhantomInfoAffix CreateAffixItem()
		{
			return new RogueBattlePhantomInfoAffix();
		}

		// Token: 0x06033B52 RID: 211794 RVA: 0x00C1C648 File Offset: 0x00C1A848
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattlePhantomInfo.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattlePhantomInfo.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B724 RID: 112420
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<RogueBattlePhantomInfoAffix, PhantomAffixInfo> AffixLayout;
	}
}
