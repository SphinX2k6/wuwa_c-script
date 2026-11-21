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
	// Token: 0x02003A8D RID: 14989
	public class TrapDefenseBuildingMachineInfoView : UiViewBase
	{
		// Token: 0x0602684B RID: 157771 RVA: 0x00ACBCC4 File Offset: 0x00AC9EC4
		[NullableContext(1)]
		public TrapDefenseBuildingMachineInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602684C RID: 157772 RVA: 0x00ACBCD0 File Offset: 0x00AC9ED0
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

		// Token: 0x0602684D RID: 157773 RVA: 0x00ACBD78 File Offset: 0x00AC9F78
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingMachineInfoView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingMachineInfoView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602684E RID: 157774 RVA: 0x00ACBDBB File Offset: 0x00AC9FBB
		protected override void OnBeforeDestroy()
		{
			this.InfoItem = null;
		}

		// Token: 0x0602684F RID: 157775 RVA: 0x00ACBDC4 File Offset: 0x00AC9FC4
		private void OnClickedMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x040151BD RID: 86461
		[Nullable(2)]
		protected TrapDefenseBuildingDevelopDetailInfoItem InfoItem;

		// Token: 0x02009697 RID: 38551
		internal class EMainDefine
		{
			// Token: 0x0402F04E RID: 192590
			public const int BtnMask = 0;

			// Token: 0x0402F04F RID: 192591
			public const int BuildingItem = 1;
		}
	}
}
