using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B06 RID: 15110
	public class TowerDefenseWaveTipView : GenericPromptFloatTipsBase
	{
		// Token: 0x06026CE0 RID: 158944 RVA: 0x00ADC116 File Offset: 0x00ADA316
		[NullableContext(1)]
		public TowerDefenseWaveTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026CE1 RID: 158945 RVA: 0x00ADC120 File Offset: 0x00ADA320
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026CE2 RID: 158946 RVA: 0x00ADC168 File Offset: 0x00ADA368
		protected override void OnStart()
		{
			IPromptParamHub promptParamHub = this.OpenParam as IPromptParamHub;
			TableTextArgNew promptMainTextObj = GenericPromptConfig.Instance.GetPromptMainTextObj(promptParamHub.PromptId.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), promptMainTextObj.TextKey ?? "", Array.Empty<object>());
		}

		// Token: 0x0200970E RID: 38670
		private class EComponent
		{
			// Token: 0x0402F265 RID: 193125
			public const int WaveText = 0;
		}
	}
}
