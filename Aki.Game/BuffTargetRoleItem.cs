using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200171A RID: 5914
[NullableContext(2)]
[Nullable(0)]
public class BuffTargetRoleItem : UiPanelBase
{
	// Token: 0x0600AA94 RID: 43668 RVA: 0x002651AE File Offset: 0x002633AE
	[NullableContext(1)]
	public void Initialize(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600AA95 RID: 43669 RVA: 0x002651B8 File Offset: 0x002633B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUINiagara))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickedSelectedRoleButton))
		};
	}

	// Token: 0x0600AA96 RID: 43670 RVA: 0x002652D0 File Offset: 0x002634D0
	private void OnClickedSelectedRoleButton()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback(this);
		}
	}

	// Token: 0x0600AA97 RID: 43671 RVA: 0x002652E8 File Offset: 0x002634E8
	protected override void OnStart()
	{
		this.ItemGrid = new MediumItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.NiagaraBuffItem = base.GetUiNiagara(9);
		this.NiagaraBuffItem.SetUIActive(false);
	}

	// Token: 0x0600AA98 RID: 43672 RVA: 0x00265342 File Offset: 0x00263542
	protected override void OnBeforeDestroy()
	{
		this.ItemGrid = null;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.ResetBuffTargetRoleItem();
		this.EndNiagaraBuff();
		this.NiagaraBuffItem = null;
	}

	// Token: 0x0600AA99 RID: 43673 RVA: 0x0026536F File Offset: 0x0026356F
	public void ResetBuffTargetRoleItem()
	{
		this.UseBuffItemRoleData = null;
		this.NiagaraBuffResourceFlag = false;
		this.RemoveEntityEvents();
	}

	// Token: 0x0600AA9A RID: 43674 RVA: 0x00265385 File Offset: 0x00263585
	public void Tick(float delta)
	{
		if (!this.IsPlayingAnimation)
		{
			return;
		}
		if (this.AnimationCurrentTime > 200f)
		{
			this.FinishUseItemAnimation();
			return;
		}
		this.RefreshAnimationValueBar();
		this.AnimationCurrentTime += delta;
	}

	// Token: 0x0600AA9B RID: 43675 RVA: 0x002653B8 File Offset: 0x002635B8
	[NullableContext(1)]
	public void RefreshBuffTargetRoleItem(UseBuffItemRoleData useBuffItemRoleData)
	{
		this.UseBuffItemRoleData = useBuffItemRoleData;
		int roleConfigId = useBuffItemRoleData.RoleConfigId;
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleConfigId).Value;
		int roleLevel = useBuffItemRoleData.RoleLevel;
		float num = (float)Math.Floor((double)useBuffItemRoleData.CurrentAttribute);
		float num2 = (float)Math.Floor((double)useBuffItemRoleData.MaxAttribute);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(roleConfigId),
			SkinId = value.SkinId,
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				roleLevel
			},
			ElementId = new int?(value.ElementId)
		};
		this.ItemGrid.Apply<CharacterMediumItemGrid>(parameters);
		this.SetCurrentValueBarPercent(num / num2);
		this.SetValueText((int)num, (int)num2);
		this.SetPreviewValueBarVisible(false);
		this.SetAnimationValueBarVisible(false);
		this.SetAddValueTextVisible(false);
		this.SetSelected(false);
		this.SetNoneRole(false);
		this.AddEntityEvents();
	}

	// Token: 0x0600AA9C RID: 43676 RVA: 0x002654B3 File Offset: 0x002636B3
	public void RemoveRole()
	{
		this.SetNoneRole(true);
		this.RemoveEntityEvents();
		this.UseBuffItemRoleData = null;
	}

	// Token: 0x0600AA9D RID: 43677 RVA: 0x002654C9 File Offset: 0x002636C9
	private void AddEntityEvents()
	{
		if (this.UseBuffItemRoleData == null)
		{
			return;
		}
		this.UseBuffItemRoleData.Entity.GetComponent<BaseAttributeComponent>().AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnCharOnHealthChanged), "Life.BuffTargetRoleItem");
	}

	// Token: 0x0600AA9E RID: 43678 RVA: 0x002654FB File Offset: 0x002636FB
	private void RemoveEntityEvents()
	{
		if (this.UseBuffItemRoleData == null)
		{
			return;
		}
		this.UseBuffItemRoleData.Entity.GetComponent<BaseAttributeComponent>().RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnCharOnHealthChanged));
	}

	// Token: 0x0600AA9F RID: 43679 RVA: 0x0026552C File Offset: 0x0026372C
	private void OnCharOnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		if (newValue == oldValue)
		{
			return;
		}
		if (this.UseBuffItemRoleData == null)
		{
			return;
		}
		float currentValue = this.UseBuffItemRoleData.Entity.GetComponent<BaseAttributeComponent>().GetCurrentValue(EAttributeType.LifeMax);
		this.UseBuffItemRoleData.SetCurrentAttribute(newValue);
		this.PlayPreviewBarAnimation(oldValue, newValue, currentValue);
	}

	// Token: 0x0600AAA0 RID: 43680 RVA: 0x00265574 File Offset: 0x00263774
	public void RefreshPreviewUseItem(float currentAttribute, float maxAttribute, float addAttribute)
	{
		float num = Math.Min(currentAttribute + addAttribute, maxAttribute);
		float num2 = Math.Min(addAttribute, maxAttribute - currentAttribute);
		this.SetCurrentValueBarPercent(currentAttribute / maxAttribute);
		this.SetPreviewValueBarPercent(num / maxAttribute);
		this.SetPreviewValueBarVisible(addAttribute > 0f);
		this.SetAddValueText((int)Math.Floor((double)num2));
		this.SetAddValueTextVisible(addAttribute > 0f);
		this.SetPreviewValueText((int)Math.Floor((double)num), (int)Math.Floor((double)maxAttribute));
	}

	// Token: 0x0600AAA1 RID: 43681 RVA: 0x002655EC File Offset: 0x002637EC
	public void ResetPreviewUseItem()
	{
		float currentAttribute = this.UseBuffItemRoleData.CurrentAttribute;
		float maxAttribute = this.UseBuffItemRoleData.MaxAttribute;
		this.SetPreviewValueBarVisible(false);
		this.SetAddValueTextVisible(false);
		this.SetValueText((int)currentAttribute, (int)maxAttribute);
	}

	// Token: 0x0600AAA2 RID: 43682 RVA: 0x0026562C File Offset: 0x0026382C
	public void SetCurrentValueBarPercent(float percent)
	{
		UUISprite sprite = base.GetSprite(4);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = percent <= 0.2f;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		sprite.SetFillAmount(percent);
	}

	// Token: 0x0600AAA3 RID: 43683 RVA: 0x00265667 File Offset: 0x00263867
	public void SetPreviewValueBarPercent(float percent)
	{
		base.GetSprite(5).SetFillAmount(percent);
	}

	// Token: 0x0600AAA4 RID: 43684 RVA: 0x00265676 File Offset: 0x00263876
	public void SetPreviewValueBarVisible(bool bVisible)
	{
		base.GetSprite(5).SetUIActive(bVisible);
	}

	// Token: 0x0600AAA5 RID: 43685 RVA: 0x00265685 File Offset: 0x00263885
	public void SetAnimationValueBarPercent(float percent)
	{
		base.GetSprite(3).SetFillAmount(percent);
	}

	// Token: 0x0600AAA6 RID: 43686 RVA: 0x00265694 File Offset: 0x00263894
	private void SetAnimationColorState(float percent)
	{
		UUISprite sprite = base.GetSprite(3);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = percent <= 0.2f;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0600AAA7 RID: 43687 RVA: 0x002656C8 File Offset: 0x002638C8
	public void SetAnimationValueBarVisible(bool bVisible)
	{
		base.GetSprite(3).SetUIActive(bVisible);
	}

	// Token: 0x0600AAA8 RID: 43688 RVA: 0x002656D8 File Offset: 0x002638D8
	public void SetAddValueText(int addValue)
	{
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("+");
		defaultInterpolatedStringHandler.AppendFormatted<int>(addValue);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600AAA9 RID: 43689 RVA: 0x00265716 File Offset: 0x00263916
	private void SetAddValueTextVisible(bool bVisible)
	{
		base.GetText(1).SetUIActive(bVisible);
	}

	// Token: 0x0600AAAA RID: 43690 RVA: 0x00265728 File Offset: 0x00263928
	private void SetValueText(int currentValue, int maxValue)
	{
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (currentValue <= 0)
		{
			UUIText uuitext = text;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#ff0000ff>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)currentValue));
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)maxValue));
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			return;
		}
		UUIText uuitext2 = text;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)currentValue));
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)maxValue));
		uuitext2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600AAAB RID: 43691 RVA: 0x002657D0 File Offset: 0x002639D0
	public void SetPreviewValueText(int value, int maxValue)
	{
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#00ff00ff>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("</color>/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxValue);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x0600AAAC RID: 43692 RVA: 0x00265824 File Offset: 0x00263A24
	public void SetSelected(bool bSelected)
	{
		if (bSelected)
		{
			this.ItemGrid.SetSelected(true, false);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Selected", false, null, false);
		}
		else
		{
			this.ResetPreviewUseItem();
			this.SetAnimationValueBarVisible(false);
			this.ItemGrid.SetSelected(false, false);
		}
		this.IsRoleSelected = bSelected;
	}

	// Token: 0x0600AAAD RID: 43693 RVA: 0x0026587F File Offset: 0x00263A7F
	public bool IsSelected()
	{
		return this.IsRoleSelected;
	}

	// Token: 0x0600AAAE RID: 43694 RVA: 0x00265888 File Offset: 0x00263A88
	public void SetNoneRole(bool bNone)
	{
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(6);
		item.SetUIActive(bNone);
		item2.SetUIActive(!bNone);
	}

	// Token: 0x0600AAAF RID: 43695 RVA: 0x002658B4 File Offset: 0x00263AB4
	public UseBuffItemRoleData GetUseBuffItemRoleData()
	{
		return this.UseBuffItemRoleData;
	}

	// Token: 0x0600AAB0 RID: 43696 RVA: 0x002658BC File Offset: 0x00263ABC
	[NullableContext(1)]
	public void BindOnClickedBuffTargetRoleItem(Action<BuffTargetRoleItem> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x0600AAB1 RID: 43697 RVA: 0x002658C8 File Offset: 0x00263AC8
	private void StartNiagaraBuff()
	{
		Action startNiagaraAnimation = delegate()
		{
			this.NiagaraBuffItem.SetUIActive(true);
			this.NiagaraBuffItem.ActivateSystem(true);
		};
		if (!this.NiagaraBuffResourceFlag)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("Niagara_BuffTreat");
			base.SetNiagaraSystemByPath(resourcePath, this.NiagaraBuffItem, delegate(bool _)
			{
				this.NiagaraBuffResourceFlag = true;
				startNiagaraAnimation();
			});
			return;
		}
		startNiagaraAnimation();
	}

	// Token: 0x0600AAB2 RID: 43698 RVA: 0x00265931 File Offset: 0x00263B31
	private void EndNiagaraBuff()
	{
		this.NiagaraBuffItem.DeactivateSystem();
		this.NiagaraBuffItem.SetUIActive(false);
	}

	// Token: 0x0600AAB3 RID: 43699 RVA: 0x0026594C File Offset: 0x00263B4C
	private void PlayPreviewBarAnimation(float currentAttribute, float targetAttribute, float maxAttribute)
	{
		if (currentAttribute == targetAttribute)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.YYZ;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 3);
		defaultInterpolatedStringHandler.AppendLiteral("播放属性进度条动画，currentAttribute：");
		defaultInterpolatedStringHandler.AppendFormatted<float>(currentAttribute);
		defaultInterpolatedStringHandler.AppendLiteral(",targetAttribute:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(targetAttribute);
		defaultInterpolatedStringHandler.AppendLiteral(",maxAttribute:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(maxAttribute);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		if (!this.IsPlayingAnimation)
		{
			this.AnimationCurrentAttribute = currentAttribute;
		}
		this.StartNiagaraBuff();
		this.AnimationTargetAttribute = targetAttribute;
		this.AnimationMaxAttribute = maxAttribute;
		this.AnimationCurrentTime = 0f;
		this.IsPlayingAnimation = true;
		this.SetAnimationValueBarVisible(true);
		this.SetAnimationColorState(this.AnimationCurrentAttribute / this.AnimationMaxAttribute);
		this.ResetPreviewUseItem();
		this.LevelSequencePlayer.PlayLevelSequenceByName("Reply", false, null, false);
	}

	// Token: 0x0600AAB4 RID: 43700 RVA: 0x00265A34 File Offset: 0x00263C34
	private void FinishUseItemAnimation()
	{
		this.IsPlayingAnimation = false;
		this.AnimationCurrentTime = -1f;
		float currentAttribute = this.UseBuffItemRoleData.CurrentAttribute;
		float maxAttribute = this.UseBuffItemRoleData.MaxAttribute;
		float addAttribute = this.UseBuffItemRoleData.GetAddAttribute();
		this.SetAnimationColorState(currentAttribute / maxAttribute);
		this.RefreshPreviewUseItem(currentAttribute, maxAttribute, addAttribute);
		this.SetAnimationValueBarVisible(false);
		if (this.OnUseItemAnimationFinishedCallback != null)
		{
			this.OnUseItemAnimationFinishedCallback();
		}
	}

	// Token: 0x0600AAB5 RID: 43701 RVA: 0x00265AA4 File Offset: 0x00263CA4
	[NullableContext(1)]
	public void BindOnUseItemAnimationFinished(Action onUseItemAnimationFinishedCallback)
	{
		this.OnUseItemAnimationFinishedCallback = onUseItemAnimationFinishedCallback;
	}

	// Token: 0x0600AAB6 RID: 43702 RVA: 0x00265AB0 File Offset: 0x00263CB0
	private void RefreshAnimationValueBar()
	{
		float alpha = Math.Min(this.AnimationCurrentTime / 200f, 1f);
		this.AnimationCurrentAttribute = MathUtils.Instance.Lerp(this.AnimationCurrentAttribute, this.AnimationTargetAttribute, alpha);
		this.SetAnimationValueBarPercent(this.AnimationCurrentAttribute / this.AnimationMaxAttribute);
	}

	// Token: 0x04004D70 RID: 19824
	private const int ANIMATION_LENGTH = 200;

	// Token: 0x04004D71 RID: 19825
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x04004D72 RID: 19826
	private UseBuffItemRoleData UseBuffItemRoleData;

	// Token: 0x04004D73 RID: 19827
	private float AnimationCurrentAttribute = -1f;

	// Token: 0x04004D74 RID: 19828
	private float AnimationTargetAttribute;

	// Token: 0x04004D75 RID: 19829
	private float AnimationCurrentTime;

	// Token: 0x04004D76 RID: 19830
	private bool IsPlayingAnimation;

	// Token: 0x04004D77 RID: 19831
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<BuffTargetRoleItem> OnClickedCallback;

	// Token: 0x04004D78 RID: 19832
	private float AnimationMaxAttribute;

	// Token: 0x04004D79 RID: 19833
	private Action OnUseItemAnimationFinishedCallback;

	// Token: 0x04004D7A RID: 19834
	private MediumItemGrid ItemGrid;

	// Token: 0x04004D7B RID: 19835
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004D7C RID: 19836
	private UUINiagara NiagaraBuffItem;

	// Token: 0x04004D7D RID: 19837
	private bool NiagaraBuffResourceFlag;

	// Token: 0x04004D7E RID: 19838
	private bool IsRoleSelected;

	// Token: 0x02007D18 RID: 32024
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028F81 RID: 167809
		ItemGridItem,
		// Token: 0x04028F82 RID: 167810
		AddValueText,
		// Token: 0x04028F83 RID: 167811
		CurrentValueText,
		// Token: 0x04028F84 RID: 167812
		AnimationValueBarSprite,
		// Token: 0x04028F85 RID: 167813
		CurrentValueBarSprite,
		// Token: 0x04028F86 RID: 167814
		PreviewValueBarSprite,
		// Token: 0x04028F87 RID: 167815
		RoleDetailItem,
		// Token: 0x04028F88 RID: 167816
		SelectedButton,
		// Token: 0x04028F89 RID: 167817
		NoneRoleItem,
		// Token: 0x04028F8A RID: 167818
		NiagaraBuff
	}
}
