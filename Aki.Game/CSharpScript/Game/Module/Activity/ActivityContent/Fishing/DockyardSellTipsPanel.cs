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
	// Token: 0x02005546 RID: 21830
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardSellTipsPanel : UiPanelBase
	{
		// Token: 0x06036272 RID: 221810 RVA: 0x00F1D650 File Offset: 0x00F1B850
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

		// Token: 0x06036273 RID: 221811 RVA: 0x00F1D6F8 File Offset: 0x00F1B8F8
		private UniTask InitTipsPanel()
		{
			DockyardSellTipsPanel.<InitTipsPanel>d__6 <InitTipsPanel>d__;
			<InitTipsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsPanel>d__.<>4__this = this;
			<InitTipsPanel>d__.<>1__state = -1;
			<InitTipsPanel>d__.<>t__builder.Start<DockyardSellTipsPanel.<InitTipsPanel>d__6>(ref <InitTipsPanel>d__);
			return <InitTipsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06036274 RID: 221812 RVA: 0x00F1D73C File Offset: 0x00F1B93C
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardSellTipsPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036275 RID: 221813 RVA: 0x00F1D77F File Offset: 0x00F1B97F
		private void OnSellClick()
		{
			Action<int, int> sellClick = this.SellClick;
			if (sellClick == null)
			{
				return;
			}
			sellClick(this.Data.IncId, this.Data.ItemId);
		}

		// Token: 0x06036276 RID: 221814 RVA: 0x00F1D7A8 File Offset: 0x00F1B9A8
		private void RefreshSellBtnActive()
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(this.Data.Price > 0);
		}

		// Token: 0x06036277 RID: 221815 RVA: 0x00F1D7DC File Offset: 0x00F1B9DC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			DockyardSellTipsPanel.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06036278 RID: 221816 RVA: 0x00F1D820 File Offset: 0x00F1BA20
		protected override UniTask OnHideAsyncImplementImplement()
		{
			DockyardSellTipsPanel.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<DockyardSellTipsPanel.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06036279 RID: 221817 RVA: 0x00F1D863 File Offset: 0x00F1BA63
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0603627A RID: 221818 RVA: 0x00F1D870 File Offset: 0x00F1BA70
		protected void Refresh()
		{
			this.TipsPanel.Refresh(this.Data);
			this.TipsPanel.SetPanelVisible(true, false);
			this.RefreshSellBtnActive();
		}

		// Token: 0x0603627B RID: 221819 RVA: 0x00F1D896 File Offset: 0x00F1BA96
		public void ShowTipsPanel(DockyardItemBlockOriginalData data)
		{
			this.Data = data;
			this.Refresh();
			this.SetActive(true);
		}

		// Token: 0x0603627C RID: 221820 RVA: 0x00F1D8AC File Offset: 0x00F1BAAC
		public void HideTipsPanel()
		{
			if (base.IsShowOrShowing)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603627D RID: 221821 RVA: 0x00F1D8BD File Offset: 0x00F1BABD
		public void SetSellClick(Action<int, int> sellClick)
		{
			this.SellClick = sellClick;
		}

		// Token: 0x0401C949 RID: 117065
		protected DockyardTipsPanel TipsPanel;

		// Token: 0x0401C94A RID: 117066
		protected UiSequencePlayer SequencePlayer;

		// Token: 0x0401C94B RID: 117067
		protected DockyardItemBlockOriginalData Data;

		// Token: 0x0401C94C RID: 117068
		protected Action<int, int> SellClick;

		// Token: 0x0200B1CC RID: 45516
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F58 RID: 225112
			public const int TipsItem = 0;

			// Token: 0x04036F59 RID: 225113
			public const int SellBtn = 1;
		}
	}
}
