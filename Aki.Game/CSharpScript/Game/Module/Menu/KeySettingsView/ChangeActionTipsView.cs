using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545A RID: 21594
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeActionTipsView : UiViewBase
	{
		// Token: 0x060371F9 RID: 225785 RVA: 0x00D10ED0 File Offset: 0x00D0F0D0
		[NullableContext(1)]
		public ChangeActionTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060371FA RID: 225786 RVA: 0x00D10EDC File Offset: 0x00D0F0DC
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

		// Token: 0x060371FB RID: 225787 RVA: 0x00D10F87 File Offset: 0x00D0F187
		private void OnConfirmButtonClicked()
		{
			if (this.OnConfirmCallback != null)
			{
				this.OnConfirmCallback(this.IsRevert);
			}
			base.CloseMe(null);
		}

		// Token: 0x060371FC RID: 225788 RVA: 0x00D10FA9 File Offset: 0x00D0F1A9
		private void OnCancelButtonClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x060371FD RID: 225789 RVA: 0x00D10FB4 File Offset: 0x00D0F1B4
		protected override UniTask OnBeforeStartAsync()
		{
			ChangeActionTipsView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ChangeActionTipsView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060371FE RID: 225790 RVA: 0x00D10FF8 File Offset: 0x00D0F1F8
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

		// Token: 0x060371FF RID: 225791 RVA: 0x00D11097 File Offset: 0x00D0F297
		protected override void OnBeforeDestroy()
		{
			this.OneRowItem = null;
			this.TwoRowItem = null;
			this.OnConfirmCallback = null;
		}

		// Token: 0x06037200 RID: 225792 RVA: 0x00D110AE File Offset: 0x00D0F2AE
		[NullableContext(1)]
		private void OnSelected(ChangeActionRowView changeActionRowView, bool bRevert)
		{
			this.OneRowItem.SetSelected(this.OneRowItem.IsRevert == bRevert);
			this.TwoRowItem.SetSelected(this.TwoRowItem.IsRevert == bRevert);
			this.IsRevert = bRevert;
		}

		// Token: 0x0401D150 RID: 119120
		private Action<bool> OnConfirmCallback;

		// Token: 0x0401D151 RID: 119121
		private KeySettingRowData KeySettingRowData;

		// Token: 0x0401D152 RID: 119122
		private ChangeActionRowView OneRowItem;

		// Token: 0x0401D153 RID: 119123
		private ChangeActionRowView TwoRowItem;

		// Token: 0x0401D154 RID: 119124
		private bool IsRevert;

		// Token: 0x0200B6D1 RID: 46801
		[NullableContext(0)]
		public class EChildType
		{
			// Token: 0x0403762A RID: 226858
			public const int ConfirmButton = 0;

			// Token: 0x0403762B RID: 226859
			public const int CancelButton = 1;

			// Token: 0x0403762C RID: 226860
			public const int OneRowItem = 2;

			// Token: 0x0403762D RID: 226861
			public const int TwoRowItem = 3;
		}
	}
}
