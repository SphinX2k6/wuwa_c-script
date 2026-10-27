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
	// Token: 0x02004C72 RID: 19570
	[NullableContext(2)]
	[Nullable(0)]
	public class SheriffClueItem : GridProxyAbstract<int>
	{
		// Token: 0x0603294A RID: 207178 RVA: 0x00BCA387 File Offset: 0x00BC8587
		[NullableContext(1)]
		public SheriffClueItem(SheriffMainProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0603294B RID: 207179 RVA: 0x00BCA398 File Offset: 0x00BC8598
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

		// Token: 0x0603294C RID: 207180 RVA: 0x00BCA4C4 File Offset: 0x00BC86C4
		protected override void OnStart()
		{
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			base.GetExtendToggle(0).OnHover.Add(new Action(this.OnHoverItem));
		}

		// Token: 0x0603294D RID: 207181 RVA: 0x00BCA528 File Offset: 0x00BC8728
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

		// Token: 0x0603294E RID: 207182 RVA: 0x00BCA57C File Offset: 0x00BC877C
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

		// Token: 0x0603294F RID: 207183 RVA: 0x00BCA698 File Offset: 0x00BC8898
		public void RefreshSelected()
		{
			if (this.CheckSelectCallback != null)
			{
				this.SetSelected(this.CheckSelectCallback(base.GridIndex), false);
			}
		}

		// Token: 0x06032950 RID: 207184 RVA: 0x00BCA6BA File Offset: 0x00BC88BA
		protected void SetSelected(EToggleState state, bool jumpToLastFrame = true)
		{
			base.GetExtendToggle(0).SetActive(state != EToggleState.ETT_UnDetermined, false);
			base.GetExtendToggle(0).SetToggleState(state, false, false, jumpToLastFrame);
		}

		// Token: 0x06032951 RID: 207185 RVA: 0x00BCA6E1 File Offset: 0x00BC88E1
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int, bool> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.CurId, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06032952 RID: 207186 RVA: 0x00BCA700 File Offset: 0x00BC8900
		private bool OnCanExecuteChange()
		{
			EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
			Func<int, EToggleState, bool> checkCanChangeCallback = this.CheckCanChangeCallback;
			return checkCanChangeCallback == null || checkCanChangeCallback(this.CurId, toggleState);
		}

		// Token: 0x06032953 RID: 207187 RVA: 0x00BCA732 File Offset: 0x00BC8932
		private void OnHoverItem()
		{
			if (Info.Instance.IsInGamepad())
			{
				this.Proxy.OnHoverClue(base.GridIndex);
			}
		}

		// Token: 0x06032954 RID: 207188 RVA: 0x00BCA751 File Offset: 0x00BC8951
		private void OnClickBtnCommon()
		{
			this.Proxy.ClickClueDetail(base.GridIndex);
		}

		// Token: 0x06032955 RID: 207189 RVA: 0x00BCA764 File Offset: 0x00BC8964
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

		// Token: 0x0401AEA3 RID: 110243
		protected int CurId;

		// Token: 0x0401AEA4 RID: 110244
		[Nullable(1)]
		protected SheriffMainProxy Proxy;

		// Token: 0x0401AEA5 RID: 110245
		public Action<int, bool> OnToggleStateChangedCallback;

		// Token: 0x0401AEA6 RID: 110246
		public Func<int, EToggleState, bool> CheckCanChangeCallback;

		// Token: 0x0401AEA7 RID: 110247
		public Func<int, EToggleState> CheckSelectCallback;

		// Token: 0x0401AEA8 RID: 110248
		public Func<bool> CheckToggleEnable;

		// Token: 0x0200AE25 RID: 44581
		[NullableContext(0)]
		private static class EClueItem
		{
			// Token: 0x04034E35 RID: 216629
			public const int Tog = 0;

			// Token: 0x04034E36 RID: 216630
			public const int TxtName = 1;

			// Token: 0x04034E37 RID: 216631
			public const int TxtIcon = 2;

			// Token: 0x04034E38 RID: 216632
			public const int PanelLock = 3;

			// Token: 0x04034E39 RID: 216633
			public const int BtnCommon = 4;

			// Token: 0x04034E3A RID: 216634
			public const int PanelHint = 5;
		}
	}
}
