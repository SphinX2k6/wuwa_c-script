using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE5 RID: 19173
	public class TrapDefenseBuildingMachineInfoView : UiViewBase
	{
		// Token: 0x06031ABB RID: 203451 RVA: 0x00B87D10 File Offset: 0x00B85F10
		[NullableContext(1)]
		public TrapDefenseBuildingMachineInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031ABC RID: 203452 RVA: 0x00B87D1C File Offset: 0x00B85F1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031ABD RID: 203453 RVA: 0x00B87DC4 File Offset: 0x00B85FC4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingMachineInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingMachineInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031ABE RID: 203454 RVA: 0x00B87E07 File Offset: 0x00B86007
		protected override void OnBeforeDestroy()
		{
			this.InfoItem = null;
		}

		// Token: 0x06031ABF RID: 203455 RVA: 0x00B87E10 File Offset: 0x00B86010
		private void OnClickedMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401A86B RID: 108651
		[Nullable(2)]
		protected TrapDefenseBuildingDevelopDetailInfoItem InfoItem;

		// Token: 0x0200AC77 RID: 44151
		internal class EMainDefine
		{
			// Token: 0x0403469D RID: 214685
			public const int BtnMask = 0;

			// Token: 0x0403469E RID: 214686
			public const int BuildingItem = 1;
		}
	}
}
