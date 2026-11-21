using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200482F RID: 18479
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressButtonCoreFix : InteractionLongPressButton
	{
		// Token: 0x0602E71E RID: 190238 RVA: 0x00CF5C44 File Offset: 0x00CF3E44
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

		// Token: 0x0602E71F RID: 190239 RVA: 0x00CF5CD4 File Offset: 0x00CF3ED4
		protected override UniTask OnBeforeStartAsync()
		{
			InteractionLongPressButtonCoreFix.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InteractionLongPressButtonCoreFix.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E720 RID: 190240 RVA: 0x00CF5D17 File Offset: 0x00CF3F17
		protected override void ResolveComponents()
		{
			this.ProgressRing = base.GetTexture(1);
			base.SetupPressButton(base.GetButton(0));
		}

		// Token: 0x0602E721 RID: 190241 RVA: 0x00CF5D33 File Offset: 0x00CF3F33
		protected override void SetProgress(float progress)
		{
			UUITexture progressRing = this.ProgressRing;
			if (progressRing == null)
			{
				return;
			}
			progressRing.SetFillAmount(progress);
		}

		// Token: 0x0602E722 RID: 190242 RVA: 0x00CF5D46 File Offset: 0x00CF3F46
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

		// Token: 0x0602E723 RID: 190243 RVA: 0x00CF5D7E File Offset: 0x00CF3F7E
		protected override void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x0602E724 RID: 190244 RVA: 0x00CF5D91 File Offset: 0x00CF3F91
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.ProgressRing = null;
			this.KeyItem = null;
		}

		// Token: 0x04018BA0 RID: 101280
		private UUITexture ProgressRing;

		// Token: 0x04018BA1 RID: 101281
		private InputMultiKeyItem KeyItem;

		// Token: 0x04018BA2 RID: 101282
		private bool IsMobile;

		// Token: 0x0200A496 RID: 42134
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04032FF1 RID: 208881
			Button,
			// Token: 0x04032FF2 RID: 208882
			ProgressRing,
			// Token: 0x04032FF3 RID: 208883
			TipsPop,
			// Token: 0x04032FF4 RID: 208884
			HotKey
		}
	}
}
