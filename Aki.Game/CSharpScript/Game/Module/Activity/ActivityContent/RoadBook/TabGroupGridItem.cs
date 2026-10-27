using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061FA RID: 25082
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabGroupGridItem : GridProxyAbstract<ITabGroupData>
	{
		// Token: 0x0603F495 RID: 259221 RVA: 0x00F4B0EC File Offset: 0x00F492EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x0603F496 RID: 259222 RVA: 0x00F4B188 File Offset: 0x00F49388
		protected override UniTask OnBeforeStartAsync()
		{
			TabGroupGridItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabGroupGridItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F497 RID: 259223 RVA: 0x00F4B1CC File Offset: 0x00F493CC
		public override UniTask RefreshAsync(ITabGroupData data, bool isSelected, int gridIndex)
		{
			TabGroupGridItem.<RefreshAsync>d__5 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TabGroupGridItem.<RefreshAsync>d__5>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F498 RID: 259224 RVA: 0x00F4B217 File Offset: 0x00F49417
		private TabGridItem OnCreateTabItem()
		{
			return new TabGridItem
			{
				OnChildToggleCallback = this.OnChildToggleCallback
			};
		}

		// Token: 0x0603F499 RID: 259225 RVA: 0x00F4B22A File Offset: 0x00F4942A
		public void SelectFirstTab()
		{
			this.TabLayout.SelectGridProxy(0, true);
		}

		// Token: 0x04021032 RID: 135218
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x04021033 RID: 135219
		private GenericLayout<TabGridItem, MotorChallengePlayData> TabLayout;

		// Token: 0x04021034 RID: 135220
		[Nullable(2)]
		private ITabGroupData Data;
	}
}
