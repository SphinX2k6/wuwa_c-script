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
	// Token: 0x0200594F RID: 22863
	public class HonamiStoryTechSuccessEffectView : UiViewBase
	{
		// Token: 0x0603A052 RID: 237650 RVA: 0x00DCA6CA File Offset: 0x00DC88CA
		[NullableContext(1)]
		public HonamiStoryTechSuccessEffectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A053 RID: 237651 RVA: 0x00DCA6D4 File Offset: 0x00DC88D4
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

		// Token: 0x0603A054 RID: 237652 RVA: 0x00DCA824 File Offset: 0x00DC8A24
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiStoryTechSuccessEffectView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTechSuccessEffectView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A055 RID: 237653 RVA: 0x00DCA868 File Offset: 0x00DC8A68
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

		// Token: 0x0603A056 RID: 237654 RVA: 0x00DCA903 File Offset: 0x00DC8B03
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603A057 RID: 237655 RVA: 0x00DCA90C File Offset: 0x00DC8B0C
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

		// Token: 0x0401E442 RID: 123970
		[Nullable(2)]
		private SuccessDescriptionItem TextItem;

		// Token: 0x0401E443 RID: 123971
		private HonamiStoryTalent? Data;

		// Token: 0x0200BBE2 RID: 48098
		private enum EComponent
		{
			// Token: 0x04038BA7 RID: 232359
			TextScrollLayout,
			// Token: 0x04038BA8 RID: 232360
			TextItem,
			// Token: 0x04038BA9 RID: 232361
			Title,
			// Token: 0x04038BAA RID: 232362
			TipsText,
			// Token: 0x04038BAB RID: 232363
			TipsButton,
			// Token: 0x04038BAC RID: 232364
			TipsButton2
		}
	}
}
