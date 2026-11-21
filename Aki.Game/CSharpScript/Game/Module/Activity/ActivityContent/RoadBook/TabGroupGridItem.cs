using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005178 RID: 20856
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TabGroupGridItem : GridProxyAbstract<ITabGroupData>
	{
		// Token: 0x06034156 RID: 213334 RVA: 0x00E92044 File Offset: 0x00E90244
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

		// Token: 0x06034157 RID: 213335 RVA: 0x00E920E0 File Offset: 0x00E902E0
		protected override UniTask OnBeforeStartAsync()
		{
			TabGroupGridItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TabGroupGridItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034158 RID: 213336 RVA: 0x00E92124 File Offset: 0x00E90324
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

		// Token: 0x06034159 RID: 213337 RVA: 0x00E9216F File Offset: 0x00E9036F
		private TabGridItem OnCreateTabItem()
		{
			return new TabGridItem
			{
				OnChildToggleCallback = this.OnChildToggleCallback
			};
		}

		// Token: 0x0603415A RID: 213338 RVA: 0x00E92182 File Offset: 0x00E90382
		public void SelectFirstTab()
		{
			this.TabLayout.SelectGridProxy(0, true);
		}

		// Token: 0x0401B961 RID: 112993
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<MotorChallengePlayData, MenuTabToggleItem> OnChildToggleCallback;

		// Token: 0x0401B962 RID: 112994
		private GenericLayout<TabGridItem, MotorChallengePlayData> TabLayout;

		// Token: 0x0401B963 RID: 112995
		[Nullable(2)]
		private ITabGroupData Data;
	}
}
