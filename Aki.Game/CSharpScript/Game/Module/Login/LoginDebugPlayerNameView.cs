using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056AE RID: 22190
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginDebugPlayerNameView : UiViewBase
	{
		// Token: 0x06038748 RID: 231240 RVA: 0x00D6749A File Offset: 0x00D6569A
		public LoginDebugPlayerNameView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038749 RID: 231241 RVA: 0x00D674A4 File Offset: 0x00D656A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITextInputComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancelBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603874A RID: 231242 RVA: 0x00D675D0 File Offset: 0x00D657D0
		protected override void OnBeforeCreate()
		{
			this.OnSuccessCallBack = (Action)this.OpenParam;
		}

		// Token: 0x0603874B RID: 231243 RVA: 0x00D675E3 File Offset: 0x00D657E3
		private void OnTextChangeCallBack(string inString)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(inString.Length > 0);
		}

		// Token: 0x0603874C RID: 231244 RVA: 0x00D67600 File Offset: 0x00D65800
		protected override void OnStart()
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.OnTextChangeCallBack));
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(false);
		}

		// Token: 0x0603874D RID: 231245 RVA: 0x00D6764F File Offset: 0x00D6584F
		private void OnClickCancelBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603874E RID: 231246 RVA: 0x00D67658 File Offset: 0x00D65858
		private void OnClickConfirmBtn()
		{
			string text = base.GetInputText(0).GetText();
			if (StringUtils.GetStringRealCount(text) > 12)
			{
				this.ShowNameTooLongView();
				return;
			}
			LoginModel.Instance.SetPlayerName(text);
			base.CloseMe(null);
			Action onSuccessCallBack = this.OnSuccessCallBack;
			if (onSuccessCallBack == null)
			{
				return;
			}
			onSuccessCallBack();
		}

		// Token: 0x0603874F RID: 231247 RVA: 0x00D676A8 File Offset: 0x00D658A8
		private void ShowNameTooLongView()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ChangeName);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038750 RID: 231248 RVA: 0x00D676C9 File Offset: 0x00D658C9
		protected override void OnBeforeDestroy()
		{
			this.OnSuccessCallBack = null;
		}

		// Token: 0x0401DA61 RID: 121441
		private Action OnSuccessCallBack;
	}
}
