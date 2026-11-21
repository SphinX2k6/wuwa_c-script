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
	// Token: 0x02003F7C RID: 16252
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineComponentItem : UiPanelBase
	{
		// Token: 0x0602921A RID: 168474 RVA: 0x00B8C430 File Offset: 0x00B8A630
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

		// Token: 0x0602921B RID: 168475 RVA: 0x00B8C534 File Offset: 0x00B8A734
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

		// Token: 0x0602921C RID: 168476 RVA: 0x00B8C580 File Offset: 0x00B8A780
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineComponentItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineComponentItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602921D RID: 168477 RVA: 0x00B8C5C3 File Offset: 0x00B8A7C3
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0602921E RID: 168478 RVA: 0x00B8C5D6 File Offset: 0x00B8A7D6
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

		// Token: 0x0602921F RID: 168479 RVA: 0x00B8C60C File Offset: 0x00B8A80C
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

		// Token: 0x06029220 RID: 168480 RVA: 0x00B8C658 File Offset: 0x00B8A858
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

		// Token: 0x06029221 RID: 168481 RVA: 0x00B8C6D6 File Offset: 0x00B8A8D6
		public void SetComponentFunction(Action<QuestMultiLineComponentData> componentFunction)
		{
			this.ComponentFunction = componentFunction;
		}

		// Token: 0x06029222 RID: 168482 RVA: 0x00B8C6DF File Offset: 0x00B8A8DF
		public void SetClickable(bool clickable)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(clickable);
		}

		// Token: 0x06029223 RID: 168483 RVA: 0x00B8C6F4 File Offset: 0x00B8A8F4
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

		// Token: 0x06029224 RID: 168484 RVA: 0x00B8C740 File Offset: 0x00B8A940
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

		// Token: 0x06029225 RID: 168485 RVA: 0x00B8C7E8 File Offset: 0x00B8A9E8
		public void RefreshDialogueSide()
		{
			if (this.ComponentData != null)
			{
				this.RefreshDialogue(this.ComponentData);
			}
		}

		// Token: 0x06029226 RID: 168486 RVA: 0x00B8C800 File Offset: 0x00B8AA00
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

		// Token: 0x06029227 RID: 168487 RVA: 0x00B8C884 File Offset: 0x00B8AA84
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

		// Token: 0x06029228 RID: 168488 RVA: 0x00B8C913 File Offset: 0x00B8AB13
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

		// Token: 0x06029229 RID: 168489 RVA: 0x00B8C938 File Offset: 0x00B8AB38
		private void OnToggleClickComponent(EToggleState state)
		{
			this.OnClickComponent();
		}

		// Token: 0x0602922A RID: 168490 RVA: 0x00B8C940 File Offset: 0x00B8AB40
		public void SetVisibleForAnim(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x0602922B RID: 168491 RVA: 0x00B8C954 File Offset: 0x00B8AB54
		public UniTask PlayAppearAsync()
		{
			QuestMultiLineComponentItem.<PlayAppearAsync>d__26 <PlayAppearAsync>d__;
			<PlayAppearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAppearAsync>d__.<>4__this = this;
			<PlayAppearAsync>d__.<>1__state = -1;
			<PlayAppearAsync>d__.<>t__builder.Start<QuestMultiLineComponentItem.<PlayAppearAsync>d__26>(ref <PlayAppearAsync>d__);
			return <PlayAppearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401662C RID: 91692
		private const float ROLE_ICON_DESIGN_SIZE = 160f;

		// Token: 0x0401662D RID: 91693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineComponentData> ComponentFunction;

		// Token: 0x0401662E RID: 91694
		[Nullable(2)]
		private QuestMultiLineComponentData ComponentData;

		// Token: 0x0401662F RID: 91695
		[Nullable(2)]
		private QuestMultiLineDialogueItem DialogLeftPanel;

		// Token: 0x04016630 RID: 91696
		[Nullable(2)]
		private QuestMultiLineDialogueItem DialogRightPanel;

		// Token: 0x04016631 RID: 91697
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04016632 RID: 91698
		[Nullable(2)]
		private QuestMultiLineFightStateItem FightStateItem;

		// Token: 0x04016633 RID: 91699
		private string FightStatePrefabPath = string.Empty;

		// Token: 0x04016634 RID: 91700
		private string HeadLoopEffectKey = string.Empty;
	}
}
