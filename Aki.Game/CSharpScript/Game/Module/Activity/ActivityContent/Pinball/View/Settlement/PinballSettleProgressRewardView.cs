using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Level;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x0200526F RID: 21103
	public class PinballSettleProgressRewardView : UiPanelBase
	{
		// Token: 0x06034888 RID: 215176 RVA: 0x00EB2DCC File Offset: 0x00EB0FCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034889 RID: 215177 RVA: 0x00EB2EBC File Offset: 0x00EB10BC
		protected override UniTask OnBeforeStartAsync()
		{
			PinballSettleProgressRewardView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballSettleProgressRewardView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603488A RID: 215178 RVA: 0x00EB2F00 File Offset: 0x00EB1100
		[NullableContext(1)]
		public void ShowProgressRewardList(int progress, int[] progressList, int[] scoreLevelDropId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), "Pinball_BattleSettlement_Score", new <>z__ReadOnlySingleElementList<object>(progress));
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount((progress < progressList[0]) ? 0f : ((float)(progress - progressList[0]) / (float)(progressList[1] - progressList[0])));
			}
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount((progress < progressList[1]) ? 0f : ((float)(progress - progressList[1]) / (float)(progressList[2] - progressList[1])));
			}
			for (int i = 0; i < this.Items.Count; i++)
			{
				PinballLevelScoreData data = new PinballLevelScoreData
				{
					CurScore = progress,
					ConfigScore = progressList[i],
					ConfigDropId = scoreLevelDropId[i]
				};
				this.Items[i].Refresh(data);
			}
		}

		// Token: 0x0401BDB7 RID: 114103
		[Nullable(1)]
		private readonly List<PinballLevelInfoScoreItem> Items = new List<PinballLevelInfoScoreItem>();

		// Token: 0x0200AECE RID: 44750
		private enum EComponent
		{
			// Token: 0x04036017 RID: 221207
			TextScore,
			// Token: 0x04036018 RID: 221208
			ProgressOne,
			// Token: 0x04036019 RID: 221209
			ProgressTwo,
			// Token: 0x0403601A RID: 221210
			ProgressRewardItemOne,
			// Token: 0x0403601B RID: 221211
			ProgressRewardItemTwo,
			// Token: 0x0403601C RID: 221212
			ProgressRewardItemThree
		}
	}
}
