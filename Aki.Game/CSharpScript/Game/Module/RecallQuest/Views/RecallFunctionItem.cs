using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02004F1A RID: 20250
	public class RecallFunctionItem : GridProxyAbstract<int>
	{
		// Token: 0x06033EBE RID: 212670 RVA: 0x00C2B304 File Offset: 0x00C29504
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033EBF RID: 212671 RVA: 0x00C2B3EC File Offset: 0x00C295EC
		private void ButtonClick()
		{
			if (this.FunctionId != 0)
			{
				FunctionController.Instance.OpenFunctionRelateView((EFunctionType)this.FunctionId);
			}
		}

		// Token: 0x06033EC0 RID: 212672 RVA: 0x00C2B406 File Offset: 0x00C29606
		public override void Refresh(int recallFunctionId, bool isSelected, int gridIndex)
		{
			this.UpdateItem(recallFunctionId);
		}

		// Token: 0x06033EC1 RID: 212673 RVA: 0x00C2B410 File Offset: 0x00C29610
		public void UpdateItem(int recallFunctionId)
		{
			this.FunctionId = RecallQuestConfig.Instance.GetRecallFunctionConfig(recallFunctionId).Value.FunctionId;
			RecallFunction? recallFunctionConfig = RecallQuestConfig.Instance.GetRecallFunctionConfig(recallFunctionId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), recallFunctionConfig.Value.FunctionName, Array.Empty<object>());
			UUISpriteTransition uiSpriteTransition = base.GetUiSpriteTransition(2);
			if (this.FunctionId == 10001)
			{
				string roleFunctionIconPath = FunctionConfig.Instance.GetRoleFunctionIconPath();
				base.SetSpriteTransitionByPath(roleFunctionIconPath, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			}
			else
			{
				base.SetSpriteTransitionByPath(recallFunctionConfig.Value.FunctionIcon, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x06033EC2 RID: 212674 RVA: 0x00C2B4C2 File Offset: 0x00C296C2
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(1);
			button.OnPointEnterCallBack.Unbind();
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x0401B976 RID: 113014
		protected int FunctionId;

		// Token: 0x0200B061 RID: 45153
		private class EFunctionItemDefine
		{
			// Token: 0x0403586E RID: 219246
			public const int FunctionName = 0;

			// Token: 0x0403586F RID: 219247
			public const int Button = 1;

			// Token: 0x04035870 RID: 219248
			public const int IconSpriteTransition = 2;

			// Token: 0x04035871 RID: 219249
			public const int RedDotItem = 3;
		}
	}
}
