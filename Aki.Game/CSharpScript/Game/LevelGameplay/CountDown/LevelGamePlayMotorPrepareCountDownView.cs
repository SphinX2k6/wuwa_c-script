using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006096 RID: 24726
	public class LevelGamePlayMotorPrepareCountDownView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603B512 RID: 242962 RVA: 0x010CA101 File Offset: 0x010C8301
		[NullableContext(1)]
		public LevelGamePlayMotorPrepareCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B513 RID: 242963 RVA: 0x010CA10C File Offset: 0x010C830C
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

		// Token: 0x0603B514 RID: 242964 RVA: 0x010CA154 File Offset: 0x010C8354
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

		// Token: 0x0603B515 RID: 242965 RVA: 0x010CA1AC File Offset: 0x010C83AC
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

		// Token: 0x0603B516 RID: 242966 RVA: 0x010CA1F4 File Offset: 0x010C83F4
		protected override void OnAfterPlayStartSequence()
		{
			EventSystem.Instance.Emit(EEventName.LevelGamePlayPrepareCountDownEnd);
			base.CloseMe(null);
		}

		// Token: 0x0200B963 RID: 47459
		private class EViewComponent
		{
			// Token: 0x040392CF RID: 234191
			public const int TextTip = 0;
		}
	}
}
