using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A0A RID: 6666
[NullableContext(1)]
[Nullable(0)]
public class DamageView : UiPanelBase
{
	// Token: 0x0600C351 RID: 50001 RVA: 0x002C2DC0 File Offset: 0x002C0FC0
	public void Init()
	{
		AActor damageView = BattleUiControl.Instance.Pool.GetDamageView();
		base.CreateByActor(damageView, null);
	}

	// Token: 0x0600C352 RID: 50002 RVA: 0x002C2DE8 File Offset: 0x002C0FE8
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

	// Token: 0x0600C353 RID: 50003 RVA: 0x002C2F0C File Offset: 0x002C110C
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

	// Token: 0x0600C354 RID: 50004 RVA: 0x002C2F6C File Offset: 0x002C116C
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

	// Token: 0x0600C355 RID: 50005 RVA: 0x002C2FD6 File Offset: 0x002C11D6
	protected override bool DestroyOverride()
	{
		BattleUiControl.Instance.Pool.RecycleDamageView(this.RootActor);
		return true;
	}

	// Token: 0x0600C356 RID: 50006 RVA: 0x002C2FF0 File Offset: 0x002C11F0
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

	// Token: 0x0600C357 RID: 50007 RVA: 0x002C33E8 File Offset: 0x002C15E8
	private string FormatNumber(float num)
	{
		return DamageUiManager.Instance.FormatDamageNumber(num);
	}

	// Token: 0x0600C358 RID: 50008 RVA: 0x002C33F5 File Offset: 0x002C15F5
	public void ClearData()
	{
		this.DamageViewData = null;
		this.StopDamageViewAnim();
		this.SetActive(false);
		this.SetCriticalNiagaraVisible(false);
	}

	// Token: 0x0600C359 RID: 50009 RVA: 0x002C3414 File Offset: 0x002C1614
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

	// Token: 0x0600C35A RID: 50010 RVA: 0x002C34D4 File Offset: 0x002C16D4
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

	// Token: 0x0600C35B RID: 50011 RVA: 0x002C354C File Offset: 0x002C174C
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

	// Token: 0x0600C35C RID: 50012 RVA: 0x002C366C File Offset: 0x002C186C
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

	// Token: 0x0600C35D RID: 50013 RVA: 0x002C3724 File Offset: 0x002C1924
	private void RefreshDamageLocation()
	{
		FVector2D fvector2D = ULGUIBPLibrary.ConvertWorldPosToLGUIPos(Global.CharacterController, this.DamageLocationUe);
		float x = fvector2D.X + (float)this.RandomUiPosition.X;
		float y = fvector2D.Y + (float)this.RandomUiPosition.Y;
		this.SetDamageLocation(x, y);
	}

	// Token: 0x0600C35E RID: 50014 RVA: 0x002C3774 File Offset: 0x002C1974
	private void RefreshPlayerDamageLocation()
	{
		FVector2D fvector2D = ULGUIBPLibrary.ConvertWorldPosToLGUIPos(Global.CharacterController, this.DamageLocationUe);
		float x = fvector2D.X + (float)this.RandomUiPosition.X;
		float y = fvector2D.Y + (float)this.RandomUiPosition.Y;
		this.SetDamageLocation(x, y);
	}

	// Token: 0x0600C35F RID: 50015 RVA: 0x002C37C4 File Offset: 0x002C19C4
	private void RefreshDepth()
	{
		int hierarchyIndex = DamageUiManager.Instance.TotalDamageViewNum - 1;
		this.RootItem.SetHierarchyIndex(hierarchyIndex);
	}

	// Token: 0x0600C360 RID: 50016 RVA: 0x002C37EC File Offset: 0x002C19EC
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

