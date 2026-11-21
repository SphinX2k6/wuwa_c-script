using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage.View
{
	// Token: 0x020040CB RID: 16587
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneMessageButtonHelper
	{
		// Token: 0x06029EE3 RID: 171747 RVA: 0x00BDA6FC File Offset: 0x00BD88FC
		public PhoneMessageButtonHelper(UUIItem RootItem, AUIBaseActor RootActor, UUIItem RedDotItem, UUISprite SpriteEnterIcon, UUIItem PanelPrefabHead, UUITexture TexIconHead, UUIItem BubbleItem, UUINiagara NiagaraItem, Action<string, UUITexture> SetTextureByPathFunc)
		{
		}

		// Token: 0x06029EE4 RID: 171748 RVA: 0x00BDA76C File Offset: 0x00BD896C
		public void Init()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.<RootItem>P);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceFinishEvent), false);
			this.<RootActor>P.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			this.RedDotInitAlpha = this.<RedDotItem>P.GetAlpha();
			this.RedDotInitScale = new FVector?(this.<RedDotItem>P.GetRelativeTransform().GetScale3D());
			this.EnterIconInitAlpha = this.<SpriteEnterIcon>P.GetAlpha();
			this.EnterIconInitScale = new FVector?(this.<SpriteEnterIcon>P.GetRelativeTransform().GetScale3D());
		}

		// Token: 0x06029EE5 RID: 171749 RVA: 0x00BDA81C File Offset: 0x00BD8A1C
		public void OnShowBattleChildView()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) == "Phone_Icon_Out")
			{
				return;
			}
			if (PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead == 0)
			{
				if (this.CheckModelQueueHaveId())
				{
					this.PopShowHeadIcon();
					return;
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.StopCurrentSequence(false, false);
				}
				this.<PanelPrefabHead>P.SetUIActive(false);
				this.<SpriteEnterIcon>P.SetUIActive(true);
				this.ResetButton();
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.ResumeSequence();
				return;
			}
		}

		// Token: 0x06029EE6 RID: 171750 RVA: 0x00BDA8A5 File Offset: 0x00BD8AA5
		public void OnHideBattleChildView()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PauseSequence();
		}

		// Token: 0x06029EE7 RID: 171751 RVA: 0x00BDA8B7 File Offset: 0x00BD8AB7
		public void Clear()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06029EE8 RID: 171752 RVA: 0x00BDA8D1 File Offset: 0x00BD8AD1
		public void CheckAndPlayPhoneSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) != null)
			{
				return;
			}
			if (!this.CheckModelQueueHaveId())
			{
				return;
			}
			this.PlayPhoneSequence("Phone_Icon_Out");
		}

		// Token: 0x06029EE9 RID: 171753 RVA: 0x00BDA8FC File Offset: 0x00BD8AFC
		public void PopShowHeadIcon()
		{
			if (!this.CheckModelQueueHaveId())
			{
				return;
			}
			PhoneMsgModel instance = PhoneMsgModel.Instance;
			List<int> currentToBeNotifiedMsgInSmallHeadQueue = instance.CurrentToBeNotifiedMsgInSmallHeadQueue;
			int num = currentToBeNotifiedMsgInSmallHeadQueue[0];
			currentToBeNotifiedMsgInSmallHeadQueue.RemoveAt(0);
			instance.CurrentShowingMsgIdInSmallHead = num;
			this.SetAndShowHeadIcon(num);
		}

		// Token: 0x06029EEA RID: 171754 RVA: 0x00BDA938 File Offset: 0x00BD8B38
		private void SetAndShowHeadIcon(int shortMessageId)
		{
			int whichChat = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMessageId).Value.WhichChat;
			string iconSmall = PhoneMsgModel.Instance.GetChatPartnerConfigNew(whichChat).Value.IconSmall;
			this.<PanelPrefabHead>P.SetUIActive(true);
			this.<BubbleItem>P.SetUIActive(true);
			this.<SetTextureByPathFunc>P(iconSmall, this.<TexIconHead>P);
			this.PlayPhoneSequence("Phone_Circle_In");
		}

		// Token: 0x06029EEB RID: 171755 RVA: 0x00BDA9B4 File Offset: 0x00BD8BB4
		public void HideHeadIcon()
		{
			this.PlayPhoneSequence("Phone_Icon_In");
			this.<BubbleItem>P.SetUIActive(false);
			PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead = 0;
		}

		// Token: 0x06029EEC RID: 171756 RVA: 0x00BDA9D8 File Offset: 0x00BD8BD8
		private void SequenceFinishEvent(string sequenceName)
		{
			if (sequenceName == "Phone_Circle_In")
			{
				if (!this.CheckModelQueueHaveId())
				{
					this.HideHeadIcon();
					return;
				}
				this.PopShowHeadIcon();
			}
			if (sequenceName == "Phone_Icon_Out")
			{
				if (!this.CheckModelQueueHaveId())
				{
					this.HideHeadIcon();
					return;
				}
				this.PopShowHeadIcon();
			}
			if (sequenceName == "Phone_Icon_In")
			{
				if (!this.CheckModelQueueHaveId())
				{
					this.ResetButton();
					return;
				}
				this.PlayPhoneSequence("Phone_Icon_Out");
			}
		}

		// Token: 0x06029EED RID: 171757 RVA: 0x00BDAA50 File Offset: 0x00BD8C50
		private void ResetButton()
		{
			this.<SpriteEnterIcon>P.SetUIActive(true);
			this.<PanelPrefabHead>P.SetUIActive(false);
			this.<NiagaraItem>P.SetUIActive(false);
			this.<RedDotItem>P.SetAlpha(this.RedDotInitAlpha);
			if (this.RedDotInitScale != null)
			{
				this.<RedDotItem>P.SetUIItemScale(this.RedDotInitScale.Value);
			}
			this.<SpriteEnterIcon>P.SetAlpha(this.EnterIconInitAlpha);
			if (this.EnterIconInitScale != null)
			{
				this.<SpriteEnterIcon>P.SetUIItemScale(this.EnterIconInitScale.Value);
			}
		}

		// Token: 0x06029EEE RID: 171758 RVA: 0x00BDAAEC File Offset: 0x00BD8CEC
		private void PlayPhoneSequence(string sequenceKey)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null && levelSequencePlayer.CheckSeqActorIsUnStopped(sequenceKey))
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.ReplaySequenceByKey(sequenceKey);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.PlaySequencePurely(sequenceKey, false, false, null, null, false);
				return;
			}
		}

		// Token: 0x06029EEF RID: 171759 RVA: 0x00BDAB3E File Offset: 0x00BD8D3E
		private bool CheckModelQueueHaveId()
		{
			return PhoneMsgModel.Instance.CurrentToBeNotifiedMsgInSmallHeadQueue.Count > 0;
		}

		// Token: 0x06029EF0 RID: 171760 RVA: 0x00BDAB52 File Offset: 0x00BD8D52
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Phone_Circle_Switch")
			{
				this.PopShowHeadIcon();
			}
		}

		// Token: 0x04016DA9 RID: 93609
		[CompilerGenerated]
		private UUIItem <RootItem>P = RootItem;

		// Token: 0x04016DAA RID: 93610
		[CompilerGenerated]
		private AUIBaseActor <RootActor>P = RootActor;

		// Token: 0x04016DAB RID: 93611
		[CompilerGenerated]
		private UUIItem <RedDotItem>P = RedDotItem;

		// Token: 0x04016DAC RID: 93612
		[CompilerGenerated]
		private UUISprite <SpriteEnterIcon>P = SpriteEnterIcon;

		// Token: 0x04016DAD RID: 93613
		[CompilerGenerated]
		private UUIItem <PanelPrefabHead>P = PanelPrefabHead;

		// Token: 0x04016DAE RID: 93614
		[CompilerGenerated]
		private UUITexture <TexIconHead>P = TexIconHead;

		// Token: 0x04016DAF RID: 93615
		[CompilerGenerated]
		private UUIItem <BubbleItem>P = BubbleItem;

		// Token: 0x04016DB0 RID: 93616
		[CompilerGenerated]
		private UUINiagara <NiagaraItem>P = NiagaraItem;

		// Token: 0x04016DB1 RID: 93617
		[CompilerGenerated]
		private Action<string, UUITexture> <SetTextureByPathFunc>P = SetTextureByPathFunc;

		// Token: 0x04016DB2 RID: 93618
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04016DB3 RID: 93619
		private float RedDotInitAlpha = 1f;

		// Token: 0x04016DB4 RID: 93620
		private float EnterIconInitAlpha = 1f;

		// Token: 0x04016DB5 RID: 93621
		private FVector? RedDotInitScale;

		// Token: 0x04016DB6 RID: 93622
		private FVector? EnterIconInitScale;
	}
}
