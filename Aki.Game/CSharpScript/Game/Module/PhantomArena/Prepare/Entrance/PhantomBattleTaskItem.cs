using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005169 RID: 20841
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomBattleTaskItem : GridProxyAbstract<PhantomArenaTaskData>
	{
		// Token: 0x06035485 RID: 218245 RVA: 0x00C9E060 File Offset: 0x00C9C260
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpButton)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton))
			};
		}

		// Token: 0x06035486 RID: 218246 RVA: 0x00C9E14D File Offset: 0x00C9C34D
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x06035487 RID: 218247 RVA: 0x00C9E170 File Offset: 0x00C9C370
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06035488 RID: 218248 RVA: 0x00C9E177 File Offset: 0x00C9C377
		private void OnClickGetButton()
		{
			PhantomArenaController.Instance.TaskAllRewardRequest(this.Data.TaskConfig.Id);
		}

		// Token: 0x06035489 RID: 218249 RVA: 0x00C9E193 File Offset: 0x00C9C393
		private void OnClickJumpButton()
		{
			if (this.Data == null || this.JumpId == 0)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(this.JumpId, null);
		}

		// Token: 0x0603548A RID: 218250 RVA: 0x00C9E1B4 File Offset: 0x00C9C3B4
		public override void Refresh(PhantomArenaTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RewardScrollView.RefreshByData(data.Reward, null, false);
			PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(this.Data.TaskConfig.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), taskConfigById.Value.Desc, Array.Empty<object>());
			UUIText text = base.GetText(4);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.TaskConfig.Current);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.TaskConfig.Target);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			ActivityTaskState status = this.Data.TaskConfig.Status;
			this.JumpId = taskConfigById.Value.AccessPath;
			if (status == ActivityTaskState.ActivityTaskRunning && taskConfigById.Value.AccessPath != 0)
			{
				UUIButtonComponent button = base.GetButton(0);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(true);
				}
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(0);
				if (button2 != null)
				{
					button2.RootUIComp.Get().SetUIActive(false);
				}
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(status == ActivityTaskState.ActivityTaskTaken);
			}
			UUIButtonComponent button3 = base.GetButton(1);
			if (button3 != null)
			{
				button3.RootUIComp.Get().SetUIActive(status == ActivityTaskState.ActivityTaskFinish);
			}
			UUIText text2 = base.GetText(6);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(status == ActivityTaskState.ActivityTaskRunning);
		}

		// Token: 0x0401C577 RID: 116087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401C578 RID: 116088
		[Nullable(2)]
		private PhantomArenaTaskData Data;

		// Token: 0x0401C579 RID: 116089
		private int JumpId;

		// Token: 0x0200B2CB RID: 45771
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x040362BD RID: 221885
			public const int JumpBtn = 0;

			// Token: 0x040362BE RID: 221886
			public const int GetBtn = 1;

			// Token: 0x040362BF RID: 221887
			public const int PanelDone = 2;

			// Token: 0x040362C0 RID: 221888
			public const int TxtName = 3;

			// Token: 0x040362C1 RID: 221889
			public const int ProgressText = 4;

			// Token: 0x040362C2 RID: 221890
			public const int RewardScroll = 5;

			// Token: 0x040362C3 RID: 221891
			public const int DoingText = 6;
		}
	}
}
