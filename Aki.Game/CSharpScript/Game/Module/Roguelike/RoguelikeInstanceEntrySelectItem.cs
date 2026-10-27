using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E10 RID: 19984
	public class RoguelikeInstanceEntrySelectItem : GridProxyAbstract<RougePopularEntrie>
	{
		// Token: 0x060338ED RID: 211181 RVA: 0x00C0D2C4 File Offset: 0x00C0B4C4
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

		// Token: 0x060338EE RID: 211182 RVA: 0x00C0D438 File Offset: 0x00C0B638
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

		// Token: 0x060338EF RID: 211183 RVA: 0x00C0D504 File Offset: 0x00C0B704
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}

		// Token: 0x060338F0 RID: 211184 RVA: 0x00C0D528 File Offset: 0x00C0B728
		protected void OnToggleStateChange(EToggleState state)
		{
			if (this.OnSelectBuff != null)
			{
				this.OnSelectBuff(this.DataId, state == EToggleState.ETT_Checked, base.GetExtendToggle(4));
			}
		}

		// Token: 0x060338F1 RID: 211185 RVA: 0x00C0D54E File Offset: 0x00C0B74E
		public bool IsToggleSelected()
		{
			return base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x060338F2 RID: 211186 RVA: 0x00C0D55F File Offset: 0x00C0B75F
		public void SetToggleInteractive(bool isInteractive)
		{
			base.GetExtendToggle(4).SetSelfInteractive(isInteractive);
		}

		// Token: 0x0401B588 RID: 112008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, bool, UUIExtendToggle> OnSelectBuff;

		// Token: 0x0401B589 RID: 112009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<UUIExtendToggle, bool> CheckCanExecuteChange;

		// Token: 0x0401B58A RID: 112010
		public int DataId;

		// Token: 0x0200AFAA RID: 44970
		public class ERoguelikeInstanceEntrySelectItem
		{
			// Token: 0x04035548 RID: 218440
			public const int TextureIcon = 0;

			// Token: 0x04035549 RID: 218441
			public const int TxtTitle = 1;

			// Token: 0x0403554A RID: 218442
			public const int TxtBuffNumber = 2;

			// Token: 0x0403554B RID: 218443
			public const int TxtDescription = 3;

			// Token: 0x0403554C RID: 218444
			public const int ExtendToggle = 4;
		}
	}
}
