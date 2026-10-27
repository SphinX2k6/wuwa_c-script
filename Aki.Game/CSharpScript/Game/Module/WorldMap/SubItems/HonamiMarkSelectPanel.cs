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
	// Token: 0x02004850 RID: 18512
	public class HonamiMarkSelectPanel : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x1700790E RID: 30990
		// (get) Token: 0x06030707 RID: 198407 RVA: 0x00B3F2EF File Offset: 0x00B3D4EF
		// (set) Token: 0x06030708 RID: 198408 RVA: 0x00B3F2F7 File Offset: 0x00B3D4F7
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x06030709 RID: 198409 RVA: 0x00B3F300 File Offset: 0x00B3D500
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

		// Token: 0x0603070A RID: 198410 RVA: 0x00B3F36C File Offset: 0x00B3D56C
		protected override UniTask OnBeforeStartAsync()
		{
			HonamiMarkSelectPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiMarkSelectPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603070B RID: 198411 RVA: 0x00B3F3AF File Offset: 0x00B3D5AF
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x0603070C RID: 198412 RVA: 0x00B3F3B8 File Offset: 0x00B3D5B8
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			base.SetUiActive(showMode == EWorldMapShowMode.HonamiStory);
		}

		// Token: 0x0401A07D RID: 106621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<HonamiMarkSelectItem, int> ScrollView;
	}
}
