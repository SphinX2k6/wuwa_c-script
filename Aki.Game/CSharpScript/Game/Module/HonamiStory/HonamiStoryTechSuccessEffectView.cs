using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004928 RID: 18728
	public class HonamiStoryTechSuccessEffectView : UiViewBase
	{
		// Token: 0x0602EF75 RID: 192373 RVA: 0x00D1997E File Offset: 0x00D17B7E
		[NullableContext(1)]
		public HonamiStoryTechSuccessEffectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602EF76 RID: 192374 RVA: 0x00D19988 File Offset: 0x00D17B88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickCloseBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EF77 RID: 192375 RVA: 0x00D19AD8 File Offset: 0x00D17CD8
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiStoryTechSuccessEffectView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechSuccessEffectView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EF78 RID: 192376 RVA: 0x00D19B1C File Offset: 0x00D17D1C
		protected override void OnBeforeShow()
		{
			this.Data = new HonamiStoryTalent?((HonamiStoryTalent)this.OpenParam);
			if (this.Data != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.Value.SuccessTitle, Array.Empty<object>());
				this.TextItem.SetDescriptionText(this.Data.Value.SuccessDesc, this.Data.Value.SuccessDescParams());
				base.GetText(3).ShowTextNew("Text_BackToView_Text");
			}
		}

		// Token: 0x0602EF79 RID: 192377 RVA: 0x00D19BB7 File Offset: 0x00D17DB7
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602EF7A RID: 192378 RVA: 0x00D19BC0 File Offset: 0x00D17DC0
		protected override void OnAfterDestroy()
		{
			HonamiStoryModel instance = HonamiStoryModel.Instance;
			bool flag;
			if (this.Data == null)
			{
				flag = false;
			}
			else
			{
				int type = this.Data.GetValueOrDefault().Type;
				flag = true;
			}
			if (flag && (this.Data.Value.Type == 1 || this.Data.Value.Type == 2))
			{
				string flowListName = instance.CurrentSelectNode.GetConfig.FlowListName;
				int flowId = instance.CurrentSelectNode.GetConfig.FlowId;
				int stateId = instance.CurrentSelectNode.GetConfig.StateId;
				if (!string.IsNullOrEmpty(flowListName) && flowId != 0 && stateId != 0)
				{
					FlowController.Instance.StartFlow(flowListName, flowId, stateId, null, 0L, false, false, false, null);
				}
			}
		}

		// Token: 0x04018EDF RID: 102111
		[Nullable(2)]
		private SuccessDescriptionItem TextItem;

		// Token: 0x04018EE0 RID: 102112
		private HonamiStoryTalent? Data;

		// Token: 0x0200A5F1 RID: 42481
		private enum EComponent
		{
			// Token: 0x04033586 RID: 210310
			TextScrollLayout,
			// Token: 0x04033587 RID: 210311
			TextItem,
			// Token: 0x04033588 RID: 210312
			Title,
			// Token: 0x04033589 RID: 210313
			TipsText,
			// Token: 0x0403358A RID: 210314
			TipsButton,
			// Token: 0x0403358B RID: 210315
			TipsButton2
		}
	}
}
