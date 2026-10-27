using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006016 RID: 24598
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisSelectLevelItemGrid : GridProxyAbstract<ITetrisSelectGroupData>
	{
		// Token: 0x0603E4A5 RID: 255141 RVA: 0x00F0B754 File Offset: 0x00F09954
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603E4A6 RID: 255142 RVA: 0x00F0B7B0 File Offset: 0x00F099B0
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisSelectLevelItemGrid.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisSelectLevelItemGrid.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E4A7 RID: 255143 RVA: 0x00F0B7F4 File Offset: 0x00F099F4
		public override void Refresh(ITetrisSelectGroupData data, bool isSelected, int gridIndex)
		{
			this.LevelData = data;
			int num = data.ChallengeIds[0];
			Tetris levelConfig = ActivityTetrisConfig.Instance.GetLevelConfig(num);
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (!TetrisUtils.IsEggLevel(levelConfig) || tetrisData == null || tetrisData.CheckPreChallengeComplete(num))
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

		// Token: 0x0603E4A8 RID: 255144 RVA: 0x00F0B874 File Offset: 0x00F09A74
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

		// Token: 0x0603E4A9 RID: 255145 RVA: 0x00F0B8DB File Offset: 0x00F09ADB
		public void PlayAnim(string sequenceName)
		{
			this.ItemDetailPanel.PlayAnim(sequenceName);
		}

		// Token: 0x0603E4AA RID: 255146 RVA: 0x00F0B8E9 File Offset: 0x00F09AE9
		public UUIItem GetGridItem()
		{
			return base.GetItem(0);
		}

		// Token: 0x040208E0 RID: 133344
		[Nullable(2)]
		private ITetrisSelectGroupData LevelData;

		// Token: 0x040208E1 RID: 133345
		[Nullable(2)]
		private TetrisSelectLevelItemDetailPanel ItemDetailPanel;
	}
}
