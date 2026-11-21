using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049F7 RID: 18935
	public class FunctionItem : UiPanelBase
	{
		// Token: 0x0602F763 RID: 194403 RVA: 0x00D3C88F File Offset: 0x00D3AA8F
		[NullableContext(1)]
		public FunctionItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602F764 RID: 194404 RVA: 0x00D3C8A4 File Offset: 0x00D3AAA4
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

		// Token: 0x0602F765 RID: 194405 RVA: 0x00D3C8EC File Offset: 0x00D3AAEC
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

		// Token: 0x0602F766 RID: 194406 RVA: 0x00D3C9F8 File Offset: 0x00D3ABF8
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

		// Token: 0x0602F767 RID: 194407 RVA: 0x00D3CA78 File Offset: 0x00D3AC78
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

		// Token: 0x0602F768 RID: 194408 RVA: 0x00D3CB30 File Offset: 0x00D3AD30
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

		// Token: 0x0602F769 RID: 194409 RVA: 0x00D3CB94 File Offset: 0x00D3AD94
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				UUIItem item = base.GetItem(4);
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
				this.RedDotName = null;
			}
		}

		// Token: 0x0602F76A RID: 194410 RVA: 0x00D3CBD9 File Offset: 0x00D3ADD9
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

		// Token: 0x04019244 RID: 102980
		protected int FunctionId;

		// Token: 0x04019245 RID: 102981
		private ERedDotName? RedDotName;

		// Token: 0x0200A699 RID: 42649
		private class EFunctionItemDefine
		{
			// Token: 0x040337FF RID: 210943
			public const int LockIcon = 0;

			// Token: 0x04033800 RID: 210944
			public const int FunctionName = 1;

			// Token: 0x04033801 RID: 210945
			public const int Button = 2;

			// Token: 0x04033802 RID: 210946
			public const int IconSpriteTransition = 3;

			// Token: 0x04033803 RID: 210947
			public const int RedDotItem = 4;
		}
	}
}
