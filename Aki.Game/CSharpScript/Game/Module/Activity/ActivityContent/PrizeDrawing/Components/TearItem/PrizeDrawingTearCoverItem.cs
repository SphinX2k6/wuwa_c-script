using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem
{
	// Token: 0x020062AD RID: 25261
	[NullableContext(2)]
	[Nullable(0)]
	public class PrizeDrawingTearCoverItem : PrizeDrawingTearCoverItemBase
	{
		// Token: 0x0603F89C RID: 260252 RVA: 0x00F5D7F4 File Offset: 0x00F5B9F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F89D RID: 260253 RVA: 0x00F5DA34 File Offset: 0x00F5BC34
		protected override void OnStart()
		{
			this.TearRoot = base.GetItem(1);
			this.TearShadowRoot = base.GetItem(5);
			TArray<UUIItem> attachUIChildren = this.TearRoot.GetAttachUIChildren();
			for (int i = 0; i < attachUIChildren.Num(); i++)
			{
				this.TearItemList.Add(attachUIChildren.Get(i));
			}
			TArray<UUIItem> attachUIChildren2 = this.TearShadowRoot.GetAttachUIChildren();
			for (int j = 0; j < attachUIChildren2.Num(); j++)
			{
				this.TearShadowItemList.Add(attachUIChildren2.Get(j));
			}
			this.EmojiItemList.AddRange(new UUIItem[]
			{
				base.GetItem(6),
				base.GetItem(7),
				base.GetItem(8),
				base.GetItem(9)
			});
			foreach (UUIItem uiItem in this.EmojiItemList)
			{
				this.EmojiSeqPlayerList.Add(new LevelSequencePlayer(uiItem));
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitializeFx();
		}

		// Token: 0x0603F89E RID: 260254 RVA: 0x00F5DB60 File Offset: 0x00F5BD60
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			foreach (LevelSequencePlayer levelSequencePlayer2 in this.EmojiSeqPlayerList)
			{
				levelSequencePlayer2.Clear();
			}
			if (this.LoopAudioHandle != null)
			{
				AudioSystem.Instance.ExecuteAction(this.LoopAudioHandle.Value, EAudioActionType.Stop, null);
			}
		}

		// Token: 0x0603F89F RID: 260255 RVA: 0x00F5DBF0 File Offset: 0x00F5BDF0
		public void OnTick(float progress)
		{
			if (this.IsOpened)
			{
				return;
			}
			if (progress > 0.1f && !this.IsDragStarted)
			{
				this.IsDragStarted = true;
				this.OnFirstStartDrag();
			}
			float num = 1f / (float)this.TearItemList.Count;
			float alpha = Math.Abs(progress % num) / num;
			int num2 = (int)Math.Floor((double)(progress / num));
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 >= this.TearItemList.Count)
			{
				this.PlayRevelAnimation();
				this.Open(true);
				return;
			}
			if (this.CachedSelectedIndex != num2)
			{
				if (num2 > this.CachedTearAudioIndex)
				{
					this.CachedTearAudioIndex = num2;
					AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_tear_new_click");
				}
				else if (num2 < this.CachedSelectedIndex)
				{
					AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_tear_back");
				}
				else
				{
					AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_tear_torn_click");
				}
				this.SetTearActive(num2);
			}
			int num3 = num2 - 1;
			if (num3 > this.CachedEmojiIndex)
			{
				this.SetEmojiActive(num3);
				this.EmojiSeqPlayerList[num3].PlaySequencePurely("Emoji", false, false, null, null, false);
			}
			if (num3 == -1)
			{
				this.SetEmojiActive(-1);
			}
			float from = (num2 - 1 >= 0 && num2 - 1 < PrizeDrawingTearCoverItemConstants.ShineDissolve.Length) ? PrizeDrawingTearCoverItemConstants.ShineDissolve[num2 - 1] : 0f;
			float to = (num2 < PrizeDrawingTearCoverItemConstants.ShineDissolve.Length) ? PrizeDrawingTearCoverItemConstants.ShineDissolve[num2] : 0f;
			float value = MathUtils.Instance.Lerp(from, to, alpha);
			UUINiagara shineItem = this.ShineItem;
			if (shineItem != null)
			{
				shineItem.SetNiagaraVarFloat("Dissolve", value);
			}
			UUINiagara shineItemMinor = this.ShineItemMinor;
			if (shineItemMinor != null)
			{
				shineItemMinor.SetNiagaraVarFloat("Dissolve", value);
			}
			float from2 = (num2 - 1 >= 0 && num2 - 1 < PrizeDrawingTearCoverItemConstants.GlowMaskOffsetV.Length) ? PrizeDrawingTearCoverItemConstants.GlowMaskOffsetV[num2 - 1] : -4f;
			float to2 = (num2 < PrizeDrawingTearCoverItemConstants.GlowMaskOffsetV.Length) ? PrizeDrawingTearCoverItemConstants.GlowMaskOffsetV[num2] : -4f;
			this.GlowOffsetVector.A = MathUtils.Instance.Lerp(from2, to2, alpha);
			UUITexture glowItem = this.GlowItem;
			if (glowItem != null)
			{
				glowItem.SetCustomMaterialVectorParameter(PrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			UUITexture glowItemMinor = this.GlowItemMinor;
			if (glowItemMinor != null)
			{
				glowItemMinor.SetCustomMaterialVectorParameter(PrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			float from3 = (num2 - 1 >= 0 && num2 - 1 < PrizeDrawingTearCoverItemConstants.GlowAlpha.Length) ? PrizeDrawingTearCoverItemConstants.GlowAlpha[num2 - 1] : 0f;
			float to3 = (num2 < PrizeDrawingTearCoverItemConstants.GlowAlpha.Length) ? PrizeDrawingTearCoverItemConstants.GlowAlpha[num2] : 0f;
			float alpha2 = MathUtils.Instance.Lerp(from3, to3, alpha);
			UUITexture glowItem2 = this.GlowItem;
			if (glowItem2 != null)
			{
				glowItem2.SetAlpha(alpha2);
			}
			UUITexture glowItemMinor2 = this.GlowItemMinor;
			if (glowItemMinor2 != null)
			{
				glowItemMinor2.SetAlpha(alpha2);
			}
			AudioSystem.Instance.SetRtpcValue("sys_game_prizedrawing_ticket_torn", progress * 100f, null);
		}

		// Token: 0x0603F8A0 RID: 260256 RVA: 0x00F5DEB5 File Offset: 0x00F5C0B5
		public bool IsUnOpened()
		{
			return !this.IsOpened;
		}

		// Token: 0x0603F8A1 RID: 260257 RVA: 0x00F5DEC0 File Offset: 0x00F5C0C0
		private void SetTearActive(int index)
		{
			if (this.CachedSelectedIndex >= 0 && this.CachedSelectedIndex < this.TearItemList.Count)
			{
				UUIItem uuiitem = this.TearItemList[this.CachedSelectedIndex];
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			if (index >= 0 && index < this.TearItemList.Count)
			{
				UUIItem uuiitem2 = this.TearItemList[index];
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(true);
				}
			}
			if (this.CachedSelectedIndex >= 0 && this.CachedSelectedIndex < this.TearShadowItemList.Count)
			{
				UUIItem uuiitem3 = this.TearShadowItemList[this.CachedSelectedIndex];
				if (uuiitem3 != null)
				{
					uuiitem3.SetUIActive(false);
				}
			}
			if (index >= 0 && index < this.TearShadowItemList.Count)
			{
				UUIItem uuiitem4 = this.TearShadowItemList[index];
				if (uuiitem4 != null)
				{
					uuiitem4.SetUIActive(true);
				}
			}
			this.CachedSelectedIndex = index;
		}

		// Token: 0x0603F8A2 RID: 260258 RVA: 0x00F5DF9C File Offset: 0x00F5C19C
		private void SetEmojiActive(int index)
		{
			if (this.CachedEmojiIndex >= 0 && this.CachedEmojiIndex < this.EmojiItemList.Count)
			{
				UUIItem uuiitem = this.EmojiItemList[this.CachedEmojiIndex];
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
			}
			if (index >= 0 && index < this.EmojiItemList.Count)
			{
				UUIItem uuiitem2 = this.EmojiItemList[index];
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(true);
				}
			}
			this.CachedEmojiIndex = index;
		}

		// Token: 0x0603F8A3 RID: 260259 RVA: 0x00F5E013 File Offset: 0x00F5C213
		public void SetTearShadowActive(bool active)
		{
			UUIItem tearShadowRoot = this.TearShadowRoot;
			if (tearShadowRoot == null)
			{
				return;
			}
			tearShadowRoot.SetUIActive(active);
		}

		// Token: 0x0603F8A4 RID: 260260 RVA: 0x00F5E028 File Offset: 0x00F5C228
		public void Open(bool playAudio)
		{
			this.IsOpened = true;
			UUIItem tearRoot = this.TearRoot;
			if (tearRoot != null)
			{
				tearRoot.SetUIActive(false);
			}
			UUIItem tearShadowRoot = this.TearShadowRoot;
			if (tearShadowRoot != null)
			{
				tearShadowRoot.SetUIActive(false);
			}
			this.SetEmojiActive(-1);
			this.OnOpened();
			if (!playAudio)
			{
				return;
			}
			if (this.FxLevel != EFxLevel.None)
			{
				if (this.LoopAudioHandle != null)
				{
					AudioSystem.Instance.ExecuteAction(this.LoopAudioHandle.Value, EAudioActionType.Stop, null);
					this.LoopAudioHandle = null;
				}
				AudioSystem.Instance.SetRtpcValue("sys_game_prizedrawing_ticket_torn", 0f, null);
				AudioSystem.Instance.PostEvent("stop_ui_prizedrawing_ticket_bigprize_light_loop");
			}
			switch (this.FxLevel)
			{
			case EFxLevel.None:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_tear_new_click");
				return;
			case EFxLevel.Minor:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_normalprize_light_finish");
				return;
			case EFxLevel.Super:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_finish");
				return;
			default:
				return;
			}
		}

		// Token: 0x0603F8A5 RID: 260261 RVA: 0x00F5E12A File Offset: 0x00F5C32A
		public void PlayRevelAnimation()
		{
			PrizeDrawingTearItemBase tearItem = this.TearItem;
			if (tearItem == null)
			{
				return;
			}
			tearItem.PlayRevelAnimation();
		}

		// Token: 0x0603F8A6 RID: 260262 RVA: 0x00F5E13C File Offset: 0x00F5C33C
		private void OnFirstStartDrag()
		{
			if (this.FxLevel == EFxLevel.Super)
			{
				UUINiagara burstItem = this.BurstItem;
				if (burstItem != null)
				{
					burstItem.SetUIActive(true);
				}
			}
			else if (this.FxLevel == EFxLevel.Minor)
			{
				UUINiagara burstItemMinor = this.BurstItemMinor;
				if (burstItemMinor != null)
				{
					burstItemMinor.SetUIActive(true);
				}
			}
			if (this.FxLevel != EFxLevel.None)
			{
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_start");
			}
		}

		// Token: 0x0603F8A7 RID: 260263 RVA: 0x00F5E199 File Offset: 0x00F5C399
		public void OnStartDragging()
		{
			if (this.FxLevel != EFxLevel.None)
			{
				this.LoopAudioHandle = new int?(AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_loop"));
			}
		}

		// Token: 0x0603F8A8 RID: 260264 RVA: 0x00F5E1C0 File Offset: 0x00F5C3C0
		public void OnStopDragging()
		{
			if (this.FxLevel != EFxLevel.None)
			{
				if (this.LoopAudioHandle != null)
				{
					AudioSystem.Instance.ExecuteAction(this.LoopAudioHandle.Value, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(1000), null, null)));
					this.LoopAudioHandle = null;
				}
				AudioSystem.Instance.PostEvent("stop_ui_prizedrawing_ticket_bigprize_light_loop");
			}
		}

		// Token: 0x0603F8A9 RID: 260265 RVA: 0x00F5E232 File Offset: 0x00F5C432
		protected void OnOpened()
		{
			Action openedCallback = this.OpenedCallback;
			if (openedCallback == null)
			{
				return;
			}
			openedCallback();
		}

		// Token: 0x0603F8AA RID: 260266 RVA: 0x00F5E244 File Offset: 0x00F5C444
		public void Reset()
		{
			this.IsOpened = false;
			this.TearRoot.SetUIActive(true);
			this.SetTearActive(0);
			UUINiagara shineItem = this.ShineItem;
			if (shineItem != null)
			{
				shineItem.SetNiagaraVarFloat("Dissolve", 0f);
			}
			UUINiagara shineItemMinor = this.ShineItemMinor;
			if (shineItemMinor != null)
			{
				shineItemMinor.SetNiagaraVarFloat("Dissolve", 0f);
			}
			this.GlowOffsetVector.A = -4f;
			UUITexture glowItem = this.GlowItem;
			if (glowItem != null)
			{
				glowItem.SetCustomMaterialVectorParameter(PrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			UUITexture glowItemMinor = this.GlowItemMinor;
			if (glowItemMinor != null)
			{
				glowItemMinor.SetCustomMaterialVectorParameter(PrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			UUITexture glowItem2 = this.GlowItem;
			if (glowItem2 != null)
			{
				glowItem2.SetAlpha(0f);
			}
			UUITexture glowItemMinor2 = this.GlowItemMinor;
			if (glowItemMinor2 != null)
			{
				glowItemMinor2.SetAlpha(0f);
			}
			UUINiagara burstItem = this.BurstItem;
			if (burstItem != null)
			{
				burstItem.SetUIActive(false);
			}
			UUINiagara burstItemMinor = this.BurstItemMinor;
			if (burstItemMinor != null)
			{
				burstItemMinor.SetUIActive(false);
			}
			this.CachedTearAudioIndex = 0;
			this.IsDragStarted = false;
		}

		// Token: 0x0603F8AB RID: 260267 RVA: 0x00F5E348 File Offset: 0x00F5C548
		public void RefreshEffectVisible(EFxLevel fxLevel)
		{
			this.FxLevel = fxLevel;
			this.TearShadowRoot.SetUIActive(fxLevel == EFxLevel.None);
			UUIItem fxControl = this.FxControl;
			if (fxControl != null)
			{
				fxControl.SetUIActive(fxLevel == EFxLevel.Super);
			}
			UUIItem fxControl2 = this.FxControl;
			if (fxControl2 != null)
			{
				fxControl2.SetAlpha(fxLevel == EFxLevel.Super);
			}
			UUIItem fxControlMinor = this.FxControlMinor;
			if (fxControlMinor != null)
			{
				fxControlMinor.SetUIActive(fxLevel == EFxLevel.Minor);
			}
			UUIItem fxControlMinor2 = this.FxControlMinor;
			if (fxControlMinor2 == null)
			{
				return;
			}
			fxControlMinor2.SetAlpha(fxLevel == EFxLevel.Minor);
		}

		// Token: 0x0603F8AC RID: 260268 RVA: 0x00F5E3C0 File Offset: 0x00F5C5C0
		[NullableContext(1)]
		public UniTask CreateTearItem(List<IKujiAwardData> rewards, ETearType tearType)
		{
			PrizeDrawingTearCoverItem.<CreateTearItem>d__40 <CreateTearItem>d__;
			<CreateTearItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTearItem>d__.<>4__this = this;
			<CreateTearItem>d__.rewards = rewards;
			<CreateTearItem>d__.tearType = tearType;
			<CreateTearItem>d__.<>1__state = -1;
			<CreateTearItem>d__.<>t__builder.Start<PrizeDrawingTearCoverItem.<CreateTearItem>d__40>(ref <CreateTearItem>d__);
			return <CreateTearItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603F8AD RID: 260269 RVA: 0x00F5E413 File Offset: 0x00F5C613
		[NullableContext(1)]
		public UUIItem GetFxControl()
		{
			return this.FxControl;
		}

		// Token: 0x0603F8AE RID: 260270 RVA: 0x00F5E41B File Offset: 0x00F5C61B
		[NullableContext(1)]
		public UUIItem GetFxControlMinor()
		{
			return this.FxControlMinor;
		}

		// Token: 0x0603F8AF RID: 260271 RVA: 0x00F5E424 File Offset: 0x00F5C624
		private void InitializeFx()
		{
			this.ShineItem = base.GetUiNiagara(3);
			this.GlowItem = base.GetTexture(4);
			this.BurstItem = base.GetUiNiagara(2);
			this.ShineItemMinor = base.GetUiNiagara(13);
			this.BurstItemMinor = base.GetUiNiagara(12);
			this.GlowItemMinor = base.GetTexture(11);
			this.FxControl = base.GetItem(14);
			this.FxControlMinor = base.GetItem(15);
			UUINiagara shineItem = this.ShineItem;
			if (shineItem != null)
			{
				shineItem.SetUIActive(true);
			}
			UUITexture glowItem = this.GlowItem;
			if (glowItem != null)
			{
				glowItem.SetUIActive(true);
			}
			UUINiagara burstItem = this.BurstItem;
			if (burstItem != null)
			{
				burstItem.SetUIActive(false);
			}
			UUINiagara shineItemMinor = this.ShineItemMinor;
			if (shineItemMinor != null)
			{
				shineItemMinor.SetUIActive(true);
			}
			UUINiagara burstItemMinor = this.BurstItemMinor;
			if (burstItemMinor != null)
			{
				burstItemMinor.SetUIActive(false);
			}
			UUITexture glowItemMinor = this.GlowItemMinor;
			if (glowItemMinor != null)
			{
				glowItemMinor.SetUIActive(true);
			}
			UUIItem fxControl = this.FxControl;
			if (fxControl != null)
			{
				fxControl.SetUIActive(false);
			}
			UUIItem fxControlMinor = this.FxControlMinor;
			if (fxControlMinor == null)
			{
				return;
			}
			fxControlMinor.SetUIActive(false);
		}

		// Token: 0x0402139A RID: 136090
		[Nullable(1)]
		private readonly List<UUIItem> TearItemList = new List<UUIItem>();

		// Token: 0x0402139B RID: 136091
		[Nullable(1)]
		private readonly List<UUIItem> TearShadowItemList = new List<UUIItem>();

		// Token: 0x0402139C RID: 136092
		private int CachedSelectedIndex;

		// Token: 0x0402139D RID: 136093
		private bool IsOpened;

		// Token: 0x0402139E RID: 136094
		public Action OpenedCallback;

		// Token: 0x0402139F RID: 136095
		private FLinearColor GlowOffsetVector = new FLinearColor(1f, 5f, 0f, 0f);

		// Token: 0x040213A0 RID: 136096
		[Nullable(1)]
		private readonly List<UUIItem> EmojiItemList = new List<UUIItem>();

		// Token: 0x040213A1 RID: 136097
		[Nullable(1)]
		private readonly List<LevelSequencePlayer> EmojiSeqPlayerList = new List<LevelSequencePlayer>();

		// Token: 0x040213A2 RID: 136098
		private int CachedEmojiIndex = -1;

		// Token: 0x040213A3 RID: 136099
		private int CachedTearAudioIndex;

		// Token: 0x040213A4 RID: 136100
		private EFxLevel FxLevel;

		// Token: 0x040213A5 RID: 136101
		private bool IsDragStarted;

		// Token: 0x040213A6 RID: 136102
		private int? LoopAudioHandle;

		// Token: 0x040213A7 RID: 136103
		private UUIItem TearRoot;

		// Token: 0x040213A8 RID: 136104
		private UUIItem TearShadowRoot;

		// Token: 0x040213A9 RID: 136105
		private UUINiagara ShineItem;

		// Token: 0x040213AA RID: 136106
		private UUITexture GlowItem;

		// Token: 0x040213AB RID: 136107
		private UUINiagara BurstItem;

		// Token: 0x040213AC RID: 136108
		private UUINiagara ShineItemMinor;

		// Token: 0x040213AD RID: 136109
		private UUINiagara BurstItemMinor;

		// Token: 0x040213AE RID: 136110
		private UUITexture GlowItemMinor;

		// Token: 0x040213AF RID: 136111
		private UUIItem FxControl;

		// Token: 0x040213B0 RID: 136112
		private UUIItem FxControlMinor;

		// Token: 0x040213B1 RID: 136113
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
