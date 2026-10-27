using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053D8 RID: 21464
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryLevelItem : UiPanelBase
	{
		// Token: 0x06036DCB RID: 224715 RVA: 0x00CFE243 File Offset: 0x00CFC443
		public DarkCoastDeliveryLevelItem(DarkCoastDeliveryLevelData data)
		{
			this.LevelData = data;
		}

		// Token: 0x06036DCC RID: 224716 RVA: 0x00CFE25C File Offset: 0x00CFC45C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickToggleCallback))
			};
		}

		// Token: 0x06036DCD RID: 224717 RVA: 0x00CFE31C File Offset: 0x00CFC51C
		protected override void OnBeforeCreateImplement()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
			base.GetExtendToggle(4).CanExecuteChange.Bind(() => base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_UnChecked);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x06036DCE RID: 224718 RVA: 0x00CFE36B File Offset: 0x00CFC56B
		protected override void OnStart()
		{
			this.RefreshUi();
		}

		// Token: 0x06036DCF RID: 224719 RVA: 0x00CFE373 File Offset: 0x00CFC573
		protected override void OnBeforeShow()
		{
			if (this.IsFirstShow)
			{
				this.PlaySequence(true);
				this.IsFirstShow = false;
			}
		}

		// Token: 0x06036DD0 RID: 224720 RVA: 0x00CFE38C File Offset: 0x00CFC58C
		public void RefreshUi()
		{
			DarkCoastDelivery config = this.LevelData.Config;
			MingSuDefine.EDarkCoastDeliveryLevelDataState darkCoastDeliveryGuardState = this.LevelData.GetDarkCoastDeliveryGuardState();
			base.SetTextureShowUntilLoaded(config.Icon, base.GetTexture(0), null);
			this.SetSpriteByPath(config.LevelIcon, base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(config.LevelSelectIcon, base.GetSprite(2), false, null, null);
			base.GetItem(3).SetUIActive(darkCoastDeliveryGuardState == MingSuDefine.EDarkCoastDeliveryLevelDataState.Passed);
		}

		// Token: 0x06036DD1 RID: 224721 RVA: 0x00CFE414 File Offset: 0x00CFC614
		public void PlaySequence(bool skipToLastFrame)
		{
			switch (this.LevelData.GetDarkCoastDeliveryGuardState())
			{
			case MingSuDefine.EDarkCoastDeliveryLevelDataState.Lock:
				this.UiLevelSequence.PlaySequence("Lock", false, null);
				break;
			case MingSuDefine.EDarkCoastDeliveryLevelDataState.UnLock:
				this.UiLevelSequence.PlaySequence("Unlock", false, null);
				break;
			case MingSuDefine.EDarkCoastDeliveryLevelDataState.Passed:
				this.UiLevelSequence.PlaySequence("Receive", false, null);
				break;
			case MingSuDefine.EDarkCoastDeliveryLevelDataState.Received:
				this.UiLevelSequence.PlaySequence("Done", false, null);
				break;
			}
			if (skipToLastFrame)
			{
				this.UiLevelSequence.StopPrevSequence(false, true);
			}
		}

		// Token: 0x06036DD2 RID: 224722 RVA: 0x00CFE4C8 File Offset: 0x00CFC6C8
		public void SetSelect(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(4).SetToggleStateForce(state2, false, false, false);
		}

		// Token: 0x06036DD3 RID: 224723 RVA: 0x00CFE4F0 File Offset: 0x00CFC6F0
		public void JumpUnCheckedToCheckedAnim()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			FToggleAnimationPlayInfo ftoggleAnimationPlayInfo = extendToggle.StateSwitchAnimations.Get(EToggleStateSwitch.UnCheckedToChecked);
			if (ftoggleAnimationPlayInfo == null)
			{
				return;
			}
			FSoftObjectPath levelSequence = ftoggleAnimationPlayInfo.Animation.LevelSequence;
			(extendToggle.GetOwner() as AUIBaseActor).SequenceJumpToEnd(levelSequence);
		}

		// Token: 0x06036DD4 RID: 224724 RVA: 0x00CFE53A File Offset: 0x00CFC73A
		private void OnClickToggleCallback(EToggleState state)
		{
			if (this.ClickToggleCallBack != null)
			{
				this.ClickToggleCallBack(this.LevelData, this);
			}
		}

		// Token: 0x06036DD5 RID: 224725 RVA: 0x00CFE556 File Offset: 0x00CFC756
		public void SetClickToggleCallback(Action<DarkCoastDeliveryLevelData, DarkCoastDeliveryLevelItem> callback)
		{
			this.ClickToggleCallBack = callback;
		}

		// Token: 0x0401CF36 RID: 118582
		public readonly DarkCoastDeliveryLevelData LevelData;

		// Token: 0x0401CF37 RID: 118583
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401CF38 RID: 118584
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<DarkCoastDeliveryLevelData, DarkCoastDeliveryLevelItem> ClickToggleCallBack;

		// Token: 0x0401CF39 RID: 118585
		private bool IsFirstShow = true;

		// Token: 0x0200B67C RID: 46716
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0403746F RID: 226415
			public const int MonsterTexture = 0;

			// Token: 0x04037470 RID: 226416
			public const int LevelIcon = 1;

			// Token: 0x04037471 RID: 226417
			public const int LevelSelectIcon = 2;

			// Token: 0x04037472 RID: 226418
			public const int RedDotItem = 3;

			// Token: 0x04037473 RID: 226419
			public const int Toggle = 4;

			// Token: 0x04037474 RID: 226420
			public const int ArrowItem = 5;
		}
	}
}
