using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D3 RID: 25299
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballPermanentRewardTaskItem : GridProxyAbstract<PinballTaskData>
	{
		// Token: 0x0603FAA4 RID: 260772 RVA: 0x00F674D0 File Offset: 0x00F656D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnRewardBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FAA5 RID: 260773 RVA: 0x00F6765E File Offset: 0x00F6585E
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x0603FAA6 RID: 260774 RVA: 0x00F67684 File Offset: 0x00F65884
		public override void Refresh(PinballTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			this.RewardScroll.RefreshByData(data.RewardList, null, false);
			base.GetButton(6).RootUIComp.Get().SetUIActive(data.IsUnclaimed);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(data.IsFinished);
			base.GetText(5).SetUIActive(data.IsDoing);
			UUIText text = base.GetText(1);
			if (data.QuestNameTextKey != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.QuestNameTextKey, Array.Empty<object>());
			}
			else
			{
				text.SetText(data.QuestName, true);
			}
			base.GetText(2).SetUIActive(data.Target != 0);
			UUIText text2 = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603FAA7 RID: 260775 RVA: 0x00F67788 File Offset: 0x00F65988
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603FAA8 RID: 260776 RVA: 0x00F67790 File Offset: 0x00F65990
		private UniTask OnRewardBtnClickAsync()
		{
			PinballPermanentRewardTaskItem.<OnRewardBtnClickAsync>d__7 <OnRewardBtnClickAsync>d__;
			<OnRewardBtnClickAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRewardBtnClickAsync>d__.<>4__this = this;
			<OnRewardBtnClickAsync>d__.<>1__state = -1;
			<OnRewardBtnClickAsync>d__.<>t__builder.Start<PinballPermanentRewardTaskItem.<OnRewardBtnClickAsync>d__7>(ref <OnRewardBtnClickAsync>d__);
			return <OnRewardBtnClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FAA9 RID: 260777 RVA: 0x00F677D3 File Offset: 0x00F659D3
		private void OnRewardBtnClick()
		{
			this.OnRewardBtnClickAsync().Forget();
		}

		// Token: 0x04021434 RID: 136244
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04021435 RID: 136245
		[Nullable(2)]
		private PinballTaskData TaskData;

		// Token: 0x04021436 RID: 136246
		[Nullable(2)]
		public Func<int, UniTask> OnTaskRewardClick;

		// Token: 0x0200C4BD RID: 50365
		[NullableContext(0)]
		private enum ETaskComponents
		{
			// Token: 0x0403B5DA RID: 243162
			ScriptBtn,
			// Token: 0x0403B5DB RID: 243163
			TxtName,
			// Token: 0x0403B5DC RID: 243164
			TxtNum,
			// Token: 0x0403B5DD RID: 243165
			ItemLayout,
			// Token: 0x0403B5DE RID: 243166
			ItemBaseB,
			// Token: 0x0403B5DF RID: 243167
			TxtDoing,
			// Token: 0x0403B5E0 RID: 243168
			BtnConfirmBaseA,
			// Token: 0x0403B5E1 RID: 243169
			RedPoint,
			// Token: 0x0403B5E2 RID: 243170
			PanelDone
		}
	}
}
