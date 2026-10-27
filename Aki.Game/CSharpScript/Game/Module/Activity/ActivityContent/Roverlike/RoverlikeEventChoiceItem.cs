using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F6 RID: 24822
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeEventChoiceItem : GridProxyAbstract<IRoverlikeEventChoiceData>
	{
		// Token: 0x0603EC5A RID: 257114 RVA: 0x00F29924 File Offset: 0x00F27B24
		public void BindOnItemSelect(Action<IRoverlikeEventChoiceData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603EC5B RID: 257115 RVA: 0x00F2992D File Offset: 0x00F27B2D
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603EC5C RID: 257116 RVA: 0x00F29940 File Offset: 0x00F27B40
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EC5D RID: 257117 RVA: 0x00F29954 File Offset: 0x00F27B54
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

		// Token: 0x0603EC5E RID: 257118 RVA: 0x00F299FC File Offset: 0x00F27BFC
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

		// Token: 0x0603EC5F RID: 257119 RVA: 0x00F29A48 File Offset: 0x00F27C48
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

		// Token: 0x0603EC60 RID: 257120 RVA: 0x00F29AAD File Offset: 0x00F27CAD
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

		// Token: 0x0603EC61 RID: 257121 RVA: 0x00F29AD4 File Offset: 0x00F27CD4
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

		// Token: 0x0603EC62 RID: 257122 RVA: 0x00F29B0F File Offset: 0x00F27D0F
		protected override void OnBeforeDestroy()
		{
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(1));
			this.OnItemSelect = null;
		}

		// Token: 0x04020CCF RID: 134351
		[Nullable(2)]
		private IRoverlikeEventChoiceData CurrentData;

		// Token: 0x04020CD0 RID: 134352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeEventChoiceData> OnItemSelect;

		// Token: 0x0200C353 RID: 50003
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF3C RID: 241468
			public const int TogCommon = 0;

			// Token: 0x0403AF3D RID: 241469
			public const int TxtName = 1;
		}
	}
}
