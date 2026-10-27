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
	// Token: 0x02004ADA RID: 19162
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffGetView : UiViewBase
	{
		// Token: 0x06031A12 RID: 203282 RVA: 0x00B83AC2 File Offset: 0x00B81CC2
		public TrapDefenseBdBuffGetView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031A13 RID: 203283 RVA: 0x00B83ACC File Offset: 0x00B81CCC
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

		// Token: 0x06031A14 RID: 203284 RVA: 0x00B83B94 File Offset: 0x00B81D94
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdBuffGetView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffGetView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A15 RID: 203285 RVA: 0x00B83BD7 File Offset: 0x00B81DD7
		protected override void OnStart()
		{
		}

		// Token: 0x06031A16 RID: 203286 RVA: 0x00B83BD9 File Offset: 0x00B81DD9
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06031A17 RID: 203287 RVA: 0x00B83BDB File Offset: 0x00B81DDB
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06031A18 RID: 203288 RVA: 0x00B83BDD File Offset: 0x00B81DDD
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06031A19 RID: 203289 RVA: 0x00B83BE5 File Offset: 0x00B81DE5
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06031A1A RID: 203290 RVA: 0x00B83BE7 File Offset: 0x00B81DE7
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031A1B RID: 203291 RVA: 0x00B83BF0 File Offset: 0x00B81DF0
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

		// Token: 0x06031A1C RID: 203292 RVA: 0x00B83C20 File Offset: 0x00B81E20
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

		// Token: 0x06031A1D RID: 203293 RVA: 0x00B83C7C File Offset: 0x00B81E7C
		protected override void OnAfterPlayStartSequence()
		{
			this.CheckBdUpStageEffect().Forget();
		}

		// Token: 0x06031A1E RID: 203294 RVA: 0x00B83C8C File Offset: 0x00B81E8C
		public UniTask CheckBdUpStageEffect()
		{
			TrapDefenseBdBuffGetView.<CheckBdUpStageEffect>d__16 <CheckBdUpStageEffect>d__;
			<CheckBdUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckBdUpStageEffect>d__.<>4__this = this;
			<CheckBdUpStageEffect>d__.<>1__state = -1;
			<CheckBdUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffGetView.<CheckBdUpStageEffect>d__16>(ref <CheckBdUpStageEffect>d__);
			return <CheckBdUpStageEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06031A1F RID: 203295 RVA: 0x00B83CCF File Offset: 0x00B81ECF
		protected override void OnAfterDestroy()
		{
		}

		// Token: 0x0401A823 RID: 108579
		public TrapDefenseBdSumBuffDescPanel PanelBdBuffDesc;

		// Token: 0x0401A824 RID: 108580
		public TrapDefenseBdBuffSelectBdItem BdProgressItem;

		// Token: 0x0401A825 RID: 108581
		public TrapDefenseBdBuffData BdBuffData;

		// Token: 0x0200AC5A RID: 44122
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403460D RID: 214541
			public const int BtnClose = 0;

			// Token: 0x0403460E RID: 214542
			public const int ItemBuffDesc = 1;

			// Token: 0x0403460F RID: 214543
			public const int ItemBdProgress = 2;
		}
	}
}
