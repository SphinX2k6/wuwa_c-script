using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200443D RID: 17469
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeActionTipsView : UiViewBase
	{
		// Token: 0x0602C142 RID: 180546 RVA: 0x00C602E8 File Offset: 0x00C5E4E8
		[NullableContext(1)]
		public ChangeActionTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C143 RID: 180547 RVA: 0x00C602F4 File Offset: 0x00C5E4F4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnConfirmButtonClicked)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnCancelButtonClicked))
			};
		}

		// Token: 0x0602C144 RID: 180548 RVA: 0x00C6039F File Offset: 0x00C5E59F
		private void OnConfirmButtonClicked()
		{
			if (this.OnConfirmCallback != null)
			{
				this.OnConfirmCallback(this.IsRevert);
			}
			base.CloseMe(null);
		}

		// Token: 0x0602C145 RID: 180549 RVA: 0x00C603C1 File Offset: 0x00C5E5C1
		private void OnCancelButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602C146 RID: 180550 RVA: 0x00C603CC File Offset: 0x00C5E5CC
		protected override UniTask OnBeforeStartAsync()
		{
			ChangeActionTipsView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChangeActionTipsView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C147 RID: 180551 RVA: 0x00C60410 File Offset: 0x00C5E610
		protected override void OnStart()
		{
			IChangeActionInfo changeActionInfo = this.OpenParam as IChangeActionInfo;
			EInputControllerType inputControllerType = changeActionInfo.InputControllerType;
			this.OnConfirmCallback = changeActionInfo.OnConfirmCallback;
			this.KeySettingRowData = changeActionInfo.KeySettingRowData;
			ChangeActionRowView oneRowItem = this.OneRowItem;
			if (oneRowItem != null)
			{
				oneRowItem.Refresh(this.KeySettingRowData, inputControllerType, false);
			}
			ChangeActionRowView twoRowItem = this.TwoRowItem;
			if (twoRowItem != null)
			{
				twoRowItem.Refresh(this.KeySettingRowData, inputControllerType, true);
			}
			ChangeActionRowView oneRowItem2 = this.OneRowItem;
			if (oneRowItem2 != null)
			{
				oneRowItem2.SetSelected(true);
			}
			ChangeActionRowView oneRowItem3 = this.OneRowItem;
			if (oneRowItem3 != null)
			{
				oneRowItem3.SetActive(true);
			}
			ChangeActionRowView twoRowItem2 = this.TwoRowItem;
			if (twoRowItem2 == null)
			{
				return;
			}
			twoRowItem2.SetActive(true);
		}

		// Token: 0x0602C148 RID: 180552 RVA: 0x00C604AF File Offset: 0x00C5E6AF
		protected override void OnBeforeDestroy()
		{
			this.OneRowItem = null;
			this.TwoRowItem = null;
			this.OnConfirmCallback = null;
		}

		// Token: 0x0602C149 RID: 180553 RVA: 0x00C604C6 File Offset: 0x00C5E6C6
		[NullableContext(1)]
		private void OnSelected(ChangeActionRowView changeActionRowView, bool bRevert)
		{
			this.OneRowItem.SetSelected(this.OneRowItem.IsRevert == bRevert);
			this.TwoRowItem.SetSelected(this.TwoRowItem.IsRevert == bRevert);
			this.IsRevert = bRevert;
		}

		// Token: 0x04017BE9 RID: 97257
		private Action<bool> OnConfirmCallback;

		// Token: 0x04017BEA RID: 97258
		private KeySettingRowData KeySettingRowData;

		// Token: 0x04017BEB RID: 97259
		private ChangeActionRowView OneRowItem;

		// Token: 0x04017BEC RID: 97260
		private ChangeActionRowView TwoRowItem;

		// Token: 0x04017BED RID: 97261
		private bool IsRevert;

		// Token: 0x0200A109 RID: 41225
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x0403207F RID: 204927
			public const int ConfirmButton = 0;

			// Token: 0x04032080 RID: 204928
			public const int CancelButton = 1;

			// Token: 0x04032081 RID: 204929
			public const int OneRowItem = 2;

			// Token: 0x04032082 RID: 204930
			public const int TwoRowItem = 3;
		}
	}
}