	// Token: 0x0600C361 RID: 50017 RVA: 0x002C3870 File Offset: 0x002C1A70
	private void SetCriticalItemVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(4);
		if (item.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600C362 RID: 50018 RVA: 0x002C3898 File Offset: 0x002C1A98
	public void SetCriticalNiagaraVisible(bool bVisible)
	{
		UUINiagara uiNiagara = base.GetUiNiagara(3);
		if (uiNiagara.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		uiNiagara.SetUIActive(bVisible);
	}

	// Token: 0x0600C363 RID: 50019 RVA: 0x002C38C0 File Offset: 0x002C1AC0
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

	// Token: 0x0600C364 RID: 50020 RVA: 0x002C3998 File Offset: 0x002C1B98
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

	// Token: 0x0600C365 RID: 50021 RVA: 0x002C39C0 File Offset: 0x002C1BC0
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

	// Token: 0x0600C366 RID: 50022 RVA: 0x002C3A5D File Offset: 0x002C1C5D
	private void SetDamageLocation(float x, float y)
	{
		this.RootItem.SetAnchorOffsetX(x);
		this.RootItem.SetAnchorOffsetY(y);
	}

	// Token: 0x0600C367 RID: 50023 RVA: 0x002C3A77 File Offset: 0x002C1C77
	public void SetTimeScale(float timeScale)
	{
		this.TimeScale = timeScale;
		if (timeScale == 1f)
		{
			this.UpdateCurTimeScale(1f);
		}
	}

	// Token: 0x04005A2B RID: 23083
	private const float ANIM_TIME = 1200f;

	// Token: 0x04005A2C RID: 23084
	private const float ANIM_SCALE_TIME = 700f;

	// Token: 0x04005A2D RID: 23085
	private const float MOBLIE_FONT_SIZE_SCALE = 1.5f;

	// Token: 0x04005A2E RID: 23086
	private const float CRITICAL_OFFSET_SCALE = 1f;

	// Token: 0x04005A2F RID: 23087
	private const int MERGE_NUM = 10;

	// Token: 0x04005A30 RID: 23088
	private const float MERGE_PER_TEXT_TIME = 100f;

	// Token: 0x04005A31 RID: 23089
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

	// Token: 0x04005A32 RID: 23090
	private readonly global::Vector DamageLocation = global::Vector.Create();

	// Token: 0x04005A33 RID: 23091
	private readonly global::Vector BaseLocation = global::Vector.Create();

	// Token: 0x04005A34 RID: 23092
	private FVectorDouble DamageLocationUe = FVectorDouble.ZeroVector;

	// Token: 0x04005A35 RID: 23093
	private readonly Vector2D RandomUiPosition = Vector2D.Create();

	// Token: 0x04005A36 RID: 23094
	[Nullable(2)]
	private UUIText DamageNum;

	// Token: 0x04005A37 RID: 23095
	[Nullable(2)]
	private UUIText DamageText;

	// Token: 0x04005A38 RID: 23096
	[Nullable(2)]
	private string CriticalNiagaraPath;

	// Token: 0x04005A39 RID: 23097
	[Nullable(2)]
	private UNiagaraSystem CriticalNiagara;

	// Token: 0x04005A3A RID: 23098
	[Nullable(2)]
	private DamageViewData DamageViewData;

	// Token: 0x04005A3B RID: 23099
	private readonly Stat StatInitializeDamageView = Stat.Create("[DamageView]InitializeDamageView", "", "");

	// Token: 0x04005A3C RID: 23100
	private float AnimEndTime;

	// Token: 0x04005A3D RID: 23101
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ULGUIPlayTweenComponent> Animations;

	// Token: 0x04005A3E RID: 23102
	private float FontSize;

	// Token: 0x04005A3F RID: 23103
	private float TimeScale = 1f;

	// Token: 0x04005A40 RID: 23104
	private float CurTimeScale = 1f;

	// Token: 0x04005A41 RID: 23105
	private readonly List<string> TextList = new List<string>();

	// Token: 0x04005A42 RID: 23106
	private int TextIndex = -1;

	// Token: 0x04005A43 RID: 23107
	private bool IsFollowPlayer;

	// Token: 0x02007F43 RID: 32579
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x040298E7 RID: 170215
		DamageNum,
		// Token: 0x040298E8 RID: 170216
		DamageBox,
		// Token: 0x040298E9 RID: 170217
		DamageText,
		// Token: 0x040298EA RID: 170218
		CriticalNiagara,
		// Token: 0x040298EB RID: 170219
		CriticalItem,
		// Token: 0x040298EC RID: 170220
		AnimOwnDamage,
		// Token: 0x040298ED RID: 170221
		AnimOwnCriticalDamage,
		// Token: 0x040298EE RID: 170222
		AnimMonsterDamage,
		// Token: 0x040298EF RID: 170223
		AnimMonsterCriticalDamage,
		// Token: 0x040298F0 RID: 170224
		AnimBuff,
		// Token: 0x040298F1 RID: 170225
		AnimSpecialDamage,
		// Token: 0x040298F2 RID: 170226
		AnimSpecialCriticalDamage
	}
}
