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
	// Token: 0x02006451 RID: 25681
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorLinkageBackgroundItem : UiPanelBase
	{
		// Token: 0x060408BF RID: 264383 RVA: 0x00F9FBCC File Offset: 0x00F9DDCC
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

		// Token: 0x060408C0 RID: 264384 RVA: 0x00F9FC3C File Offset: 0x00F9DE3C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorLinkageBackgroundItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorLinkageBackgroundItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060408C1 RID: 264385 RVA: 0x00F9FC80 File Offset: 0x00F9DE80
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

		// Token: 0x060408C2 RID: 264386 RVA: 0x00F9FCD8 File Offset: 0x00F9DED8
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x060408C3 RID: 264387 RVA: 0x00F9FCEA File Offset: 0x00F9DEEA
		protected override void OnBeforeShow()
		{
			this.Refresh(false);
		}

		// Token: 0x060408C4 RID: 264388 RVA: 0x00F9FCF4 File Offset: 0x00F9DEF4
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

		// Token: 0x060408C5 RID: 264389 RVA: 0x00F9FD40 File Offset: 0x00F9DF40
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

		// Token: 0x060408C6 RID: 264390 RVA: 0x00F9FD8F File Offset: 0x00F9DF8F
		public void SetIpId(int ipId)
		{
			this.IpId = ipId;
		}

		// Token: 0x060408C7 RID: 264391 RVA: 0x00F9FD98 File Offset: 0x00F9DF98
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

		// Token: 0x060408C8 RID: 264392 RVA: 0x00F9FE06 File Offset: 0x00F9E006
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

		// Token: 0x060408C9 RID: 264393 RVA: 0x00F9FE40 File Offset: 0x00F9E040
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

		// Token: 0x04021912 RID: 137490
		private int IpId;

		// Token: 0x04021913 RID: 137491
		private int SelectedIndex;

		// Token: 0x04021914 RID: 137492
		private MotorLinkageStickerItem StickerItemA;

		// Token: 0x04021915 RID: 137493
		private MotorLinkageStickerItem StickerItemB;

		// Token: 0x04021916 RID: 137494
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
