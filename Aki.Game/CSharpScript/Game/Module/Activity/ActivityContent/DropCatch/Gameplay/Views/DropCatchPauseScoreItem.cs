using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006700 RID: 26368
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropCatchPauseScoreItem : GridProxyAbstract<IScoreLevelItemData>
	{
		// Token: 0x06041DFB RID: 269819 RVA: 0x00FF9AEC File Offset: 0x00FF7CEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06041DFC RID: 269820 RVA: 0x00FF9B48 File Offset: 0x00FF7D48
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchPauseScoreItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchPauseScoreItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041DFD RID: 269821 RVA: 0x00FF9B8C File Offset: 0x00FF7D8C
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

		// Token: 0x0402250A RID: 140554
		[Nullable(2)]
		private DropCatchStarItemView StarItemView;
	}
}
