using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006415 RID: 25621
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MotorFightLevelListPanel : GridProxyAbstract<List<MotorFightLevelData>>
	{
		// Token: 0x06040706 RID: 263942 RVA: 0x00F97094 File Offset: 0x00F95294
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040707 RID: 263943 RVA: 0x00F970DC File Offset: 0x00F952DC
		protected override void OnStart()
		{
			this.LevelLayout = new GenericLayout<MotorFightLevelItem, MotorFightLevelData>(base.GetVerticalLayout(0), new Func<MotorFightLevelItem>(this.CreateMotorFightLevelItem), null, false, true);
		}

		// Token: 0x06040708 RID: 263944 RVA: 0x00F97100 File Offset: 0x00F95300
		public override UniTask RefreshAsync(List<MotorFightLevelData> dataList, bool isSelected, int gridIndex)
		{
			MotorFightLevelListPanel.<RefreshAsync>d__4 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.dataList = dataList;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<MotorFightLevelListPanel.<RefreshAsync>d__4>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040709 RID: 263945 RVA: 0x00F9714B File Offset: 0x00F9534B
		private MotorFightLevelItem CreateMotorFightLevelItem()
		{
			return new MotorFightLevelItem();
		}

		// Token: 0x0604070A RID: 263946 RVA: 0x00F97152 File Offset: 0x00F95352
		[NullableContext(2)]
		public UUIItem GuideGetLevelItem(int index)
		{
			return this.LevelLayout.GetItemByIndex(index);
		}

		// Token: 0x0604070B RID: 263947 RVA: 0x00F97160 File Offset: 0x00F95360
		[NullableContext(2)]
		public UUIItem GetLevelNavigationItem()
		{
			IReadOnlyList<MotorFightLevelData> datas = this.LevelLayout.GetDatas();
			int index = 0;
			for (int i = 0; i < datas.Count; i++)
			{
				if (!datas[i].IsFinished)
				{
					index = i;
					break;
				}
			}
			MotorFightLevelItem layoutItemByIndex = this.LevelLayout.GetLayoutItemByIndex(index);
			if (layoutItemByIndex == null)
			{
				return null;
			}
			return layoutItemByIndex.GetNavigationItem();
		}

		// Token: 0x0402180F RID: 137231
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightLevelItem, MotorFightLevelData> LevelLayout;

		// Token: 0x0200C639 RID: 50745
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BD89 RID: 245129
			public const int LayoutLevel = 0;
		}
	}
}
