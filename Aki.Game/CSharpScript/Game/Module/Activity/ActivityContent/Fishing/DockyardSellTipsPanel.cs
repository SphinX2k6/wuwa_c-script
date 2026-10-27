using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C8 RID: 26056
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardSellTipsPanel : UiPanelBase
	{
		// Token: 0x060415AD RID: 267693 RVA: 0x00FD6610 File Offset: 0x00FD4810
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnSellClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060415AE RID: 267694 RVA: 0x00FD66B8 File Offset: 0x00FD48B8
		private UniTask InitTipsPanel()
		{
			DockyardSellTipsPanel.<InitTipsPanel>d__6 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardSellTipsPanel.<InitTipsPanel>d__6>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060415AF RID: 267695 RVA: 0x00FD66FC File Offset: 0x00FD48FC
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardSellTipsPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060415B0 RID: 267696 RVA: 0x00FD673F File Offset: 0x00FD493F
		private void OnSellClick()
		{
			Action<int, int> sellClick = this.SellClick;
			if (sellClick == null)
			{
				return;
			}
			sellClick(this.Data.IncId, this.Data.ItemId);
		}

		// Token: 0x060415B1 RID: 267697 RVA: 0x00FD6768 File Offset: 0x00FD4968
		private void RefreshSellBtnActive()
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(this.Data.Price > 0);
		}

		// Token: 0x060415B2 RID: 267698 RVA: 0x00FD679C File Offset: 0x00FD499C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			DockyardSellTipsPanel.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060415B3 RID: 267699 RVA: 0x00FD67E0 File Offset: 0x00FD49E0
		protected override UniTask OnHideAsyncImplementImplement()
		{
			DockyardSellTipsPanel.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060415B4 RID: 267700 RVA: 0x00FD6823 File Offset: 0x00FD4A23
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x060415B5 RID: 267701 RVA: 0x00FD6830 File Offset: 0x00FD4A30
		protected void Refresh()
		{
			this.TipsPanel.Refresh(this.Data);
			this.TipsPanel.SetPanelVisible(true, false);
			this.RefreshSellBtnActive();
		}

		// Token: 0x060415B6 RID: 267702 RVA: 0x00FD6856 File Offset: 0x00FD4A56
		public void ShowTipsPanel(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
			this.Refresh();
			this.SetActive(true);
		}

		// Token: 0x060415B7 RID: 267703 RVA: 0x00FD686C File Offset: 0x00FD4A6C
		public void HideTipsPanel()
		{
			if (base.IsShowOrShowing)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x060415B8 RID: 267704 RVA: 0x00FD687D File Offset: 0x00FD4A7D
		public void SetSellClick(Action<int, int> sellClick)
		{
			this.SellClick = sellClick;
		}

		// Token: 0x04022018 RID: 139288
		protected DockyardTipsPanel TipsPanel;

		// Token: 0x04022019 RID: 139289
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0402201A RID: 139290
		protected DockyardItemBlockOriginalData Data;

		// Token: 0x0402201B RID: 139291
		protected Action<int, int> SellClick;

		// Token: 0x0200C7E9 RID: 51177
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C60A RID: 247306
			public const int TipsItem = 0;

			// Token: 0x0403C60B RID: 247307
			public const int SellBtn = 1;
		}
	}
}
