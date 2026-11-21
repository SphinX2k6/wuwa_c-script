using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EEE RID: 16110
	public class RacingBetsAdvanceItem : RacingBetsMatchItemBase
	{
		// Token: 0x06028E02 RID: 167426 RVA: 0x00B7846C File Offset: 0x00B7666C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06028E03 RID: 167427 RVA: 0x00B784C8 File Offset: 0x00B766C8
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsAdvanceItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsAdvanceItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016383 RID: 91011
		public ERacingBetsMatchTableType MatchTableType = ERacingBetsMatchTableType.GroupMatch;

		// Token: 0x02009AA0 RID: 39584
		private class EComponent
		{
			// Token: 0x040302E4 RID: 197348
			public const int TextTitle = 0;

			// Token: 0x040302E5 RID: 197349
			public const int LayoutDango = 1;

			// Token: 0x040302E6 RID: 197350
			public const int ItemDango = 2;
		}
	}
}
