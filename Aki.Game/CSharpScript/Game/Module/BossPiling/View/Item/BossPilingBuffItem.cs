using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C22 RID: 23586
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingBuffItem : SyncGridProxyAbstract<BossPilingBuffCountInfo>
	{
		// Token: 0x0603B967 RID: 244071 RVA: 0x00E363E4 File Offset: 0x00E345E4
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

		// Token: 0x0603B968 RID: 244072 RVA: 0x00E36538 File Offset: 0x00E34738
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

		// Token: 0x0603B969 RID: 244073 RVA: 0x00E365B8 File Offset: 0x00E347B8
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

		// Token: 0x0603B96A RID: 244074 RVA: 0x00E3667C File Offset: 0x00E3487C
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

		// Token: 0x0603B96B RID: 244075 RVA: 0x00E366A7 File Offset: 0x00E348A7
		private void OnToggleStateChange(EToggleState _)
		{
			if (this.OnToggleClicked != null)
			{
				this.OnToggleClicked(this.CurInfo);
			}
		}

		// Token: 0x0401F05F RID: 127071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<BossPilingBuffCountInfo> OnToggleClicked;

		// Token: 0x0401F060 RID: 127072
		[Nullable(2)]
		public Func<int, bool> IsSelectedCb;

		// Token: 0x0401F061 RID: 127073
		[Nullable(2)]
		protected BossPilingBuffCountItem CountItem;

		// Token: 0x0401F062 RID: 127074
		protected BossPilingBuffCountInfo CurInfo;

		// Token: 0x0200BE0C RID: 48652
		[NullableContext(0)]
		private enum EBuff
		{
			// Token: 0x040394E2 RID: 234722
			QualitySprite,
			// Token: 0x040394E3 RID: 234723
			ItemTexture,
			// Token: 0x040394E4 RID: 234724
			BottomText,
			// Token: 0x040394E5 RID: 234725
			BottomTextBgSprite,
			// Token: 0x040394E6 RID: 234726
			TopAdditionItem,
			// Token: 0x040394E7 RID: 234727
			BottomAdditionItem,
			// Token: 0x040394E8 RID: 234728
			ExtendToggle,
			// Token: 0x040394E9 RID: 234729
			UnderTextAdditionItem,
			// Token: 0x040394EA RID: 234730
			SkinQualitySprite
		}
	}
}
