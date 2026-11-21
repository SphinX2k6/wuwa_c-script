using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059DF RID: 23007
	public class SolarSchoolUpgradePopupView : UiViewBase
	{
		// Token: 0x06038AAB RID: 232107 RVA: 0x00FDC22F File Offset: 0x00FDA42F
		[NullableContext(1)]
		public SolarSchoolUpgradePopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038AAC RID: 232108 RVA: 0x00FDC244 File Offset: 0x00FDA444
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.CloseSelf));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.CloseSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038AAD RID: 232109 RVA: 0x00FDC354 File Offset: 0x00FDA554
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolUpgradePopupView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolUpgradePopupView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AAE RID: 232110 RVA: 0x00FDC398 File Offset: 0x00FDA598
		protected override void OnBeforeDestroy()
		{
			foreach (SolarSchoolUpgradeItem solarSchoolUpgradeItem in this.Items)
			{
				solarSchoolUpgradeItem.Destroy(null);
			}
			this.Items.Clear();
			SolarSchoolUpgradePopupParam solarSchoolUpgradePopupParam = this.OpenParam as SolarSchoolUpgradePopupParam;
			if (solarSchoolUpgradePopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolUpgradePopupParam.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0401DD7E RID: 122238
		[Nullable(1)]
		private readonly List<SolarSchoolUpgradeItem> Items = new List<SolarSchoolUpgradeItem>();

		// Token: 0x0200B58B RID: 46475
		private class EComponent
		{
			// Token: 0x0403822E RID: 229934
			public const int BtnClose = 1;

			// Token: 0x0403822F RID: 229935
			public const int UiVLayout = 2;

			// Token: 0x04038230 RID: 229936
			public const int PnlItem = 3;

			// Token: 0x04038231 RID: 229937
			public const int BtnCon = 4;
		}
	}
}
