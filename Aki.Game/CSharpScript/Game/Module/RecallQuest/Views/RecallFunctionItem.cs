using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02003EE3 RID: 16099
	public class RecallFunctionItem : GridProxyAbstract<int>
	{
		// Token: 0x06028D29 RID: 167209 RVA: 0x00B74978 File Offset: 0x00B72B78
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

		// Token: 0x06028D2A RID: 167210 RVA: 0x00B74A60 File Offset: 0x00B72C60
		private void ButtonClick()
		{
			if (this.FunctionId != 0)
			{
				FunctionController.Instance.OpenFunctionRelateView((EFunctionType)this.FunctionId);
			}
		}

		// Token: 0x06028D2B RID: 167211 RVA: 0x00B74A7A File Offset: 0x00B72C7A
		public override void Refresh(int recallFunctionId, bool isSelected, int gridIndex)
		{
			this.UpdateItem(recallFunctionId);
		}

		// Token: 0x06028D2C RID: 167212 RVA: 0x00B74A84 File Offset: 0x00B72C84
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

		// Token: 0x06028D2D RID: 167213 RVA: 0x00B74B36 File Offset: 0x00B72D36
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(1);
			button.OnPointEnterCallBack.Unbind();
			button.OnPointExitCallBack.Unbind();
		}

		// Token: 0x04016349 RID: 90953
		protected int FunctionId;

		// Token: 0x02009A91 RID: 39569
		private class EFunctionItemDefine
		{
			// Token: 0x04030299 RID: 197273
			public const int FunctionName = 0;

			// Token: 0x0403029A RID: 197274
			public const int Button = 1;

			// Token: 0x0403029B RID: 197275
			public const int IconSpriteTransition = 2;

			// Token: 0x0403029C RID: 197276
			public const int RedDotItem = 3;
		}
	}
}
