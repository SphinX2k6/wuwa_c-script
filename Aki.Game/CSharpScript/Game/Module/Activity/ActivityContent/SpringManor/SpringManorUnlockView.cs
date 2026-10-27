using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006097 RID: 24727
	public class SpringManorUnlockView : UiTickViewBase
	{
		// Token: 0x0603E801 RID: 256001 RVA: 0x00F1B4E0 File Offset: 0x00F196E0
		[NullableContext(1)]
		public SpringManorUnlockView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E802 RID: 256002 RVA: 0x00F1B50C File Offset: 0x00F1970C
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

		// Token: 0x0603E803 RID: 256003 RVA: 0x00F1B5F4 File Offset: 0x00F197F4
		protected override void OnStart()
		{
			this.CloseTimer = (float)this.CloseTime;
			this.FillBar = base.GetSprite(1);
		}

		// Token: 0x0603E804 RID: 256004 RVA: 0x00F1B610 File Offset: 0x00F19810
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

		// Token: 0x0603E805 RID: 256005 RVA: 0x00F1B66F File Offset: 0x00F1986F
		private void OnClickButton()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorAtmosphereLevelView, null, null);
		}

		// Token: 0x04020B5F RID: 133983
		private bool IsClosing;

		// Token: 0x04020B60 RID: 133984
		private float CloseTimer;

		// Token: 0x04020B61 RID: 133985
		private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("SpringManorLevelDisplayTime").Value;

		// Token: 0x04020B62 RID: 133986
		[Nullable(2)]
		private UUISprite FillBar;
	}
}
