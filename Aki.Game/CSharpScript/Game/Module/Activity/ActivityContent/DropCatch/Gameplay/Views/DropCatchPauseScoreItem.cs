using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005650 RID: 22096
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropCatchPauseScoreItem : GridProxyAbstract<IScoreLevelItemData>
	{
		// Token: 0x06036947 RID: 223559 RVA: 0x00F3AEE0 File Offset: 0x00F390E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06036948 RID: 223560 RVA: 0x00F3AF3C File Offset: 0x00F3913C
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchPauseScoreItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchPauseScoreItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036949 RID: 223561 RVA: 0x00F3AF80 File Offset: 0x00F39180
		public override void Refresh(IScoreLevelItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), EDropCatchTextId.TextScoreLevel.ToEnumString(), new <>z__ReadOnlySingleElementList<object>(data.Score));
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(data.IsFinish);
			}
			DropCatchStarItemView starItemView = this.StarItemView;
			if (starItemView == null)
			{
				return;
			}
			starItemView.Refresh(data.IsFinish);
		}

		// Token: 0x0401CD63 RID: 118115
		[Nullable(2)]
		private DropCatchStarItemView StarItemView;
	}
}
