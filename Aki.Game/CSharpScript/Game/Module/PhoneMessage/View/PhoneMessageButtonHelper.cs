using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhoneMessage.View
{
	// Token: 0x020050FB RID: 20731
	[NullableContext(1)]
	[Nullable(0)]
	public class PhoneMessageButtonHelper
	{
		// Token: 0x06034FEA RID: 217066 RVA: 0x00C8D420 File Offset: 0x00C8B620
		public PhoneMessageButtonHelper(UUIItem RootItem, AUIBaseActor RootActor, UUIItem RedDotItem, UUISprite SpriteEnterIcon, UUIItem PanelPrefabHead, UUITexture TexIconHead, UUIItem BubbleItem, UUINiagara NiagaraItem, Action<string, UUITexture> SetTextureByPathFunc)
		{
		}

		// Token: 0x06034FEB RID: 217067 RVA: 0x00C8D490 File Offset: 0x00C8B690
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

		// Token: 0x06034FEC RID: 217068 RVA: 0x00C8D540 File Offset: 0x00C8B740
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

		// Token: 0x06034FED RID: 217069 RVA: 0x00C8D5C9 File Offset: 0x00C8B7C9
		public void OnHideBattleChildView()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PauseSequence();
		}

		// Token: 0x06034FEE RID: 217070 RVA: 0x00C8D5DB File Offset: 0x00C8B7DB
		public void Clear()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06034FEF RID: 217071 RVA: 0x00C8D5F5 File Offset: 0x00C8B7F5
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

		// Token: 0x06034FF0 RID: 217072 RVA: 0x00C8D620 File Offset: 0x00C8B820
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

		// Token: 0x06034FF1 RID: 217073 RVA: 0x00C8D65C File Offset: 0x00C8B85C
		private void SetAndShowHeadIcon(int shortMessageId)
		{
			int whichChat = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMessageId).Value.WhichChat;
			string iconSmall = PhoneMsgModel.Instance.GetChatPartnerConfigNew(whichChat).Value.IconSmall;
			this.<PanelPrefabHead>P.SetUIActive(true);
			this.<BubbleItem>P.SetUIActive(true);
			this.<SetTextureByPathFunc>P(iconSmall, this.<TexIconHead>P);
			this.PlayPhoneSequence("Phone_Circle_In");
		}

		// Token: 0x06034FF2 RID: 217074 RVA: 0x00C8D6D8 File Offset: 0x00C8B8D8
		public void HideHeadIcon()
		{
			this.PlayPhoneSequence("Phone_Icon_In");
			this.<BubbleItem>P.SetUIActive(false);
			PhoneMsgModel.Instance.CurrentShowingMsgIdInSmallHead = 0;
		}

		// Token: 0x06034FF3 RID: 217075 RVA: 0x00C8D6FC File Offset: 0x00C8B8FC
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

		// Token: 0x06034FF4 RID: 217076 RVA: 0x00C8D774 File Offset: 0x00C8B974
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

		// Token: 0x06034FF5 RID: 217077 RVA: 0x00C8D810 File Offset: 0x00C8BA10
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

		// Token: 0x06034FF6 RID: 217078 RVA: 0x00C8D862 File Offset: 0x00C8BA62
		private bool CheckModelQueueHaveId()
		{
			return PhoneMsgModel.Instance.CurrentToBeNotifiedMsgInSmallHeadQueue.Count > 0;
		}

		// Token: 0x06034FF7 RID: 217079 RVA: 0x00C8D876 File Offset: 0x00C8BA76
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Phone_Circle_Switch")
			{
				this.PopShowHeadIcon();
			}
		}

		// Token: 0x0401C376 RID: 115574
		[CompilerGenerated]
		private UUIItem <RootItem>P = RootItem;

		// Token: 0x0401C377 RID: 115575
		[CompilerGenerated]
		private AUIBaseActor <RootActor>P = RootActor;

		// Token: 0x0401C378 RID: 115576
		[CompilerGenerated]
		private UUIItem <RedDotItem>P = RedDotItem;

		// Token: 0x0401C379 RID: 115577
		[CompilerGenerated]
		private UUISprite <SpriteEnterIcon>P = SpriteEnterIcon;

		// Token: 0x0401C37A RID: 115578
		[CompilerGenerated]
		private UUIItem <PanelPrefabHead>P = PanelPrefabHead;

		// Token: 0x0401C37B RID: 115579
		[CompilerGenerated]
		private UUITexture <TexIconHead>P = TexIconHead;

		// Token: 0x0401C37C RID: 115580
		[CompilerGenerated]
		private UUIItem <BubbleItem>P = BubbleItem;

		// Token: 0x0401C37D RID: 115581
		[CompilerGenerated]
		private UUINiagara <NiagaraItem>P = NiagaraItem;

		// Token: 0x0401C37E RID: 115582
		[CompilerGenerated]
		private Action<string, UUITexture> <SetTextureByPathFunc>P = SetTextureByPathFunc;

		// Token: 0x0401C37F RID: 115583
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401C380 RID: 115584
		private float RedDotInitAlpha = 1f;

		// Token: 0x0401C381 RID: 115585
		private float EnterIconInitAlpha = 1f;

		// Token: 0x0401C382 RID: 115586
		private FVector? RedDotInitScale;

		// Token: 0x0401C383 RID: 115587
		private FVector? EnterIconInitScale;
	}
}
