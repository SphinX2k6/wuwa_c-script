using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005183 RID: 20867
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardDeleteFilterItem : GridProxyAbstract<IDeckBuilderCardDeleteFilterItemData>
	{
		// Token: 0x06035606 RID: 218630 RVA: 0x00CA4CA8 File Offset: 0x00CA2EA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleClickInternal))
			};
		}

		// Token: 0x06035607 RID: 218631 RVA: 0x00CA4D54 File Offset: 0x00CA2F54
		[NullableContext(1)]
		public override void Refresh(IDeckBuilderCardDeleteFilterItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			PhantomBattleCardElement phantomBattleElementConfig = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig((int)data.Element);
			base.SetTextureByPath(phantomBattleElementConfig.DeleteFilterIcon, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), phantomBattleElementConfig.Name, Array.Empty<object>());
			if (data.Enabled)
			{
				EToggleState state = data.Selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				base.GetExtendToggle(0).SetToggleState(state, false, false, false);
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x06035608 RID: 218632 RVA: 0x00CA4DEC File Offset: 0x00CA2FEC
		private void OnItemToggleClickInternal(EToggleState toggleState)
		{
			EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
			Action<int, EToggleState> onItemToggleStateChange = this.OnItemToggleStateChange;
			if (onItemToggleStateChange == null)
			{
				return;
			}
			onItemToggleStateChange(base.GridIndex, toggleState2);
		}

		// Token: 0x0401C5E5 RID: 116197
		protected IDeckBuilderCardDeleteFilterItemData Data;

		// Token: 0x0401C5E6 RID: 116198
		public Action<int, EToggleState> OnItemToggleStateChange;

		// Token: 0x0200B2F7 RID: 45815
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040363D4 RID: 222164
			public const int ItemToggle = 0;

			// Token: 0x040363D5 RID: 222165
			public const int IconRootItem = 1;

			// Token: 0x040363D6 RID: 222166
			public const int IconTexture = 2;

			// Token: 0x040363D7 RID: 222167
			public const int IconSprite = 3;

			// Token: 0x040363D8 RID: 222168
			public const int NameText = 4;
		}
	}
}
