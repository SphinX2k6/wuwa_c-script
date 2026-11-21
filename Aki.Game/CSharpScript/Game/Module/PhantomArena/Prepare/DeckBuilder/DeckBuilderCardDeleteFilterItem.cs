using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004153 RID: 16723
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderCardDeleteFilterItem : GridProxyAbstract<IDeckBuilderCardDeleteFilterItemData>
	{
		// Token: 0x0602A501 RID: 173313 RVA: 0x00BF2260 File Offset: 0x00BF0460
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

		// Token: 0x0602A502 RID: 173314 RVA: 0x00BF230C File Offset: 0x00BF050C
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

		// Token: 0x0602A503 RID: 173315 RVA: 0x00BF23A4 File Offset: 0x00BF05A4
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

		// Token: 0x0401701A RID: 94234
		protected IDeckBuilderCardDeleteFilterItemData Data;

		// Token: 0x0401701B RID: 94235
		public Action<int, EToggleState> OnItemToggleStateChange;

		// Token: 0x02009D30 RID: 40240
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E29 RID: 200233
			public const int ItemToggle = 0;

			// Token: 0x04030E2A RID: 200234
			public const int IconRootItem = 1;

			// Token: 0x04030E2B RID: 200235
			public const int IconTexture = 2;

			// Token: 0x04030E2C RID: 200236
			public const int IconSprite = 3;

			// Token: 0x04030E2D RID: 200237
			public const int NameText = 4;
		}
	}
}
