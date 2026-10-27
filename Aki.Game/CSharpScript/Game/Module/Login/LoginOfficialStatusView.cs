using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x020056B2 RID: 22194
	public class LoginOfficialStatusView : UiViewBase
	{
		// Token: 0x06038758 RID: 231256 RVA: 0x00D677DD File Offset: 0x00D659DD
		[NullableContext(1)]
		public LoginOfficialStatusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038759 RID: 231257 RVA: 0x00D677E6 File Offset: 0x00D659E6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0603875A RID: 231258 RVA: 0x00D67801 File Offset: 0x00D65A01
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0603875B RID: 231259 RVA: 0x00D6781C File Offset: 0x00D65A1C
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

		// Token: 0x0603875C RID: 231260 RVA: 0x00D67864 File Offset: 0x00D65A64
		protected override void OnStart()
		{
			this.RefreshStatus();
		}

		// Token: 0x0603875D RID: 231261 RVA: 0x00D6786C File Offset: 0x00D65A6C
		private void RefreshStatus()
		{
			int loginStatus = (int)LoginModel.Instance.GetLoginStatus();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "ELoginStatus", new <>z__ReadOnlySingleElementList<object>(loginStatus));
		}
	}
}
