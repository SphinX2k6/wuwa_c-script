using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005088 RID: 20616
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeBlessingReplaceView : RoverlikeActionViewBase
	{
		// Token: 0x06033994 RID: 211348 RVA: 0x00E715A3 File Offset: 0x00E6F7A3
		[NullableContext(1)]
		public RoverlikeBlessingReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033995 RID: 211349 RVA: 0x00E715AC File Offset: 0x00E6F7AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnReplaceClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnKeepClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033996 RID: 211350 RVA: 0x00E716D8 File Offset: 0x00E6F8D8
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeBlessingReplaceView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeBlessingReplaceView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033997 RID: 211351 RVA: 0x00E7171B File Offset: 0x00E6F91B
		private void OnBtnReplaceClick()
		{
			base.TryInteractAction(delegate
			{
				IRoverlikeBlessingReplaceParam param = this.Param;
				if (param != null)
				{
					Action onConfirm = param.OnConfirm;
					if (onConfirm != null)
					{
						onConfirm();
					}
				}
				base.CloseMe(null);
			});
		}

		// Token: 0x06033998 RID: 211352 RVA: 0x00E71730 File Offset: 0x00E6F930
		private void OnBtnKeepClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033999 RID: 211353 RVA: 0x00E7173C File Offset: 0x00E6F93C
		private void RefreshBlessingCards()
		{
			if (this.Param == null)
			{
				return;
			}
			bool flag = this.Param.Type == ERoverlikeBlessingReplaceType.Replace;
			IRoverlikeBlessingItemData data = new RoverlikeBlessingItemData
			{
				BlessId = this.Param.CurBlessId,
				AllowToggleInteract = new bool?(false)
			};
			IRoverlikeBlessingItemData data2 = new RoverlikeBlessingItemData
			{
				BlessId = this.Param.NewBlessId,
				AllowToggleInteract = new bool?(false),
				ShowRecommend = new bool?(!flag)
			};
			RoverlikeBlessingCardItem curBlessingItem = this.CurBlessingItem;
			if (curBlessingItem != null)
			{
				curBlessingItem.Refresh(data, false, 0);
			}
			RoverlikeBlessingCardItem newBlessingItem = this.NewBlessingItem;
			if (newBlessingItem == null)
			{
				return;
			}
			newBlessingItem.Refresh(data2, false, 1);
		}

		// Token: 0x0603399A RID: 211354 RVA: 0x00E717DD File Offset: 0x00E6F9DD
		protected override void OnBeforeShow()
		{
			RoverlikeBlessingCardItem curBlessingItem = this.CurBlessingItem;
			if (curBlessingItem != null)
			{
				curBlessingItem.RefreshDescMode();
			}
			RoverlikeBlessingCardItem newBlessingItem = this.NewBlessingItem;
			if (newBlessingItem == null)
			{
				return;
			}
			newBlessingItem.RefreshDescMode();
		}

		// Token: 0x0603399B RID: 211355 RVA: 0x00E71800 File Offset: 0x00E6FA00
		protected override void OnStart()
		{
			IRoverlikeBlessingReplaceParam roverlikeBlessingReplaceParam = this.OpenParam as IRoverlikeBlessingReplaceParam;
			if (roverlikeBlessingReplaceParam == null)
			{
				return;
			}
			this.Param = roverlikeBlessingReplaceParam;
			this.RefreshBlessingCards();
			string textStringId = (roverlikeBlessingReplaceParam.Type == ERoverlikeBlessingReplaceType.Enhance) ? "RoverRogue_BlessingUpgrade" : "RoverRogue_BlessingReplace";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603399C RID: 211356 RVA: 0x00E71857 File Offset: 0x00E6FA57
		protected override void OnBeforeDestroy()
		{
			this.Param = null;
		}

		// Token: 0x0401B627 RID: 112167
		protected RoverlikeBlessingCardItem CurBlessingItem;

		// Token: 0x0401B628 RID: 112168
		protected RoverlikeBlessingCardItem NewBlessingItem;

		// Token: 0x0401B629 RID: 112169
		private IRoverlikeBlessingReplaceParam Param;

		// Token: 0x0200AD41 RID: 44353
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358B9 RID: 219321
			public const int ItemCurBlessing = 0;

			// Token: 0x040358BA RID: 219322
			public const int ItemNewBlessing = 1;

			// Token: 0x040358BB RID: 219323
			public const int BtnKeep = 2;

			// Token: 0x040358BC RID: 219324
			public const int BtnReplace = 3;

			// Token: 0x040358BD RID: 219325
			public const int TxtTitle = 4;
		}
	}
}
