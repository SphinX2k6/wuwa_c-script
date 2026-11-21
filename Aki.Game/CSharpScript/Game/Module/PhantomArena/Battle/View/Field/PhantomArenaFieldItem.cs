using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02004232 RID: 16946
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldItem : UiPanelBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x0602AD9E RID: 175518 RVA: 0x00C0F660 File Offset: 0x00C0D860
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUITexture)),
				new ValueTuple<int, Type>(12, typeof(UUITexture)),
				new ValueTuple<int, Type>(13, typeof(UUINiagara)),
				new ValueTuple<int, Type>(14, typeof(UUINiagara)),
				new ValueTuple<int, Type>(15, typeof(UUINiagara)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnInteractClick))
			};
		}

		// Token: 0x0602AD9F RID: 175519 RVA: 0x00C0F81C File Offset: 0x00C0DA1C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaFieldItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaFieldItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADA0 RID: 175520 RVA: 0x00C0F860 File Offset: 0x00C0DA60
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			this.SwitchActiveState(false);
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointerExit));
		}

		// Token: 0x0602ADA1 RID: 175521 RVA: 0x00C0F8D0 File Offset: 0x00C0DAD0
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602ADA2 RID: 175522 RVA: 0x00C0F8DD File Offset: 0x00C0DADD
		private void OnInteractClick()
		{
			Action<PhantomArenaFieldData, PhantomArenaFieldItem> interactClickCallback = this.InteractClickCallback;
			if (interactClickCallback == null)
			{
				return;
			}
			interactClickCallback(this.FieldData, this);
		}

		// Token: 0x0602ADA3 RID: 175523 RVA: 0x00C0F8F6 File Offset: 0x00C0DAF6
		private void OnPointerEnter()
		{
			Action<PhantomArenaFieldData, UUIItem> pointerEnterCallback = this.PointerEnterCallback;
			if (pointerEnterCallback == null)
			{
				return;
			}
			pointerEnterCallback(this.FieldData, base.GetItem(16));
		}

		// Token: 0x0602ADA4 RID: 175524 RVA: 0x00C0F916 File Offset: 0x00C0DB16
		private void OnPointerExit()
		{
			Action pointerExitCallback = this.PointerExitCallback;
			if (pointerExitCallback == null)
			{
				return;
			}
			pointerExitCallback();
		}

		// Token: 0x0602ADA5 RID: 175525 RVA: 0x00C0F928 File Offset: 0x00C0DB28
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (!(sequenceName == "CdClose"))
			{
				if (sequenceName == "CdStart")
				{
					base.GetTexture(3).SetUIActive(false);
				}
				return;
			}
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0602ADA6 RID: 175526 RVA: 0x00C0F964 File Offset: 0x00C0DB64
		private void RefreshCount()
		{
			if (this.FieldData.HasCountSkill)
			{
				base.GetItem(8).SetUIActive(true);
				base.GetText(9).SetText(this.FieldData.CurEffectCount.ToString() + "/" + this.FieldData.MaxEffectCount.ToString(), true);
				if (this.FieldData.CurEffectCount == this.FieldData.MaxEffectCount)
				{
					this.Sequence.PlaySequencePurely("BuffNumFull", false, false);
				}
				else if (this.LastEffectCount < this.FieldData.CurEffectCount)
				{
					this.Sequence.PlaySequencePurely("BuffNumAdd", false, false);
				}
				this.LastEffectCount = this.FieldData.CurEffectCount;
				return;
			}
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x0602ADA7 RID: 175527 RVA: 0x00C0FA3C File Offset: 0x00C0DC3C
		private void RefreshCdState()
		{
			if (this.IsLastInSkillCd && !this.FieldData.IsInSkillCd)
			{
				UUISprite sprite = base.GetSprite(3);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				this.Sequence.PlaySequence("CdClose", false, null);
			}
			else if (!this.IsLastInSkillCd && this.FieldData.IsInSkillCd)
			{
				UUISprite sprite2 = base.GetSprite(7);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(true);
				}
				this.Sequence.PlaySequence("CdStart", false, null);
			}
			this.IsLastInSkillCd = this.FieldData.IsInSkillCd;
		}

		// Token: 0x0602ADA8 RID: 175528 RVA: 0x00C0FAE0 File Offset: 0x00C0DCE0
		private void RefreshInteractState()
		{
			if (!this.IsLastCanInteract && this.FieldData.IsCanInteractive)
			{
				this.Sequence.PlaySequence("Activate", false, null);
				this.SwitchActiveState(true);
			}
			else if (this.IsLastCanInteract && !this.FieldData.IsCanInteractive)
			{
				this.SwitchActiveState(false);
			}
			this.IsLastCanInteract = this.FieldData.IsCanInteractive;
		}

		// Token: 0x0602ADA9 RID: 175529 RVA: 0x00C0FB54 File Offset: 0x00C0DD54
		private void RefreshTexState()
		{
			if (this.FieldData.CardData != null && !StringUtils.IsBlank(this.FieldData.FieldButtonColor))
			{
				FColor color = FColor.FromHex(this.FieldData.FieldButtonColor);
				base.GetTexture(11).SetColor(color);
				base.GetTexture(12).SetColor(color);
			}
		}

		// Token: 0x0602ADAA RID: 175530 RVA: 0x00C0FBB0 File Offset: 0x00C0DDB0
		private void RefreshNiagaraState()
		{
			if (this.FieldData.CardData != null)
			{
				if (!StringUtils.IsBlank(this.FieldData.FieldNorColor))
				{
					UUINiagara uiNiagara = base.GetUiNiagara(13);
					FColor fcolor = FColor.FromHex(this.FieldData.FieldNorColor);
					FLinearColor value = new FLinearColor(ref fcolor);
					uiNiagara.SetNiagaraVarLinearColor("Base_Color", value);
				}
				if (!StringUtils.IsBlank(this.FieldData.FieldActivateColor))
				{
					UUIItem uiNiagara2 = base.GetUiNiagara(15);
					FColor color = FColor.FromHex(this.FieldData.FieldActivateColor);
					uiNiagara2.SetColor(color);
				}
			}
		}

		// Token: 0x0602ADAB RID: 175531 RVA: 0x00C0FC3C File Offset: 0x00C0DE3C
		private UniTask RefreshIcon()
		{
			PhantomArenaFieldItem.<RefreshIcon>d__24 <RefreshIcon>d__;
			<RefreshIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshIcon>d__.<>4__this = this;
			<RefreshIcon>d__.<>1__state = -1;
			<RefreshIcon>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshIcon>d__24>(ref <RefreshIcon>d__);
			return <RefreshIcon>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADAC RID: 175532 RVA: 0x00C0FC80 File Offset: 0x00C0DE80
		private UniTask RefreshNiagaraSystemState()
		{
			PhantomArenaFieldItem.<RefreshNiagaraSystemState>d__25 <RefreshNiagaraSystemState>d__;
			<RefreshNiagaraSystemState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagaraSystemState>d__.<>4__this = this;
			<RefreshNiagaraSystemState>d__.<>1__state = -1;
			<RefreshNiagaraSystemState>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshNiagaraSystemState>d__25>(ref <RefreshNiagaraSystemState>d__);
			return <RefreshNiagaraSystemState>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADAD RID: 175533 RVA: 0x00C0FCC4 File Offset: 0x00C0DEC4
		private UniTask RefreshLockState()
		{
			PhantomArenaFieldItem.<RefreshLockState>d__26 <RefreshLockState>d__;
			<RefreshLockState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLockState>d__.<>4__this = this;
			<RefreshLockState>d__.<>1__state = -1;
			<RefreshLockState>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshLockState>d__26>(ref <RefreshLockState>d__);
			return <RefreshLockState>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADAE RID: 175534 RVA: 0x00C0FD07 File Offset: 0x00C0DF07
		private void SwitchActiveState(bool isActive)
		{
			base.GetItem(4).SetUIActive(isActive);
			base.GetItem(1).SetUIActive(!isActive);
		}

		// Token: 0x0602ADAF RID: 175535 RVA: 0x00C0FD28 File Offset: 0x00C0DF28
		public UniTask Refresh(PhantomArenaFieldData filedData)
		{
			PhantomArenaFieldItem.<Refresh>d__28 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.filedData = filedData;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<PhantomArenaFieldItem.<Refresh>d__28>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADB0 RID: 175536 RVA: 0x00C0FD74 File Offset: 0x00C0DF74
		public UniTask RefreshSelf()
		{
			PhantomArenaFieldItem.<RefreshSelf>d__29 <RefreshSelf>d__;
			<RefreshSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSelf>d__.<>4__this = this;
			<RefreshSelf>d__.<>1__state = -1;
			<RefreshSelf>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshSelf>d__29>(ref <RefreshSelf>d__);
			return <RefreshSelf>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADB1 RID: 175537 RVA: 0x00C0FDB8 File Offset: 0x00C0DFB8
		public void UseSkill()
		{
			this.Sequence.PlaySequence("Use", false, null);
		}

		// Token: 0x0602ADB2 RID: 175538 RVA: 0x00C0FDDF File Offset: 0x00C0DFDF
		public void ResetSkill()
		{
			this.Sequence.PlaySequencePurely("UnUse", false, false);
		}

		// Token: 0x0602ADB3 RID: 175539 RVA: 0x00C0FDF3 File Offset: 0x00C0DFF3
		public void SetInteractClickCallback(Action<PhantomArenaFieldData, PhantomArenaFieldItem> callback)
		{
			this.InteractClickCallback = callback;
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x00C0FDFC File Offset: 0x00C0DFFC
		public void SetFinishSkillInteractCallback(Action<PhantomArenaFieldData> callback)
		{
			this.FinishSkillInteractClickCallback = callback;
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x00C0FE05 File Offset: 0x00C0E005
		public void SetPointerEnterCallback(Action<PhantomArenaFieldData, UUIItem> callback)
		{
			this.PointerEnterCallback = callback;
		}

		// Token: 0x0602ADB6 RID: 175542 RVA: 0x00C0FE0E File Offset: 0x00C0E00E
		public void SetPointerExitCallback(Action callback)
		{
			this.PointerExitCallback = callback;
		}

		// Token: 0x0602ADB7 RID: 175543 RVA: 0x00C0FE18 File Offset: 0x00C0E018
		public string GetFieldDesc()
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.FieldData.CardConfigId).FieldTriggerDesc;
		}

		// Token: 0x0602ADB8 RID: 175544 RVA: 0x00C0FE42 File Offset: 0x00C0E042
		public void SetFieldItemActive(bool active)
		{
			if (this.FieldData.CardData != null && active)
			{
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0602ADB9 RID: 175545 RVA: 0x00C0FE68 File Offset: 0x00C0E068
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			if (!tagList.Contains(EPhantomArenaInteractTag.OwnFiled))
			{
				return false;
			}
			int? dataId = skillTriggerInfo.DataId;
			int cardConfigId = this.FieldData.CardConfigId;
			return dataId.GetValueOrDefault() == cardConfigId & dataId != null;
		}

		// Token: 0x0602ADBA RID: 175546 RVA: 0x00C0FEAA File Offset: 0x00C0E0AA
		public void HandleSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(2, true);
		}

		// Token: 0x0602ADBB RID: 175547 RVA: 0x00C0FEBE File Offset: 0x00C0E0BE
		public void CancelSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(0, true);
		}

		// Token: 0x0602ADBC RID: 175548 RVA: 0x00C0FED4 File Offset: 0x00C0E0D4
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x0602ADBD RID: 175549 RVA: 0x00C0FEEA File Offset: 0x00C0E0EA
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x0602ADBE RID: 175550 RVA: 0x00C0FEFB File Offset: 0x00C0E0FB
		public void FinishSkillInteract()
		{
			Action<PhantomArenaFieldData> finishSkillInteractClickCallback = this.FinishSkillInteractClickCallback;
			if (finishSkillInteractClickCallback == null)
			{
				return;
			}
			finishSkillInteractClickCallback(this.FieldData);
		}

		// Token: 0x0602ADBF RID: 175551 RVA: 0x00C0FF13 File Offset: 0x00C0E113
		public void CancelSkillInteract()
		{
			this.Sequence.PlaySequencePurely("UnUse", false, false);
		}

		// Token: 0x0602ADC0 RID: 175552 RVA: 0x00C0FF27 File Offset: 0x00C0E127
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401732B RID: 95019
		public PhantomArenaFieldData FieldData;

		// Token: 0x0401732C RID: 95020
		protected PhantomArenaSealItem SealItem;

		// Token: 0x0401732D RID: 95021
		protected Action<PhantomArenaFieldData, PhantomArenaFieldItem> InteractClickCallback;

		// Token: 0x0401732E RID: 95022
		protected Action<PhantomArenaFieldData> FinishSkillInteractClickCallback;

		// Token: 0x0401732F RID: 95023
		protected Action<PhantomArenaFieldData, UUIItem> PointerEnterCallback;

		// Token: 0x04017330 RID: 95024
		protected Action PointerExitCallback;

		// Token: 0x04017331 RID: 95025
		protected UiSequencePlayer Sequence;

		// Token: 0x04017332 RID: 95026
		protected bool IsLastInSkillCd;

		// Token: 0x04017333 RID: 95027
		protected bool IsLastCanInteract;

		// Token: 0x04017334 RID: 95028
		protected int LastEffectCount;

		// Token: 0x02009E7A RID: 40570
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403142A RID: 201770
			public const int InteractButton = 0;

			// Token: 0x0403142B RID: 201771
			public const int NormalItem = 1;

			// Token: 0x0403142C RID: 201772
			public const int NormalRing = 2;

			// Token: 0x0403142D RID: 201773
			public const int NormalIcon = 3;

			// Token: 0x0403142E RID: 201774
			public const int ActiveItem = 4;

			// Token: 0x0403142F RID: 201775
			public const int ActiveRing = 5;

			// Token: 0x04031430 RID: 201776
			public const int ActiveIcon = 6;

			// Token: 0x04031431 RID: 201777
			public const int CdIcon = 7;

			// Token: 0x04031432 RID: 201778
			public const int CountItem = 8;

			// Token: 0x04031433 RID: 201779
			public const int CountText = 9;

			// Token: 0x04031434 RID: 201780
			public const int SealItem = 10;

			// Token: 0x04031435 RID: 201781
			public const int NormalTex = 11;

			// Token: 0x04031436 RID: 201782
			public const int ActivateTex = 12;

			// Token: 0x04031437 RID: 201783
			public const int NormalNiagara = 13;

			// Token: 0x04031438 RID: 201784
			public const int ElementNiagara = 14;

			// Token: 0x04031439 RID: 201785
			public const int ActivateNiagara = 15;

			// Token: 0x0403143A RID: 201786
			public const int ContentItem = 16;
		}
	}
}
