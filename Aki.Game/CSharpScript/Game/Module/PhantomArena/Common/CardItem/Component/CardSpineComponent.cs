using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C4 RID: 16836
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardSpineComponent : CardComponentBase<ICardSpineComponentData>
	{
		// Token: 0x0602A989 RID: 174473 RVA: 0x00C02D08 File Offset: 0x00C00F08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x0602A98A RID: 174474 RVA: 0x00C02D2B File Offset: 0x00C00F2B
		protected override void OnStart()
		{
			this.SetActive(true);
		}

		// Token: 0x0602A98B RID: 174475 RVA: 0x00C02D34 File Offset: 0x00C00F34
		public override void Refresh(ICardSpineComponentData data)
		{
			CardSpineComponent.<>c__DisplayClass2_0 CS$<>8__locals1 = new CardSpineComponent.<>c__DisplayClass2_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			new UiAsyncTask("Refresh", delegate()
			{
				CardSpineComponent.<>c__DisplayClass2_0.<<Refresh>b__0>d <<Refresh>b__0>d;
				<<Refresh>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<Refresh>b__0>d.<>4__this = CS$<>8__locals1;
				<<Refresh>b__0>d.<>1__state = -1;
				<<Refresh>b__0>d.<>t__builder.Start<CardSpineComponent.<>c__DisplayClass2_0.<<Refresh>b__0>d>(ref <<Refresh>b__0>d);
				return <<Refresh>b__0>d.<>t__builder.Task;
			}, null).Run();
		}

		// Token: 0x0602A98C RID: 174476 RVA: 0x00C02D74 File Offset: 0x00C00F74
		public UniTask RefreshAsync(ICardSpineComponentData data)
		{
			CardSpineComponent.<RefreshAsync>d__3 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<CardSpineComponent.<RefreshAsync>d__3>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x02009DAB RID: 40363
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403107E RID: 200830
			public const int CardSpine = 0;
		}
	}
}
