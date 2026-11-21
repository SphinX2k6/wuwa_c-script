using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BB RID: 17339
	[NullableContext(1)]
	[Nullable(0)]
	public class DarkCoastDeliveryLevelItem : UiPanelBase
	{
		// Token: 0x0602BD12 RID: 179474 RVA: 0x00C4D313 File Offset: 0x00C4B513
		public DarkCoastDeliveryLevelItem(DarkCoastDeliveryLevelData data)
		{
			this.LevelData = data;
		}

		// Token: 0x0602BD13 RID: 179475 RVA: 0x00C4D32C File Offset: 0x00C4B52C
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

		// Token: 0x0602BD14 RID: 179476 RVA: 0x00C4D3EC File Offset: 0x00C4B5EC
		protected override void OnBeforeCreateImplement()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
			base.GetExtendToggle(4).CanExecuteChange.Bind(() => base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_UnChecked);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0602BD15 RID: 179477 RVA: 0x00C4D43B File Offset: 0x00C4B63B
		protected override void OnStart()
		{
			this.RefreshUi();
		}

		// Token: 0x0602BD16 RID: 179478 RVA: 0x00C4D443 File Offset: 0x00C4B643
		protected override void OnBeforeShow()
		{
			if (this.IsFirstShow)
			{
				this.PlaySequence(true);
				this.IsFirstShow = false;
			}
		}

		// Token: 0x0602BD17 RID: 179479 RVA: 0x00C4D45C File Offset: 0x00C4B65C
		public void RefreshUi()
		{
			DarkCoastDelivery config = this.LevelData.Config;
			MingSuDefine.EDarkCoastDeliveryLevelDataState darkCoastDeliveryGuardState = this.LevelData.GetDarkCoastDeliveryGuardState();
			base.SetTextureShowUntilLoaded(config.Icon, base.GetTexture(0), null);
			this.SetSpriteByPath(config.LevelIcon, base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(config.LevelSelectIcon, base.GetSprite(2), false, null, null);
			base.GetItem(3).SetUIActive(darkCoastDeliveryGuardState == MingSuDefine.EDarkCoastDeliveryLevelDataState.Passed);
		}

		// Token: 0x0602BD18 RID: 179480 RVA: 0x00C4D4E4 File Offset: 0x00C4B6E4
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

		// Token: 0x0602BD19 RID: 179481 RVA: 0x00C4D598 File Offset: 0x00C4B798
		public void SetSelect(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(4).SetToggleStateForce(state2, false, false, false);
		}

		// Token: 0x0602BD1A RID: 179482 RVA: 0x00C4D5C0 File Offset: 0x00C4B7C0
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

		// Token: 0x0602BD1B RID: 179483 RVA: 0x00C4D60A File Offset: 0x00C4B80A
		private void OnClickToggleCallback(EToggleState state)
		{
			if (this.ClickToggleCallBack != null)
			{
				this.ClickToggleCallBack(this.LevelData, this);
			}
		}

		// Token: 0x0602BD1C RID: 179484 RVA: 0x00C4D626 File Offset: 0x00C4B826
		public void SetClickToggleCallback(Action<DarkCoastDeliveryLevelData, DarkCoastDeliveryLevelItem> callback)
		{
			this.ClickToggleCallBack = callback;
		}

		// Token: 0x040179CE RID: 96718
		public readonly DarkCoastDeliveryLevelData LevelData;

		// Token: 0x040179CF RID: 96719
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x040179D0 RID: 96720
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<DarkCoastDeliveryLevelData, DarkCoastDeliveryLevelItem> ClickToggleCallBack;

		// Token: 0x040179D1 RID: 96721
		private bool IsFirstShow = true;

		// Token: 0x0200A0B4 RID: 41140
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04031EC4 RID: 204484
			public const int MonsterTexture = 0;

			// Token: 0x04031EC5 RID: 204485
			public const int LevelIcon = 1;

			// Token: 0x04031EC6 RID: 204486
			public const int LevelSelectIcon = 2;

			// Token: 0x04031EC7 RID: 204487
			public const int RedDotItem = 3;

			// Token: 0x04031EC8 RID: 204488
			public const int Toggle = 4;

			// Token: 0x04031EC9 RID: 204489
			public const int ArrowItem = 5;
		}
	}
}
