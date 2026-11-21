using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x02004688 RID: 18056
	public class LoginOfficialStatusView : UiViewBase
	{
		// Token: 0x0602D655 RID: 185941 RVA: 0x00CB59A1 File Offset: 0x00CB3BA1
		[NullableContext(1)]
		public LoginOfficialStatusView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D656 RID: 185942 RVA: 0x00CB59AA File Offset: 0x00CB3BAA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0602D657 RID: 185943 RVA: 0x00CB59C5 File Offset: 0x00CB3BC5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.LoginStatusChange, new Action(this.RefreshStatus));
		}

		// Token: 0x0602D658 RID: 185944 RVA: 0x00CB59E0 File Offset: 0x00CB3BE0
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

		// Token: 0x0602D659 RID: 185945 RVA: 0x00CB5A28 File Offset: 0x00CB3C28
		protected override void OnStart()
		{
			this.RefreshStatus();
		}

		// Token: 0x0602D65A RID: 185946 RVA: 0x00CB5A30 File Offset: 0x00CB3C30
		private void RefreshStatus()
		{
			int loginStatus = (int)LoginModel.Instance.GetLoginStatus();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "ELoginStatus", new <>z__ReadOnlySingleElementList<object>(loginStatus));
		}
	}
}
