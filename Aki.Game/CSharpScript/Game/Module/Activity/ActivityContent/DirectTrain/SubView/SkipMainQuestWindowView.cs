using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.SubView
{
	// Token: 0x02005697 RID: 22167
	[NullableContext(1)]
	[Nullable(0)]
	public class SkipMainQuestWindowView : UiViewBase
	{
		// Token: 0x06036B25 RID: 224037 RVA: 0x00F4313F File Offset: 0x00F4133F
		public SkipMainQuestWindowView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036B26 RID: 224038 RVA: 0x00F43148 File Offset: 0x00F41348
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

		// Token: 0x06036B27 RID: 224039 RVA: 0x00F43214 File Offset: 0x00F41414
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

		// Token: 0x06036B28 RID: 224040 RVA: 0x00F43306 File Offset: 0x00F41506
		private void OnCancelBtnClick(int _)
		{
			base.CloseMe(null);
		}

		// Token: 0x06036B29 RID: 224041 RVA: 0x00F4330F File Offset: 0x00F4150F
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

		// Token: 0x06036B2A RID: 224042 RVA: 0x00F43328 File Offset: 0x00F41528
		private void SetPlotTxtByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x06036B2B RID: 224043 RVA: 0x00F4333D File Offset: 0x00F4153D
		private void SetDescriptionTxtByTextId(string textId, params string[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, args);
		}

		// Token: 0x0401CE57 RID: 118359
		[Nullable(2)]
		private ButtonItem CancelBtn;

		// Token: 0x0401CE58 RID: 118360
		[Nullable(2)]
		private ButtonItem SkipBtn;

		// Token: 0x0401CE59 RID: 118361
		[Nullable(2)]
		private TSkipMainQuestWindowSkipCallBack SkipCallBack;

		// Token: 0x0401CE5A RID: 118362
		private int ActivityId;

		// Token: 0x0200B28E RID: 45710
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040372B5 RID: 225973
			TxtPlot,
			// Token: 0x040372B6 RID: 225974
			TxtContent,
			// Token: 0x040372B7 RID: 225975
			BtnConfirmA,
			// Token: 0x040372B8 RID: 225976
			BtnConfirmA2,
			// Token: 0x040372B9 RID: 225977
			TxtDescription
		}
	}
}
