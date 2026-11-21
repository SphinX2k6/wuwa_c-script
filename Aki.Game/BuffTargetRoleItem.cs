using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000BD2 RID: 3026
[NullableContext(2)]
[Nullable(0)]
public class BuffTargetRoleItem : UiPanelBase
{
	// Token: 0x06007E77 RID: 32375 RVA: 0x0026F6FE File Offset: 0x0026D8FE
	[NullableContext(1)]
	public void Initialize(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06007E78 RID: 32376 RVA: 0x0026F708 File Offset: 0x0026D908
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

	// Token: 0x06007E79 RID: 32377 RVA: 0x0026F820 File Offset: 0x0026DA20
	private void OnClickedSelectedRoleButton()
	{
		if (this.OnClickedCallback != null)
		{
			this.OnClickedCallback(this);
		}
	}

	// Token: 0x06007E7A RID: 32378 RVA: 0x0026F838 File Offset: 0x0026DA38
	protected override void OnStart()
	{
		this.ItemGrid = new MediumItemGrid();
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.NiagaraBuffItem = base.GetUiNiagara(9);
		this.NiagaraBuffItem.SetUIActive(false);
	}

	// Token: 0x06007E7B RID: 32379 RVA: 0x0026F892 File Offset: 0x0026DA92
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

	// Token: 0x06007E7C RID: 32380 RVA: 0x0026F8BF File Offset: 0x0026DABF
	public void ResetBuffTargetRoleItem()
	{
		this.UseBuffItemRoleData = null;
		this.NiagaraBuffResourceFlag = false;
		this.RemoveEntityEvents();
	}

	// Token: 0x06007E7D RID: 32381 RVA: 0x0026F8D5 File Offset: 0x0026DAD5
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

	// Token: 0x06007E7E RID: 32382 RVA: 0x0026F908 File Offset: 0x0026DB08
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

	// Token: 0x06007E7F RID: 32383 RVA: 0x0026FA03 File Offset: 0x0026DC03
	public void RemoveRole()
	{
		this.SetNoneRole(true);
		this.RemoveEntityEvents();
		this.UseBuffItemRoleData = null;
	}

	// Token: 0x06007E80 RID: 32384 RVA: 0x0026FA19 File Offset: 0x0026DC19
	private void AddEntityEvents()
	{
		if (this.UseBuffItemRoleData == null)
		{
			return;
		}
		this.UseBuffItemRoleData.Entity.GetComponent<BaseAttributeComponent>().AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnCharOnHealthChanged), "Life.BuffTargetRoleItem");
	}

	// Token: 0x06007E81 RID: 32385 RVA: 0x0026FA4B File Offset: 0x0026DC4B
	private void RemoveEntityEvents()
	{
		if (this.UseBuffItemRoleData == null)
		{
			return;
		}
		this.UseBuffItemRoleData.Entity.GetComponent<BaseAttributeComponent>().RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnCharOnHealthChanged));
	}

	// Token: 0x06007E82 RID: 32386 RVA: 0x0026FA7C File Offset: 0x0026DC7C
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

	// Token: 0x06007E83 RID: 32387 RVA: 0x0026FAC4 File Offset: 0x0026DCC4
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

	// Token: 0x06007E84 RID: 32388 RVA: 0x0026FB3C File Offset: 0x0026DD3C
	public void ResetPreviewUseItem()
	{
		float currentAttribute = this.UseBuffItemRoleData.CurrentAttribute;
		float maxAttribute = this.UseBuffItemRoleData.MaxAttribute;
		this.SetPreviewValueBarVisible(false);
		this.SetAddValueTextVisible(false);
		this.SetValueText((int)currentAttribute, (int)maxAttribute);
	}

	// Token: 0x06007E85 RID: 32389 RVA: 0x0026FB7C File Offset: 0x0026DD7C
	public void SetCurrentValueBarPercent(float percent)
	{
		UUISprite sprite = base.GetSprite(4);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = percent <= 0.2f;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		sprite.SetFillAmount(percent);
	}

	// Token: 0x06007E86 RID: 32390 RVA: 0x0026FBB7 File Offset: 0x0026DDB7
	public void SetPreviewValueBarPercent(float percent)
	{
		base.GetSprite(5).SetFillAmount(percent);
	}

	// Token: 0x06007E87 RID: 32391 RVA: 0x0026FBC6 File Offset: 0x0026DDC6
	public void SetPreviewValueBarVisible(bool bVisible)
	{
		base.GetSprite(5).SetUIActive(bVisible);
	}

	// Token: 0x06007E88 RID: 32392 RVA: 0x0026FBD5 File Offset: 0x0026DDD5
	public void SetAnimationValueBarPercent(float percent)
	{
		base.GetSprite(3).SetFillAmount(percent);
	}

	// Token: 0x06007E89 RID: 32393 RVA: 0x0026FBE4 File Offset: 0x0026DDE4
	private void SetAnimationColorState(float percent)
	{
		UUISprite sprite = base.GetSprite(3);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = percent <= 0.2f;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x06007E8A RID: 32394 RVA: 0x0026FC18 File Offset: 0x0026DE18
	public void SetAnimationValueBarVisible(bool bVisible)
	{
		base.GetSprite(3).SetUIActive(bVisible);
	}

	// Token: 0x06007E8B RID: 32395 RVA: 0x0026FC28 File Offset: 0x0026DE28
	public void SetAddValueText(int addValue)
	{
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("+");
		defaultInterpolatedStringHandler.AppendFormatted<int>(addValue);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06007E8C RID: 32396 RVA: 0x0026FC66 File Offset: 0x0026DE66
	private void SetAddValueTextVisible(bool bVisible)
	{
		base.GetText(1).SetUIActive(bVisible);
	}

	// Token: 0x06007E8D RID: 32397 RVA: 0x0026FC78 File Offset: 0x0026DE78
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

	// Token: 0x06007E8E RID: 32398 RVA: 0x0026FD20 File Offset: 0x0026DF20
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

	// Token: 0x06007E8F RID: 32399 RVA: 0x0026FD74 File Offset: 0x0026DF74
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

	// Token: 0x06007E90 RID: 32400 RVA: 0x0026FDCF File Offset: 0x0026DFCF
	public bool IsSelected()
	{
		return this.IsRoleSelected;
	}

	// Token: 0x06007E91 RID: 32401 RVA: 0x0026FDD8 File Offset: 0x0026DFD8
	public void SetNoneRole(bool bNone)
	{
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(6);
		item.SetUIActive(bNone);
		item2.SetUIActive(!bNone);
	}

	// Token: 0x06007E92 RID: 32402 RVA: 0x0026FE04 File Offset: 0x0026E004
	public UseBuffItemRoleData GetUseBuffItemRoleData()
	{
		return this.UseBuffItemRoleData;
	}

	// Token: 0x06007E93 RID: 32403 RVA: 0x0026FE0C File Offset: 0x0026E00C
	[NullableContext(1)]
	public void BindOnClickedBuffTargetRoleItem(Action<BuffTargetRoleItem> onClickedCallback)
	{
		this.OnClickedCallback = onClickedCallback;
	}

	// Token: 0x06007E94 RID: 32404 RVA: 0x0026FE18 File Offset: 0x0026E018
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

	// Token: 0x06007E95 RID: 32405 RVA: 0x0026FE81 File Offset: 0x0026E081
	private void EndNiagaraBuff()
	{
		this.NiagaraBuffItem.DeactivateSystem();
		this.NiagaraBuffItem.SetUIActive(false);
	}

	// Token: 0x06007E96 RID: 32406 RVA: 0x0026FE9C File Offset: 0x0026E09C
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

	// Token: 0x06007E97 RID: 32407 RVA: 0x0026FF84 File Offset: 0x0026E184
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

	// Token: 0x06007E98 RID: 32408 RVA: 0x0026FFF4 File Offset: 0x0026E1F4
	[NullableContext(1)]
	public void BindOnUseItemAnimationFinished(Action onUseItemAnimationFinishedCallback)
	{
		this.OnUseItemAnimationFinishedCallback = onUseItemAnimationFinishedCallback;
	}

	// Token: 0x06007E99 RID: 32409 RVA: 0x00270000 File Offset: 0x0026E200
	private void RefreshAnimationValueBar()
	{
		float alpha = Math.Min(this.AnimationCurrentTime / 200f, 1f);
		this.AnimationCurrentAttribute = MathUtils.Instance.Lerp(this.AnimationCurrentAttribute, this.AnimationTargetAttribute, alpha);
		this.SetAnimationValueBarPercent(this.AnimationCurrentAttribute / this.AnimationMaxAttribute);
	}

	// Token: 0x04004E18 RID: 19992
	private const int ANIMATION_LENGTH = 200;

	// Token: 0x04004E19 RID: 19993
	private const float LOW_HP_PERCENT = 0.2f;

	// Token: 0x04004E1A RID: 19994
	private UseBuffItemRoleData UseBuffItemRoleData;

	// Token: 0x04004E1B RID: 19995
	private float AnimationCurrentAttribute = -1f;

	// Token: 0x04004E1C RID: 19996
	private float AnimationTargetAttribute;

	// Token: 0x04004E1D RID: 19997
	private float AnimationCurrentTime;

	// Token: 0x04004E1E RID: 19998
	private bool IsPlayingAnimation;

	// Token: 0x04004E1F RID: 19999
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<BuffTargetRoleItem> OnClickedCallback;

	// Token: 0x04004E20 RID: 20000
	private float AnimationMaxAttribute;

	// Token: 0x04004E21 RID: 20001
	private Action OnUseItemAnimationFinishedCallback;

	// Token: 0x04004E22 RID: 20002
	private MediumItemGrid ItemGrid;

	// Token: 0x04004E23 RID: 20003
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004E24 RID: 20004
	private UUINiagara NiagaraBuffItem;

	// Token: 0x04004E25 RID: 20005
	private bool NiagaraBuffResourceFlag;

	// Token: 0x04004E26 RID: 20006
	private bool IsRoleSelected;

	// Token: 0x02006E9D RID: 28317
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040242AA RID: 148138
		ItemGridItem,
		// Token: 0x040242AB RID: 148139
		AddValueText,
		// Token: 0x040242AC RID: 148140
		CurrentValueText,
		// Token: 0x040242AD RID: 148141
		AnimationValueBarSprite,
		// Token: 0x040242AE RID: 148142
		CurrentValueBarSprite,
		// Token: 0x040242AF RID: 148143
		PreviewValueBarSprite,
		// Token: 0x040242B0 RID: 148144
		RoleDetailItem,
		// Token: 0x040242B1 RID: 148145
		SelectedButton,
		// Token: 0x040242B2 RID: 148146
		NoneRoleItem,
		// Token: 0x040242B3 RID: 148147
		NiagaraBuff
	}
}
