using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004C02 RID: 19458
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBuffItem : SyncGridProxyAbstract<BossPilingBuffCountInfo>
	{
		// Token: 0x060308B2 RID: 198834 RVA: 0x00D86740 File Offset: 0x00D84940
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060308B3 RID: 198835 RVA: 0x00D86894 File Offset: 0x00D84A94
		protected override void OnStart()
		{
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(6).bLockStateOnSelect = true;
			base.GetExtendToggle(6).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			this.CountItem = new BossPilingBuffCountItem();
			this.CountItem.CreateByResourceIdAsync("UiItem_ItemAMult", base.GetItem(4), false).ContinueWith(delegate()
			{
				if (this.CurInfo.Count > 0)
				{
					this.CountItem.Refresh(this.CurInfo.Count);
				}
			});
		}

		// Token: 0x060308B4 RID: 198836 RVA: 0x00D86914 File Offset: 0x00D84B14
		public override void Refresh(BossPilingBuffCountInfo data)
		{
			this.CurInfo = data;
			if (this.CountItem.IsShowOrShowing)
			{
				this.CountItem.Refresh(data.Count);
			}
			BossPilingBuff value = BossPilingConfig.Instance.GetBuffInfo(data.BuffId).Value;
			base.SetQualityIconById(base.GetSprite(0), value.Quality, null, null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
			base.GetText(2).ShowTextNew(value.Name);
			if (this.IsSelectedCb != null)
			{
				this.SetSelected(this.IsSelectedCb(data.BuffId));
			}
		}

		// Token: 0x060308B5 RID: 198837 RVA: 0x00D869D8 File Offset: 0x00D84BD8
		protected void SetSelected(bool isSelected)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, false);
		}

		// Token: 0x060308B6 RID: 198838 RVA: 0x00D86A03 File Offset: 0x00D84C03
		private void OnToggleStateChange(EToggleState _)
		{
			if (this.OnToggleClicked != null)
			{
				this.OnToggleClicked(this.CurInfo);
			}
		}

		// Token: 0x04019B10 RID: 105232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingBuffCountInfo> OnToggleClicked;

		// Token: 0x04019B11 RID: 105233
		[Nullable(2)]
		public Func<int, bool> IsSelectedCb;

		// Token: 0x04019B12 RID: 105234
		[Nullable(2)]
		protected BossPilingBuffCountItem CountItem;

		// Token: 0x04019B13 RID: 105235
		protected BossPilingBuffCountInfo CurInfo;

		// Token: 0x0200A814 RID: 43028
		[NullableContext(0)]
		private enum EBuff
		{
			// Token: 0x04033EA5 RID: 212645
			QualitySprite,
			// Token: 0x04033EA6 RID: 212646
			ItemTexture,
			// Token: 0x04033EA7 RID: 212647
			BottomText,
			// Token: 0x04033EA8 RID: 212648
			BottomTextBgSprite,
			// Token: 0x04033EA9 RID: 212649
			TopAdditionItem,
			// Token: 0x04033EAA RID: 212650
			BottomAdditionItem,
			// Token: 0x04033EAB RID: 212651
			ExtendToggle,
			// Token: 0x04033EAC RID: 212652
			UnderTextAdditionItem,
			// Token: 0x04033EAD RID: 212653
			SkinQualitySprite
		}
	}
}
