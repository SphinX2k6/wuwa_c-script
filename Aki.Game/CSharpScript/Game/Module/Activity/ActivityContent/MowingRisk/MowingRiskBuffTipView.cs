using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063E0 RID: 25568
	public class MowingRiskBuffTipView : GenericPromptFloatTipsBase
	{
		// Token: 0x060404FC RID: 263420 RVA: 0x00F8E28F File Offset: 0x00F8C48F
		[NullableContext(1)]
		public MowingRiskBuffTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060404FD RID: 263421 RVA: 0x00F8E298 File Offset: 0x00F8C498
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060404FE RID: 263422 RVA: 0x00F8E304 File Offset: 0x00F8C504
		protected override void OnStart()
		{
			IMowingRiskInBattleBuffData mowingRiskInBattleBuffData = this.OpenParam as IMowingRiskInBattleBuffData;
			base.SetTextureByPath(mowingRiskInBattleBuffData.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), mowingRiskInBattleBuffData.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x0200C5F8 RID: 50680
		private class EComponent
		{
			// Token: 0x0403BC5D RID: 244829
			public const int IconTexture = 0;

			// Token: 0x0403BC5E RID: 244830
			public const int TitleText = 1;
		}
	}
}
