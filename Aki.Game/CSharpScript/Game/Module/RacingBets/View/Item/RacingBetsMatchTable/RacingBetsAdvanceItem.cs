using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F25 RID: 20261
	public class RacingBetsAdvanceItem : RacingBetsMatchItemBase
	{
		// Token: 0x06033F94 RID: 212884 RVA: 0x00C2ECC4 File Offset: 0x00C2CEC4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06033F95 RID: 212885 RVA: 0x00C2ED20 File Offset: 0x00C2CF20
		protected override UniTask OnBeforeStartAsync()
		{
			RacingBetsAdvanceItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsAdvanceItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B9AE RID: 113070
		public ERacingBetsMatchTableType MatchTableType = ERacingBetsMatchTableType.GroupMatch;

		// Token: 0x0200B070 RID: 45168
		private class EComponent
		{
			// Token: 0x040358B9 RID: 219321
			public const int TextTitle = 0;

			// Token: 0x040358BA RID: 219322
			public const int LayoutDango = 1;

			// Token: 0x040358BB RID: 219323
			public const int ItemDango = 2;
		}
	}
}
