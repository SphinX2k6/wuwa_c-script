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
	// Token: 0x02004398 RID: 17304
	public class MoralePrompt : GenericPromptFloatTipsBase
	{
		// Token: 0x0602BB61 RID: 179041 RVA: 0x00C44B4B File Offset: 0x00C42D4B
		[NullableContext(1)]
		public MoralePrompt(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BB62 RID: 179042 RVA: 0x00C44B54 File Offset: 0x00C42D54
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

		// Token: 0x0602BB63 RID: 179043 RVA: 0x00C44C08 File Offset: 0x00C42E08
		protected override void OnStart()
		{
			base.OnStart();
			IPromptParamHub promptParamHub = this.OpenParam as IPromptParamHub;
			IMoralePromptData moralePromptData = ((promptParamHub != null) ? promptParamHub.ExtraParamObj : null) as IMoralePromptData;
			this.ShowArea(moralePromptData.AreaId);
			EventSystem.Instance.Emit(EEventName.OnMoralePromptShow);
		}

		// Token: 0x0602BB64 RID: 179044 RVA: 0x00C44C54 File Offset: 0x00C42E54
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

		// Token: 0x0200A089 RID: 41097
		private class EComponent
		{
			// Token: 0x04031E10 RID: 204304
			public const int MainText = 0;

			// Token: 0x04031E11 RID: 204305
			public const int SubText = 1;

			// Token: 0x04031E12 RID: 204306
			public const int Area1 = 2;

			// Token: 0x04031E13 RID: 204307
			public const int Area2 = 3;

			// Token: 0x04031E14 RID: 204308
			public const int Area3 = 4;

			// Token: 0x04031E15 RID: 204309
			public const int Area4 = 5;

			// Token: 0x04031E16 RID: 204310
			public const int Area5 = 6;
		}
	}
}
