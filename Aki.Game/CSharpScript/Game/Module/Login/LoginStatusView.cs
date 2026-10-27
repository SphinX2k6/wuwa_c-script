using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056B9 RID: 22201
	public class LoginStatusView : UiViewBase
	{
		// Token: 0x06038782 RID: 231298 RVA: 0x00D682AF File Offset: 0x00D664AF
		[NullableContext(1)]
		public LoginStatusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038783 RID: 231299 RVA: 0x00D682B8 File Offset: 0x00D664B8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x06038784 RID: 231300 RVA: 0x00D682D3 File Offset: 0x00D664D3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x06038785 RID: 231301 RVA: 0x00D682F0 File Offset: 0x00D664F0
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

		// Token: 0x06038786 RID: 231302 RVA: 0x00D68338 File Offset: 0x00D66538
		protected override void OnStart()
		{
			this.RefreshStatus();
		}

		// Token: 0x06038787 RID: 231303 RVA: 0x00D68340 File Offset: 0x00D66540
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

		// Token: 0x0200B87A RID: 47226
		public enum ELoginStatusCom
		{
			// Token: 0x04037D6D RID: 228717
			MySelf
		}
	}
}
