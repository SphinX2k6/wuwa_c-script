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
	// Token: 0x02004C5B RID: 19547
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffShowClueViewPanel : UiPanelBase
	{
		// Token: 0x0603288E RID: 206990 RVA: 0x00BC5DAC File Offset: 0x00BC3FAC
		public SheriffShowClueViewPanel(List<int> dataList, int? inputClue = null)
		{
			this.DataList = dataList;
			if (inputClue != null && inputClue.Value != 0)
			{
				this.CurIndex = this.DataList.IndexOf(inputClue.Value);
			}
		}

		// Token: 0x0603288F RID: 206991 RVA: 0x00BC5DE8 File Offset: 0x00BC3FE8
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

		// Token: 0x06032890 RID: 206992 RVA: 0x00BC5FBC File Offset: 0x00BC41BC
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.PagePointLayout = new GenericLayout<SheriffMainCluePagePoint, bool>(base.GetHorizontalLayout(4), new Func<SheriffMainCluePagePoint>(this.CreatePagePointItem), null, false, true);
		}

		// Token: 0x06032891 RID: 206993 RVA: 0x00BC5FF0 File Offset: 0x00BC41F0
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

		// Token: 0x06032892 RID: 206994 RVA: 0x00BC608C File Offset: 0x00BC428C
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

		// Token: 0x06032893 RID: 206995 RVA: 0x00BC620E File Offset: 0x00BC440E
		private SheriffMainCluePagePoint CreatePagePointItem()
		{
			return new SheriffMainCluePagePoint();
		}

		// Token: 0x06032894 RID: 206996 RVA: 0x00BC6218 File Offset: 0x00BC4418
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

		// Token: 0x06032895 RID: 206997 RVA: 0x00BC6288 File Offset: 0x00BC4488
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

		// Token: 0x06032896 RID: 206998 RVA: 0x00BC62EC File Offset: 0x00BC44EC
		private void OnClickBtnBackB2()
		{
			Action closeCallBack = this.CloseCallBack;
			if (closeCallBack == null)
			{
				return;
			}
			closeCallBack();
		}

		// Token: 0x0401AE64 RID: 110180
		[Nullable(2)]
		public Action CloseCallBack;

		// Token: 0x0401AE65 RID: 110181
		protected int CurIndex;

		// Token: 0x0401AE66 RID: 110182
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AE67 RID: 110183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SheriffMainCluePagePoint, bool> PagePointLayout;

		// Token: 0x0401AE68 RID: 110184
		protected List<int> DataList;

		// Token: 0x0200AE00 RID: 44544
		[NullableContext(0)]
		private static class EPanelDefine
		{
			// Token: 0x04034D9A RID: 216474
			public const int BtnPageArrowRight = 0;

			// Token: 0x04034D9B RID: 216475
			public const int BtnPageArrowLeft = 1;

			// Token: 0x04034D9C RID: 216476
			public const int TexIcon = 2;

			// Token: 0x04034D9D RID: 216477
			public const int TxtLock = 3;

			// Token: 0x04034D9E RID: 216478
			public const int PanelPage = 4;

			// Token: 0x04034D9F RID: 216479
			public const int ItemPoint = 5;

			// Token: 0x04034DA0 RID: 216480
			public const int TxtName = 6;

			// Token: 0x04034DA1 RID: 216481
			public const int TxtInfo = 7;

			// Token: 0x04034DA2 RID: 216482
			public const int BtnBackB2 = 8;
		}
	}
}
