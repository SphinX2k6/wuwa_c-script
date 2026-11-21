using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C23 RID: 15395
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffClueItem : GridProxyAbstract<int>
	{
		// Token: 0x060276FD RID: 161533 RVA: 0x00B0EFEB File Offset: 0x00B0D1EB
		[NullableContext(1)]
		public SheriffClueItem(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x060276FE RID: 161534 RVA: 0x00B0EFFC File Offset: 0x00B0D1FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnCommon));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060276FF RID: 161535 RVA: 0x00B0F128 File Offset: 0x00B0D328
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			base.GetExtendToggle(0).OnHover.Add(new Action(this.OnHoverItem));
		}

		// Token: 0x06027700 RID: 161536 RVA: 0x00B0F18C File Offset: 0x00B0D38C
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
				extendToggle.CanExecuteChange.Unbind();
				extendToggle.OnHover.Remove(new Action(this.OnHoverItem));
			}
		}

		// Token: 0x06027701 RID: 161537 RVA: 0x00B0F1E0 File Offset: 0x00B0D3E0
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.CurId = data;
			base.GetItem(3).SetUIActive(data <= 0);
			if (data <= 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Inference_Desc_6", Array.Empty<object>());
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
			}
			else
			{
				SheriffClue? clueConfigById = SheriffConfig.Instance.GetClueConfigById(data);
				if (clueConfigById == null)
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), clueConfigById.Value.Name, Array.Empty<object>());
				UUITexture texture2 = base.GetTexture(2);
				if (texture2 != null)
				{
					texture2.SetUIActive(true);
				}
				base.SetTextureByPath(clueConfigById.Value.Icon, base.GetTexture(2), null, null);
			}
			bool flag = true;
			if (this.CheckSelectCallback != null)
			{
				EToggleState etoggleState = this.CheckSelectCallback(gridIndex);
				this.SetSelected(etoggleState, true);
				flag = (etoggleState != EToggleState.ETT_UnDetermined);
			}
			base.GetItem(5).SetUIActive(flag && this.Proxy.CheckIsHinting(this.CurId));
		}

		// Token: 0x06027702 RID: 161538 RVA: 0x00B0F2FC File Offset: 0x00B0D4FC
		public void RefreshSelected()
		{
			if (this.CheckSelectCallback != null)
			{
				this.SetSelected(this.CheckSelectCallback(base.GridIndex), false);
			}
		}

		// Token: 0x06027703 RID: 161539 RVA: 0x00B0F31E File Offset: 0x00B0D51E
		protected void SetSelected(EToggleState state, bool jumpToLastFrame = true)
		{
			base.GetExtendToggle(0).SetActive(state != EToggleState.ETT_UnDetermined, false);
			base.GetExtendToggle(0).SetToggleState(state, false, false, jumpToLastFrame);
		}

		// Token: 0x06027704 RID: 161540 RVA: 0x00B0F345 File Offset: 0x00B0D545
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int, bool> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.CurId, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06027705 RID: 161541 RVA: 0x00B0F364 File Offset: 0x00B0D564
		private bool OnCanExecuteChange()
		{
			EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
			Func<int, EToggleState, bool> checkCanChangeCallback = this.CheckCanChangeCallback;
			return checkCanChangeCallback == null || checkCanChangeCallback(this.CurId, toggleState);
		}

		// Token: 0x06027706 RID: 161542 RVA: 0x00B0F396 File Offset: 0x00B0D596
		private void OnHoverItem()
		{
			if (Info.Instance.IsInGamepad())
			{
				this.Proxy.OnHoverClue(base.GridIndex);
			}
		}

		// Token: 0x06027707 RID: 161543 RVA: 0x00B0F3B5 File Offset: 0x00B0D5B5
		private void OnClickBtnCommon()
		{
			this.Proxy.ClickClueDetail(base.GridIndex);
		}

		// Token: 0x06027708 RID: 161544 RVA: 0x00B0F3C8 File Offset: 0x00B0D5C8
		public UUIItem GetGuideMagnifierItem()
		{
			UUIButtonComponent button = base.GetButton(4);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x04015800 RID: 88064
		protected int CurId;

		// Token: 0x04015801 RID: 88065
		[Nullable(1)]
		protected SheriffMainProxy Proxy;

		// Token: 0x04015802 RID: 88066
		public Action<int, bool> OnToggleStateChangedCallback;

		// Token: 0x04015803 RID: 88067
		public Func<int, EToggleState, bool> CheckCanChangeCallback;

		// Token: 0x04015804 RID: 88068
		public Func<int, EToggleState> CheckSelectCallback;

		// Token: 0x04015805 RID: 88069
		public Func<bool> CheckToggleEnable;

		// Token: 0x02009843 RID: 38979
		[NullableContext(0)]
		private static class EClueItem
		{
			// Token: 0x0402F7DA RID: 194522
			public const int Tog = 0;

			// Token: 0x0402F7DB RID: 194523
			public const int TxtName = 1;

			// Token: 0x0402F7DC RID: 194524
			public const int TxtIcon = 2;

			// Token: 0x0402F7DD RID: 194525
			public const int PanelLock = 3;

			// Token: 0x0402F7DE RID: 194526
			public const int BtnCommon = 4;

			// Token: 0x0402F7DF RID: 194527
			public const int PanelHint = 5;
		}
	}
}
