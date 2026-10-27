using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005342 RID: 21314
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueTaskItem : GridProxyAbstract<RogueTaskData>
	{
		// Token: 0x06036765 RID: 223077 RVA: 0x00CE5760 File Offset: 0x00CE3960
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

		// Token: 0x06036766 RID: 223078 RVA: 0x00CE5835 File Offset: 0x00CE3A35
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		}

		// Token: 0x06036767 RID: 223079 RVA: 0x00CE5858 File Offset: 0x00CE3A58
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06036768 RID: 223080 RVA: 0x00CE585F File Offset: 0x00CE3A5F
		private void OnClickGetButton()
		{
			ActivityPermanentRogueController.Instance.RequestTaskAward(this.TaskData.Id);
		}

		// Token: 0x06036769 RID: 223081 RVA: 0x00CE5878 File Offset: 0x00CE3A78
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

		// Token: 0x0401CCFD RID: 118013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401CCFE RID: 118014
		private RogueTaskData TaskData;
	}
}
