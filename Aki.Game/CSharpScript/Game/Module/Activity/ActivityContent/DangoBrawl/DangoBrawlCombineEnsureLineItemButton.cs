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
	// Token: 0x020067E9 RID: 26601
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlCombineEnsureLineItemButton : UiPanelBase
	{
		// Token: 0x17009704 RID: 38660
		// (get) Token: 0x0604245A RID: 271450 RVA: 0x01015EE4 File Offset: 0x010140E4
		[Nullable(2)]
		protected DangoBrawlTouchController Touch
		{
			[NullableContext(2)]
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x0604245B RID: 271451 RVA: 0x01015EF0 File Offset: 0x010140F0
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

		// Token: 0x0604245C RID: 271452 RVA: 0x01015FD8 File Offset: 0x010141D8
		protected override void OnStart()
		{
			ActivityDangoBrawlData activityDangoBrawlData = this.OpenParam as ActivityDangoBrawlData;
			if (activityDangoBrawlData != null)
			{
				this.ActData = activityDangoBrawlData;
			}
			this.InitSequencePlayer();
		}

		// Token: 0x0604245D RID: 271453 RVA: 0x01016001 File Offset: 0x01014201
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x0604245E RID: 271454 RVA: 0x0101600C File Offset: 0x0101420C
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

		// Token: 0x0604245F RID: 271455 RVA: 0x010160A0 File Offset: 0x010142A0
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

		// Token: 0x06042460 RID: 271456 RVA: 0x010160F8 File Offset: 0x010142F8
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06042461 RID: 271457 RVA: 0x01016112 File Offset: 0x01014312
		private void OnStartSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06042462 RID: 271458 RVA: 0x01016114 File Offset: 0x01014314
		private void OnEndSequenceEvent(string sequenceStartEvent)
		{
		}

		// Token: 0x06042463 RID: 271459 RVA: 0x01016118 File Offset: 0x01014318
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

		// Token: 0x04022936 RID: 141622
		private ActivityDangoBrawlData ActData;

		// Token: 0x04022937 RID: 141623
		private DangoBrawlCombineRowData Row;

		// Token: 0x04022938 RID: 141624
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C91A RID: 51482
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CB75 RID: 248693
			BtnCombine,
			// Token: 0x0403CB76 RID: 248694
			PnlNormal,
			// Token: 0x0403CB77 RID: 248695
			PnlLock,
			// Token: 0x0403CB78 RID: 248696
			TxtCombine
		}
	}
}
