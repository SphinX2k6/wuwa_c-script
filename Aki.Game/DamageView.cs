using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EC9 RID: 3785
[NullableContext(1)]
[Nullable(0)]
public class DamageView : UiPanelBase
{
	// Token: 0x06009761 RID: 38753 RVA: 0x002CDE30 File Offset: 0x002CC030
	public void Init()
	{
		AActor damageView = BattleUiControl.Instance.Pool.GetDamageView();
		base.CreateByActor(damageView, null);
	}

	// Token: 0x06009762 RID: 38754 RVA: 0x002CDE58 File Offset: 0x002CC058
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUINiagara)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x06009763 RID: 38755 RVA: 0x002CDF7C File Offset: 0x002CC17C
	protected override void OnStart()
	{
		this.DamageNum = base.GetText(0);
		this.DamageText = base.GetText(2);
		this.FontSize = this.DamageNum.GetSize();
		this.TimeScale = 1f;
		this.CurTimeScale = 1f;
		if (Info.Instance.IsMobilePlatform())
		{
			this.RefreshFontSize();
		}
	}

	// Token: 0x06009764 RID: 38756 RVA: 0x002CDFDC File Offset: 0x002CC1DC
	public void RefreshFontSize()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			int num = (int)Math.Floor((double)(this.FontSize * 1.5f));
			this.DamageNum.SetFontSize((float)num);
			this.DamageText.SetFontSize((float)num);
			return;
		}
		this.DamageNum.SetFontSize(this.FontSize);
		this.DamageText.SetFontSize(this.FontSize);
	}

	// Token: 0x06009765 RID: 38757 RVA: 0x002CE046 File Offset: 0x002CC246
	protected override bool DestroyOverride()
	{
		BattleUiControl.Instance.Pool.RecycleDamageView(this.RootActor);
		return true;
	}

	// Token: 0x06009766 RID: 38758 RVA: 0x002CE060 File Offset: 0x002CC260
	public void InitializeData(float damage, global::Vector damageLocation, global::Vector baseLocation, DamageViewData damageViewData, bool bCritical = false, bool bCure = false, bool bOwnPlayerDamage = false, string damageText = "", int damageTextAreaId = 0, [Nullable(new byte[]
	{
		2,
		1
	})] List<DamageInfo> mergeDamageInfoList = null)
	{
		if (damageViewData == null)
		{
			return;
		}
		this.IsFollowPlayer = bOwnPlayerDamage;
		this.DamageViewData = damageViewData;
		this.DamageLocation.FromUeVector(damageLocation);
		this.BaseLocation.FromUeVector(baseLocation);
		this.DamageLocationUe = this.DamageLocation.ToUeVector(false);
		DamageTextArea? damageTextAreaById = DamageUiManager.Instance.GetDamageTextAreaById(damageTextAreaId);
		APlayerController characterController = Global.CharacterController;
		FVectorDouble fvectorDouble = this.DamageLocation.ToUeVector(false);
		FVector2D fvector2D = ULGUIBPLibrary.ConvertWorldPosToLGUIPos(characterController, fvectorDouble);
		float num;
		float num2;
		float num3;
		float num4;
		if (damageTextAreaById != null)
		{
			num = (float)damageTextAreaById.Value.MinDeviationX;
			num2 = (float)damageTextAreaById.Value.MaxDeviationX;
			num3 = (float)damageTextAreaById.Value.MinDeviationY;
			num4 = (float)damageTextAreaById.Value.MaxDeviationY;
		}
		else
		{
			num = damageViewData.MinRandomOffsetX;
			num2 = damageViewData.MaxRandomOffsetX;
			num3 = damageViewData.MinRandomOffsetY;
			num4 = damageViewData.MaxRandomOffsetY;
		}
		if (bCritical)
		{
			num *= 1f;
			num3 *= 1f;
			num2 *= 1f;
			num4 *= 1f;
		}
		this.RandomUiPosition.X = (double)MathUtils.Instance.GetRandomFloatNumber(num, num2);
		this.RandomUiPosition.Y = (double)MathUtils.Instance.GetRandomFloatNumber(num3, num4);
		this.SetDamageLocation(fvector2D.X + (float)this.RandomUiPosition.X, fvector2D.Y + (float)this.RandomUiPosition.Y);
		this.TextList.Clear();
		if (mergeDamageInfoList != null)
		{
			if (StringUtils.IsEmpty(damageText))
			{
				string text;
				if (!bCure)
				{
					text = damage.ToString();
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("+");
					defaultInterpolatedStringHandler.AppendFormatted<float>(damage);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				string item = text;
				this.TextList.Add(item);
			}
			float num5 = 0f;
			int num6 = 1;
			foreach (DamageInfo damageInfo in mergeDamageInfoList)
			{
				if (StringUtils.IsEmpty(damageText))
				{
					damageInfo.Damage = (float)Math.Floor((double)Math.Abs(damageInfo.Damage));
					num6++;
					if (num6 < 10)
					{
						List<string> textList = this.TextList;
						string item2;
						if (!damageInfo.IsCure)
						{
							item2 = damageInfo.Damage.ToString();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
							defaultInterpolatedStringHandler.AppendLiteral("+");
							defaultInterpolatedStringHandler.AppendFormatted<float>(damageInfo.Damage);
							item2 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						textList.Add(item2);
					}
					else if (bCure)
					{
						num5 += damageInfo.Damage;
					}
					else
					{
						num5 -= damageInfo.Damage;
					}
				}
			}
			if (num5 > 0f)
			{
				List<string> textList2 = this.TextList;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<float>(num5);
				textList2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			else if (num5 < 0f)
			{
				List<string> textList3 = this.TextList;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<float>(Math.Abs(num5));
				textList3.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		if (this.TextList.Count > 0)
		{
			this.TextIndex = 0;
			this.PlayDamageViewAnim(bOwnPlayerDamage, false, false);
			this.RefreshCriticalNiagara(false);
			this.RefreshTextDisplay(this.TextList[0], false, false);
		}
		else
		{
			this.TextIndex = -1;
			bool flag = !StringUtils.IsEmpty(damageText);
			string text2 = this.FormatNumber(damage);
			string damageTextString = flag ? damageText : (bCure ? ("+" + text2) : text2.ToString());
			this.PlayDamageViewAnim(bOwnPlayerDamage, bCritical, flag);
			this.RefreshCriticalNiagara(bCritical);
			this.RefreshTextDisplay(damageTextString, bCritical, flag);
		}
		this.RefreshDepth();
		this.SetActive(true);
		this.DamageNum.SetAlpha(0f);
	}

	// Token: 0x06009767 RID: 38759 RVA: 0x002CE458 File Offset: 0x002CC658
	private string FormatNumber(float num)
	{
		return DamageUiManager.Instance.FormatDamageNumber(num);
	}

	// Token: 0x06009768 RID: 38760 RVA: 0x002CE465 File Offset: 0x002CC665
	public void ClearData()
	{
		this.DamageViewData = null;
		this.StopDamageViewAnim();
		this.SetActive(false);
		this.SetCriticalNiagaraVisible(false);
	}

	// Token: 0x06009769 RID: 38761 RVA: 0x002CE484 File Offset: 0x002CC684
	private void PlayDamageViewAnim(bool bOwnPlayerDamage, bool bCritical, bool bCustomText)
	{
		this.AnimEndTime = 1200f;
		string sequencePath = this.DamageViewData.GetSequencePath(bOwnPlayerDamage, bCritical, bCustomText);
		int name;
		if (!this.DamageAnimMap.TryGetValue(sequencePath, out name))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "缺少伤害数字动画";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sequencePath", sequencePath);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		TArray<UActorComponent> tarray = base.GetItem(name).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
		this.Animations = new List<ULGUIPlayTweenComponent>();
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			ULGUIPlayTweenComponent ulguiplayTweenComponent = tarray.Get(i) as ULGUIPlayTweenComponent;
			this.Animations.Add(ulguiplayTweenComponent);
			ulguiplayTweenComponent.Play();
		}
	}

	// Token: 0x0600976A RID: 38762 RVA: 0x002CE544 File Offset: 0x002CC744
	private void StopDamageViewAnim()
	{
		if (this.Animations == null)
		{
			return;
		}
		this.SetTimeScale(1f);
		foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.Animations)
		{
			if (ulguiplayTweenComponent != null && ulguiplayTweenComponent.IsValid())
			{
				ulguiplayTweenComponent.Stop();
			}
		}
		this.Animations = null;
	}

	// Token: 0x0600976B RID: 38763 RVA: 0x002CE5BC File Offset: 0x002CC7BC
	public void Tick(float delta)
	{
		if (this.RootItem == null)
		{
			return;
		}
		if (this.CriticalNiagara != null)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			uiNiagara.SetNiagaraSystem(this.CriticalNiagara);
			uiNiagara.ActivateSystem(true);
			this.CriticalNiagara = null;
		}
		if (this.TimeScale == 1f)
		{
			this.AnimEndTime -= delta;
		}
		else if (this.AnimEndTime > 700f)
		{
			this.AnimEndTime -= delta;
		}
		else
		{
			this.AnimEndTime -= delta * this.TimeScale;
			this.UpdateCurTimeScale(this.TimeScale);
		}
		if (this.AnimEndTime <= 0f)
		{
			DamageUiManager.Instance.RemoveDamageView(this);
			return;
		}
		if (this.TextIndex != -1)
		{
			int num = (int)Math.Floor((double)((1200f - this.AnimEndTime) / 100f));
			if (this.TextIndex != num)
			{
				this.TextIndex = num;
				if (this.TextList.Count > num)
				{
					this.DamageNum.SetText(this.TextList[num], true);
				}
			}
		}
		if (!this.IsFollowPlayer)
		{
			this.RefreshDamageLocation();
			return;
		}
		this.RefreshPlayerDamageLocation();
	}

	// Token: 0x0600976C RID: 38764 RVA: 0x002CE6DC File Offset: 0x002CC8DC
	private void UpdateCurTimeScale(float timeScale)
	{
		if (this.CurTimeScale == timeScale)
		{
			return;
		}
		this.CurTimeScale = timeScale;
		if (this.Animations == null)
		{
			return;
		}
		foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.Animations)
		{
			if (ulguiplayTweenComponent != null && ulguiplayTweenComponent.IsValid())
			{
				ULGUIPlayTween playTween = ulguiplayTweenComponent.GetPlayTween();
				ULTweener ultweener = (playTween != null) ? playTween.GetTweener() : null;
				if (ultweener != null)
				{
					ultweener.SetSpeed(this.CurTimeScale);
				}
			}
		}
		UUINiagara uiNiagara = base.GetUiNiagara(3);
		AActor aactor = (uiNiagara != null) ? uiNiagara.GetOwner() : null;
		if (aactor != null)
		{
			aactor.CustomTimeDilation = this.CurTimeScale;
		}
	}

	// Token: 0x0600976D RID: 38765 RVA: 0x002CE794 File Offset: 0x002CC994
	private void RefreshDamageLocation()
	{
		FVector2D fvector2D = ULGUIBPLibrary.ConvertWorldPosToLGUIPos(Global.CharacterController, this.DamageLocationUe);
		float x = fvector2D.X + (float)this.RandomUiPosition.X;
		float y = fvector2D.Y + (float)this.RandomUiPosition.Y;
		this.SetDamageLocation(x, y);
	}

	// Token: 0x0600976E RID: 38766 RVA: 0x002CE7E4 File Offset: 0x002CC9E4
	private void RefreshPlayerDamageLocation()
	{
		FVector2D fvector2D = ULGUIBPLibrary.ConvertWorldPosToLGUIPos(Global.CharacterController, this.DamageLocationUe);
		float x = fvector2D.X + (float)this.RandomUiPosition.X;
		float y = fvector2D.Y + (float)this.RandomUiPosition.Y;
		this.SetDamageLocation(x, y);
	}

	// Token: 0x0600976F RID: 38767 RVA: 0x002CE834 File Offset: 0x002CCA34
	private void RefreshDepth()
	{
		int hierarchyIndex = DamageUiManager.Instance.TotalDamageViewNum - 1;
		this.RootItem.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x06009770 RID: 38768 RVA: 0x002CE85C File Offset: 0x002CCA5C
	private void SetCriticalNiagara(string niagaraPath)
	{
		if (this.CriticalNiagaraPath == niagaraPath)
		{
			return;
		}
		UUINiagara criticalNiagara = base.GetUiNiagara(3);
		if (StringUtils.IsEmpty(niagaraPath))
		{
			this.CriticalNiagaraPath = null;
			criticalNiagara.DeactivateSystem();
			criticalNiagara.SetNiagaraSystem(null);
			return;
		}
		this.CriticalNiagaraPath = niagaraPath;
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(niagaraPath, delegate([Nullable(2)] UNiagaraSystem niagaraSystem, string _)
		{
			if (niagaraSystem == null || !niagaraSystem.IsValid())
			{
				return;
			}
			if (criticalNiagara == null)
			{
				return;
			}
			this.CriticalNiagara = niagaraSystem;
		}, 100, "js_undefined");
	}

	// Token: 0x06009771 RID: 38769 RVA: 0x002CE8E0 File Offset: 0x002CCAE0
	private void SetCriticalItemVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(4);
		if (item.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06009772 RID: 38770 RVA: 0x002CE908 File Offset: 0x002CCB08
	public void SetCriticalNiagaraVisible(bool bVisible)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(3);
		if (uiNiagara.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		uiNiagara.SetUIActive(bVisible);
	}

	// Token: 0x06009773 RID: 38771 RVA: 0x002CE930 File Offset: 0x002CCB30
	private void RefreshTextDisplay(string damageTextString, bool bCritical, bool bCustomText)
	{
		if (bCustomText)
		{
			this.SetDamageTextStyle(this.DamageNum, bCritical);
			if (this.DamageText.GetText() != damageTextString)
			{
				LguiUtil.Instance.SetLocalText(this.DamageText, damageTextString, Array.Empty<object>());
			}
			if (this.DamageNum.IsUIActiveSelf())
			{
				this.DamageNum.SetUIActive(false);
			}
			if (!this.DamageText.IsUIActiveSelf())
			{
				this.DamageText.SetUIActive(true);
				return;
			}
		}
		else
		{
			this.SetDamageTextStyle(this.DamageNum, bCritical);
			if (this.DamageNum.GetText() != damageTextString)
			{
				this.DamageNum.SetText(damageTextString, true);
			}
			if (!this.DamageNum.IsUIActiveSelf())
			{
				this.DamageNum.SetUIActive(true);
			}
			if (this.DamageText.IsUIActiveSelf())
			{
				this.DamageText.SetUIActive(false);
			}
		}
	}

	// Token: 0x06009774 RID: 38772 RVA: 0x002CEA08 File Offset: 0x002CCC08
	private void RefreshCriticalNiagara(bool bCritical)
	{
		if (bCritical)
		{
			this.SetCriticalItemVisible(true);
			this.SetCriticalNiagara(this.DamageViewData.GetCriticalNiagaraPath());
			return;
		}
		this.SetCriticalItemVisible(false);
	}

	// Token: 0x06009775 RID: 38773 RVA: 0x002CEA30 File Offset: 0x002CCC30
	private void SetDamageTextStyle(UUIText damageText, bool bCritical)
	{
		UUIEffectOutline uuieffectOutline = damageText.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
		FColor? fcolor = this.DamageViewData.GetTextColor();
		FColor? fcolor2 = this.DamageViewData.GetStrokeColor();
		if (bCritical)
		{
			fcolor = this.DamageViewData.GetCriticalTextColor();
			fcolor2 = this.DamageViewData.GetCriticalStrokeColor();
		}
		if (!(damageText.GetColor() == fcolor.Value))
		{
			damageText.SetColor(fcolor.Value);
		}
		if (!(uuieffectOutline.GetOutlineColor() == fcolor2.Value))
		{
			uuieffectOutline.SetOutlineColor(fcolor2.Value);
		}
	}

	// Token: 0x06009776 RID: 38774 RVA: 0x002CEACD File Offset: 0x002CCCCD
	private void SetDamageLocation(float x, float y)
	{
		this.RootItem.SetAnchorOffsetX(x);
		this.RootItem.SetAnchorOffsetY(y);
	}

	// Token: 0x06009777 RID: 38775 RVA: 0x002CEAE7 File Offset: 0x002CCCE7
	public void SetTimeScale(float timeScale)
	{
		this.TimeScale = timeScale;
		if (timeScale == 1f)
		{
			this.UpdateCurTimeScale(1f);
		}
	}

	// Token: 0x04005AFA RID: 23290
	private const float ANIM_TIME = 1200f;

	// Token: 0x04005AFB RID: 23291
	private const float ANIM_SCALE_TIME = 700f;

	// Token: 0x04005AFC RID: 23292
	private const float MOBLIE_FONT_SIZE_SCALE = 1.5f;

	// Token: 0x04005AFD RID: 23293
	private const float CRITICAL_OFFSET_SCALE = 1f;

	// Token: 0x04005AFE RID: 23294
	private const int MERGE_NUM = 10;

	// Token: 0x04005AFF RID: 23295
	private const float MERGE_PER_TEXT_TIME = 100f;

	// Token: 0x04005B00 RID: 23296
	private readonly Dictionary<string, int> DamageAnimMap = new Dictionary<string, int>
	{
		{
			"Ani_OwnDamageSequence",
			5
		},
		{
			"Ani_OwnCriticalDamageSequence",
			6
		},
		{
			"Ani_MonsterDamageSequence",
			7
		},
		{
			"Ani_MonsterCriticalDamageSequence",
			8
		},
		{
			"Ani_BuffSequence",
			9
		},
		{
			"Ani_SpecialDamage",
			10
		},
		{
			"Ani_SpecialCriticalDamage",
			11
		}
	};

	// Token: 0x04005B01 RID: 23297
	private readonly global::Vector DamageLocation = global::Vector.Create();

	// Token: 0x04005B02 RID: 23298
	private readonly global::Vector BaseLocation = global::Vector.Create();

	// Token: 0x04005B03 RID: 23299
	private FVectorDouble DamageLocationUe = FVectorDouble.ZeroVector;

	// Token: 0x04005B04 RID: 23300
	private readonly Vector2D RandomUiPosition = Vector2D.Create();

	// Token: 0x04005B05 RID: 23301
	[Nullable(2)]
	private UUIText DamageNum;

	// Token: 0x04005B06 RID: 23302
	[Nullable(2)]
	private UUIText DamageText;

	// Token: 0x04005B07 RID: 23303
	[Nullable(2)]
	private string CriticalNiagaraPath;

	// Token: 0x04005B08 RID: 23304
	[Nullable(2)]
	private UNiagaraSystem CriticalNiagara;

	// Token: 0x04005B09 RID: 23305
	[Nullable(2)]
	private DamageViewData DamageViewData;

	// Token: 0x04005B0A RID: 23306
	private readonly Stat StatInitializeDamageView = Stat.Create("[DamageView]InitializeDamageView", "", "");

	// Token: 0x04005B0B RID: 23307
	private float AnimEndTime;

	// Token: 0x04005B0C RID: 23308
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ULGUIPlayTweenComponent> Animations;

	// Token: 0x04005B0D RID: 23309
	private float FontSize;

	// Token: 0x04005B0E RID: 23310
	private float TimeScale = 1f;

	// Token: 0x04005B0F RID: 23311
	private float CurTimeScale = 1f;

	// Token: 0x04005B10 RID: 23312
	private readonly List<string> TextList = new List<string>();

	// Token: 0x04005B11 RID: 23313
	private int TextIndex = -1;

	// Token: 0x04005B12 RID: 23314
	private bool IsFollowPlayer;

	// Token: 0x020070D2 RID: 28882
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x04024C24 RID: 150564
		DamageNum,
		// Token: 0x04024C25 RID: 150565
		DamageBox,
		// Token: 0x04024C26 RID: 150566
		DamageText,
		// Token: 0x04024C27 RID: 150567
		CriticalNiagara,
		// Token: 0x04024C28 RID: 150568
		CriticalItem,
		// Token: 0x04024C29 RID: 150569
		AnimOwnDamage,
		// Token: 0x04024C2A RID: 150570
		AnimOwnCriticalDamage,
		// Token: 0x04024C2B RID: 150571
		AnimMonsterDamage,
		// Token: 0x04024C2C RID: 150572
		AnimMonsterCriticalDamage,
		// Token: 0x04024C2D RID: 150573
		AnimBuff,
		// Token: 0x04024C2E RID: 150574
		AnimSpecialDamage,
		// Token: 0x04024C2F RID: 150575
		AnimSpecialCriticalDamage
	}
}
