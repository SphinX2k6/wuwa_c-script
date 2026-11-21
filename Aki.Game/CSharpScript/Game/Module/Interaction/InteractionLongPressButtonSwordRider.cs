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
	// Token: 0x02004833 RID: 18483
	[NullableContext(2)]
	[Nullable(0)]
	public class InteractionLongPressButtonSwordRider : InteractionLongPressButton
	{
		// Token: 0x0602E734 RID: 190260 RVA: 0x00CF5E8C File Offset: 0x00CF408C
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

		// Token: 0x0602E735 RID: 190261 RVA: 0x00CF5FBC File Offset: 0x00CF41BC
		protected override UniTask OnBeforeStartAsync()
		{
			InteractionLongPressButtonSwordRider.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InteractionLongPressButtonSwordRider.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E736 RID: 190262 RVA: 0x00CF6000 File Offset: 0x00CF4200
		protected override void ResolveComponents()
		{
			int name = this.IsMobile ? 0 : 0;
			int name2 = this.IsMobile ? 1 : 1;
			this.ProgressFill = base.GetTexture(name2);
			base.SetupPressButton(base.GetButton(name));
			this.SequencePlayer = ((this.RootItem != null) ? new UiSequencePlayer(this.RootItem) : null);
		}

		// Token: 0x0602E737 RID: 190263 RVA: 0x00CF605D File Offset: 0x00CF425D
		protected override void SetProgress(float progress)
		{
			UUITexture progressFill = this.ProgressFill;
			if (progressFill == null)
			{
				return;
			}
			progressFill.SetFillAmount(progress);
		}

		// Token: 0x0602E738 RID: 190264 RVA: 0x00CF6070 File Offset: 0x00CF4270
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

		// Token: 0x0602E739 RID: 190265 RVA: 0x00CF60A8 File Offset: 0x00CF42A8
		protected override void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.SetActive(false);
		}

		// Token: 0x0602E73A RID: 190266 RVA: 0x00CF60BC File Offset: 0x00CF42BC
		protected override void PlayEnterSequence()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x0602E73B RID: 190267 RVA: 0x00CF60E8 File Offset: 0x00CF42E8
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

		// Token: 0x04018BA7 RID: 101287
		private UUITexture ProgressFill;

		// Token: 0x04018BA8 RID: 101288
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04018BA9 RID: 101289
		private InputMultiKeyItem KeyItem;

		// Token: 0x04018BAA RID: 101290
		private bool IsMobile;

		// Token: 0x0200A499 RID: 42137
		[NullableContext(0)]
		private enum EChildTypeMobile
		{
			// Token: 0x04032FFB RID: 208891
			Button,
			// Token: 0x04032FFC RID: 208892
			ProgressFill,
			// Token: 0x04032FFD RID: 208893
			Icon,
			// Token: 0x04032FFE RID: 208894
			InfoPanel,
			// Token: 0x04032FFF RID: 208895
			TipsText
		}

		// Token: 0x0200A49A RID: 42138
		[NullableContext(0)]
		private enum EChildTypePc
		{
			// Token: 0x04033001 RID: 208897
			Button,
			// Token: 0x04033002 RID: 208898
			ProgressFill,
			// Token: 0x04033003 RID: 208899
			Icon,
			// Token: 0x04033004 RID: 208900
			KeyItem,
			// Token: 0x04033005 RID: 208901
			InfoPanel,
			// Token: 0x04033006 RID: 208902
			TipsText
		}
	}
}
