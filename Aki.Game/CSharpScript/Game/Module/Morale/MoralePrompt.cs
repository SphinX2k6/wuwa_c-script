using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053B5 RID: 21429
	public class MoralePrompt : GenericPromptFloatTipsBase
	{
		// Token: 0x06036C1B RID: 224283 RVA: 0x00CF5AA3 File Offset: 0x00CF3CA3
		[NullableContext(1)]
		public MoralePrompt(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036C1C RID: 224284 RVA: 0x00CF5AAC File Offset: 0x00CF3CAC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x06036C1D RID: 224285 RVA: 0x00CF5B60 File Offset: 0x00CF3D60
		protected override void OnStart()
		{
			base.OnStart();
			IPromptParamHub promptParamHub = this.OpenParam as IPromptParamHub;
			IMoralePromptData moralePromptData = ((promptParamHub != null) ? promptParamHub.ExtraParamObj : null) as IMoralePromptData;
			this.ShowArea(moralePromptData.AreaId);
			EventSystem.Instance.Emit(EEventName.OnMoralePromptShow);
		}

		// Token: 0x06036C1E RID: 224286 RVA: 0x00CF5BAC File Offset: 0x00CF3DAC
		private void ShowArea(EMoraleAreaType areaId)
		{
			int? num = null;
			switch (areaId)
			{
			case EMoraleAreaType.MoraleArea1:
				num = new int?(2);
				break;
			case EMoraleAreaType.MoraleArea2:
				num = new int?(3);
				break;
			case EMoraleAreaType.MoraleArea3:
				num = new int?(4);
				break;
			case EMoraleAreaType.MoraleArea4:
				num = new int?(5);
				break;
			case EMoraleAreaType.MoraleArea5:
				num = new int?(6);
				break;
			}
			if (num != null)
			{
				base.GetItem(num.Value).SetUIActive(true);
			}
		}

		// Token: 0x0200B651 RID: 46673
		private class EComponent
		{
			// Token: 0x040373BB RID: 226235
			public const int MainText = 0;

			// Token: 0x040373BC RID: 226236
			public const int SubText = 1;

			// Token: 0x040373BD RID: 226237
			public const int Area1 = 2;

			// Token: 0x040373BE RID: 226238
			public const int Area2 = 3;

			// Token: 0x040373BF RID: 226239
			public const int Area3 = 4;

			// Token: 0x040373C0 RID: 226240
			public const int Area4 = 5;

			// Token: 0x040373C1 RID: 226241
			public const int Area5 = 6;
		}
	}
}
