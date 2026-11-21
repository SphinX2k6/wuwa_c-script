using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BD RID: 17341
	public class DarkCoastDeliveryLevelUpView : UiViewBase
	{
		// Token: 0x0602BD21 RID: 179489 RVA: 0x00C4D697 File Offset: 0x00C4B897
		[NullableContext(1)]
		public DarkCoastDeliveryLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BD22 RID: 179490 RVA: 0x00C4D6A0 File Offset: 0x00C4B8A0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn))
			};
		}

		// Token: 0x0602BD23 RID: 179491 RVA: 0x00C4D734 File Offset: 0x00C4B934
		protected override UniTask OnBeforeStartAsync()
		{
			DarkCoastDeliveryLevelUpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DarkCoastDeliveryLevelUpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BD24 RID: 179492 RVA: 0x00C4D777 File Offset: 0x00C4B977
		[NullableContext(1)]
		private DarkCoastDeliveryLevelUpItem InitLevelUpItem()
		{
			return new DarkCoastDeliveryLevelUpItem();
		}

		// Token: 0x0602BD25 RID: 179493 RVA: 0x00C4D77E File Offset: 0x00C4B97E
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x040179D2 RID: 96722
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DarkCoastDeliveryLevelUpItem, DarkCoastDeliveryLevelData> VisionLayout;

		// Token: 0x0200A0B6 RID: 41142
		private static class EComponent
		{
			// Token: 0x04031ECB RID: 204491
			public const int CloseBtn = 0;

			// Token: 0x04031ECC RID: 204492
			public const int PreLevelTexture = 1;

			// Token: 0x04031ECD RID: 204493
			public const int CurLevelTexture = 2;

			// Token: 0x04031ECE RID: 204494
			public const int VisionLayout = 3;
		}
	}
}
