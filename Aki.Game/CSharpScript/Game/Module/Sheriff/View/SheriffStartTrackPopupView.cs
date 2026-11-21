using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C0E RID: 15374
	public class SheriffStartTrackPopupView : UiViewBase
	{
		// Token: 0x0602764B RID: 161355 RVA: 0x00B0AF52 File Offset: 0x00B09152
		[NullableContext(1)]
		public SheriffStartTrackPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602764C RID: 161356 RVA: 0x00B0AF5C File Offset: 0x00B0915C
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

		// Token: 0x0602764D RID: 161357 RVA: 0x00B0AFA4 File Offset: 0x00B091A4
		protected override void OnStart()
		{
			SheriffStartTrackPopupViewData sheriffStartTrackPopupViewData = this.OpenParam as SheriffStartTrackPopupViewData;
			if (sheriffStartTrackPopupViewData == null)
			{
				return;
			}
			SheriffAnomaly? anomalyConfigById = SheriffConfig.Instance.GetAnomalyConfigById(sheriffStartTrackPopupViewData.AnomalyId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), (anomalyConfigById != null) ? anomalyConfigById.GetValueOrDefault().Name : null, Array.Empty<object>());
		}

		// Token: 0x0602764E RID: 161358 RVA: 0x00B0B003 File Offset: 0x00B09203
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200981F RID: 38943
		private static class EComponents
		{
			// Token: 0x0402F748 RID: 194376
			public const int TitleText = 0;
		}
	}
}
