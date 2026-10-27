using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02004B94 RID: 19348
	public class SettlementTargetItem : UiPanelBase
	{
		// Token: 0x06032229 RID: 205353 RVA: 0x00BA5A8E File Offset: 0x00BA3C8E
		[NullableContext(1)]
		public SettlementTargetItem(ITargetDescribeAndScore config)
		{
		}

		// Token: 0x0603222A RID: 205354 RVA: 0x00BA5AA0 File Offset: 0x00BA3CA0
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

		// Token: 0x0603222B RID: 205355 RVA: 0x00BA5B2C File Offset: 0x00BA3D2C
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

		// Token: 0x0401AB54 RID: 109396
		[Nullable(1)]
		public readonly ITargetDescribeAndScore Config = config;

		// Token: 0x0200ADA6 RID: 44454
		private enum EViewComponent
		{
			// Token: 0x04034BD1 RID: 216017
			AchieveBg,
			// Token: 0x04034BD2 RID: 216018
			TargetText,
			// Token: 0x04034BD3 RID: 216019
			AchieveItem
		}
	}
}
