using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AAB RID: 23211
	public class DreamLinkRoleSelectPanel : UiPanelBase
	{
		// Token: 0x0603ACC7 RID: 240839 RVA: 0x00E02520 File Offset: 0x00E00720
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603ACC8 RID: 240840 RVA: 0x00E025AC File Offset: 0x00E007AC
		private void RefreshHandle()
		{
			foreach (DreamLinkRoleItem dreamLinkRoleItem in this.RoleItemList)
			{
				dreamLinkRoleItem.Refresh();
			}
		}

		// Token: 0x0603ACC9 RID: 240841 RVA: 0x00E025FC File Offset: 0x00E007FC
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRoleSelectPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRoleSelectPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACCA RID: 240842 RVA: 0x00E02640 File Offset: 0x00E00840
		public void RefreshInstId(int instId)
		{
			foreach (DreamLinkRoleItem dreamLinkRoleItem in this.RoleItemList)
			{
				dreamLinkRoleItem.RefreshInstId(instId);
			}
		}

		// Token: 0x0401EB00 RID: 125696
		[Nullable(1)]
		public List<DreamLinkRoleItem> RoleItemList = new List<DreamLinkRoleItem>();

		// Token: 0x0200BCF5 RID: 48373
		private class EPanelDefine
		{
			// Token: 0x04038FD3 RID: 233427
			public const int RoleItem1 = 0;

			// Token: 0x04038FD4 RID: 233428
			public const int RoleItem2 = 1;

			// Token: 0x04038FD5 RID: 233429
			public const int RoleItem3 = 2;
		}
	}
}
