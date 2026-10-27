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
	// Token: 0x020053DA RID: 21466
	public class DarkCoastDeliveryLevelUpView : UiViewBase
	{
		// Token: 0x06036DDA RID: 224730 RVA: 0x00CFE5C7 File Offset: 0x00CFC7C7
		[NullableContext(1)]
		public DarkCoastDeliveryLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036DDB RID: 224731 RVA: 0x00CFE5D0 File Offset: 0x00CFC7D0
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

		// Token: 0x06036DDC RID: 224732 RVA: 0x00CFE664 File Offset: 0x00CFC864
		protected override UniTask OnBeforeStartAsync()
		{
			DarkCoastDeliveryLevelUpView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DarkCoastDeliveryLevelUpView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036DDD RID: 224733 RVA: 0x00CFE6A7 File Offset: 0x00CFC8A7
		[NullableContext(1)]
		private DarkCoastDeliveryLevelUpItem InitLevelUpItem()
		{
			return new DarkCoastDeliveryLevelUpItem();
		}

		// Token: 0x06036DDE RID: 224734 RVA: 0x00CFE6AE File Offset: 0x00CFC8AE
		private void OnClickCloseBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401CF3A RID: 118586
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DarkCoastDeliveryLevelUpItem, DarkCoastDeliveryLevelData> VisionLayout;

		// Token: 0x0200B67E RID: 46718
		private static class EComponent
		{
			// Token: 0x04037476 RID: 226422
			public const int CloseBtn = 0;

			// Token: 0x04037477 RID: 226423
			public const int PreLevelTexture = 1;

			// Token: 0x04037478 RID: 226424
			public const int CurLevelTexture = 2;

			// Token: 0x04037479 RID: 226425
			public const int VisionLayout = 3;
		}
	}
}
