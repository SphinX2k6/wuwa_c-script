using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005739 RID: 22329
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineEnsureLineItemButton : UiPanelBase
	{
		// Token: 0x17006A45 RID: 27205
		// (get) Token: 0x06036FB0 RID: 225200 RVA: 0x00F5737C File Offset: 0x00F5557C
		[Nullable(2)]
		protected DangoBrawlTouchController Touch
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x06036FB1 RID: 225201 RVA: 0x00F57388 File Offset: 0x00F55588
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCombine));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036FB2 RID: 225202 RVA: 0x00F57470 File Offset: 0x00F55670
		protected override void OnStart()
		{
			ActivityDangoBrawlData activityDangoBrawlData = this.OpenParam as ActivityDangoBrawlData;
			if (activityDangoBrawlData != null)
			{
				this.ActData = activityDangoBrawlData;
			}
			this.InitSequencePlayer();
		}

		// Token: 0x06036FB3 RID: 225203 RVA: 0x00F57499 File Offset: 0x00F55699
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x06036FB4 RID: 225204 RVA: 0x00F574A4 File Offset: 0x00F556A4
		public void Refresh(DangoBrawlCombineRowData row)
		{
			this.Row = row;
			bool flag = DangoBrawlViewManager.TryBlockIfCombineUniqueWeapon(row, false);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				bool bUseChangeColor = flag;
				UUIText text2 = base.GetText(3);
				FColor? fcolor;
				FColor? fcolor2;
				if (text2 == null)
				{
					fcolor = null;
					fcolor2 = fcolor;
				}
				else
				{
					fcolor2 = new FColor?(text2.changeColor);
				}
				fcolor = fcolor2;
				text.SetChangeColor(bUseChangeColor, fcolor);
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x06036FB5 RID: 225205 RVA: 0x00F57538 File Offset: 0x00F55738
		private void InitSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
			this.SequencePlayer.BindOnStartSequenceEvent(new Action<string>(this.OnStartSequenceEvent));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		}

		// Token: 0x06036FB6 RID: 225206 RVA: 0x00F57590 File Offset: 0x00F55790
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06036FB7 RID: 225207 RVA: 0x00F575AA File Offset: 0x00F557AA
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06036FB8 RID: 225208 RVA: 0x00F575AC File Offset: 0x00F557AC
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06036FB9 RID: 225209 RVA: 0x00F575B0 File Offset: 0x00F557B0
		private void OnClickCombine()
		{
			if (DangoBrawlViewManager.TryBlockIfThreeChoose(true) || DangoBrawlViewManager.TryBlockIfCombineUniqueWeapon(this.Row, true) || DangoBrawlViewManager.TryBlockIfLayerMode(true))
			{
				return;
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null && touch.IsFsmBlocking)
			{
				return;
			}
			DangoBrawlCombineRowData row = this.Row;
			ActivityDangoBrawlData actData = this.ActData;
			ValueTuple<bool, DangoBrawlBagSlotInfo> valueTuple = DangoBrawlCombineUtil.ComputeComposeTarget(row, (actData != null) ? actData.BagpackData : null);
			bool item = valueTuple.Item1;
			DangoBrawlBagSlotInfo item2 = valueTuple.Item2;
			int[] itemUids = Array.ConvertAll<CombineItem, int>(this.Row.SourceItems, (CombineItem x) => x.Uid);
			EDragSourceKind[] sourceKinds = Array.ConvertAll<CombineItem, EDragSourceKind>(this.Row.SourceItems, (CombineItem x) => x.Source);
			DangoBrawlCombineRowData row2 = this.Row;
			ActivityDangoBrawlData actData2 = this.ActData;
			int mainUid = DangoBrawlCombineUtil.ResolveMainUid(row2, (actData2 != null) ? actData2.BagpackData : null);
			ActivityDangoBrawlController.Instance.RequestShopCompose(mainUid, itemUids, sourceKinds, this.Row.ComposeId, this.Row.ResultItemId, item, item2).Forget<bool>();
		}

		// Token: 0x0401D193 RID: 119187
		private ActivityDangoBrawlData ActData;

		// Token: 0x0401D194 RID: 119188
		private DangoBrawlCombineRowData Row;

		// Token: 0x0401D195 RID: 119189
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B2E8 RID: 45800
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037466 RID: 226406
			BtnCombine,
			// Token: 0x04037467 RID: 226407
			PnlNormal,
			// Token: 0x04037468 RID: 226408
			PnlLock,
			// Token: 0x04037469 RID: 226409
			TxtCombine
		}
	}
}
