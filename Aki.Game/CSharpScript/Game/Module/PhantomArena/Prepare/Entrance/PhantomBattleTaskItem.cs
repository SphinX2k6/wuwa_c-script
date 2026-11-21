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
	// Token: 0x02004139 RID: 16697
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomBattleTaskItem : GridProxyAbstract<PhantomArenaTaskData>
	{
		// Token: 0x0602A381 RID: 172929 RVA: 0x00BEB5AC File Offset: 0x00BE97AC
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

		// Token: 0x0602A382 RID: 172930 RVA: 0x00BEB699 File Offset: 0x00BE9899
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x0602A383 RID: 172931 RVA: 0x00BEB6BC File Offset: 0x00BE98BC
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602A384 RID: 172932 RVA: 0x00BEB6C3 File Offset: 0x00BE98C3
		private void OnClickGetButton()
		{
			PhantomArenaController.Instance.TaskAllRewardRequest(this.Data.TaskConfig.Id);
		}

		// Token: 0x0602A385 RID: 172933 RVA: 0x00BEB6DF File Offset: 0x00BE98DF
		private void OnClickJumpButton()
		{
			if (this.Data == null || this.JumpId == 0)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(this.JumpId, null);
		}

		// Token: 0x0602A386 RID: 172934 RVA: 0x00BEB700 File Offset: 0x00BE9900
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

		// Token: 0x04016FAC RID: 94124
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04016FAD RID: 94125
		[Nullable(2)]
		private PhantomArenaTaskData Data;

		// Token: 0x04016FAE RID: 94126
		private int JumpId;

		// Token: 0x02009D05 RID: 40197
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x04030D14 RID: 199956
			public const int JumpBtn = 0;

			// Token: 0x04030D15 RID: 199957
			public const int GetBtn = 1;

			// Token: 0x04030D16 RID: 199958
			public const int PanelDone = 2;

			// Token: 0x04030D17 RID: 199959
			public const int TxtName = 3;

			// Token: 0x04030D18 RID: 199960
			public const int ProgressText = 4;

			// Token: 0x04030D19 RID: 199961
			public const int RewardScroll = 5;

			// Token: 0x04030D1A RID: 199962
			public const int DoingText = 6;
		}
	}
}
