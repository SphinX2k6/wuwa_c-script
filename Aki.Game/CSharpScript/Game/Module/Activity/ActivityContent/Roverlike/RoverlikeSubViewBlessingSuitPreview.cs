using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200610E RID: 24846
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingSuitPreview : RoverlikeActionSubViewBase
	{
		// Token: 0x17009178 RID: 37240
		// (get) Token: 0x0603ED06 RID: 257286 RVA: 0x00F2B86E File Offset: 0x00F29A6E
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.BlessingSuitPreview;
			}
		}

		// Token: 0x17009179 RID: 37241
		// (get) Token: 0x0603ED07 RID: 257287 RVA: 0x00F2B871 File Offset: 0x00F29A71
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSetPreview";
			}
		}

		// Token: 0x0603ED08 RID: 257288 RVA: 0x00F2B878 File Offset: 0x00F29A78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603ED09 RID: 257289 RVA: 0x00F2B8E1 File Offset: 0x00F29AE1
		protected override void OnStart()
		{
			this.BlessingSuitLayout = new GenericLayout<RoverlikeBlessingSuitItem, IRoverlikeBlessingSuitData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingSuitItem>(this.CreateBlessingSuitItem), null, false, true);
		}

		// Token: 0x0603ED0A RID: 257290 RVA: 0x00F2B904 File Offset: 0x00F29B04
		private RoverlikeBlessingSuitItem CreateBlessingSuitItem()
		{
			RoverlikeBlessingSuitItem roverlikeBlessingSuitItem = new RoverlikeBlessingSuitItem();
			roverlikeBlessingSuitItem.BindOnSuitClick(new Action<IRoverlikeBlessingSuitData>(this.OnSuitItemClick));
			return roverlikeBlessingSuitItem;
		}

		// Token: 0x0603ED0B RID: 257291 RVA: 0x00F2B920 File Offset: 0x00F29B20
		private void OnSuitItemClick(IRoverlikeBlessingSuitData data)
		{
			List<IRoverlikeBlessingSuitData> list = this.OpenParam as List<IRoverlikeBlessingSuitData>;
			if (list == null || list.Count == 0)
			{
				return;
			}
			int num = list.IndexOf(data);
			RoverlikeBlessingSuitSelectParam openParam = new RoverlikeBlessingSuitSelectParam
			{
				SuitDataList = list,
				SelectedIndex = ((num >= 0) ? num : 0)
			};
			RoverlikeController.Instance.OpenActionSubView(ERoverActionSubViewType.BlessingSuitSelect, openParam);
			RoverlikeController.Instance.FinishActionSubView(this.IncId);
		}

		// Token: 0x0603ED0C RID: 257292 RVA: 0x00F2B985 File Offset: 0x00F29B85
		private void RefreshBlessingSuitLayout(List<IRoverlikeBlessingSuitData> dataList)
		{
			this.BlessingSuitLayout.RefreshByData(dataList, new Action(this.OnBlessingSuitLayoutRefreshed), true);
		}

		// Token: 0x0603ED0D RID: 257293 RVA: 0x00F2B9A0 File Offset: 0x00F29BA0
		private void OnBlessingSuitLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingSuitPreview");
		}

		// Token: 0x0603ED0E RID: 257294 RVA: 0x00F2B9B8 File Offset: 0x00F29BB8
		public override void OnRefreshSubView()
		{
			List<IRoverlikeBlessingSuitData> list = this.OpenParam as List<IRoverlikeBlessingSuitData>;
			if (list != null && list.Count > 0)
			{
				this.RefreshBlessingSuitLayout(list);
			}
		}

		// Token: 0x04020D04 RID: 134404
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitItem, IRoverlikeBlessingSuitData> BlessingSuitLayout;

		// Token: 0x0200C366 RID: 50022
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF7C RID: 241532
			public const int BlessingSuitLayout = 0;

			// Token: 0x0403AF7D RID: 241533
			public const int BlessingSuitItem = 1;
		}
	}
}
