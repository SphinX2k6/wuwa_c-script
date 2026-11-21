using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x02004684 RID: 18052
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginDebugPlayerNameView : UiViewBase
	{
		// Token: 0x0602D645 RID: 185925 RVA: 0x00CB565E File Offset: 0x00CB385E
		public LoginDebugPlayerNameView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D646 RID: 185926 RVA: 0x00CB5668 File Offset: 0x00CB3868
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

		// Token: 0x0602D647 RID: 185927 RVA: 0x00CB5794 File Offset: 0x00CB3994
		protected override void OnBeforeCreate()
		{
			this.OnSuccessCallBack = (Action)this.OpenParam;
		}

		// Token: 0x0602D648 RID: 185928 RVA: 0x00CB57A7 File Offset: 0x00CB39A7
		private void OnTextChangeCallBack(string inString)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(inString.Length > 0);
		}

		// Token: 0x0602D649 RID: 185929 RVA: 0x00CB57C4 File Offset: 0x00CB39C4
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

		// Token: 0x0602D64A RID: 185930 RVA: 0x00CB5813 File Offset: 0x00CB3A13
		private void OnClickCancelBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D64B RID: 185931 RVA: 0x00CB581C File Offset: 0x00CB3A1C
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

		// Token: 0x0602D64C RID: 185932 RVA: 0x00CB586C File Offset: 0x00CB3A6C
		private void ShowNameTooLongView()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ChangeName);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602D64D RID: 185933 RVA: 0x00CB588D File Offset: 0x00CB3A8D
		protected override void OnBeforeDestroy()
		{
			this.OnSuccessCallBack = null;
		}

		// Token: 0x040184EC RID: 99564
		private Action OnSuccessCallBack;
	}
}
