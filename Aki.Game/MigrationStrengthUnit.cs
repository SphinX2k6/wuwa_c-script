using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F50 RID: 8016
[NullableContext(1)]
[Nullable(0)]
public class MigrationStrengthUnit : HudUnitBase
{
	// Token: 0x0600F80C RID: 63500 RVA: 0x003BFD7D File Offset: 0x003BDF7D
	public void InitData(int strengthLineCount)
	{
		this.StrengthItemCount = strengthLineCount;
		this.RefreshSingleStrengthItemRotation(this.StrengthItemCount);
		this.RefreshSingleStrengthItemVisible(this.StrengthItemCount);
	}

	// Token: 0x0600F80D RID: 63501 RVA: 0x003BFDA0 File Offset: 0x003BDFA0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F80E RID: 63502 RVA: 0x003BFF38 File Offset: 0x003BE138
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		for (int i = 0; i < 4; i++)
		{
			this.AddSingleStrengthItem(i == 0);
		}
		base.GetTexture(2).SetUIActive(false);
		this.SetNormal(true);
		this.InitAllTweenAnim();
	}

	// Token: 0x0600F80F RID: 63503 RVA: 0x003BFF83 File Offset: 0x003BE183
	protected override void OnAfterShow()
	{
		this.PlayStartAnim();
	}

	// Token: 0x0600F810 RID: 63504 RVA: 0x003BFF8C File Offset: 0x003BE18C
	protected override UniTask OnBeforeHideAsync()
	{
		MigrationStrengthUnit.<OnBeforeHideAsync>d__34 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MigrationStrengthUnit.<OnBeforeHideAsync>d__34>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F811 RID: 63505 RVA: 0x003BFFCF File Offset: 0x003BE1CF
	protected override void OnBeforeDestroy()
	{
		this.RefreshEntity(null);
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F812 RID: 63506 RVA: 0x003BFFE4 File Offset: 0x003BE1E4
	public void SetNormal(bool bNormal)
	{
		if (this.IsNormalState == bNormal)
		{
			return;
		}
		this.IsNormalState = bNormal;
		base.GetTexture(0).SetUIActive(bNormal);
		base.GetTexture(1).SetUIActive(!bNormal);
		int num = (!this.IsNormalState) ? 1 : 0;
		base.GetTexture(3).SetColor(MigrationStrengthUnit.BarColor[num]);
		foreach (UUISprite uuisprite in this.StrengthSingleLineSpriteList)
		{
			uuisprite.SetColor(MigrationStrengthUnit.LineColor[num]);
		}
	}

	// Token: 0x0600F813 RID: 63507 RVA: 0x003C0090 File Offset: 0x003BE290
	private void RefreshSingleStrengthItemRotation(int count)
	{
		float num = 360f / (float)count;
		float num2 = 0f;
		for (int i = 0; i < count; i++)
		{
			UUIItem uuiitem = (i < this.StrengthSingleLineActorList.Count) ? this.GetSingleStrengthItem(i) : null;
			if (uuiitem == null)
			{
				uuiitem = this.AddSingleStrengthItem(false);
			}
			this.RotationCache.Yaw = num2;
			uuiitem.SetUIRelativeRotation(this.RotationCache);
			num2 += num;
		}
	}

	// Token: 0x0600F814 RID: 63508 RVA: 0x003C00F8 File Offset: 0x003BE2F8
	private void RefreshSingleStrengthItemVisible(int count)
	{
		for (int i = 0; i < this.StrengthSingleLineActorList.Count; i++)
		{
			UUIItem uuiitem = this.StrengthSingleLineActorList[i];
			bool flag = i < count;
			if (uuiitem.IsUIActiveSelf() != flag)
			{
				uuiitem.SetUIActive(flag);
			}
		}
	}

	// Token: 0x0600F815 RID: 63509 RVA: 0x003C0140 File Offset: 0x003BE340
	private UUIItem AddSingleStrengthItem(bool isFirst = false)
	{
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(5);
		UUIItem uuiitem;
		if (isFirst)
		{
			uuiitem = item2;
		}
		else
		{
			uuiitem = (LguiUtil.Instance.DuplicateActor(item2.GetOwner(), item).GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		}
		UUISprite item3 = uuiitem.GetAttachUIChild(0).GetOwner().GetComponentByClass(UUISprite.StaticClass()) as UUISprite;
		this.StrengthSingleLineActorList.Add(uuiitem);
		this.StrengthSingleLineSpriteList.Add(item3);
		return uuiitem;
	}

	// Token: 0x0600F816 RID: 63510 RVA: 0x003C01C6 File Offset: 0x003BE3C6
	private UUIItem GetSingleStrengthItem(int index)
	{
		return this.StrengthSingleLineActorList[index];
	}

	// Token: 0x0600F817 RID: 63511 RVA: 0x003C01D4 File Offset: 0x003BE3D4
	[NullableContext(2)]
	public void RefreshEntity(BattleUiRoleData roleData)
	{
		if (roleData == null)
		{
			this.EntityHandle = null;
			this.ActorComponent = null;
			return;
		}
		this.EntityHandle = roleData.EntityHandle;
		this.ActorComponent = roleData.EntityHandle.Entity.GetComponent<CharacterActorComponent>();
	}

	// Token: 0x0600F818 RID: 63512 RVA: 0x003C020C File Offset: 0x003BE40C
	public void SetStrengthPercent(float strength, float maxStrength)
	{
		float num = (maxStrength <= 0f) ? 0f : (strength / maxStrength);
		if (this.TargetStrengthPercent == num)
		{
			return;
		}
		if (this.CurStrengthPercent < num && this.TargetStrengthPercent != -1f)
		{
			this.RecoverPercentAnimSpeed = (num - this.CurStrengthPercent) / 250f;
		}
		else
		{
			this.CurStrengthPercent = num;
			this.RecoverPercentAnimSpeed = 0f;
			base.GetTexture(3).SetFillAmount(this.CurStrengthPercent);
		}
		this.TargetStrengthPercent = num;
		this.SetNormal(num >= 0.2f);
	}

	// Token: 0x0600F819 RID: 63513 RVA: 0x003C02A0 File Offset: 0x003BE4A0
	public void SetRecoverState(bool isRecover)
	{
		if (this.IsRecover == isRecover)
		{
			return;
		}
		this.IsRecover = isRecover;
		UUITexture texture = base.GetTexture(2);
		if (isRecover)
		{
			this.RecoverAnimState = 1;
			this.PlayRecoverInAnim();
			this.RecoverBottomLimitPercent = this.CurStrengthPercent;
			this.RotationCache.Yaw = 360f * this.RecoverBottomLimitPercent;
			texture.SetUIRelativeRotation(this.RotationCache);
			base.GetTexture(6).SetUIRelativeRotation(this.RotationCache);
			texture.SetUIActive(true);
			return;
		}
		this.RecoverAnimState = 0;
		this.PlayRecoverOutAnim();
		texture.SetUIActive(false);
	}

	// Token: 0x0600F81A RID: 63514 RVA: 0x003C0334 File Offset: 0x003BE534
	public void TickRecoverAnim(float delta)
	{
		if (this.TargetStrengthPercent > this.CurStrengthPercent)
		{
			this.CurStrengthPercent += delta * this.RecoverPercentAnimSpeed;
			this.CurStrengthPercent = Math.Min(this.CurStrengthPercent, this.TargetStrengthPercent);
			base.GetTexture(3).SetFillAmount(this.CurStrengthPercent);
		}
		if (this.RecoverAnimState == 1)
		{
			float fillAmount = this.CurStrengthPercent - this.RecoverBottomLimitPercent;
			base.GetTexture(6).SetFillAmount(fillAmount);
			base.GetTexture(2).SetFillAmount(fillAmount);
			if (this.CurStrengthPercent == this.TargetStrengthPercent)
			{
				this.RecoverAnimState = 2;
				this.RecoverAnimStayTime = 1400f;
				return;
			}
		}
		else if (this.RecoverAnimState == 2)
		{
			this.RecoverAnimStayTime -= delta;
			if (this.RecoverAnimStayTime <= 0f)
			{
				this.RecoverAnimState = 3;
				return;
			}
		}
		else if (this.RecoverAnimState == 3)
		{
			this.RecoverBottomLimitPercent += delta * this.RecoverPercentAnimSpeed;
			if (this.RecoverBottomLimitPercent >= this.CurStrengthPercent)
			{
				this.RecoverBottomLimitPercent = this.CurStrengthPercent;
				this.RecoverAnimState = 0;
			}
			this.RotationCache.Yaw = 360f * this.RecoverBottomLimitPercent;
			float fillAmount2 = this.CurStrengthPercent - this.RecoverBottomLimitPercent;
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(6);
			texture.SetUIRelativeRotation(this.RotationCache);
			texture2.SetUIRelativeRotation(this.RotationCache);
			texture.SetFillAmount(fillAmount2);
			texture2.SetFillAmount(fillAmount2);
		}
	}

	// Token: 0x0600F81B RID: 63515 RVA: 0x003C04AC File Offset: 0x003BE6AC
	public void RefreshTargetPosition(float delta)
	{
		if (!base.GetActive())
		{
			return;
		}
		if (this.ActorComponent == null)
		{
			return;
		}
		TsBaseCharacter actor = this.ActorComponent.Actor;
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		FVectorDouble actorLocation = this.ActorComponent.ActorLocation;
		if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, this.ScreenPos))
		{
			return;
		}
		float num = (float)this.ScreenPos.X;
		float num2 = (float)this.ScreenPos.Y;
		if (this.OffsetX == 0f && this.OffsetY == 0f)
		{
			this.OffsetX = num;
			this.OffsetY = num2;
			base.SetAnchorOffset(this.OffsetX, this.OffsetY);
			return;
		}
		this.SpeedX = this.GetSpeed(delta, num, this.OffsetX, this.SpeedX);
		this.SpeedY = this.GetSpeed(delta, num2, this.OffsetY, this.SpeedY);
		float num3 = this.SpeedX * delta;
		float num4 = this.SpeedY * delta;
		if (num3 < 0.5f && num3 > -0.5f && num4 < 0.5f && num4 > -0.5f)
		{
			return;
		}
		this.OffsetX += num3;
		this.OffsetY += num4;
		base.SetAnchorOffset(this.OffsetX, this.OffsetY);
	}

	// Token: 0x0600F81C RID: 63516 RVA: 0x003C05F8 File Offset: 0x003BE7F8
	private float GetSpeed(float delta, float target, float cur, float lastSpeed)
	{
		float num = target - cur;
		bool flag = false;
		if (num < 0f)
		{
			num = -num;
			flag = true;
		}
		if (num < 1f)
		{
			return 0f;
		}
		float num2;
		if (delta >= 200f)
		{
			num2 = num / delta;
		}
		else
		{
			num2 = num / 200f;
		}
		if (flag)
		{
			num2 = -num2;
		}
		return MathUtils.Instance.Lerp(lastSpeed, num2, 0.5f);
	}

	// Token: 0x0600F81D RID: 63517 RVA: 0x003C065A File Offset: 0x003BE85A
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.InitTweenAnim(9);
		base.InitTweenAnim(10);
	}

	// Token: 0x0600F81E RID: 63518 RVA: 0x003C067A File Offset: 0x003BE87A
	private void PlayStartAnim()
	{
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600F81F RID: 63519 RVA: 0x003C0684 File Offset: 0x003BE884
	private UniTask PlayCloseAnim()
	{
		MigrationStrengthUnit.<PlayCloseAnim>d__49 <PlayCloseAnim>d__;
		<PlayCloseAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseAnim>d__.<>4__this = this;
		<PlayCloseAnim>d__.<>1__state = -1;
		<PlayCloseAnim>d__.<>t__builder.Start<MigrationStrengthUnit.<PlayCloseAnim>d__49>(ref <PlayCloseAnim>d__);
		return <PlayCloseAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600F820 RID: 63520 RVA: 0x003C06C7 File Offset: 0x003BE8C7
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600F821 RID: 63521 RVA: 0x003C06E9 File Offset: 0x003BE8E9
	private void PlayRecoverInAnim()
	{
		base.StopTweenAnim(10);
		base.PlayTweenAnim(9);
	}

	// Token: 0x0600F822 RID: 63522 RVA: 0x003C06FB File Offset: 0x003BE8FB
	private void PlayRecoverOutAnim()
	{
		base.StopTweenAnim(9);
		base.PlayTweenAnim(10);
	}

	// Token: 0x04007305 RID: 29445
	private const float NORMAL_PERCENT = 0.2f;

	// Token: 0x04007306 RID: 29446
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 4;

	// Token: 0x04007307 RID: 29447
	private const float MAX_DELTA_TIME = 200f;

	// Token: 0x04007308 RID: 29448
	private const float MIN_DELTA_OFFSET = 0.5f;

	// Token: 0x04007309 RID: 29449
	private const float RECOVER_ANIM_TIME = 250f;

	// Token: 0x0400730A RID: 29450
	private const float RECOVER_STAY_TIME = 1400f;

	// Token: 0x0400730B RID: 29451
	private const float CLOSE_ANIM_TIME = 250f;

	// Token: 0x0400730C RID: 29452
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x0400730D RID: 29453
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x0400730E RID: 29454
	private readonly List<UUISprite> StrengthSingleLineSpriteList = new List<UUISprite>();

	// Token: 0x0400730F RID: 29455
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x04007310 RID: 29456
	[StaticVariableRuleIgnore]
	private static readonly FColor[] BarColor = new FColor[]
	{
		FColor.FromHex("#3db9cb"),
		FColor.FromHex("#cb3d55")
	};

	// Token: 0x04007311 RID: 29457
	[StaticVariableRuleIgnore]
	private static readonly FColor[] LineColor = new FColor[]
	{
		FColor.FromHex("#234063"),
		FColor.FromHex("#633323")
	};

	// Token: 0x04007312 RID: 29458
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x04007313 RID: 29459
	[Nullable(2)]
	public CharacterActorComponent ActorComponent;

	// Token: 0x04007314 RID: 29460
	private float TargetStrengthPercent = -1f;

	// Token: 0x04007315 RID: 29461
	private float CurStrengthPercent;

	// Token: 0x04007316 RID: 29462
	private bool IsRecover;

	// Token: 0x04007317 RID: 29463
	private int RecoverAnimState;

	// Token: 0x04007318 RID: 29464
	private float RecoverAnimStayTime;

	// Token: 0x04007319 RID: 29465
	private float RecoverPercentAnimSpeed;

	// Token: 0x0400731A RID: 29466
	private float RecoverBottomLimitPercent;

	// Token: 0x0400731B RID: 29467
	private int StrengthItemCount = 1;

	// Token: 0x0400731C RID: 29468
	private bool IsNormalState;

	// Token: 0x0400731D RID: 29469
	private float OffsetX;

	// Token: 0x0400731E RID: 29470
	private float OffsetY;

	// Token: 0x0400731F RID: 29471
	private float SpeedX;

	// Token: 0x04007320 RID: 29472
	private float SpeedY;

	// Token: 0x04007321 RID: 29473
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x0200854B RID: 34123
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B655 RID: 177749
		BgTextureNormal,
		// Token: 0x0402B656 RID: 177750
		BgTextureLow,
		// Token: 0x0402B657 RID: 177751
		EffectTexture,
		// Token: 0x0402B658 RID: 177752
		BarTexture,
		// Token: 0x0402B659 RID: 177753
		StrengthLineItem,
		// Token: 0x0402B65A RID: 177754
		StrengthSingleLineItem,
		// Token: 0x0402B65B RID: 177755
		LightTexture,
		// Token: 0x0402B65C RID: 177756
		AnimStart,
		// Token: 0x0402B65D RID: 177757
		AnimClose,
		// Token: 0x0402B65E RID: 177758
		AnimRecoverIn,
		// Token: 0x0402B65F RID: 177759
		AnimRecoverOut
	}
}
