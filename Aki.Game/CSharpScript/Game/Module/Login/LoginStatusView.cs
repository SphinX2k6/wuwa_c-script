using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x0200468F RID: 18063
	public class LoginStatusView : UiViewBase
	{
		// Token: 0x0602D67F RID: 185983 RVA: 0x00CB6473 File Offset: 0x00CB4673
		[NullableContext(1)]
		public LoginStatusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D680 RID: 185984 RVA: 0x00CB647C File Offset: 0x00CB467C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0602D681 RID: 185985 RVA: 0x00CB6497 File Offset: 0x00CB4697
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0602D682 RID: 185986 RVA: 0x00CB64B4 File Offset: 0x00CB46B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D683 RID: 185987 RVA: 0x00CB64FC File Offset: 0x00CB46FC
		protected override void OnStart()
		{
			this.RefreshStatus();
		}

		// Token: 0x0602D684 RID: 185988 RVA: 0x00CB6504 File Offset: 0x00CB4704
		private void RefreshStatus()
		{
			LoginDefine.ELoginStatus loginStatus = LoginModel.Instance.GetLoginStatus();
			LoginDefine.ELoginStatus? lastFailStatus = LoginModel.Instance.GetLastFailStatus();
			string newText;
			if (lastFailStatus != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral("登录状态:");
				defaultInterpolatedStringHandler.AppendFormatted<LoginDefine.ELoginStatus>(loginStatus);
				defaultInterpolatedStringHandler.AppendLiteral(", 上一次失败:");
				defaultInterpolatedStringHandler.AppendFormatted<LoginDefine.ELoginStatus?>(lastFailStatus);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("登录状态:");
				defaultInterpolatedStringHandler.AppendFormatted<LoginDefine.ELoginStatus>(loginStatus);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0200A2A1 RID: 41633
		public enum ELoginStatusCom
		{
			// Token: 0x04032787 RID: 206727
			MySelf
		}
	}
}
