using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DD9 RID: 15833
	public class RoguelikeInstanceEntrySelectItem : GridProxyAbstract<RougePopularEntrie>
	{
		// Token: 0x06028758 RID: 165720 RVA: 0x00B567D0 File Offset: 0x00B549D0
		public override void Refresh(RougePopularEntrie data, bool isSelected, int gridIndex)
		{
			this.DataId = data.Id;
			bool flag = RoguelikeInstanceEntrySelectView.SelectIndexList.Contains(data.Id);
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(4);
			if (extendToggle2 == null || !extendToggle2.CanExecuteChange.IsBound())
			{
				UUIExtendToggle extendToggle3 = base.GetExtendToggle(4);
				if (extendToggle3 != null)
				{
					extendToggle3.CanExecuteChange.Unbind();
				}
			}
			UUIExtendToggle extendToggle4 = base.GetExtendToggle(4);
			if (extendToggle4 != null)
			{
				extendToggle4.CanExecuteChange.Bind(() => this.CheckCanExecuteChange == null || this.CheckCanExecuteChange(base.GetExtendToggle(4)));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
			if (data.Category == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Roguelike_Instance_Entry_Buff_Number", new <>z__ReadOnlySingleElementList<object>(Math.Abs(data.Rate / 100).ToString()));
			}
			else if (data.Category == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Roguelike_Instance_Entry_DeBuff_Number", new <>z__ReadOnlySingleElementList<object>(Math.Abs(data.Rate / 100).ToString()));
			}
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Describe, data.DescriptionParam());
		}

		// Token: 0x06028759 RID: 165721 RVA: 0x00B56944 File Offset: 0x00B54B44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602875A RID: 165722 RVA: 0x00B56A10 File Offset: 0x00B54C10
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}

		// Token: 0x0602875B RID: 165723 RVA: 0x00B56A34 File Offset: 0x00B54C34
		protected void OnToggleStateChange(EToggleState state)
		{
			if (this.OnSelectBuff != null)
			{
				this.OnSelectBuff(this.DataId, state == EToggleState.ETT_Checked, base.GetExtendToggle(4));
			}
		}

		// Token: 0x0602875C RID: 165724 RVA: 0x00B56A5A File Offset: 0x00B54C5A
		public bool IsToggleSelected()
		{
			return base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0602875D RID: 165725 RVA: 0x00B56A6B File Offset: 0x00B54C6B
		public void SetToggleInteractive(bool isInteractive)
		{
			base.GetExtendToggle(4).SetSelfInteractive(isInteractive);
		}

		// Token: 0x04015F5B RID: 89947
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, bool, UUIExtendToggle> OnSelectBuff;

		// Token: 0x04015F5C RID: 89948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<UUIExtendToggle, bool> CheckCanExecuteChange;

		// Token: 0x04015F5D RID: 89949
		public int DataId;

		// Token: 0x020099DF RID: 39391
		public class ERoguelikeInstanceEntrySelectItem
		{
			// Token: 0x0402FF7B RID: 196475
			public const int TextureIcon = 0;

			// Token: 0x0402FF7C RID: 196476
			public const int TxtTitle = 1;

			// Token: 0x0402FF7D RID: 196477
			public const int TxtBuffNumber = 2;

			// Token: 0x0402FF7E RID: 196478
			public const int TxtDescription = 3;

			// Token: 0x0402FF7F RID: 196479
			public const int ExtendToggle = 4;
		}
	}
}
