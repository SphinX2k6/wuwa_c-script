using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200585B RID: 22619
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressButtonSwordRider : InteractionLongPressButton
	{
		// Token: 0x06039817 RID: 235543 RVA: 0x00DA7164 File Offset: 0x00DA5364
		protected override void OnRegisterComponent()
		{
			this.IsMobile = Info.Instance.IsInTouch();
			if (this.IsMobile)
			{
				this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
				{
					new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
					new ValueTuple<int, Type>(1, typeof(UUITexture)),
					new ValueTuple<int, Type>(2, typeof(UUISprite)),
					new ValueTuple<int, Type>(3, typeof(UUIItem)),
					new ValueTuple<int, Type>(4, typeof(UUIText))
				};
				return;
			}
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x06039818 RID: 235544 RVA: 0x00DA7294 File Offset: 0x00DA5494
		protected override UniTask OnBeforeStartAsync()
		{
			InteractionLongPressButtonSwordRider.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InteractionLongPressButtonSwordRider.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039819 RID: 235545 RVA: 0x00DA72D8 File Offset: 0x00DA54D8
		protected override void ResolveComponents()
		{
			int name = this.IsMobile ? 0 : 0;
			int name2 = this.IsMobile ? 1 : 1;
			this.ProgressFill = base.GetTexture(name2);
			base.SetupPressButton(base.GetButton(name));
			this.SequencePlayer = ((this.RootItem != null) ? new UiSequencePlayer(this.RootItem) : null);
		}

		// Token: 0x0603981A RID: 235546 RVA: 0x00DA7335 File Offset: 0x00DA5535
		protected override void SetProgress(float progress)
		{
			UUITexture progressFill = this.ProgressFill;
			if (progressFill == null)
			{
				return;
			}
			progressFill.SetFillAmount(progress);
		}

		// Token: 0x0603981B RID: 235547 RVA: 0x00DA7348 File Offset: 0x00DA5548
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

		// Token: 0x0603981C RID: 235548 RVA: 0x00DA7380 File Offset: 0x00DA5580
		protected override void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x0603981D RID: 235549 RVA: 0x00DA7394 File Offset: 0x00DA5594
		protected override void PlayEnterSequence()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x0603981E RID: 235550 RVA: 0x00DA73C0 File Offset: 0x00DA55C0
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.ProgressFill = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.KeyItem = null;
		}

		// Token: 0x0401E10A RID: 123146
		private UUITexture ProgressFill;

		// Token: 0x0401E10B RID: 123147
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401E10C RID: 123148
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401E10D RID: 123149
		private bool IsMobile;

		// Token: 0x0200BA82 RID: 47746
		[NullableContext(0)]
		private enum EChildTypeMobile
		{
			// Token: 0x04038604 RID: 230916
			Button,
			// Token: 0x04038605 RID: 230917
			ProgressFill,
			// Token: 0x04038606 RID: 230918
			Icon,
			// Token: 0x04038607 RID: 230919
			InfoPanel,
			// Token: 0x04038608 RID: 230920
			TipsText
		}

		// Token: 0x0200BA83 RID: 47747
		[NullableContext(0)]
		private enum EChildTypePc
		{
			// Token: 0x0403860A RID: 230922
			Button,
			// Token: 0x0403860B RID: 230923
			ProgressFill,
			// Token: 0x0403860C RID: 230924
			Icon,
			// Token: 0x0403860D RID: 230925
			KeyItem,
			// Token: 0x0403860E RID: 230926
			InfoPanel,
			// Token: 0x0403860F RID: 230927
			TipsText
		}
	}
}
