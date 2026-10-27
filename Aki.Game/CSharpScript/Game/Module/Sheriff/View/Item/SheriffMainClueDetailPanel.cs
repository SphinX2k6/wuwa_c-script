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
	// Token: 0x02004C6A RID: 19562
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMainClueDetailPanel : UiTabViewBase
	{
		// Token: 0x0603291D RID: 207133 RVA: 0x00BC91C4 File Offset: 0x00BC73C4
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

		// Token: 0x0603291E RID: 207134 RVA: 0x00BC9398 File Offset: 0x00BC7598
		protected override void OnStart()
		{
			this.Proxy = (this.ExtraParams as SheriffMainProxy);
			this.PagePointLayout = new GenericLayout<SheriffMainCluePagePoint, bool>(base.GetHorizontalLayout(4), new Func<SheriffMainCluePagePoint>(this.CreatePagePointItem), null, false, true);
			SheriffAnomalyInfo anomalyInfo = this.Proxy.GetAnomalyInfo();
			this.AnomalyInfo = anomalyInfo;
			this.DataList = SheriffModel.Instance.GetClueListByAnomalyId(anomalyInfo.AnomalyId);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603291F RID: 207135 RVA: 0x00BC9414 File Offset: 0x00BC7614
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

		// Token: 0x06032920 RID: 207136 RVA: 0x00BC9494 File Offset: 0x00BC7694
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

		// Token: 0x06032921 RID: 207137 RVA: 0x00BC9612 File Offset: 0x00BC7812
		private SheriffMainCluePagePoint CreatePagePointItem()
		{
			return new SheriffMainCluePagePoint();
		}

		// Token: 0x06032922 RID: 207138 RVA: 0x00BC961C File Offset: 0x00BC781C
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

		// Token: 0x06032923 RID: 207139 RVA: 0x00BC968C File Offset: 0x00BC788C
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

		// Token: 0x06032924 RID: 207140 RVA: 0x00BC96F0 File Offset: 0x00BC78F0
		private void OnClickBtnBackB2()
		{
			this.Proxy.CloseClueDetail();
		}

		// Token: 0x0401AE90 RID: 110224
		[Nullable(2)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AE91 RID: 110225
		[Nullable(2)]
		protected SheriffAnomalyInfo AnomalyInfo;

		// Token: 0x0401AE92 RID: 110226
		protected List<int> DataList = new List<int>();

		// Token: 0x0401AE93 RID: 110227
		protected int CurIndex;

		// Token: 0x0401AE94 RID: 110228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffMainCluePagePoint, bool> PagePointLayout;

		// Token: 0x0401AE95 RID: 110229
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AE1D RID: 44573
		[NullableContext(0)]
		private static class EDefine
		{
			// Token: 0x04034E13 RID: 216595
			public const int BtnPageArrowRight = 0;

			// Token: 0x04034E14 RID: 216596
			public const int BtnPageArrowLeft = 1;

			// Token: 0x04034E15 RID: 216597
			public const int TexIcon = 2;

			// Token: 0x04034E16 RID: 216598
			public const int TxtLock = 3;

			// Token: 0x04034E17 RID: 216599
			public const int PanelPage = 4;

			// Token: 0x04034E18 RID: 216600
			public const int ItemPoint = 5;

			// Token: 0x04034E19 RID: 216601
			public const int TxtName = 6;

			// Token: 0x04034E1A RID: 216602
			public const int TxtInfo = 7;

			// Token: 0x04034E1B RID: 216603
			public const int BtnBackB2 = 8;
		}
	}
}
