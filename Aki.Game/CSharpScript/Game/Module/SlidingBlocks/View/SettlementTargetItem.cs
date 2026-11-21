using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B3E RID: 15166
	public class SettlementTargetItem : UiPanelBase
	{
		// Token: 0x06026FB9 RID: 159673 RVA: 0x00AE9BDA File Offset: 0x00AE7DDA
		[NullableContext(1)]
		public SettlementTargetItem(ITargetDescribeAndScore config)
		{
		}

		// Token: 0x06026FBA RID: 159674 RVA: 0x00AE9BEC File Offset: 0x00AE7DEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026FBB RID: 159675 RVA: 0x00AE9C78 File Offset: 0x00AE7E78
		protected override void OnStart()
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(this.Config.DescribeTextKey);
			}
			double score = SlidingBlocksModel.Instance.GameData.Score;
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(score >= (double)this.Config.Score);
		}

		// Token: 0x040154A8 RID: 87208
		[Nullable(1)]
		public readonly ITargetDescribeAndScore Config = config;

		// Token: 0x020097C5 RID: 38853
		private enum EViewComponent
		{
			// Token: 0x0402F578 RID: 193912
			AchieveBg,
			// Token: 0x0402F579 RID: 193913
			TargetText,
			// Token: 0x0402F57A RID: 193914
			AchieveItem
		}
	}
}
