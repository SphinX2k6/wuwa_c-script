using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.SubView
{
	// Token: 0x02006747 RID: 26439
	[NullableContext(1)]
	[Nullable(0)]
	public class SkipMainQuestWindowView : UiViewBase
	{
		// Token: 0x06041FD6 RID: 270294 RVA: 0x01001D4B File Offset: 0x00FFFF4B
		public SkipMainQuestWindowView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041FD7 RID: 270295 RVA: 0x01001D54 File Offset: 0x00FFFF54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041FD8 RID: 270296 RVA: 0x01001E20 File Offset: 0x01000020
		protected override void OnStart()
		{
			ISkipMainQuestWindowParam skipMainQuestWindowParam = this.OpenParam as ISkipMainQuestWindowParam;
			ActivityDirectTrainModel instance = ActivityDirectTrainModel.Instance;
			this.SkipCallBack = ((skipMainQuestWindowParam != null) ? skipMainQuestWindowParam.SkipCallBack : null);
			this.ActivityId = ((skipMainQuestWindowParam != null) ? skipMainQuestWindowParam.ActivityId : 0);
			this.CancelBtn = new ButtonItem(base.GetButton(2).RootUIComp.Get());
			this.CancelBtn.SetFunction(new Action<int>(this.OnCancelBtnClick));
			this.CancelBtn.SetLocalTextNew("ConfirmBox_1_ButtonText_0", Array.Empty<object>());
			this.SkipBtn = new ButtonItem(base.GetButton(3).RootUIComp.Get());
			this.SkipBtn.SetFunction(new Action<int>(this.OnSkipBtnClick));
			this.SetDescriptionTxtByTextId(instance.GetSkipTipTitleTextId(this.ActivityId), Array.Empty<string>());
			this.SetPlotTxtByTextId(instance.GetSkipTipContentTextId(this.ActivityId), Array.Empty<string>());
		}

		// Token: 0x06041FD9 RID: 270297 RVA: 0x01001F12 File Offset: 0x01000112
		private void OnCancelBtnClick(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x06041FDA RID: 270298 RVA: 0x01001F1B File Offset: 0x0100011B
		private void OnSkipBtnClick(int _)
		{
			base.CloseMe(null);
			TSkipMainQuestWindowSkipCallBack skipCallBack = this.SkipCallBack;
			if (skipCallBack == null)
			{
				return;
			}
			skipCallBack();
		}

		// Token: 0x06041FDB RID: 270299 RVA: 0x01001F34 File Offset: 0x01000134
		private void SetPlotTxtByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06041FDC RID: 270300 RVA: 0x01001F49 File Offset: 0x01000149
		private void SetDescriptionTxtByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
		}

		// Token: 0x040225FE RID: 140798
		[Nullable(2)]
		private ButtonItem CancelBtn;

		// Token: 0x040225FF RID: 140799
		[Nullable(2)]
		private ButtonItem SkipBtn;

		// Token: 0x04022600 RID: 140800
		[Nullable(2)]
		private TSkipMainQuestWindowSkipCallBack SkipCallBack;

		// Token: 0x04022601 RID: 140801
		private int ActivityId;

		// Token: 0x0200C8BF RID: 51391
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403C9BB RID: 248251
			TxtPlot,
			// Token: 0x0403C9BC RID: 248252
			TxtContent,
			// Token: 0x0403C9BD RID: 248253
			BtnConfirmA,
			// Token: 0x0403C9BE RID: 248254
			BtnConfirmA2,
			// Token: 0x0403C9BF RID: 248255
			TxtDescription
		}
	}
}
