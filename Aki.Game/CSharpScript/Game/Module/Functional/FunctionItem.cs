using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A1B RID: 23067
	public class FunctionItem : UiPanelBase
	{
		// Token: 0x0603A81A RID: 239642 RVA: 0x00DEC2FF File Offset: 0x00DEA4FF
		[NullableContext(1)]
		public FunctionItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603A81B RID: 239643 RVA: 0x00DEC314 File Offset: 0x00DEA514
		[NullableContext(2)]
		public UUIItem GetButtonItem()
		{
			UUIButtonComponent button = base.GetButton(2);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x0603A81C RID: 239644 RVA: 0x00DEC35C File Offset: 0x00DEA55C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A81D RID: 239645 RVA: 0x00DEC468 File Offset: 0x00DEA668
		private void ButtonClick()
		{
			if (this.FunctionId != 0)
			{
				FunctionController.Instance.OpenFunctionRelateView((EFunctionType)this.FunctionId);
				OnClickFunctionItemLogEvent onClickFunctionItemLogEvent = new OnClickFunctionItemLogEvent();
				onClickFunctionItemLogEvent.i_id = this.FunctionId;
				onClickFunctionItemLogEvent.i_type = 1;
				LogReportController.Instance.LogReport(onClickFunctionItemLogEvent);
				if (this.FunctionId == 10010 || this.FunctionId == 10040)
				{
					OnClickFunctionViewButtonLogEvent onClickFunctionViewButtonLogEvent = new OnClickFunctionViewButtonLogEvent();
					onClickFunctionViewButtonLogEvent.i_id = this.FunctionId;
					LogReportController.Instance.LogReport(onClickFunctionViewButtonLogEvent);
				}
			}
		}

		// Token: 0x0603A81E RID: 239646 RVA: 0x00DEC4E8 File Offset: 0x00DEA6E8
		public void UpdateItem(int functionId)
		{
			this.FunctionId = functionId;
			FunctionMenu? functionConfig = FunctionConfig.Instance.GetFunctionConfig(functionId);
			if (functionConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), functionConfig.Value.FunctionName, Array.Empty<object>());
			bool flag = FunctionModel.Instance.IsOpen(functionId);
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(3);
			if (functionId == 10001)
			{
				string roleFunctionIconPath = FunctionConfig.Instance.GetRoleFunctionIconPath();
				base.SetSpriteTransitionByPath(roleFunctionIconPath, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			}
			else
			{
				base.SetSpriteTransitionByPath(functionConfig.Value.FunctionIcon, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			}
			this.BindRedDot();
		}

		// Token: 0x0603A81F RID: 239647 RVA: 0x00DEC5A0 File Offset: 0x00DEA7A0
		private void BindRedDot()
		{
			if (this.FunctionId == 0)
			{
				return;
			}
			this.RedDotName = FunctionModel.Instance.GetFunctionItemRedDotName(this.FunctionId);
			UUIItem item = base.GetItem(4);
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, 0);
				return;
			}
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x0603A820 RID: 239648 RVA: 0x00DEC604 File Offset: 0x00DEA804
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				UUIItem item = base.GetItem(4);
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
				this.RedDotName = null;
			}
		}

		// Token: 0x0603A821 RID: 239649 RVA: 0x00DEC649 File Offset: 0x00DEA849
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			if (button == null)
			{
				return;
			}
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x0401E79D RID: 124829
		protected int FunctionId;

		// Token: 0x0401E79E RID: 124830
		private ERedDotName? RedDotName;

		// Token: 0x0200BC90 RID: 48272
		private class EFunctionItemDefine
		{
			// Token: 0x04038E34 RID: 233012
			public const int LockIcon = 0;

			// Token: 0x04038E35 RID: 233013
			public const int FunctionName = 1;

			// Token: 0x04038E36 RID: 233014
			public const int Button = 2;

			// Token: 0x04038E37 RID: 233015
			public const int IconSpriteTransition = 3;

			// Token: 0x04038E38 RID: 233016
			public const int RedDotItem = 4;
		}
	}
}
