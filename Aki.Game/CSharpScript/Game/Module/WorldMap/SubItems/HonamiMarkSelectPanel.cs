using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubItems
{
	// Token: 0x02003781 RID: 14209
	public class HonamiMarkSelectPanel : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x06024ED6 RID: 151254 RVA: 0x00A6F533 File Offset: 0x00A6D733
		// (set) Token: 0x06024ED7 RID: 151255 RVA: 0x00A6F53B File Offset: 0x00A6D73B
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x06024ED8 RID: 151256 RVA: 0x00A6F544 File Offset: 0x00A6D744
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024ED9 RID: 151257 RVA: 0x00A6F5B0 File Offset: 0x00A6D7B0
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiMarkSelectPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiMarkSelectPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024EDA RID: 151258 RVA: 0x00A6F5F3 File Offset: 0x00A6D7F3
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x06024EDB RID: 151259 RVA: 0x00A6F5FC File Offset: 0x00A6D7FC
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			base.SetUiActive(showMode == EWorldMapShowMode.HonamiStory);
		}

		// Token: 0x04014731 RID: 83761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<HonamiMarkSelectItem, int> ScrollView;
	}
}
