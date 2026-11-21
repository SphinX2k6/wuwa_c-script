using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.View
{
	// Token: 0x02003788 RID: 14216
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalGameplayItem : GridProxyAbstract<RegionalTerminalGameplayData>
	{
		// Token: 0x06024F33 RID: 151347 RVA: 0x00A70B1C File Offset: 0x00A6ED1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024F34 RID: 151348 RVA: 0x00A70CAC File Offset: 0x00A6EEAC
		public override UniTask RefreshAsync(RegionalTerminalGameplayData data, bool isSelected, int gridIndex)
		{
			RegionalTerminalGameplayItem.<RefreshAsync>d__10 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<RegionalTerminalGameplayItem.<RefreshAsync>d__10>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024F35 RID: 151349 RVA: 0x00A70CF7 File Offset: 0x00A6EEF7
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06024F36 RID: 151350 RVA: 0x00A70D00 File Offset: 0x00A6EF00
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			if (!this.EnableRedDot)
			{
				item.SetUIActive(false);
				return;
			}
			this.UnBindRedDot();
			this.RedDotName = this.Data.GetRedDotName();
			this.RedDotId = this.Data.GetRedDotId();
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, this.RedDotId);
				return;
			}
			item.SetUIActive(this.Data.GetRedDotState());
		}

		// Token: 0x06024F37 RID: 151351 RVA: 0x00A70D90 File Offset: 0x00A6EF90
		private void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				UUIItem item = base.GetItem(7);
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, this.RedDotId);
				this.RedDotId = 0;
				this.RedDotName = null;
			}
		}

		// Token: 0x06024F38 RID: 151352 RVA: 0x00A70DE1 File Offset: 0x00A6EFE1
		public void SetPin(bool visible)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06024F39 RID: 151353 RVA: 0x00A70DF8 File Offset: 0x00A6EFF8
		public void RefreshFunctional()
		{
			bool lockState = this.Data.GetLockState();
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				bool bUseChangeColor = lockState;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			this.SetPin(RegionalTerminalModel.Instance.IsGameplayPin(this.Data.Id));
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(lockState);
			}
			if (this.RedDotName == null)
			{
				UUIItem item2 = base.GetItem(7);
				if (item2 != null)
				{
					item2.SetUIActive(this.Data.GetRedDotState());
				}
			}
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x00A70E88 File Offset: 0x00A6F088
		private void RefreshTextState(bool state)
		{
			float alpha = (!state && this.Data.GetLockState()) ? 0.2f : 1f;
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(alpha);
		}

		// Token: 0x06024F3B RID: 151355 RVA: 0x00A70EC4 File Offset: 0x00A6F0C4
		private void OnClickToggle(EToggleState state)
		{
			this.RefreshTextState(state == EToggleState.ETT_Checked);
			Action<bool, RegionalTerminalGameplayData> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(state == EToggleState.ETT_Checked, this.Data);
		}

		// Token: 0x06024F3C RID: 151356 RVA: 0x00A70EEC File Offset: 0x00A6F0EC
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state2, false, false, false);
			}
			this.RefreshTextState(state);
		}

		// Token: 0x06024F3D RID: 151357 RVA: 0x00A70F1F File Offset: 0x00A6F11F
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06024F3E RID: 151358 RVA: 0x00A70F28 File Offset: 0x00A6F128
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06024F3F RID: 151359 RVA: 0x00A70F31 File Offset: 0x00A6F131
		public override object GetKey(RegionalTerminalGameplayData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401474F RID: 83791
		[Nullable(2)]
		private RegionalTerminalGameplayData Data;

		// Token: 0x04014750 RID: 83792
		private ERedDotName? RedDotName;

		// Token: 0x04014751 RID: 83793
		private int RedDotId;

		// Token: 0x04014752 RID: 83794
		public bool EnableRedDot = true;

		// Token: 0x04014753 RID: 83795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RegionalTerminalGameplayData> OnClickToggleCallBack;

		// Token: 0x04014754 RID: 83796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RegionalTerminalGameplayData, bool> IsToggleSelectOn;

		// Token: 0x04014755 RID: 83797
		private const float LOCK_TEXT_ALPHA = 0.2f;

		// Token: 0x04014756 RID: 83798
		private const float NORMAL_TEXT_ALPHA = 1f;

		// Token: 0x020094EA RID: 38122
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E805 RID: 190469
			public const int Toggle = 0;

			// Token: 0x0402E806 RID: 190470
			public const int TexBg = 1;

			// Token: 0x0402E807 RID: 190471
			public const int TexIcon = 2;

			// Token: 0x0402E808 RID: 190472
			public const int TxtName = 3;

			// Token: 0x0402E809 RID: 190473
			public const int TxtTag = 4;

			// Token: 0x0402E80A RID: 190474
			public const int ItemPin = 5;

			// Token: 0x0402E80B RID: 190475
			public const int ItemLock = 6;

			// Token: 0x0402E80C RID: 190476
			public const int ItemRedDot = 7;

			// Token: 0x0402E80D RID: 190477
			public const int PanelText = 8;
		}
	}
}
