using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200508C RID: 20620
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingSuitPreview : RoverlikeActionSubViewBase
	{
		// Token: 0x170064DA RID: 25818
		// (get) Token: 0x060339C8 RID: 211400 RVA: 0x00E72682 File Offset: 0x00E70882
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.BlessingSuitPreview;
			}
		}

		// Token: 0x170064DB RID: 25819
		// (get) Token: 0x060339C9 RID: 211401 RVA: 0x00E72685 File Offset: 0x00E70885
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSetPreview";
			}
		}

		// Token: 0x060339CA RID: 211402 RVA: 0x00E7268C File Offset: 0x00E7088C
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

		// Token: 0x060339CB RID: 211403 RVA: 0x00E726F5 File Offset: 0x00E708F5
		protected override void OnStart()
		{
			this.BlessingSuitLayout = new GenericLayout<RoverlikeBlessingSuitItem, IRoverlikeBlessingSuitData>(base.GetHorizontalLayout(0), new Func<RoverlikeBlessingSuitItem>(this.CreateBlessingSuitItem), null, false, true);
		}

		// Token: 0x060339CC RID: 211404 RVA: 0x00E72718 File Offset: 0x00E70918
		private RoverlikeBlessingSuitItem CreateBlessingSuitItem()
		{
			RoverlikeBlessingSuitItem roverlikeBlessingSuitItem = new RoverlikeBlessingSuitItem();
			roverlikeBlessingSuitItem.BindOnSuitClick(new Action<IRoverlikeBlessingSuitData>(this.OnSuitItemClick));
			return roverlikeBlessingSuitItem;
		}

		// Token: 0x060339CD RID: 211405 RVA: 0x00E72734 File Offset: 0x00E70934
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

		// Token: 0x060339CE RID: 211406 RVA: 0x00E72799 File Offset: 0x00E70999
		private void RefreshBlessingSuitLayout(List<IRoverlikeBlessingSuitData> dataList)
		{
			this.BlessingSuitLayout.RefreshByData(dataList, new Action(this.OnBlessingSuitLayoutRefreshed), true);
		}

		// Token: 0x060339CF RID: 211407 RVA: 0x00E727B4 File Offset: 0x00E709B4
		private void OnBlessingSuitLayoutRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingSuitPreview");
		}

		// Token: 0x060339D0 RID: 211408 RVA: 0x00E727CC File Offset: 0x00E709CC
		public override void OnRefreshSubView()
		{
			List<IRoverlikeBlessingSuitData> list = this.OpenParam as List<IRoverlikeBlessingSuitData>;
			if (list != null && list.Count > 0)
			{
				this.RefreshBlessingSuitLayout(list);
			}
		}

		// Token: 0x0401B631 RID: 112177
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingSuitItem, IRoverlikeBlessingSuitData> BlessingSuitLayout;

		// Token: 0x0200AD4E RID: 44366
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358E1 RID: 219361
			public const int BlessingSuitLayout = 0;

			// Token: 0x040358E2 RID: 219362
			public const int BlessingSuitItem = 1;
		}
	}
}
