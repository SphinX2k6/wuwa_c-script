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
	// Token: 0x0200574A RID: 22346
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlCardItem : GridProxyAbstract<DangoBrawlCardItemData>
	{
		// Token: 0x0603718D RID: 225677 RVA: 0x00F60574 File Offset: 0x00F5E774
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

		// Token: 0x0603718E RID: 225678 RVA: 0x00F606E0 File Offset: 0x00F5E8E0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlCardItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlCardItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603718F RID: 225679 RVA: 0x00F60723 File Offset: 0x00F5E923
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => this.CanToggleExecuteChange());
			this.CreateSequencePlayer();
		}

		// Token: 0x06037190 RID: 225680 RVA: 0x00F60748 File Offset: 0x00F5E948
		protected override void OnBeforeDestroy()
		{
			this.ClearHyperlinkBind();
			this.ClearSequencePlayer();
		}

		// Token: 0x06037191 RID: 225681 RVA: 0x00F60758 File Offset: 0x00F5E958
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

		// Token: 0x06037192 RID: 225682 RVA: 0x00F60782 File Offset: 0x00F5E982
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06037193 RID: 225683 RVA: 0x00F6079C File Offset: 0x00F5E99C
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

		// Token: 0x06037194 RID: 225684 RVA: 0x00F60980 File Offset: 0x00F5EB80
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

		// Token: 0x06037195 RID: 225685 RVA: 0x00F609EC File Offset: 0x00F5EBEC
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

		// Token: 0x06037196 RID: 225686 RVA: 0x00F60A1C File Offset: 0x00F5EC1C
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

		// Token: 0x06037197 RID: 225687 RVA: 0x00F60A9B File Offset: 0x00F5EC9B
		public void PlayChooseSeq()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("ChooseB", false, false);
		}

		// Token: 0x06037198 RID: 225688 RVA: 0x00F60AB4 File Offset: 0x00F5ECB4
		private void OnClickRefresh()
		{
			DangoBrawlCardItemData data = this.Data;
			if (data != null && data.RemainRefreshCount <= 0)
			{
				return;
			}
			ActivityDangoBrawlController.Instance.RequestEventRefresh(this.Index).Forget<bool>();
		}

		// Token: 0x06037199 RID: 225689 RVA: 0x00F60AE6 File Offset: 0x00F5ECE6
		private void OnClickCard(EToggleState toggleState)
		{
			Action<int> clickCardCallBack = this.ClickCardCallBack;
			if (clickCardCallBack == null)
			{
				return;
			}
			clickCardCallBack(this.Index);
		}

		// Token: 0x0603719A RID: 225690 RVA: 0x00F60AFE File Offset: 0x00F5ECFE
		public void SetToggleState(bool bSelectOn, bool bFireEvent = true)
		{
			this.RefreshToggleState(bSelectOn, bFireEvent);
		}

		// Token: 0x0603719B RID: 225691 RVA: 0x00F60B08 File Offset: 0x00F5ED08
		private void RefreshToggleState(bool selectOn, bool bFireEvent = false)
		{
			EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x0603719C RID: 225692 RVA: 0x00F60B2E File Offset: 0x00F5ED2E
		[NullableContext(1)]
		public void BindCanToggleExecuteChange(Func<int, bool> func)
		{
			this.CanToggleExecuteChangeInternal = func;
		}

		// Token: 0x0603719D RID: 225693 RVA: 0x00F60B37 File Offset: 0x00F5ED37
		private bool CanToggleExecuteChange()
		{
			Func<int, bool> canToggleExecuteChangeInternal = this.CanToggleExecuteChangeInternal;
			return canToggleExecuteChangeInternal == null || canToggleExecuteChangeInternal(this.Index);
		}

		// Token: 0x0401D213 RID: 119315
		public DangoBrawlCardItemData Data;

		// Token: 0x0401D214 RID: 119316
		private int Index;

		// Token: 0x0401D215 RID: 119317
		private Func<int, bool> CanToggleExecuteChangeInternal;

		// Token: 0x0401D216 RID: 119318
		public Action<int> ClickCardCallBack;

		// Token: 0x0401D217 RID: 119319
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIItem> ClickCardHyperlinkCallBack;

		// Token: 0x0401D218 RID: 119320
		private DangoBrawlCardRefreshBtn CardRefreshBtn;

		// Token: 0x0401D219 RID: 119321
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B334 RID: 45876
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040375FE RID: 226814
			TogCommon,
			// Token: 0x040375FF RID: 226815
			TexIcon,
			// Token: 0x04037600 RID: 226816
			TxtName,
			// Token: 0x04037601 RID: 226817
			TxtDescript,
			// Token: 0x04037602 RID: 226818
			RefreshBtnItem,
			// Token: 0x04037603 RID: 226819
			TexCardBg,
			// Token: 0x04037604 RID: 226820
			Recommend,
			// Token: 0x04037605 RID: 226821
			TexRing
		}
	}
}
