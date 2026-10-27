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
	// Token: 0x02004CA4 RID: 19620
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteAssemblyTabItem : UiPanelBase
	{
		// Token: 0x06032B44 RID: 207684 RVA: 0x00BD4CA0 File Offset: 0x00BD2EA0
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

		// Token: 0x06032B45 RID: 207685 RVA: 0x00BD4D09 File Offset: 0x00BD2F09
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<RouletteAssemblyTab, int>(base.GetHorizontalLayout(0), new Func<RouletteAssemblyTab>(this.CreateTabItem), null, false, true);
		}

		// Token: 0x06032B46 RID: 207686 RVA: 0x00BD4D2C File Offset: 0x00BD2F2C
		private RouletteAssemblyTab CreateTabItem()
		{
			return new RouletteAssemblyTab
			{
				ToggleCallBack = new Action<int, bool>(this.OnClickToggle)
			};
		}

		// Token: 0x06032B47 RID: 207687 RVA: 0x00BD4D48 File Offset: 0x00BD2F48
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

		// Token: 0x06032B48 RID: 207688 RVA: 0x00BD4DA4 File Offset: 0x00BD2FA4
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

		// Token: 0x06032B49 RID: 207689 RVA: 0x00BD4DEF File Offset: 0x00BD2FEF
		public void SelectTab(int selectTypeId)
		{
			this.Layout.GetLayoutItemByKey(selectTypeId).SetToggleState(true, true);
		}

		// Token: 0x0401AFE4 RID: 110564
		public int SelectedTypeId = -1;

		// Token: 0x0401AFE5 RID: 110565
		[Nullable(2)]
		public Action<int> ToggleCallBack;

		// Token: 0x0401AFE6 RID: 110566
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RouletteAssemblyTab, int> Layout;
	}
}
