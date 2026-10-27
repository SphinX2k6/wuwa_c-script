using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006F15 RID: 28437
	public class LevelGamePlayMotorPrepareCountDownView : UiViewBase, IUiViewResource
	{
		// Token: 0x06045364 RID: 283492 RVA: 0x01120161 File Offset: 0x0111E361
		[NullableContext(1)]
		public LevelGamePlayMotorPrepareCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045365 RID: 283493 RVA: 0x0112016C File Offset: 0x0111E36C
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

		// Token: 0x06045366 RID: 283494 RVA: 0x011201B4 File Offset: 0x0111E3B4
		[NullableContext(1)]
		public string GetExtraResourceId([Nullable(2)] object param)
		{
			ILevelGamePlayPrepareCountDownViewParams levelGamePlayPrepareCountDownViewParams = param as ILevelGamePlayPrepareCountDownViewParams;
			if (levelGamePlayPrepareCountDownViewParams == null || levelGamePlayPrepareCountDownViewParams.UiStyle == null)
			{
				return "";
			}
			string result;
			if (LevelGamePlayPrepareCountDownDefine.countDownUiStyleToResourceId.TryGetValue(levelGamePlayPrepareCountDownViewParams.UiStyle.Value, out result))
			{
				return result;
			}
			return "";
		}

		// Token: 0x06045367 RID: 283495 RVA: 0x0112020C File Offset: 0x0111E40C
		protected override void OnStart()
		{
			ILevelGamePlayPrepareCountDownViewParams levelGamePlayPrepareCountDownViewParams = this.OpenParam as ILevelGamePlayPrepareCountDownViewParams;
			if (levelGamePlayPrepareCountDownViewParams != null && levelGamePlayPrepareCountDownViewParams.TidText != null)
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(levelGamePlayPrepareCountDownViewParams.TidText);
				UUIText text = base.GetText(0);
				if (text == null)
				{
					return;
				}
				text.SetText(configTextByKey, true);
			}
		}

		// Token: 0x06045368 RID: 283496 RVA: 0x01120254 File Offset: 0x0111E454
		protected override void OnAfterPlayStartSequence()
		{
			EventSystem.Instance.Emit(EEventName.LevelGamePlayPrepareCountDownEnd);
			base.CloseMe(null);
		}

		// Token: 0x0200CD71 RID: 52593
		private class EViewComponent
		{
			// Token: 0x0403DEA0 RID: 253600
			public const int TextTip = 0;
		}
	}
}
