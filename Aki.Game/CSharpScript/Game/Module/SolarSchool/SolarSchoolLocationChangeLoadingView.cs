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
	// Token: 0x02005A2D RID: 23085
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolLocationChangeLoadingView : UiTickViewBase
	{
		// Token: 0x06038D97 RID: 232855 RVA: 0x00FEA369 File Offset: 0x00FE8569
		public SolarSchoolLocationChangeLoadingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D98 RID: 232856 RVA: 0x00FEA374 File Offset: 0x00FE8574
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D99 RID: 232857 RVA: 0x00FEA3E0 File Offset: 0x00FE85E0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolLocationChangeLoadingView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolLocationChangeLoadingView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D9A RID: 232858 RVA: 0x00FEA423 File Offset: 0x00FE8623
		protected override void OnBeforeShow()
		{
			this.Param.Transition.OnLoadingViewReady(this);
		}

		// Token: 0x06038D9B RID: 232859 RVA: 0x00FEA438 File Offset: 0x00FE8638
		protected override void OnTick(float delta)
		{
			this.Param.Transition.UpdateLoadingSequence();
			if (!this.Covered && this.Param.Transition.IsLoadingSequencePlaying && this.CoverItem.GetAlpha() >= 1f)
			{
				this.ApplyLocation();
			}
		}

		// Token: 0x06038D9C RID: 232860 RVA: 0x00FEA487 File Offset: 0x00FE8687
		protected override void OnAfterShow()
		{
			this.ApplyLocation();
		}

		// Token: 0x06038D9D RID: 232861 RVA: 0x00FEA48F File Offset: 0x00FE868F
		private void ApplyLocation()
		{
			if (this.Covered)
			{
				return;
			}
			this.Covered = true;
			this.Param.CoveredCallback();
		}

		// Token: 0x0401DEB1 RID: 122545
		private SolarSchoolLocationChangeLoadingParam Param;

		// Token: 0x0401DEB2 RID: 122546
		private UUIItem CoverItem;

		// Token: 0x0401DEB3 RID: 122547
		private bool Covered;

		// Token: 0x0200B5FD RID: 46589
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403846B RID: 230507
			public const int LocationIcon = 0;

			// Token: 0x0403846C RID: 230508
			public const int LocationName = 1;
		}
	}
}
