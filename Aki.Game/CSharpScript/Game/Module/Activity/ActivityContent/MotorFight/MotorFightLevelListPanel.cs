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
	// Token: 0x02005393 RID: 21395
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MotorFightLevelListPanel : GridProxyAbstract<List<MotorFightLevelData>>
	{
		// Token: 0x060353C7 RID: 218055 RVA: 0x00EDE034 File Offset: 0x00EDC234
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

		// Token: 0x060353C8 RID: 218056 RVA: 0x00EDE07C File Offset: 0x00EDC27C
		protected override void OnStart()
		{
			this.LevelLayout = new GenericLayout<MotorFightLevelItem, MotorFightLevelData>(base.GetVerticalLayout(0), new Func<MotorFightLevelItem>(this.CreateMotorFightLevelItem), null, false, true);
		}

		// Token: 0x060353C9 RID: 218057 RVA: 0x00EDE0A0 File Offset: 0x00EDC2A0
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

		// Token: 0x060353CA RID: 218058 RVA: 0x00EDE0EB File Offset: 0x00EDC2EB
		private MotorFightLevelItem CreateMotorFightLevelItem()
		{
			return new MotorFightLevelItem();
		}

		// Token: 0x060353CB RID: 218059 RVA: 0x00EDE0F2 File Offset: 0x00EDC2F2
		[NullableContext(2)]
		public UUIItem GuideGetLevelItem(int index)
		{
			return this.LevelLayout.GetItemByIndex(index);
		}

		// Token: 0x060353CC RID: 218060 RVA: 0x00EDE100 File Offset: 0x00EDC300
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

		// Token: 0x0401C13E RID: 115006
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MotorFightLevelItem, MotorFightLevelData> LevelLayout;

		// Token: 0x0200B020 RID: 45088
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040366E6 RID: 222950
			public const int LayoutLevel = 0;
		}
	}
}
