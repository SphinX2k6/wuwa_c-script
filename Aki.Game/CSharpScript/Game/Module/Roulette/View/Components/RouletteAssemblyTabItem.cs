using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View.Components
{
	// Token: 0x02003C55 RID: 15445
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteAssemblyTabItem : UiPanelBase
	{
		// Token: 0x060278F8 RID: 162040 RVA: 0x00B19A38 File Offset: 0x00B17C38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060278F9 RID: 162041 RVA: 0x00B19AA1 File Offset: 0x00B17CA1
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<RouletteAssemblyTab, int>(base.GetHorizontalLayout(0), new Func<RouletteAssemblyTab>(this.CreateTabItem), null, false, true);
		}

		// Token: 0x060278FA RID: 162042 RVA: 0x00B19AC4 File Offset: 0x00B17CC4
		private RouletteAssemblyTab CreateTabItem()
		{
			return new RouletteAssemblyTab
			{
				ToggleCallBack = new Action<int, bool>(this.OnClickToggle)
			};
		}

		// Token: 0x060278FB RID: 162043 RVA: 0x00B19AE0 File Offset: 0x00B17CE0
		private void OnClickToggle(int typeId, bool bSelected)
		{
			if (!bSelected)
			{
				return;
			}
			if (this.SelectedTypeId == typeId)
			{
				return;
			}
			if (this.SelectedTypeId != -1)
			{
				this.Layout.GetLayoutItemByKey(this.SelectedTypeId).SetToggleState(false, false);
			}
			this.SelectedTypeId = typeId;
			Action<int> toggleCallBack = this.ToggleCallBack;
			if (toggleCallBack == null)
			{
				return;
			}
			toggleCallBack(typeId);
		}

		// Token: 0x060278FC RID: 162044 RVA: 0x00B19B3C File Offset: 0x00B17D3C
		public UniTask Refresh(int[] typeIdList)
		{
			RouletteAssemblyTabItem.<Refresh>d__7 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.typeIdList = typeIdList;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RouletteAssemblyTabItem.<Refresh>d__7>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x060278FD RID: 162045 RVA: 0x00B19B87 File Offset: 0x00B17D87
		public void SelectTab(int selectTypeId)
		{
			this.Layout.GetLayoutItemByKey(selectTypeId).SetToggleState(true, true);
		}

		// Token: 0x04015945 RID: 88389
		public int SelectedTypeId = -1;

		// Token: 0x04015946 RID: 88390
		[Nullable(2)]
		public Action<int> ToggleCallBack;

		// Token: 0x04015947 RID: 88391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RouletteAssemblyTab, int> Layout;
	}
}
