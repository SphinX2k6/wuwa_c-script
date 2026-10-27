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
	// Token: 0x0200610A RID: 24842
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeBlessingReplaceView : RoverlikeActionViewBase
	{
		// Token: 0x0603ECD2 RID: 257234 RVA: 0x00F2A78F File Offset: 0x00F2898F
		[NullableContext(1)]
		public RoverlikeBlessingReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ECD3 RID: 257235 RVA: 0x00F2A798 File Offset: 0x00F28998
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

		// Token: 0x0603ECD4 RID: 257236 RVA: 0x00F2A8C4 File Offset: 0x00F28AC4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeBlessingReplaceView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeBlessingReplaceView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ECD5 RID: 257237 RVA: 0x00F2A907 File Offset: 0x00F28B07
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

		// Token: 0x0603ECD6 RID: 257238 RVA: 0x00F2A91C File Offset: 0x00F28B1C
		private void OnBtnKeepClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603ECD7 RID: 257239 RVA: 0x00F2A928 File Offset: 0x00F28B28
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

		// Token: 0x0603ECD8 RID: 257240 RVA: 0x00F2A9C9 File Offset: 0x00F28BC9
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

		// Token: 0x0603ECD9 RID: 257241 RVA: 0x00F2A9EC File Offset: 0x00F28BEC
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

		// Token: 0x0603ECDA RID: 257242 RVA: 0x00F2AA43 File Offset: 0x00F28C43
		protected override void OnBeforeDestroy()
		{
			this.Param = null;
		}

		// Token: 0x04020CFA RID: 134394
		protected RoverlikeBlessingCardItem CurBlessingItem;

		// Token: 0x04020CFB RID: 134395
		protected RoverlikeBlessingCardItem NewBlessingItem;

		// Token: 0x04020CFC RID: 134396
		private IRoverlikeBlessingReplaceParam Param;

		// Token: 0x0200C359 RID: 50009
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF54 RID: 241492
			public const int ItemCurBlessing = 0;

			// Token: 0x0403AF55 RID: 241493
			public const int ItemNewBlessing = 1;

			// Token: 0x0403AF56 RID: 241494
			public const int BtnKeep = 2;

			// Token: 0x0403AF57 RID: 241495
			public const int BtnReplace = 3;

			// Token: 0x0403AF58 RID: 241496
			public const int TxtTitle = 4;
		}
	}
}
