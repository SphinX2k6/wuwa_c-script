using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005074 RID: 20596
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeEventChoiceItem : GridProxyAbstract<IRoverlikeEventChoiceData>
	{
		// Token: 0x0603391C RID: 211228 RVA: 0x00E70738 File Offset: 0x00E6E938
		public void BindOnItemSelect(Action<IRoverlikeEventChoiceData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603391D RID: 211229 RVA: 0x00E70741 File Offset: 0x00E6E941
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603391E RID: 211230 RVA: 0x00E70754 File Offset: 0x00E6E954
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603391F RID: 211231 RVA: 0x00E70768 File Offset: 0x00E6E968
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogCommonStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033920 RID: 211232 RVA: 0x00E70810 File Offset: 0x00E6EA10
		public override void Refresh(IRoverlikeEventChoiceData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			if (RoverlikeConfig.Instance.GetEventChoiceConfig(data.ConfigId) == null)
			{
				return;
			}
			this.RefreshDescMode();
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033921 RID: 211233 RVA: 0x00E7085C File Offset: 0x00E6EA5C
		public void RefreshDescMode()
		{
			if (this.CurrentData == null)
			{
				return;
			}
			RoverRogueEventChoice? eventChoiceConfig = RoverlikeConfig.Instance.GetEventChoiceConfig(this.CurrentData.ConfigId);
			if (eventChoiceConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), eventChoiceConfig.Value.Desc, eventChoiceConfig.Value.Params());
		}

		// Token: 0x06033922 RID: 211234 RVA: 0x00E708C1 File Offset: 0x00E6EAC1
		private void OnTogCommonStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<IRoverlikeEventChoiceData> onItemSelect = this.OnItemSelect;
				if (onItemSelect == null)
				{
					return;
				}
				onItemSelect(this.CurrentData);
			}
		}

		// Token: 0x06033923 RID: 211235 RVA: 0x00E708E8 File Offset: 0x00E6EAE8
		protected override void OnStart()
		{
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(1),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Roverlike
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x06033924 RID: 211236 RVA: 0x00E70923 File Offset: 0x00E6EB23
		protected override void OnBeforeDestroy()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
			this.OnItemSelect = null;
		}

		// Token: 0x0401B5FC RID: 112124
		[Nullable(2)]
		private IRoverlikeEventChoiceData CurrentData;

		// Token: 0x0401B5FD RID: 112125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeEventChoiceData> OnItemSelect;

		// Token: 0x0200AD3B RID: 44347
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358A1 RID: 219297
			public const int TogCommon = 0;

			// Token: 0x040358A2 RID: 219298
			public const int TxtName = 1;
		}
	}
}
