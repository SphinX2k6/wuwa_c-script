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
	// Token: 0x02004A87 RID: 19079
	public class DreamLinkRoleSelectPanel : UiPanelBase
	{
		// Token: 0x0602FC13 RID: 195603 RVA: 0x00D52ACC File Offset: 0x00D50CCC
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

		// Token: 0x0602FC14 RID: 195604 RVA: 0x00D52B58 File Offset: 0x00D50D58
		private void RefreshHandle()
		{
			foreach (DreamLinkRoleItem dreamLinkRoleItem in this.RoleItemList)
			{
				dreamLinkRoleItem.Refresh();
			}
		}

		// Token: 0x0602FC15 RID: 195605 RVA: 0x00D52BA8 File Offset: 0x00D50DA8
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRoleSelectPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRoleSelectPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC16 RID: 195606 RVA: 0x00D52BEC File Offset: 0x00D50DEC
		public void RefreshInstId(int instId)
		{
			foreach (DreamLinkRoleItem dreamLinkRoleItem in this.RoleItemList)
			{
				dreamLinkRoleItem.RefreshInstId(instId);
			}
		}

		// Token: 0x040195A7 RID: 103847
		[Nullable(1)]
		public List<DreamLinkRoleItem> RoleItemList = new List<DreamLinkRoleItem>();

		// Token: 0x0200A6FE RID: 42750
		private class EPanelDefine
		{
			// Token: 0x0403399E RID: 211358
			public const int RoleItem1 = 0;

			// Token: 0x0403399F RID: 211359
			public const int RoleItem2 = 1;

			// Token: 0x040339A0 RID: 211360
			public const int RoleItem3 = 2;
		}
	}
}
