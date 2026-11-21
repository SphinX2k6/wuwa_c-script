using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005922 RID: 22818
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingTearCoverItem : SolarSchoolPrizeDrawingTearCoverItemBase
	{
		// Token: 0x060383C9 RID: 230345 RVA: 0x00FB90A8 File Offset: 0x00FB72A8
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

		// Token: 0x060383CA RID: 230346 RVA: 0x00FB92E8 File Offset: 0x00FB74E8
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

		// Token: 0x060383CB RID: 230347 RVA: 0x00FB9414 File Offset: 0x00FB7614
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

		// Token: 0x060383CC RID: 230348 RVA: 0x00FB94A4 File Offset: 0x00FB76A4
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
			float from = (num2 - 1 >= 0 && num2 - 1 < SolarSchoolPrizeDrawingTearCoverItemConstants.ShineDissolve.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.ShineDissolve[num2 - 1] : 0f;
			float to = (num2 < SolarSchoolPrizeDrawingTearCoverItemConstants.ShineDissolve.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.ShineDissolve[num2] : 0f;
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
			float from2 = (num2 - 1 >= 0 && num2 - 1 < SolarSchoolPrizeDrawingTearCoverItemConstants.GlowMaskOffsetV.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.GlowMaskOffsetV[num2 - 1] : -4f;
			float to2 = (num2 < SolarSchoolPrizeDrawingTearCoverItemConstants.GlowMaskOffsetV.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.GlowMaskOffsetV[num2] : -4f;
			this.GlowOffsetVector.A = MathUtils.Instance.Lerp(from2, to2, alpha);
			UUITexture glowItem = this.GlowItem;
			if (glowItem != null)
			{
				glowItem.SetCustomMaterialVectorParameter(SolarSchoolPrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			UUITexture glowItemMinor = this.GlowItemMinor;
			if (glowItemMinor != null)
			{
				glowItemMinor.SetCustomMaterialVectorParameter(SolarSchoolPrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			float from3 = (num2 - 1 >= 0 && num2 - 1 < SolarSchoolPrizeDrawingTearCoverItemConstants.GlowAlpha.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.GlowAlpha[num2 - 1] : 0f;
			float to3 = (num2 < SolarSchoolPrizeDrawingTearCoverItemConstants.GlowAlpha.Length) ? SolarSchoolPrizeDrawingTearCoverItemConstants.GlowAlpha[num2] : 0f;
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

		// Token: 0x060383CD RID: 230349 RVA: 0x00FB9769 File Offset: 0x00FB7969
		public bool IsUnOpened()
		{
			return !this.IsOpened;
		}

		// Token: 0x060383CE RID: 230350 RVA: 0x00FB9774 File Offset: 0x00FB7974
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

		// Token: 0x060383CF RID: 230351 RVA: 0x00FB9850 File Offset: 0x00FB7A50
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

		// Token: 0x060383D0 RID: 230352 RVA: 0x00FB98C7 File Offset: 0x00FB7AC7
		public void SetTearShadowActive(bool active)
		{
			UUIItem tearShadowRoot = this.TearShadowRoot;
			if (tearShadowRoot == null)
			{
				return;
			}
			tearShadowRoot.SetUIActive(active);
		}

		// Token: 0x060383D1 RID: 230353 RVA: 0x00FB98DC File Offset: 0x00FB7ADC
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
			if (this.FxLevel != ESolarSchoolFxLevel.None)
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
			case ESolarSchoolFxLevel.None:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_tear_new_click");
				return;
			case ESolarSchoolFxLevel.Minor:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_normalprize_light_finish");
				return;
			case ESolarSchoolFxLevel.Super:
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_finish");
				return;
			default:
				return;
			}
		}

		// Token: 0x060383D2 RID: 230354 RVA: 0x00FB99DE File Offset: 0x00FB7BDE
		public void PlayRevelAnimation()
		{
			SolarSchoolPrizeDrawingTearItemBase tearItem = this.TearItem;
			if (tearItem == null)
			{
				return;
			}
			tearItem.PlayRevelAnimation();
		}

		// Token: 0x060383D3 RID: 230355 RVA: 0x00FB99F0 File Offset: 0x00FB7BF0
		private void OnFirstStartDrag()
		{
			if (this.FxLevel == ESolarSchoolFxLevel.Super)
			{
				UUINiagara burstItem = this.BurstItem;
				if (burstItem != null)
				{
					burstItem.SetUIActive(true);
				}
			}
			else if (this.FxLevel == ESolarSchoolFxLevel.Minor)
			{
				UUINiagara burstItemMinor = this.BurstItemMinor;
				if (burstItemMinor != null)
				{
					burstItemMinor.SetUIActive(true);
				}
			}
			if (this.FxLevel != ESolarSchoolFxLevel.None)
			{
				AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_start");
			}
		}

		// Token: 0x060383D4 RID: 230356 RVA: 0x00FB9A4D File Offset: 0x00FB7C4D
		public void OnStartDragging()
		{
			if (this.FxLevel != ESolarSchoolFxLevel.None)
			{
				this.LoopAudioHandle = new int?(AudioSystem.Instance.PostEvent("play_ui_prizedrawing_ticket_bigprize_light_loop"));
			}
		}

		// Token: 0x060383D5 RID: 230357 RVA: 0x00FB9A74 File Offset: 0x00FB7C74
		public void OnStopDragging()
		{
			if (this.FxLevel != ESolarSchoolFxLevel.None)
			{
				if (this.LoopAudioHandle != null)
				{
					AudioSystem.Instance.ExecuteAction(this.LoopAudioHandle.Value, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(1000), null, null)));
					this.LoopAudioHandle = null;
				}
				AudioSystem.Instance.PostEvent("stop_ui_prizedrawing_ticket_bigprize_light_loop");
			}
		}

		// Token: 0x060383D6 RID: 230358 RVA: 0x00FB9AE6 File Offset: 0x00FB7CE6
		protected void OnOpened()
		{
			Action openedCallback = this.OpenedCallback;
			if (openedCallback == null)
			{
				return;
			}
			openedCallback();
		}

		// Token: 0x060383D7 RID: 230359 RVA: 0x00FB9AF8 File Offset: 0x00FB7CF8
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
				glowItem.SetCustomMaterialVectorParameter(SolarSchoolPrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
			}
			UUITexture glowItemMinor = this.GlowItemMinor;
			if (glowItemMinor != null)
			{
				glowItemMinor.SetCustomMaterialVectorParameter(SolarSchoolPrizeDrawingTearCoverItemConstants.GLOW_MASK_UV_NAME, this.GlowOffsetVector);
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

		// Token: 0x060383D8 RID: 230360 RVA: 0x00FB9BFC File Offset: 0x00FB7DFC
		public void RefreshEffectVisible(ESolarSchoolFxLevel fxLevel)
		{
			this.FxLevel = fxLevel;
			this.TearShadowRoot.SetUIActive(fxLevel == ESolarSchoolFxLevel.None);
			UUIItem fxControl = this.FxControl;
			if (fxControl != null)
			{
				fxControl.SetUIActive(fxLevel == ESolarSchoolFxLevel.Super);
			}
			UUIItem fxControl2 = this.FxControl;
			if (fxControl2 != null)
			{
				fxControl2.SetAlpha(fxLevel == ESolarSchoolFxLevel.Super);
			}
			UUIItem fxControlMinor = this.FxControlMinor;
			if (fxControlMinor != null)
			{
				fxControlMinor.SetUIActive(fxLevel == ESolarSchoolFxLevel.Minor);
			}
			UUIItem fxControlMinor2 = this.FxControlMinor;
			if (fxControlMinor2 == null)
			{
				return;
			}
			fxControlMinor2.SetAlpha(fxLevel == ESolarSchoolFxLevel.Minor);
		}

		// Token: 0x060383D9 RID: 230361 RVA: 0x00FB9C74 File Offset: 0x00FB7E74
		[NullableContext(1)]
		public UniTask CreateTearItem(List<ISolarSchoolPrizeAwardData> rewards, ESolarSchoolTearType tearType)
		{
			SolarSchoolPrizeDrawingTearCoverItem.<CreateTearItem>d__40 <CreateTearItem>d__;
			<CreateTearItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTearItem>d__.<>4__this = this;
			<CreateTearItem>d__.rewards = rewards;
			<CreateTearItem>d__.tearType = tearType;
			<CreateTearItem>d__.<>1__state = -1;
			<CreateTearItem>d__.<>t__builder.Start<SolarSchoolPrizeDrawingTearCoverItem.<CreateTearItem>d__40>(ref <CreateTearItem>d__);
			return <CreateTearItem>d__.<>t__builder.Task;
		}

		// Token: 0x060383DA RID: 230362 RVA: 0x00FB9CC7 File Offset: 0x00FB7EC7
		[NullableContext(1)]
		public UUIItem GetFxControl()
		{
			return this.FxControl;
		}

		// Token: 0x060383DB RID: 230363 RVA: 0x00FB9CCF File Offset: 0x00FB7ECF
		[NullableContext(1)]
		public UUIItem GetFxControlMinor()
		{
			return this.FxControlMinor;
		}

		// Token: 0x060383DC RID: 230364 RVA: 0x00FB9CD8 File Offset: 0x00FB7ED8
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

		// Token: 0x0401D9D5 RID: 121301
		[Nullable(1)]
		private readonly List<UUIItem> TearItemList = new List<UUIItem>();

		// Token: 0x0401D9D6 RID: 121302
		[Nullable(1)]
		private readonly List<UUIItem> TearShadowItemList = new List<UUIItem>();

		// Token: 0x0401D9D7 RID: 121303
		private int CachedSelectedIndex;

		// Token: 0x0401D9D8 RID: 121304
		private bool IsOpened;

		// Token: 0x0401D9D9 RID: 121305
		public Action OpenedCallback;

		// Token: 0x0401D9DA RID: 121306
		private FLinearColor GlowOffsetVector = new FLinearColor(1f, 5f, 0f, 0f);

		// Token: 0x0401D9DB RID: 121307
		[Nullable(1)]
		private readonly List<UUIItem> EmojiItemList = new List<UUIItem>();

		// Token: 0x0401D9DC RID: 121308
		[Nullable(1)]
		private readonly List<LevelSequencePlayer> EmojiSeqPlayerList = new List<LevelSequencePlayer>();

		// Token: 0x0401D9DD RID: 121309
		private int CachedEmojiIndex = -1;

		// Token: 0x0401D9DE RID: 121310
		private int CachedTearAudioIndex;

		// Token: 0x0401D9DF RID: 121311
		private ESolarSchoolFxLevel FxLevel;

		// Token: 0x0401D9E0 RID: 121312
		private bool IsDragStarted;

		// Token: 0x0401D9E1 RID: 121313
		private int? LoopAudioHandle;

		// Token: 0x0401D9E2 RID: 121314
		private UUIItem TearRoot;

		// Token: 0x0401D9E3 RID: 121315
		private UUIItem TearShadowRoot;

		// Token: 0x0401D9E4 RID: 121316
		private UUINiagara ShineItem;

		// Token: 0x0401D9E5 RID: 121317
		private UUITexture GlowItem;

		// Token: 0x0401D9E6 RID: 121318
		private UUINiagara BurstItem;

		// Token: 0x0401D9E7 RID: 121319
		private UUINiagara ShineItemMinor;

		// Token: 0x0401D9E8 RID: 121320
		private UUINiagara BurstItemMinor;

		// Token: 0x0401D9E9 RID: 121321
		private UUITexture GlowItemMinor;

		// Token: 0x0401D9EA RID: 121322
		private UUIItem FxControl;

		// Token: 0x0401D9EB RID: 121323
		private UUIItem FxControlMinor;

		// Token: 0x0401D9EC RID: 121324
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
