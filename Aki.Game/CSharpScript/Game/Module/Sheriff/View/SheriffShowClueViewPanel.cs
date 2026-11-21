using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Sheriff.View.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C0C RID: 15372
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffShowClueViewPanel : UiPanelBase
	{
		// Token: 0x06027641 RID: 161345 RVA: 0x00B0A9F8 File Offset: 0x00B08BF8
		public SheriffShowClueViewPanel(List<int> dataList, int? inputClue = null)
		{
			this.DataList = dataList;
			if (inputClue != null && inputClue.Value != 0)
			{
				this.CurIndex = this.DataList.IndexOf(inputClue.Value);
			}
		}

		// Token: 0x06027642 RID: 161346 RVA: 0x00B0AA34 File Offset: 0x00B08C34
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

		// Token: 0x06027643 RID: 161347 RVA: 0x00B0AC08 File Offset: 0x00B08E08
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.PagePointLayout = new GenericLayout<SheriffMainCluePagePoint, bool>(base.GetHorizontalLayout(4), new Func<SheriffMainCluePagePoint>(this.CreatePagePointItem), null, false, true);
		}

		// Token: 0x06027644 RID: 161348 RVA: 0x00B0AC3C File Offset: 0x00B08E3C
		protected override void OnBeforeShow()
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
			if (this.CurIndex <= 0)
			{
				for (int i = 0; i < this.DataList.Count; i++)
				{
					if (this.DataList[i] != 0)
					{
						this.CurIndex = i;
						break;
					}
				}
			}
			List<bool> list = new List<bool>();
			for (int j = 0; j < this.DataList.Count; j++)
			{
				list.Add(j == this.CurIndex);
			}
			this.PagePointLayout.RefreshByData(list, null, false);
			this.RefreshClueDetail();
		}

		// Token: 0x06027645 RID: 161349 RVA: 0x00B0ACD8 File Offset: 0x00B08ED8
		protected void RefreshClueDetail()
		{
			if (this.DataList.Count == 0)
			{
				return;
			}
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
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
			int num = this.DataList[this.CurIndex];
			base.GetTexture(2).SetUIActive(num != 0);
			base.GetText(3).SetUIActive(num == 0);
			FColor changeColor = base.GetText(6).changeColor;
			UUIItem text = base.GetText(6);
			bool bUseChangeColor = num != 0;
			FColor? fcolor = new FColor?(changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
			if (num == 0)
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

		// Token: 0x06027646 RID: 161350 RVA: 0x00B0AE5A File Offset: 0x00B0905A
		private SheriffMainCluePagePoint CreatePagePointItem()
		{
			return new SheriffMainCluePagePoint();
		}

		// Token: 0x06027647 RID: 161351 RVA: 0x00B0AE64 File Offset: 0x00B09064
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

		// Token: 0x06027648 RID: 161352 RVA: 0x00B0AED4 File Offset: 0x00B090D4
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

		// Token: 0x06027649 RID: 161353 RVA: 0x00B0AF38 File Offset: 0x00B09138
		private void OnClickBtnBackB2()
		{
			Action closeCallBack = this.CloseCallBack;
			if (closeCallBack == null)
			{
				return;
			}
			closeCallBack();
		}

		// Token: 0x040157C1 RID: 88001
		[Nullable(2)]
		public Action CloseCallBack;

		// Token: 0x040157C2 RID: 88002
		protected int CurIndex;

		// Token: 0x040157C3 RID: 88003
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040157C4 RID: 88004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffMainCluePagePoint, bool> PagePointLayout;

		// Token: 0x040157C5 RID: 88005
		protected List<int> DataList;

		// Token: 0x0200981E RID: 38942
		[NullableContext(0)]
		private static class EPanelDefine
		{
			// Token: 0x0402F73F RID: 194367
			public const int BtnPageArrowRight = 0;

			// Token: 0x0402F740 RID: 194368
			public const int BtnPageArrowLeft = 1;

			// Token: 0x0402F741 RID: 194369
			public const int TexIcon = 2;

			// Token: 0x0402F742 RID: 194370
			public const int TxtLock = 3;

			// Token: 0x0402F743 RID: 194371
			public const int PanelPage = 4;

			// Token: 0x0402F744 RID: 194372
			public const int ItemPoint = 5;

			// Token: 0x0402F745 RID: 194373
			public const int TxtName = 6;

			// Token: 0x0402F746 RID: 194374
			public const int TxtInfo = 7;

			// Token: 0x0402F747 RID: 194375
			public const int BtnBackB2 = 8;
		}
	}
}
