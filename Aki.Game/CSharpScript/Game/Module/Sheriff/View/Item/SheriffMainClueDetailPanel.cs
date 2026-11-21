using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C1B RID: 15387
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainClueDetailPanel : UiTabViewBase
	{
		// Token: 0x060276D0 RID: 161488 RVA: 0x00B0DE28 File Offset: 0x00B0C028
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnPageRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnPageLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnBackB2));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060276D1 RID: 161489 RVA: 0x00B0DFFC File Offset: 0x00B0C1FC
		protected override void OnStart()
		{
			this.Proxy = (this.ExtraParams as SheriffMainProxy);
			this.PagePointLayout = new GenericLayout<SheriffMainCluePagePoint, bool>(base.GetHorizontalLayout(4), new Func<SheriffMainCluePagePoint>(this.CreatePagePointItem), null, false, true);
			SheriffAnomalyInfo anomalyInfo = this.Proxy.GetAnomalyInfo();
			this.AnomalyInfo = anomalyInfo;
			this.DataList = SheriffModel.Instance.GetClueListByAnomalyId(anomalyInfo.AnomalyId);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060276D2 RID: 161490 RVA: 0x00B0E078 File Offset: 0x00B0C278
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
			}
			this.CurIndex = this.Proxy.CurrentClickedClueIndex;
			List<bool> list = new List<bool>();
			for (int i = 0; i < this.DataList.Count; i++)
			{
				list.Add(i == this.CurIndex);
			}
			this.PagePointLayout.RefreshByData(list, null, false);
			this.RefreshClueDetail();
		}

		// Token: 0x060276D3 RID: 161491 RVA: 0x00B0E0F8 File Offset: 0x00B0C2F8
		protected void RefreshClueDetail()
		{
			bool uiactive = this.CurIndex > 0;
			bool uiactive2 = this.CurIndex < this.DataList.Count - 1;
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive2);
			}
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(uiactive);
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
			bool flag = this.AnomalyInfo.ClueIds.Contains(this.DataList[this.CurIndex]);
			base.GetTexture(2).SetUIActive(flag);
			base.GetText(3).SetUIActive(!flag);
			FColor changeColor = base.GetText(6).changeColor;
			UUIItem text = base.GetText(6);
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
			if (!flag)
			{
				base.GetText(6).ShowTextNew("Inference_Desc_6");
				base.GetText(7).ShowTextNew("Inference_Desc_7");
				return;
			}
			SheriffClue value = SheriffConfig.Instance.GetClueConfigById(this.DataList[this.CurIndex]).Value;
			base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
			base.GetText(6).ShowTextNew(value.Name);
			base.GetText(7).ShowTextNew(value.Desc);
		}

		// Token: 0x060276D4 RID: 161492 RVA: 0x00B0E276 File Offset: 0x00B0C476
		private SheriffMainCluePagePoint CreatePagePointItem()
		{
			return new SheriffMainCluePagePoint();
		}

		// Token: 0x060276D5 RID: 161493 RVA: 0x00B0E280 File Offset: 0x00B0C480
		private void OnClickBtnPageRight()
		{
			if (this.CurIndex >= this.DataList.Count - 1)
			{
				return;
			}
			this.CurIndex++;
			List<bool> list = new List<bool>();
			for (int i = 0; i < this.DataList.Count; i++)
			{
				list.Add(i == this.CurIndex);
			}
			this.PagePointLayout.RefreshByData(list, null, false);
			this.RefreshClueDetail();
		}

		// Token: 0x060276D6 RID: 161494 RVA: 0x00B0E2F0 File Offset: 0x00B0C4F0
		private void OnClickBtnPageLeft()
		{
			if (this.CurIndex <= 0)
			{
				return;
			}
			this.CurIndex--;
			List<bool> list = new List<bool>();
			for (int i = 0; i < this.DataList.Count; i++)
			{
				list.Add(i == this.CurIndex);
			}
			this.PagePointLayout.RefreshByData(list, null, false);
			this.RefreshClueDetail();
		}

		// Token: 0x060276D7 RID: 161495 RVA: 0x00B0E354 File Offset: 0x00B0C554
		private void OnClickBtnBackB2()
		{
			this.Proxy.CloseClueDetail();
		}

		// Token: 0x040157ED RID: 88045
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x040157EE RID: 88046
		[Nullable(2)]
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x040157EF RID: 88047
		protected List<int> DataList = new List<int>();

		// Token: 0x040157F0 RID: 88048
		protected int CurIndex;

		// Token: 0x040157F1 RID: 88049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffMainCluePagePoint, bool> PagePointLayout;

		// Token: 0x040157F2 RID: 88050
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200983B RID: 38971
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x0402F7B8 RID: 194488
			public const int BtnPageArrowRight = 0;

			// Token: 0x0402F7B9 RID: 194489
			public const int BtnPageArrowLeft = 1;

			// Token: 0x0402F7BA RID: 194490
			public const int TexIcon = 2;

			// Token: 0x0402F7BB RID: 194491
			public const int TxtLock = 3;

			// Token: 0x0402F7BC RID: 194492
			public const int PanelPage = 4;

			// Token: 0x0402F7BD RID: 194493
			public const int ItemPoint = 5;

			// Token: 0x0402F7BE RID: 194494
			public const int TxtName = 6;

			// Token: 0x0402F7BF RID: 194495
			public const int TxtInfo = 7;

			// Token: 0x0402F7C0 RID: 194496
			public const int BtnBackB2 = 8;
		}
	}
}
