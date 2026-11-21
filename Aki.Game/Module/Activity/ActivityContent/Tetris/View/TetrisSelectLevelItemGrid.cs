using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FDE RID: 12254
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisSelectLevelItemGrid : GridProxyAbstract<TetrisSelectGroupData>
	{
		// Token: 0x0601D168 RID: 119144 RVA: 0x008E451C File Offset: 0x008E271C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D169 RID: 119145 RVA: 0x008E45A8 File Offset: 0x008E27A8
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisSelectLevelItemGrid.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisSelectLevelItemGrid.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D16A RID: 119146 RVA: 0x008E45EC File Offset: 0x008E27EC
		public override void Refresh(TetrisSelectGroupData data, bool isSelected, int gridIndex)
		{
			this.LevelData = data;
			int num = data.ChallengeIds[0];
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(num);
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (!TetrisUtils.IsActivityEggLevel(levelConfig) || tetrisData == null || tetrisData.CheckPreChallengeComplete(num))
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetUIActive(true);
				}
				this.RefreshPanel();
				this.ItemDetailPanel.Refresh(data);
				return;
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetUIActive(false);
		}

		// Token: 0x0601D16B RID: 119147 RVA: 0x008E466C File Offset: 0x008E286C
		private void RefreshPanel()
		{
			if (this.LevelData.GroupId % 2 == 0)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item3 = base.GetItem(2);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(1);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0601D16C RID: 119148 RVA: 0x008E46D3 File Offset: 0x008E28D3
		public void PlayAnim(string sequenceName)
		{
			this.ItemDetailPanel.PlayAnim(sequenceName);
		}

		// Token: 0x0601D16D RID: 119149 RVA: 0x008E46E1 File Offset: 0x008E28E1
		public UUIItem GetGridItem()
		{
			return base.GetItem(0);
		}

		// Token: 0x0400F527 RID: 62759
		[Nullable(2)]
		private TetrisSelectGroupData LevelData;

		// Token: 0x0400F528 RID: 62760
		[Nullable(2)]
		private TetrisSelectLevelItemDetailPanel ItemDetailPanel;
	}
}
