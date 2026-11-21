using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200535E RID: 21342
	public class MowingRiskBuffTipView : GenericPromptFloatTipsBase
	{
		// Token: 0x060351BD RID: 217533 RVA: 0x00ED5227 File Offset: 0x00ED3427
		[NullableContext(1)]
		public MowingRiskBuffTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060351BE RID: 217534 RVA: 0x00ED5230 File Offset: 0x00ED3430
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

		// Token: 0x060351BF RID: 217535 RVA: 0x00ED529C File Offset: 0x00ED349C
		protected override void OnStart()
		{
			IMowingRiskInBattleBuffData mowingRiskInBattleBuffData = this.OpenParam as IMowingRiskInBattleBuffData;
			base.SetTextureByPath(mowingRiskInBattleBuffData.IconPath, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), mowingRiskInBattleBuffData.TitleTextId, Array.Empty<object>());
		}

		// Token: 0x0200AFDF RID: 45023
		private class EComponent
		{
			// Token: 0x040365BC RID: 222652
			public const int IconTexture = 0;

			// Token: 0x040365BD RID: 222653
			public const int TitleText = 1;
		}
	}
}
