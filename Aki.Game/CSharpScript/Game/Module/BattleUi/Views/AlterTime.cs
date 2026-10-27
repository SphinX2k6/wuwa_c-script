using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB0 RID: 23728
	public class AlterTime : UiPanelBase
	{
		// Token: 0x0603BF31 RID: 245553 RVA: 0x00E540B0 File Offset: 0x00E522B0
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

		// Token: 0x0603BF32 RID: 245554 RVA: 0x00E540F8 File Offset: 0x00E522F8
		protected override void OnBeforeDestroy()
		{
			this.TimeText = null;
		}

		// Token: 0x0603BF33 RID: 245555 RVA: 0x00E54101 File Offset: 0x00E52301
		protected override void OnStart()
		{
			this.TimeText = base.GetText(0);
			base.SetUiActive(false);
		}

		// Token: 0x0603BF34 RID: 245556 RVA: 0x00E54118 File Offset: 0x00E52318
		public void SetCountdownText(double time)
		{
			int value = (int)Math.Floor(time / (double)TimeUtil.Instance.InverseMillisecond);
			string value2 = (time % (double)TimeUtil.Instance.InverseMillisecond).ToString(CultureInfo.InvariantCulture).Substring(0, 2);
			UUIText timeText = this.TimeText;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			timeText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0401F492 RID: 128146
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0200BE8A RID: 48778
		private enum EComponents
		{
			// Token: 0x0403975F RID: 235359
			UITimeText
		}
	}
}
