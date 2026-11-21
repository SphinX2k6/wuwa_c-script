using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB5 RID: 24501
	public class FishingQtePauseView : UiViewBase
	{
		// Token: 0x0603ADF5 RID: 241141 RVA: 0x010A2BAD File Offset: 0x010A0DAD
		[NullableContext(1)]
		public FishingQtePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ADF6 RID: 241142 RVA: 0x010A2BB8 File Offset: 0x010A0DB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonExitClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnButtonCabinClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnButtonResumeClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADF7 RID: 241143 RVA: 0x010A2CC5 File Offset: 0x010A0EC5
		protected override void OnStart()
		{
		}

		// Token: 0x0603ADF8 RID: 241144 RVA: 0x010A2CC7 File Offset: 0x010A0EC7
		private void OnButtonExitClicked()
		{
			FishingController.Instance.ShowConfirmBoxAndRequestFishingExit(delegate(bool success)
			{
				if (success)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x0603ADF9 RID: 241145 RVA: 0x010A2CDF File Offset: 0x010A0EDF
		private void OnButtonCabinClicked()
		{
			FishingController.Instance.OpenDockyardWareHouseView(true);
			base.CloseMe(null);
		}

		// Token: 0x0603ADFA RID: 241146 RVA: 0x010A2CF3 File Offset: 0x010A0EF3
		private void OnButtonResumeClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200B8CF RID: 47311
		private class EComponents
		{
			// Token: 0x040390AD RID: 233645
			public const int ButtonExit = 0;

			// Token: 0x040390AE RID: 233646
			public const int ButtonCabin = 1;

			// Token: 0x040390AF RID: 233647
			public const int ButtonResume = 2;
		}
	}
}
