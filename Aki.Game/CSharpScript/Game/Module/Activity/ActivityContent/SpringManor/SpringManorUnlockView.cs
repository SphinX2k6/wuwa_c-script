using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02005015 RID: 20501
	public class SpringManorUnlockView : UiTickViewBase
	{
		// Token: 0x060334C5 RID: 210117 RVA: 0x00E622A4 File Offset: 0x00E604A4
		[NullableContext(1)]
		public SpringManorUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060334C6 RID: 210118 RVA: 0x00E622D0 File Offset: 0x00E604D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060334C7 RID: 210119 RVA: 0x00E623B8 File Offset: 0x00E605B8
		protected override void OnStart()
		{
			this.CloseTimer = (float)this.CloseTime;
			this.FillBar = base.GetSprite(1);
		}

		// Token: 0x060334C8 RID: 210120 RVA: 0x00E623D4 File Offset: 0x00E605D4
		protected override void OnTick(float delta)
		{
			UUISprite fillBar = this.FillBar;
			if (fillBar != null)
			{
				fillBar.SetFillAmount(this.CloseTimer / (float)this.CloseTime);
			}
			if (this.CloseTimer <= 0f)
			{
				if (!this.IsClosing)
				{
					base.CloseMe(null);
					this.IsClosing = true;
					return;
				}
			}
			else
			{
				this.CloseTimer -= delta;
			}
		}

		// Token: 0x060334C9 RID: 210121 RVA: 0x00E62433 File Offset: 0x00E60633
		private void OnClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
		}

		// Token: 0x0401B48C RID: 111756
		private bool IsClosing;

		// Token: 0x0401B48D RID: 111757
		private float CloseTimer;

		// Token: 0x0401B48E RID: 111758
		private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("SpringManorLevelDisplayTime").Value;

		// Token: 0x0401B48F RID: 111759
		[Nullable(2)]
		private UUISprite FillBar;
	}
}
