using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005857 RID: 22615
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressButtonCoreFix : InteractionLongPressButton
	{
		// Token: 0x06039801 RID: 235521 RVA: 0x00DA6F1C File Offset: 0x00DA511C
		protected override void OnRegisterComponent()
		{
			this.IsMobile = Info.Instance.IsInTouch();
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			if (!this.IsMobile)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
			}
		}

		// Token: 0x06039802 RID: 235522 RVA: 0x00DA6FAC File Offset: 0x00DA51AC
		protected override UniTask OnBeforeStartAsync()
		{
			InteractionLongPressButtonCoreFix.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InteractionLongPressButtonCoreFix.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039803 RID: 235523 RVA: 0x00DA6FEF File Offset: 0x00DA51EF
		protected override void ResolveComponents()
		{
			this.ProgressRing = base.GetTexture(1);
			base.SetupPressButton(base.GetButton(0));
		}

		// Token: 0x06039804 RID: 235524 RVA: 0x00DA700B File Offset: 0x00DA520B
		protected override void SetProgress(float progress)
		{
			UUITexture progressRing = this.ProgressRing;
			if (progressRing == null)
			{
				return;
			}
			progressRing.SetFillAmount(progress);
		}

		// Token: 0x06039805 RID: 235525 RVA: 0x00DA701E File Offset: 0x00DA521E
		protected override void RefreshKeyItem(string actionName)
		{
			if (this.KeyItem == null)
			{
				return;
			}
			this.KeyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = (actionName ?? "通用交互")
			}, false);
			this.KeyItem.SetActive(true);
		}

		// Token: 0x06039806 RID: 235526 RVA: 0x00DA7056 File Offset: 0x00DA5256
		protected override void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x06039807 RID: 235527 RVA: 0x00DA7069 File Offset: 0x00DA5269
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.ProgressRing = null;
			this.KeyItem = null;
		}

		// Token: 0x0401E103 RID: 123139
		private UUITexture ProgressRing;

		// Token: 0x0401E104 RID: 123140
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401E105 RID: 123141
		private bool IsMobile;

		// Token: 0x0200BA7F RID: 47743
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040385FA RID: 230906
			Button,
			// Token: 0x040385FB RID: 230907
			ProgressRing,
			// Token: 0x040385FC RID: 230908
			TipsPop,
			// Token: 0x040385FD RID: 230909
			HotKey
		}
	}
}
