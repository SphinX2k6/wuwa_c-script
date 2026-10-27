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
	// Token: 0x02004B5E RID: 19294
	public class TowerDefenseWaveTipView : GenericPromptFloatTipsBase
	{
		// Token: 0x06031F51 RID: 204625 RVA: 0x00B97EDA File Offset: 0x00B960DA
		[NullableContext(1)]
		public TowerDefenseWaveTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031F52 RID: 204626 RVA: 0x00B97EE4 File Offset: 0x00B960E4
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

		// Token: 0x06031F53 RID: 204627 RVA: 0x00B97F2C File Offset: 0x00B9612C
		protected override void OnStart()
		{
			IPromptParamHub promptParamHub = this.OpenParam as IPromptParamHub;
			TableTextArgNew promptMainTextObj = GenericPromptConfig.Instance.GetPromptMainTextObj(promptParamHub.PromptId.Value);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), promptMainTextObj.TextKey ?? "", Array.Empty<object>());
		}

		// Token: 0x0200ACEF RID: 44271
		private class EComponent
		{
			// Token: 0x040348BC RID: 215228
			public const int WaveText = 0;
		}
	}
}
