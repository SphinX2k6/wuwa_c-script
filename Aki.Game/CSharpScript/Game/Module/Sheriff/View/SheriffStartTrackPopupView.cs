using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02004C5D RID: 19549
	public class SheriffStartTrackPopupView : UiViewBase
	{
		// Token: 0x06032898 RID: 207000 RVA: 0x00BC6306 File Offset: 0x00BC4506
		[NullableContext(1)]
		public SheriffStartTrackPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032899 RID: 207001 RVA: 0x00BC6310 File Offset: 0x00BC4510
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

		// Token: 0x0603289A RID: 207002 RVA: 0x00BC6358 File Offset: 0x00BC4558
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

		// Token: 0x0603289B RID: 207003 RVA: 0x00BC63B7 File Offset: 0x00BC45B7
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200AE01 RID: 44545
		private static class EComponents
		{
			// Token: 0x04034DA3 RID: 216483
			public const int TitleText = 0;
		}
	}
}
