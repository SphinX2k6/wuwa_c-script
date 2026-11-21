using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053CF RID: 21455
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorLinkageBackgroundItem : UiPanelBase
	{
		// Token: 0x06035580 RID: 218496 RVA: 0x00EE6B48 File Offset: 0x00EE4D48
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06035581 RID: 218497 RVA: 0x00EE6BB8 File Offset: 0x00EE4DB8
		protected override UniTask OnBeforeStartAsync()
		{
			MotorLinkageBackgroundItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorLinkageBackgroundItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035582 RID: 218498 RVA: 0x00EE6BFC File Offset: 0x00EE4DFC
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.StickerItemA.ClickToggleCallback = delegate()
			{
				this.OnToggleClick(0);
			};
			this.StickerItemB.ClickToggleCallback = delegate()
			{
				this.OnToggleClick(1);
			};
			this.RefreshToggle();
			this.SelectFirstIncompleteToggle();
		}

		// Token: 0x06035583 RID: 218499 RVA: 0x00EE6C54 File Offset: 0x00EE4E54
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x06035584 RID: 218500 RVA: 0x00EE6C66 File Offset: 0x00EE4E66
		protected override void OnBeforeShow()
		{
			this.Refresh(false);
		}

		// Token: 0x06035585 RID: 218501 RVA: 0x00EE6C70 File Offset: 0x00EE4E70
		public void Refresh(bool skipAnim = false)
		{
			ActivityMotorLinkageConfig.Instance.GetIpConfig(this.IpId);
			this.RefreshToggle();
			if (skipAnim)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06035586 RID: 218502 RVA: 0x00EE6CBC File Offset: 0x00EE4EBC
		private void RefreshToggle()
		{
			MotorLinkageIp ipConfig = ActivityMotorLinkageConfig.Instance.GetIpConfig(this.IpId);
			MotorLinkageStickerItem stickerItemA = this.StickerItemA;
			if (stickerItemA != null)
			{
				stickerItemA.Refresh(ipConfig.IpStickerList(0));
			}
			MotorLinkageStickerItem stickerItemB = this.StickerItemB;
			if (stickerItemB == null)
			{
				return;
			}
			stickerItemB.Refresh(ipConfig.IpStickerList(1));
		}

		// Token: 0x06035587 RID: 218503 RVA: 0x00EE6D0B File Offset: 0x00EE4F0B
		public void SetIpId(int ipId)
		{
			this.IpId = ipId;
		}

		// Token: 0x06035588 RID: 218504 RVA: 0x00EE6D14 File Offset: 0x00EE4F14
		private void OnToggleClick(int index)
		{
			if (index == 0)
			{
				MotorLinkageStickerItem stickerItemB = this.StickerItemB;
				if (stickerItemB != null)
				{
					stickerItemB.SetToggleSelect(false, null);
				}
			}
			else
			{
				MotorLinkageStickerItem stickerItemA = this.StickerItemA;
				if (stickerItemA != null)
				{
					stickerItemA.SetToggleSelect(false, null);
				}
			}
			this.SelectedIndex = index;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06035589 RID: 218505 RVA: 0x00EE6D82 File Offset: 0x00EE4F82
		public void RefreshTexture()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.SelectedIndex == 0);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.SelectedIndex == 1);
		}

		// Token: 0x0603558A RID: 218506 RVA: 0x00EE6DBC File Offset: 0x00EE4FBC
		private void SelectFirstIncompleteToggle()
		{
			if (this.StickerItemA != null && !this.StickerItemA.IsReceived())
			{
				this.StickerItemA.SetToggleSelect(true, new bool?(true));
			}
			else if (this.StickerItemB != null && !this.StickerItemB.IsReceived())
			{
				this.StickerItemB.SetToggleSelect(true, new bool?(true));
			}
			else
			{
				MotorLinkageStickerItem stickerItemA = this.StickerItemA;
				if (stickerItemA != null)
				{
					stickerItemA.SetToggleSelect(true, new bool?(true));
				}
			}
			this.RefreshTexture();
		}

		// Token: 0x0401C241 RID: 115265
		private int IpId;

		// Token: 0x0401C242 RID: 115266
		private int SelectedIndex;

		// Token: 0x0401C243 RID: 115267
		private MotorLinkageStickerItem StickerItemA;

		// Token: 0x0401C244 RID: 115268
		private MotorLinkageStickerItem StickerItemB;

		// Token: 0x0401C245 RID: 115269
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
