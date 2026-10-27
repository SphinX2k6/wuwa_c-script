using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FA RID: 26618
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCardItem : GridProxyAbstract<DangoBrawlCardItemData>
	{
		// Token: 0x06042638 RID: 271928 RVA: 0x0101F030 File Offset: 0x0101D230
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickCard));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042639 RID: 271929 RVA: 0x0101F19C File Offset: 0x0101D39C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCardItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCardItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604263A RID: 271930 RVA: 0x0101F1DF File Offset: 0x0101D3DF
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleExecuteChange());
			this.CreateSequencePlayer();
		}

		// Token: 0x0604263B RID: 271931 RVA: 0x0101F204 File Offset: 0x0101D404
		protected override void OnBeforeDestroy()
		{
			this.ClearHyperlinkBind();
			this.ClearSequencePlayer();
		}

		// Token: 0x0604263C RID: 271932 RVA: 0x0101F214 File Offset: 0x0101D414
		private void CreateSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x0604263D RID: 271933 RVA: 0x0101F23E File Offset: 0x0101D43E
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0604263E RID: 271934 RVA: 0x0101F258 File Offset: 0x0101D458
		[NullableContext(1)]
		public override void Refresh(DangoBrawlCardItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Index = gridIndex;
			DangoBrawlShopEvt? shopEvtConfigById = DangoBrawlConfig.Instance.GetShopEvtConfigById(data.CardId);
			if (shopEvtConfigById == null)
			{
				return;
			}
			this.RefreshHyperlinkBind(shopEvtConfigById.Value.HyperLinkType);
			base.SetTextureByPath(shopEvtConfigById.Value.Icon, base.GetTexture(1), null, null);
			base.SetTextureByPath(shopEvtConfigById.Value.QualityBg, base.GetTexture(5), null, null);
			base.SetTextureByPath(shopEvtConfigById.Value.QualityCircle, base.GetTexture(7), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), shopEvtConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), shopEvtConfigById.Value.Desc, Array.Empty<object>());
			DangoBrawlCardRefreshBtn cardRefreshBtn = this.CardRefreshBtn;
			if (cardRefreshBtn != null)
			{
				cardRefreshBtn.RefreshRemain(data.RemainRefreshCount);
			}
			DangoBrawlCardRefreshBtn cardRefreshBtn2 = this.CardRefreshBtn;
			if (cardRefreshBtn2 != null)
			{
				cardRefreshBtn2.SetRefreshCallback(new Action(this.OnClickRefresh));
			}
			bool interactive = data.RemainRefreshCount > 0;
			DangoBrawlCardRefreshBtn cardRefreshBtn3 = this.CardRefreshBtn;
			if (cardRefreshBtn3 != null)
			{
				cardRefreshBtn3.SetInteractive(interactive);
			}
			string text = "";
			int quality = shopEvtConfigById.Value.Quality;
			if (quality != 4)
			{
				if (quality == 5)
				{
					text = "StartB";
				}
			}
			else
			{
				text = "StartA";
			}
			if (!string.IsNullOrEmpty(text))
			{
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.PlaySequencePurely(text, false, false);
				}
			}
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			int roleId = (myActivityData != null) ? myActivityData.GetRoleId() : 0;
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(DangoBrawlRecommendUtil.IsEvtRecommended(data.CardId, roleId));
		}

		// Token: 0x0604263F RID: 271935 RVA: 0x0101F43C File Offset: 0x0101D63C
		private void RefreshHyperlinkBind(int hyperLinkType)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			this.ClearHyperlinkBind();
			if (hyperLinkType == 1)
			{
				text.OnHyperLinkClickCallBack.Bind(new Func<string, bool>(this.OnHyperLinkItemTipsClick));
				text.SetRichText(true);
				text.SetEnableHyperLinksHighlight(true);
				text.bFilterHyperLinks = false;
				text.HyperLinksHoverColor = FColor.FromHex("FED93E4C");
				return;
			}
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(text);
		}

		// Token: 0x06042640 RID: 271936 RVA: 0x0101F4A8 File Offset: 0x0101D6A8
		private void ClearHyperlinkBind()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(text);
			text.OnHyperLinkClickCallBack.Unbind();
		}

		// Token: 0x06042641 RID: 271937 RVA: 0x0101F4D8 File Offset: 0x0101D6D8
		[NullableContext(1)]
		private bool OnHyperLinkItemTipsClick(string hyperLinkId)
		{
			int key;
			if (!int.TryParse(hyperLinkId, out key) || this.Data == null)
			{
				return false;
			}
			DangoBrawlShopEvt? shopEvtConfigById = DangoBrawlConfig.Instance.GetShopEvtConfigById(this.Data.CardId);
			if (shopEvtConfigById == null)
			{
				return true;
			}
			int valueOrDefault = shopEvtConfigById.Value.GetTerm2ItemId(key).GetValueOrDefault();
			if (valueOrDefault <= 0)
			{
				return true;
			}
			UUIText text = base.GetText(3);
			Action<int, UUIItem> clickCardHyperlinkCallBack = this.ClickCardHyperlinkCallBack;
			if (clickCardHyperlinkCallBack != null)
			{
				clickCardHyperlinkCallBack(valueOrDefault, text);
			}
			return true;
		}

		// Token: 0x06042642 RID: 271938 RVA: 0x0101F557 File Offset: 0x0101D757
		public void PlayChooseSeq()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("ChooseB", false, false);
		}

		// Token: 0x06042643 RID: 271939 RVA: 0x0101F570 File Offset: 0x0101D770
		private void OnClickRefresh()
		{
			DangoBrawlCardItemData data = this.Data;
			if (data != null && data.RemainRefreshCount <= 0)
			{
				return;
			}
			ActivityDangoBrawlController.Instance.RequestEventRefresh(this.Index).Forget<bool>();
		}

		// Token: 0x06042644 RID: 271940 RVA: 0x0101F5A2 File Offset: 0x0101D7A2
		private void OnClickCard(EToggleState toggleState)
		{
			Action<int> clickCardCallBack = this.ClickCardCallBack;
			if (clickCardCallBack == null)
			{
				return;
			}
			clickCardCallBack(this.Index);
		}

		// Token: 0x06042645 RID: 271941 RVA: 0x0101F5BA File Offset: 0x0101D7BA
		public void SetToggleState(bool bSelectOn, bool bFireEvent = true)
		{
			this.RefreshToggleState(bSelectOn, bFireEvent);
		}

		// Token: 0x06042646 RID: 271942 RVA: 0x0101F5C4 File Offset: 0x0101D7C4
		private void RefreshToggleState(bool selectOn, bool bFireEvent = false)
		{
			EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x06042647 RID: 271943 RVA: 0x0101F5EA File Offset: 0x0101D7EA
		[NullableContext(1)]
		public void BindCanToggleExecuteChange(Func<int, bool> func)
		{
			this.CanToggleExecuteChangeInternal = func;
		}

		// Token: 0x06042648 RID: 271944 RVA: 0x0101F5F3 File Offset: 0x0101D7F3
		private bool CanToggleExecuteChange()
		{
			Func<int, bool> canToggleExecuteChangeInternal = this.CanToggleExecuteChangeInternal;
			return canToggleExecuteChangeInternal == null || canToggleExecuteChangeInternal(this.Index);
		}

		// Token: 0x040229B6 RID: 141750
		public DangoBrawlCardItemData Data;

		// Token: 0x040229B7 RID: 141751
		private int Index;

		// Token: 0x040229B8 RID: 141752
		private Func<int, bool> CanToggleExecuteChangeInternal;

		// Token: 0x040229B9 RID: 141753
		public Action<int> ClickCardCallBack;

		// Token: 0x040229BA RID: 141754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIItem> ClickCardHyperlinkCallBack;

		// Token: 0x040229BB RID: 141755
		private DangoBrawlCardRefreshBtn CardRefreshBtn;

		// Token: 0x040229BC RID: 141756
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C967 RID: 51559
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403CD11 RID: 249105
			TogCommon,
			// Token: 0x0403CD12 RID: 249106
			TexIcon,
			// Token: 0x0403CD13 RID: 249107
			TxtName,
			// Token: 0x0403CD14 RID: 249108
			TxtDescript,
			// Token: 0x0403CD15 RID: 249109
			RefreshBtnItem,
			// Token: 0x0403CD16 RID: 249110
			TexCardBg,
			// Token: 0x0403CD17 RID: 249111
			Recommend,
			// Token: 0x0403CD18 RID: 249112
			TexRing
		}
	}
}
