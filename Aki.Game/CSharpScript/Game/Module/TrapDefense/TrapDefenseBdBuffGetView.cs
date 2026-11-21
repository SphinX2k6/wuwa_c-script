using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A82 RID: 14978
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffGetView : UiViewBase
	{
		// Token: 0x060267A2 RID: 157602 RVA: 0x00AC7A76 File Offset: 0x00AC5C76
		public TrapDefenseBdBuffGetView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060267A3 RID: 157603 RVA: 0x00AC7A80 File Offset: 0x00AC5C80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060267A4 RID: 157604 RVA: 0x00AC7B48 File Offset: 0x00AC5D48
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdBuffGetView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffGetView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060267A5 RID: 157605 RVA: 0x00AC7B8B File Offset: 0x00AC5D8B
		protected override void OnStart()
		{
		}

		// Token: 0x060267A6 RID: 157606 RVA: 0x00AC7B8D File Offset: 0x00AC5D8D
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x060267A7 RID: 157607 RVA: 0x00AC7B8F File Offset: 0x00AC5D8F
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x060267A8 RID: 157608 RVA: 0x00AC7B91 File Offset: 0x00AC5D91
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x060267A9 RID: 157609 RVA: 0x00AC7B99 File Offset: 0x00AC5D99
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060267AA RID: 157610 RVA: 0x00AC7B9B File Offset: 0x00AC5D9B
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060267AB RID: 157611 RVA: 0x00AC7BA4 File Offset: 0x00AC5DA4
		public void UpdateData()
		{
			if (this.BdBuffData == null)
			{
				return;
			}
			this.PanelBdBuffDesc.SetActive(true);
			this.PanelBdBuffDesc.UpdateDataGetMode(this.BdBuffData);
			this.UpdateBdProgressItem();
		}

		// Token: 0x060267AC RID: 157612 RVA: 0x00AC7BD4 File Offset: 0x00AC5DD4
		private void UpdateBdProgressItem()
		{
			TrapDefenseBdData belongBdData = this.BdBuffData.GetBelongBdData();
			bool flag = !belongBdData.IsZeroBdType();
			this.BdProgressItem.SetActive(flag);
			if (flag)
			{
				if (TrapDefenseModel.Instance.RougeModeData.IsCheckBdProgress)
				{
					this.BdProgressItem.RefreshCheckProgress(belongBdData);
					return;
				}
				this.BdProgressItem.RefreshItem(belongBdData);
			}
		}

		// Token: 0x060267AD RID: 157613 RVA: 0x00AC7C30 File Offset: 0x00AC5E30
		protected override void OnAfterPlayStartSequence()
		{
			this.CheckBdUpStageEffect().Forget();
		}

		// Token: 0x060267AE RID: 157614 RVA: 0x00AC7C40 File Offset: 0x00AC5E40
		public UniTask CheckBdUpStageEffect()
		{
			TrapDefenseBdBuffGetView.<CheckBdUpStageEffect>d__16 <CheckBdUpStageEffect>d__;
			<CheckBdUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckBdUpStageEffect>d__.<>4__this = this;
			<CheckBdUpStageEffect>d__.<>1__state = -1;
			<CheckBdUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffGetView.<CheckBdUpStageEffect>d__16>(ref <CheckBdUpStageEffect>d__);
			return <CheckBdUpStageEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060267AF RID: 157615 RVA: 0x00AC7C83 File Offset: 0x00AC5E83
		protected override void OnAfterDestroy()
		{
		}

		// Token: 0x04015175 RID: 86389
		public TrapDefenseBdSumBuffDescPanel PanelBdBuffDesc;

		// Token: 0x04015176 RID: 86390
		public TrapDefenseBdBuffSelectBdItem BdProgressItem;

		// Token: 0x04015177 RID: 86391
		public TrapDefenseBdBuffData BdBuffData;

		// Token: 0x0200967A RID: 38522
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EFBE RID: 192446
			public const int BtnClose = 0;

			// Token: 0x0402EFBF RID: 192447
			public const int ItemBuffDesc = 1;

			// Token: 0x0402EFC0 RID: 192448
			public const int ItemBdProgress = 2;
		}
	}
}
