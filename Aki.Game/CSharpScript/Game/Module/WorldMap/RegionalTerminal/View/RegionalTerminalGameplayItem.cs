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
	// Token: 0x02004857 RID: 18519
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RegionalTerminalGameplayItem : GridProxyAbstract<RegionalTerminalGameplayData>
	{
		// Token: 0x06030764 RID: 198500 RVA: 0x00B408D8 File Offset: 0x00B3EAD8
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

		// Token: 0x06030765 RID: 198501 RVA: 0x00B40A68 File Offset: 0x00B3EC68
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

		// Token: 0x06030766 RID: 198502 RVA: 0x00B40AB3 File Offset: 0x00B3ECB3
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06030767 RID: 198503 RVA: 0x00B40ABC File Offset: 0x00B3ECBC
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

		// Token: 0x06030768 RID: 198504 RVA: 0x00B40B4C File Offset: 0x00B3ED4C
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

		// Token: 0x06030769 RID: 198505 RVA: 0x00B40B9D File Offset: 0x00B3ED9D
		public void SetPin(bool visible)
		{
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x0603076A RID: 198506 RVA: 0x00B40BB4 File Offset: 0x00B3EDB4
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

		// Token: 0x0603076B RID: 198507 RVA: 0x00B40C44 File Offset: 0x00B3EE44
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

		// Token: 0x0603076C RID: 198508 RVA: 0x00B40C80 File Offset: 0x00B3EE80
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

		// Token: 0x0603076D RID: 198509 RVA: 0x00B40CA8 File Offset: 0x00B3EEA8
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

		// Token: 0x0603076E RID: 198510 RVA: 0x00B40CDB File Offset: 0x00B3EEDB
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x0603076F RID: 198511 RVA: 0x00B40CE4 File Offset: 0x00B3EEE4
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06030770 RID: 198512 RVA: 0x00B40CED File Offset: 0x00B3EEED
		public override object GetKey(RegionalTerminalGameplayData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401A09B RID: 106651
		[Nullable(2)]
		private RegionalTerminalGameplayData Data;

		// Token: 0x0401A09C RID: 106652
		private ERedDotName? RedDotName;

		// Token: 0x0401A09D RID: 106653
		private int RedDotId;

		// Token: 0x0401A09E RID: 106654
		public bool EnableRedDot = true;

		// Token: 0x0401A09F RID: 106655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RegionalTerminalGameplayData> OnClickToggleCallBack;

		// Token: 0x0401A0A0 RID: 106656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<RegionalTerminalGameplayData, bool> IsToggleSelectOn;

		// Token: 0x0401A0A1 RID: 106657
		private const float LOCK_TEXT_ALPHA = 0.2f;

		// Token: 0x0401A0A2 RID: 106658
		private const float NORMAL_TEXT_ALPHA = 1f;

		// Token: 0x0200AB3C RID: 43836
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0403408D RID: 213133
			public const int Toggle = 0;

			// Token: 0x0403408E RID: 213134
			public const int TexBg = 1;

			// Token: 0x0403408F RID: 213135
			public const int TexIcon = 2;

			// Token: 0x04034090 RID: 213136
			public const int TxtName = 3;

			// Token: 0x04034091 RID: 213137
			public const int TxtTag = 4;

			// Token: 0x04034092 RID: 213138
			public const int ItemPin = 5;

			// Token: 0x04034093 RID: 213139
			public const int ItemLock = 6;

			// Token: 0x04034094 RID: 213140
			public const int ItemRedDot = 7;

			// Token: 0x04034095 RID: 213141
			public const int PanelText = 8;
		}
	}
}
