using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E34 RID: 28212
	public class FishingQtePauseView : UiViewBase
	{
		// Token: 0x06044C68 RID: 281704 RVA: 0x010F863D File Offset: 0x010F683D
		[NullableContext(1)]
		public FishingQtePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06044C69 RID: 281705 RVA: 0x010F8648 File Offset: 0x010F6848
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

		// Token: 0x06044C6A RID: 281706 RVA: 0x010F8755 File Offset: 0x010F6955
		protected override void OnStart()
		{
		}

		// Token: 0x06044C6B RID: 281707 RVA: 0x010F8757 File Offset: 0x010F6957
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

		// Token: 0x06044C6C RID: 281708 RVA: 0x010F876F File Offset: 0x010F696F
		private void OnButtonCabinClicked()
		{
			FishingController.Instance.OpenDockyardWareHouseView(true);
			base.CloseMe(null);
		}

		// Token: 0x06044C6D RID: 281709 RVA: 0x010F8783 File Offset: 0x010F6983
		private void OnButtonResumeClicked()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200CCDF RID: 52447
		private class EComponents
		{
			// Token: 0x0403DC8B RID: 253067
			public const int ButtonExit = 0;

			// Token: 0x0403DC8C RID: 253068
			public const int ButtonCabin = 1;

			// Token: 0x0403DC8D RID: 253069
			public const int ButtonResume = 2;
		}
	}
}
