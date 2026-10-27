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
	// Token: 0x02005262 RID: 21090
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldItem : UiPanelBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x06035EA3 RID: 220835 RVA: 0x00CC1FD0 File Offset: 0x00CC01D0
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

		// Token: 0x06035EA4 RID: 220836 RVA: 0x00CC218C File Offset: 0x00CC038C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaFieldItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaFieldItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035EA5 RID: 220837 RVA: 0x00CC21D0 File Offset: 0x00CC03D0
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			this.SwitchActiveState(false);
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
			button.OnPointExitCallBack.Bind(new Action(this.OnPointerExit));
		}

		// Token: 0x06035EA6 RID: 220838 RVA: 0x00CC2240 File Offset: 0x00CC0440
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035EA7 RID: 220839 RVA: 0x00CC224D File Offset: 0x00CC044D
		private void OnInteractClick()
		{
			Action<PhantomArenaFieldData, PhantomArenaFieldItem> interactClickCallback = this.InteractClickCallback;
			if (interactClickCallback == null)
			{
				return;
			}
			interactClickCallback(this.FieldData, this);
		}

		// Token: 0x06035EA8 RID: 220840 RVA: 0x00CC2266 File Offset: 0x00CC0466
		private void OnPointerEnter()
		{
			Action<PhantomArenaFieldData, UUIItem> pointerEnterCallback = this.PointerEnterCallback;
			if (pointerEnterCallback == null)
			{
				return;
			}
			pointerEnterCallback(this.FieldData, base.GetItem(16));
		}

		// Token: 0x06035EA9 RID: 220841 RVA: 0x00CC2286 File Offset: 0x00CC0486
		private void OnPointerExit()
		{
			Action pointerExitCallback = this.PointerExitCallback;
			if (pointerExitCallback == null)
			{
				return;
			}
			pointerExitCallback();
		}

		// Token: 0x06035EAA RID: 220842 RVA: 0x00CC2298 File Offset: 0x00CC0498
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

		// Token: 0x06035EAB RID: 220843 RVA: 0x00CC22D4 File Offset: 0x00CC04D4
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

		// Token: 0x06035EAC RID: 220844 RVA: 0x00CC23AC File Offset: 0x00CC05AC
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

		// Token: 0x06035EAD RID: 220845 RVA: 0x00CC2450 File Offset: 0x00CC0650
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

		// Token: 0x06035EAE RID: 220846 RVA: 0x00CC24C4 File Offset: 0x00CC06C4
		private void RefreshTexState()
		{
			if (this.FieldData.CardData != null && !StringUtils.IsBlank(this.FieldData.FieldButtonColor))
			{
				FColor color = FColor.FromHex(this.FieldData.FieldButtonColor);
				base.GetTexture(11).SetColor(color);
				base.GetTexture(12).SetColor(color);
			}
		}

		// Token: 0x06035EAF RID: 220847 RVA: 0x00CC2520 File Offset: 0x00CC0720
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

		// Token: 0x06035EB0 RID: 220848 RVA: 0x00CC25AC File Offset: 0x00CC07AC
		private UniTask RefreshIcon()
		{
			PhantomArenaFieldItem.<RefreshIcon>d__24 <RefreshIcon>d__;
			<RefreshIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshIcon>d__.<>4__this = this;
			<RefreshIcon>d__.<>1__state = -1;
			<RefreshIcon>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshIcon>d__24>(ref <RefreshIcon>d__);
			return <RefreshIcon>d__.<>t__builder.Task;
		}

		// Token: 0x06035EB1 RID: 220849 RVA: 0x00CC25F0 File Offset: 0x00CC07F0
		private UniTask RefreshNiagaraSystemState()
		{
			PhantomArenaFieldItem.<RefreshNiagaraSystemState>d__25 <RefreshNiagaraSystemState>d__;
			<RefreshNiagaraSystemState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagaraSystemState>d__.<>4__this = this;
			<RefreshNiagaraSystemState>d__.<>1__state = -1;
			<RefreshNiagaraSystemState>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshNiagaraSystemState>d__25>(ref <RefreshNiagaraSystemState>d__);
			return <RefreshNiagaraSystemState>d__.<>t__builder.Task;
		}

		// Token: 0x06035EB2 RID: 220850 RVA: 0x00CC2634 File Offset: 0x00CC0834
		private UniTask RefreshLockState()
		{
			PhantomArenaFieldItem.<RefreshLockState>d__26 <RefreshLockState>d__;
			<RefreshLockState>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLockState>d__.<>4__this = this;
			<RefreshLockState>d__.<>1__state = -1;
			<RefreshLockState>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshLockState>d__26>(ref <RefreshLockState>d__);
			return <RefreshLockState>d__.<>t__builder.Task;
		}

		// Token: 0x06035EB3 RID: 220851 RVA: 0x00CC2677 File Offset: 0x00CC0877
		private void SwitchActiveState(bool isActive)
		{
			base.GetItem(4).SetUIActive(isActive);
			base.GetItem(1).SetUIActive(!isActive);
		}

		// Token: 0x06035EB4 RID: 220852 RVA: 0x00CC2698 File Offset: 0x00CC0898
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

		// Token: 0x06035EB5 RID: 220853 RVA: 0x00CC26E4 File Offset: 0x00CC08E4
		public UniTask RefreshSelf()
		{
			PhantomArenaFieldItem.<RefreshSelf>d__29 <RefreshSelf>d__;
			<RefreshSelf>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSelf>d__.<>4__this = this;
			<RefreshSelf>d__.<>1__state = -1;
			<RefreshSelf>d__.<>t__builder.Start<PhantomArenaFieldItem.<RefreshSelf>d__29>(ref <RefreshSelf>d__);
			return <RefreshSelf>d__.<>t__builder.Task;
		}

		// Token: 0x06035EB6 RID: 220854 RVA: 0x00CC2728 File Offset: 0x00CC0928
		public void UseSkill()
		{
			this.Sequence.PlaySequence("Use", false, null);
		}

		// Token: 0x06035EB7 RID: 220855 RVA: 0x00CC274F File Offset: 0x00CC094F
		public void ResetSkill()
		{
			this.Sequence.PlaySequencePurely("UnUse", false, false);
		}

		// Token: 0x06035EB8 RID: 220856 RVA: 0x00CC2763 File Offset: 0x00CC0963
		public void SetInteractClickCallback(Action<PhantomArenaFieldData, PhantomArenaFieldItem> callback)
		{
			this.InteractClickCallback = callback;
		}

		// Token: 0x06035EB9 RID: 220857 RVA: 0x00CC276C File Offset: 0x00CC096C
		public void SetFinishSkillInteractCallback(Action<PhantomArenaFieldData> callback)
		{
			this.FinishSkillInteractClickCallback = callback;
		}

		// Token: 0x06035EBA RID: 220858 RVA: 0x00CC2775 File Offset: 0x00CC0975
		public void SetPointerEnterCallback(Action<PhantomArenaFieldData, UUIItem> callback)
		{
			this.PointerEnterCallback = callback;
		}

		// Token: 0x06035EBB RID: 220859 RVA: 0x00CC277E File Offset: 0x00CC097E
		public void SetPointerExitCallback(Action callback)
		{
			this.PointerExitCallback = callback;
		}

		// Token: 0x06035EBC RID: 220860 RVA: 0x00CC2788 File Offset: 0x00CC0988
		public string GetFieldDesc()
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(this.FieldData.CardConfigId).FieldTriggerDesc;
		}

		// Token: 0x06035EBD RID: 220861 RVA: 0x00CC27B2 File Offset: 0x00CC09B2
		public void SetFieldItemActive(bool active)
		{
			if (this.FieldData.CardData != null && active)
			{
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x06035EBE RID: 220862 RVA: 0x00CC27D8 File Offset: 0x00CC09D8
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

		// Token: 0x06035EBF RID: 220863 RVA: 0x00CC281A File Offset: 0x00CC0A1A
		public void HandleSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(2, true);
		}

		// Token: 0x06035EC0 RID: 220864 RVA: 0x00CC282E File Offset: 0x00CC0A2E
		public void CancelSortOrder()
		{
			this.RootItem.GetRenderCanvas().SetSortOrderNew(0, true);
		}

		// Token: 0x06035EC1 RID: 220865 RVA: 0x00CC2844 File Offset: 0x00CC0A44
		public UniTask StartSkillInteract()
		{
			return default(UniTask);
		}

		// Token: 0x06035EC2 RID: 220866 RVA: 0x00CC285A File Offset: 0x00CC0A5A
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x06035EC3 RID: 220867 RVA: 0x00CC286B File Offset: 0x00CC0A6B
		public void FinishSkillInteract()
		{
			Action<PhantomArenaFieldData> finishSkillInteractClickCallback = this.FinishSkillInteractClickCallback;
			if (finishSkillInteractClickCallback == null)
			{
				return;
			}
			finishSkillInteractClickCallback(this.FieldData);
		}

		// Token: 0x06035EC4 RID: 220868 RVA: 0x00CC2883 File Offset: 0x00CC0A83
		public void CancelSkillInteract()
		{
			this.Sequence.PlaySequencePurely("UnUse", false, false);
		}

		// Token: 0x06035EC5 RID: 220869 RVA: 0x00CC2897 File Offset: 0x00CC0A97
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401C8F6 RID: 116982
		public PhantomArenaFieldData FieldData;

		// Token: 0x0401C8F7 RID: 116983
		protected PhantomArenaSealItem SealItem;

		// Token: 0x0401C8F8 RID: 116984
		protected Action<PhantomArenaFieldData, PhantomArenaFieldItem> InteractClickCallback;

		// Token: 0x0401C8F9 RID: 116985
		protected Action<PhantomArenaFieldData> FinishSkillInteractClickCallback;

		// Token: 0x0401C8FA RID: 116986
		protected Action<PhantomArenaFieldData, UUIItem> PointerEnterCallback;

		// Token: 0x0401C8FB RID: 116987
		protected Action PointerExitCallback;

		// Token: 0x0401C8FC RID: 116988
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8FD RID: 116989
		protected bool IsLastInSkillCd;

		// Token: 0x0401C8FE RID: 116990
		protected bool IsLastCanInteract;

		// Token: 0x0401C8FF RID: 116991
		protected int LastEffectCount;

		// Token: 0x0200B442 RID: 46146
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040369D7 RID: 223703
			public const int InteractButton = 0;

			// Token: 0x040369D8 RID: 223704
			public const int NormalItem = 1;

			// Token: 0x040369D9 RID: 223705
			public const int NormalRing = 2;

			// Token: 0x040369DA RID: 223706
			public const int NormalIcon = 3;

			// Token: 0x040369DB RID: 223707
			public const int ActiveItem = 4;

			// Token: 0x040369DC RID: 223708
			public const int ActiveRing = 5;

			// Token: 0x040369DD RID: 223709
			public const int ActiveIcon = 6;

			// Token: 0x040369DE RID: 223710
			public const int CdIcon = 7;

			// Token: 0x040369DF RID: 223711
			public const int CountItem = 8;

			// Token: 0x040369E0 RID: 223712
			public const int CountText = 9;

			// Token: 0x040369E1 RID: 223713
			public const int SealItem = 10;

			// Token: 0x040369E2 RID: 223714
			public const int NormalTex = 11;

			// Token: 0x040369E3 RID: 223715
			public const int ActivateTex = 12;

			// Token: 0x040369E4 RID: 223716
			public const int NormalNiagara = 13;

			// Token: 0x040369E5 RID: 223717
			public const int ElementNiagara = 14;

			// Token: 0x040369E6 RID: 223718
			public const int ActivateNiagara = 15;

			// Token: 0x040369E7 RID: 223719
			public const int ContentItem = 16;
		}
	}
}
