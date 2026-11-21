using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C92 RID: 19602
	public class AlterTime : UiPanelBase
	{
		// Token: 0x06030E84 RID: 200324 RVA: 0x00DA4758 File Offset: 0x00DA2958
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

		// Token: 0x06030E85 RID: 200325 RVA: 0x00DA47A0 File Offset: 0x00DA29A0
		protected override void OnBeforeDestroy()
		{
			this.TimeText = null;
		}

		// Token: 0x06030E86 RID: 200326 RVA: 0x00DA47A9 File Offset: 0x00DA29A9
		protected override void OnStart()
		{
			this.TimeText = base.GetText(0);
			base.SetUiActive(false);
		}

		// Token: 0x06030E87 RID: 200327 RVA: 0x00DA47C0 File Offset: 0x00DA29C0
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

		// Token: 0x04019F4B RID: 106315
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0200A890 RID: 43152
		private enum EComponents
		{
			// Token: 0x04034120 RID: 213280
			UITimeText
		}
	}
}
