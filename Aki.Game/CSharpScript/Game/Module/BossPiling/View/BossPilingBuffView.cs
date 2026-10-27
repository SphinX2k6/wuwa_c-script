using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BossPiling.View.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C0D RID: 23565
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingBuffView : UiViewBase
	{
		// Token: 0x0603B8C7 RID: 243911 RVA: 0x00E327A1 File Offset: 0x00E309A1
		public BossPilingBuffView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B8C8 RID: 243912 RVA: 0x00E327BC File Offset: 0x00E309BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B8C9 RID: 243913 RVA: 0x00E328CC File Offset: 0x00E30ACC
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingBuffView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingBuffView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B8CA RID: 243914 RVA: 0x00E32910 File Offset: 0x00E30B10
		protected override void OnStart()
		{
			this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
			this.DataInfo = (this.OpenParam as BossPilingBuffViewInfo);
			Dictionary<int, List<BossPilingBuffCountInfo>> buffList = BossPilingModel.Instance.GetBuffList(this.DataInfo.LevelId, this.DataInfo.InGame);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(buffList.Count == 0);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(buffList.Count > 0);
			}
			this.DetailPanel.SetUiActive(buffList.Count > 0);
			if (buffList.Count == 0)
			{
				return;
			}
			this.InitScrollDataList(buffList);
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.MultiScroll.RefreshByData(multiTemplateScrollViewRefreshContext);
			this.RefreshTips();
		}

		// Token: 0x0603B8CB RID: 243915 RVA: 0x00E329E0 File Offset: 0x00E30BE0
		protected void InitScrollDataList(Dictionary<int, List<BossPilingBuffCountInfo>> buffMap)
		{
			foreach (KeyValuePair<int, List<BossPilingBuffCountInfo>> keyValuePair in buffMap)
			{
				int num;
				List<BossPilingBuffCountInfo> list;
				keyValuePair.Deconstruct(out num, out list);
				int data = num;
				List<BossPilingBuffCountInfo> list2 = list;
				BossPilingBuffTitleItemData item = new BossPilingBuffTitleItemData(data);
				this.ScrollDataList.Add(item);
				foreach (BossPilingBuffCountInfo bossPilingBuffCountInfo in list2)
				{
					if (this.CurSelect == -1)
					{
						this.CurSelect = bossPilingBuffCountInfo.BuffId;
						this.CurInfo = bossPilingBuffCountInfo;
					}
					BossPilingBuffItemData bossPilingBuffItemData = new BossPilingBuffItemData(bossPilingBuffCountInfo);
					bossPilingBuffItemData.OnToggleClicked = new Action<BossPilingBuffCountInfo>(this.OnToggleClicked);
					bossPilingBuffItemData.IsSelectedCb = new Func<int, bool>(this.IsSelectedCb);
					this.ScrollDataList.Add(bossPilingBuffItemData);
				}
			}
		}

		// Token: 0x0603B8CC RID: 243916 RVA: 0x00E32AE4 File Offset: 0x00E30CE4
		protected void RefreshTips()
		{
			this.LevelSequence.PlayOrReplaySequenceByName("Switch", false, null);
			this.DetailPanel.Refresh(this.CurInfo);
		}

		// Token: 0x0603B8CD RID: 243917 RVA: 0x00E32B1C File Offset: 0x00E30D1C
		private void OnToggleClicked(BossPilingBuffCountInfo buffInfo)
		{
			this.CurSelect = buffInfo.BuffId;
			this.CurInfo = buffInfo;
			this.RefreshTips();
			for (int i = 0; i < this.ScrollDataList.Count; i++)
			{
				this.MultiScroll.RefreshProxyDirectly(i);
			}
		}

		// Token: 0x0603B8CE RID: 243918 RVA: 0x00E32B65 File Offset: 0x00E30D65
		private bool IsSelectedCb(int buffId)
		{
			return buffId == this.CurSelect;
		}

		// Token: 0x0603B8CF RID: 243919 RVA: 0x00E32B70 File Offset: 0x00E30D70
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401F01C RID: 127004
		protected BossPilingBuffViewInfo DataInfo;

		// Token: 0x0401F01D RID: 127005
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401F01E RID: 127006
		protected BossPilingBuffTipsPanel DetailPanel;

		// Token: 0x0401F01F RID: 127007
		protected MultiTemplateScrollView MultiScroll;

		// Token: 0x0401F020 RID: 127008
		protected int CurSelect = -1;

		// Token: 0x0401F021 RID: 127009
		protected BossPilingBuffCountInfo CurInfo;

		// Token: 0x0401F022 RID: 127010
		protected LevelSequencePlayer LevelSequence;

		// Token: 0x0401F023 RID: 127011
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0200BDEB RID: 48619
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403942D RID: 234541
			CaptionItem,
			// Token: 0x0403942E RID: 234542
			MultiSvList,
			// Token: 0x0403942F RID: 234543
			PanelListTitle,
			// Token: 0x04039430 RID: 234544
			PanelItem,
			// Token: 0x04039431 RID: 234545
			DetailItem,
			// Token: 0x04039432 RID: 234546
			PanelNone,
			// Token: 0x04039433 RID: 234547
			PanelContent
		}
	}
}
