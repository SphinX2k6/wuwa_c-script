using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FB3 RID: 20403
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineComponentItem : UiPanelBase
	{
		// Token: 0x060343AC RID: 213932 RVA: 0x00C42C84 File Offset: 0x00C40E84
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleClickComponent))
			};
		}

		// Token: 0x060343AD RID: 213933 RVA: 0x00C42D88 File Offset: 0x00C40F88
		public UniTask RefreshComponent(QuestMultiLineComponentData componentData)
		{
			QuestMultiLineComponentItem.<RefreshComponent>d__10 <RefreshComponent>d__;
			<RefreshComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshComponent>d__.<>4__this = this;
			<RefreshComponent>d__.componentData = componentData;
			<RefreshComponent>d__.<>1__state = -1;
			<RefreshComponent>d__.<>t__builder.Start<QuestMultiLineComponentItem.<RefreshComponent>d__10>(ref <RefreshComponent>d__);
			return <RefreshComponent>d__.<>t__builder.Task;
		}

		// Token: 0x060343AE RID: 213934 RVA: 0x00C42DD4 File Offset: 0x00C40FD4
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineComponentItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineComponentItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060343AF RID: 213935 RVA: 0x00C42E17 File Offset: 0x00C41017
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060343B0 RID: 213936 RVA: 0x00C42E2A File Offset: 0x00C4102A
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			if (this.FightStateItem != null)
			{
				this.FightStateItem.DestroyAsync();
				this.FightStateItem = null;
			}
		}

		// Token: 0x060343B1 RID: 213937 RVA: 0x00C42E60 File Offset: 0x00C41060
		public void RefreshSelected(bool isSelected)
		{
			base.GetItem(1).SetUIActive(isSelected);
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle != null)
			{
				EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				extendToggle.SetToggleStateForce(state, false, false, false);
			}
			if (isSelected)
			{
				AudioSystem.Instance.PostEvent("play_ui_missionmap_roleitem_click");
			}
		}

		// Token: 0x060343B2 RID: 213938 RVA: 0x00C42EAC File Offset: 0x00C410AC
		public void RefreshRoleState(int statusType)
		{
			if (statusType == 0)
			{
				base.GetSprite(2).SetUIActive(false);
				return;
			}
			base.GetSprite(2).SetUIActive(true);
			string statusIcon = QuestMultiLineConfig.GetComponentStatusConfigById(statusType).Value.StatusIcon;
			if (!string.IsNullOrEmpty(statusIcon))
			{
				base.GetSprite(2).SetUIActive(true);
				this.SetSpriteByPath(statusIcon, base.GetSprite(2), false, null, null);
				return;
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x060343B3 RID: 213939 RVA: 0x00C42F2A File Offset: 0x00C4112A
		public void SetComponentFunction(Action<QuestMultiLineComponentData> componentFunction)
		{
			this.ComponentFunction = componentFunction;
		}

		// Token: 0x060343B4 RID: 213940 RVA: 0x00C42F33 File Offset: 0x00C41133
		public void SetClickable(bool clickable)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(clickable);
		}

		// Token: 0x060343B5 RID: 213941 RVA: 0x00C42F48 File Offset: 0x00C41148
		private UniTask RefreshFightState(QuestMultiLineComponentData componentData)
		{
			QuestMultiLineComponentItem.<RefreshFightState>d__18 <RefreshFightState>d__;
			<RefreshFightState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFightState>d__.<>4__this = this;
			<RefreshFightState>d__.componentData = componentData;
			<RefreshFightState>d__.<>1__state = -1;
			<RefreshFightState>d__.<>t__builder.Start<QuestMultiLineComponentItem.<RefreshFightState>d__18>(ref <RefreshFightState>d__);
			return <RefreshFightState>d__.<>t__builder.Task;
		}

		// Token: 0x060343B6 RID: 213942 RVA: 0x00C42F94 File Offset: 0x00C41194
		private void RefreshHeadLoopEffect(QuestMultiLineComponentData componentData)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			string text = componentData.HeadLoopEffect ?? string.Empty;
			if (text == this.HeadLoopEffectKey)
			{
				if (!string.IsNullOrEmpty(text) && !this.SequencePlayer.IsPlayingSequence(text))
				{
					this.SequencePlayer.PlayLevelSequenceByName(text, false, null, false);
				}
				return;
			}
			if (!string.IsNullOrEmpty(this.HeadLoopEffectKey))
			{
				this.SequencePlayer.StopSequenceByKey(this.HeadLoopEffectKey, false, false);
			}
			this.HeadLoopEffectKey = text;
			if (!string.IsNullOrEmpty(text))
			{
				this.SequencePlayer.PlayLevelSequenceByName(text, false, null, false);
			}
		}

		// Token: 0x060343B7 RID: 213943 RVA: 0x00C4303C File Offset: 0x00C4123C
		public void RefreshDialogueSide()
		{
			if (this.ComponentData != null)
			{
				this.RefreshDialogue(this.ComponentData);
			}
		}

		// Token: 0x060343B8 RID: 213944 RVA: 0x00C43054 File Offset: 0x00C41254
		private void RefreshDialogue(QuestMultiLineComponentData componentData)
		{
			if (QuestMultiLineUtils.IsComponentFinish(componentData))
			{
				QuestMultiLineDialogueItem dialogLeftPanel = this.DialogLeftPanel;
				if (dialogLeftPanel != null)
				{
					dialogLeftPanel.SetDialogueActive(false);
				}
				QuestMultiLineDialogueItem dialogRightPanel = this.DialogRightPanel;
				if (dialogRightPanel == null)
				{
					return;
				}
				dialogRightPanel.SetDialogueActive(false);
				return;
			}
			else
			{
				bool flag = this.ShouldUseLeftDialogue();
				QuestMultiLineDialogueItem dialogLeftPanel2 = this.DialogLeftPanel;
				if (dialogLeftPanel2 != null)
				{
					dialogLeftPanel2.SetDialogueActive(flag);
				}
				QuestMultiLineDialogueItem dialogRightPanel2 = this.DialogRightPanel;
				if (dialogRightPanel2 != null)
				{
					dialogRightPanel2.SetDialogueActive(!flag);
				}
				QuestMultiLineDialogueItem questMultiLineDialogueItem = flag ? this.DialogLeftPanel : this.DialogRightPanel;
				if (questMultiLineDialogueItem == null)
				{
					return;
				}
				questMultiLineDialogueItem.RefreshDialogue(componentData);
				return;
			}
		}

		// Token: 0x060343B9 RID: 213945 RVA: 0x00C430D8 File Offset: 0x00C412D8
		private bool ShouldUseLeftDialogue()
		{
			UUIItem item = base.GetItem(3);
			UUIItem item2 = base.GetItem(4);
			if (item == null || item2 == null)
			{
				return false;
			}
			ULGUIBPLibrary.GetUIWorldPosForceUpdate(item);
			ULGUIBPLibrary.GetUIWorldPosForceUpdate(item2);
			FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(item.GetOwner());
			UUIItem uuiitem = item;
			bool bIsScaledByDPI = true;
			FVector2D fvector2D = new FVector2D(1f, 0.5f);
			if (uuiitem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D).X <= viewportSize.X)
			{
				return false;
			}
			UUIItem uuiitem2 = item2;
			bool bIsScaledByDPI2 = true;
			fvector2D = new FVector2D(0f, 0.5f);
			return uuiitem2.GetPositionInViewportWithPivot(bIsScaledByDPI2, fvector2D).X >= 0f;
		}

		// Token: 0x060343BA RID: 213946 RVA: 0x00C43167 File Offset: 0x00C41367
		private void OnClickComponent()
		{
			if (QuestMultiLineUtils.IsComponentClickable(this.ComponentData))
			{
				Action<QuestMultiLineComponentData> componentFunction = this.ComponentFunction;
				if (componentFunction == null)
				{
					return;
				}
				componentFunction(this.ComponentData);
			}
		}

		// Token: 0x060343BB RID: 213947 RVA: 0x00C4318C File Offset: 0x00C4138C
		private void OnToggleClickComponent(EToggleState state)
		{
			this.OnClickComponent();
		}

		// Token: 0x060343BC RID: 213948 RVA: 0x00C43194 File Offset: 0x00C41394
		public void SetVisibleForAnim(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x060343BD RID: 213949 RVA: 0x00C431A8 File Offset: 0x00C413A8
		public UniTask PlayAppearAsync()
		{
			QuestMultiLineComponentItem.<PlayAppearAsync>d__26 <PlayAppearAsync>d__;
			<PlayAppearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAppearAsync>d__.<>4__this = this;
			<PlayAppearAsync>d__.<>1__state = -1;
			<PlayAppearAsync>d__.<>t__builder.Start<QuestMultiLineComponentItem.<PlayAppearAsync>d__26>(ref <PlayAppearAsync>d__);
			return <PlayAppearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BC57 RID: 113751
		private const float ROLE_ICON_DESIGN_SIZE = 160f;

		// Token: 0x0401BC58 RID: 113752
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineComponentData> ComponentFunction;

		// Token: 0x0401BC59 RID: 113753
		[Nullable(2)]
		private QuestMultiLineComponentData ComponentData;

		// Token: 0x0401BC5A RID: 113754
		[Nullable(2)]
		private QuestMultiLineDialogueItem DialogLeftPanel;

		// Token: 0x0401BC5B RID: 113755
		[Nullable(2)]
		private QuestMultiLineDialogueItem DialogRightPanel;

		// Token: 0x0401BC5C RID: 113756
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401BC5D RID: 113757
		[Nullable(2)]
		private QuestMultiLineFightStateItem FightStateItem;

		// Token: 0x0401BC5E RID: 113758
		private string FightStatePrefabPath = string.Empty;

		// Token: 0x0401BC5F RID: 113759
		private string HeadLoopEffectKey = string.Empty;
	}
}
