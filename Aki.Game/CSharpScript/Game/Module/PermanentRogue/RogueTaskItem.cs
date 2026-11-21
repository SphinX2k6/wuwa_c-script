using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004312 RID: 17170
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueTaskItem : GridProxyAbstract<RogueTaskData>
	{
		// Token: 0x0602B661 RID: 177761 RVA: 0x00C33130 File Offset: 0x00C31330
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickGetButton))
			};
		}

		// Token: 0x0602B662 RID: 177762 RVA: 0x00C33205 File Offset: 0x00C31405
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x0602B663 RID: 177763 RVA: 0x00C33228 File Offset: 0x00C31428
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602B664 RID: 177764 RVA: 0x00C3322F File Offset: 0x00C3142F
		private void OnClickGetButton()
		{
			ActivityPermanentRogueController.Instance.RequestTaskAward(this.TaskData.Id);
		}

		// Token: 0x0602B665 RID: 177765 RVA: 0x00C33248 File Offset: 0x00C31448
		public override void Refresh(RogueTaskData data, bool isSelected, int gridIndex)
		{
			this.TaskData = data;
			this.RewardScrollView.RefreshByData(data.GetRewardList(), null, false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(data.IsFinished() && !data.IsTaken());
			base.GetItem(3).SetUIActive(data.IsTaken());
			base.GetText(2).SetUIActive(!data.IsTaken() && !data.IsFinished());
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			RogueResTask? config = ConfigRogueResTaskById.GetConfig(data.Id, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.Text, Array.Empty<object>());
			if (data.Target > 0)
			{
				UUIText text = base.GetText(5);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				UUIText text2 = base.GetText(5);
				if (text2 == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			else
			{
				UUIText text3 = base.GetText(5);
				if (text3 == null)
				{
					return;
				}
				text3.SetUIActive(false);
				return;
			}
		}

		// Token: 0x04017733 RID: 96051
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x04017734 RID: 96052
		private RogueTaskData TaskData;
	}
}
