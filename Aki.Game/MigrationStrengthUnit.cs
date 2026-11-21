using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001412 RID: 5138
[NullableContext(1)]
[Nullable(0)]
public class MigrationStrengthUnit : HudUnitBase
{
	// Token: 0x0600CC2B RID: 52267 RVA: 0x003CB869 File Offset: 0x003C9A69
	public void InitData(int strengthLineCount)
	{
		this.StrengthItemCount = strengthLineCount;
		this.RefreshSingleStrengthItemRotation(this.StrengthItemCount);
		this.RefreshSingleStrengthItemVisible(this.StrengthItemCount);
	}

	// Token: 0x0600CC2C RID: 52268 RVA: 0x003CB88C File Offset: 0x003C9A8C
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

	// Token: 0x0600CC2D RID: 52269 RVA: 0x003CBA24 File Offset: 0x003C9C24
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

	// Token: 0x0600CC2E RID: 52270 RVA: 0x003CBA6F File Offset: 0x003C9C6F
	protected override void OnAfterShow()
	{
		this.PlayStartAnim();
	}

	// Token: 0x0600CC2F RID: 52271 RVA: 0x003CBA78 File Offset: 0x003C9C78
	protected override UniTask OnBeforeHideAsync()
	{
		MigrationStrengthUnit.<OnBeforeHideAsync>d__34 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<MigrationStrengthUnit.<OnBeforeHideAsync>d__34>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC30 RID: 52272 RVA: 0x003CBABB File Offset: 0x003C9CBB
	protected override void OnBeforeDestroy()
	{
		this.RefreshEntity(null);
		this.DestroyCloseAnimTimer();
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CC31 RID: 52273 RVA: 0x003CBAD0 File Offset: 0x003C9CD0
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

	// Token: 0x0600CC32 RID: 52274 RVA: 0x003CBB7C File Offset: 0x003C9D7C
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

	// Token: 0x0600CC33 RID: 52275 RVA: 0x003CBBE4 File Offset: 0x003C9DE4
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

	// Token: 0x0600CC34 RID: 52276 RVA: 0x003CBC2C File Offset: 0x003C9E2C
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

	// Token: 0x0600CC35 RID: 52277 RVA: 0x003CBCB2 File Offset: 0x003C9EB2
	private UUIItem GetSingleStrengthItem(int index)
	{
		return this.StrengthSingleLineActorList[index];
	}

	// Token: 0x0600CC36 RID: 52278 RVA: 0x003CBCC0 File Offset: 0x003C9EC0
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

	// Token: 0x0600CC37 RID: 52279 RVA: 0x003CBCF8 File Offset: 0x003C9EF8
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

	// Token: 0x0600CC38 RID: 52280 RVA: 0x003CBD8C File Offset: 0x003C9F8C
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

	// Token: 0x0600CC39 RID: 52281 RVA: 0x003CBE20 File Offset: 0x003CA020
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

	// Token: 0x0600CC3A RID: 52282 RVA: 0x003CBF98 File Offset: 0x003CA198
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

	// Token: 0x0600CC3B RID: 52283 RVA: 0x003CC0E4 File Offset: 0x003CA2E4
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

	// Token: 0x0600CC3C RID: 52284 RVA: 0x003CC146 File Offset: 0x003CA346
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.InitTweenAnim(9);
		base.InitTweenAnim(10);
	}

	// Token: 0x0600CC3D RID: 52285 RVA: 0x003CC166 File Offset: 0x003CA366
	private void PlayStartAnim()
	{
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600CC3E RID: 52286 RVA: 0x003CC170 File Offset: 0x003CA370
	private UniTask PlayCloseAnim()
	{
		MigrationStrengthUnit.<PlayCloseAnim>d__49 <PlayCloseAnim>d__;
		<PlayCloseAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseAnim>d__.<>4__this = this;
		<PlayCloseAnim>d__.<>1__state = -1;
		<PlayCloseAnim>d__.<>t__builder.Start<MigrationStrengthUnit.<PlayCloseAnim>d__49>(ref <PlayCloseAnim>d__);
		return <PlayCloseAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC3F RID: 52287 RVA: 0x003CC1B3 File Offset: 0x003CA3B3
	private void DestroyCloseAnimTimer()
	{
		if (this.CloseAnimTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseAnimTimer);
			this.CloseAnimTimer = null;
		}
	}

	// Token: 0x0600CC40 RID: 52288 RVA: 0x003CC1D5 File Offset: 0x003CA3D5
	private void PlayRecoverInAnim()
	{
		base.StopTweenAnim(10);
		base.PlayTweenAnim(9);
	}

	// Token: 0x0600CC41 RID: 52289 RVA: 0x003CC1E7 File Offset: 0x003CA3E7
	private void PlayRecoverOutAnim()
	{
		base.StopTweenAnim(9);
		base.PlayTweenAnim(10);
	}

	// Token: 0x040073E6 RID: 29670
	private const float NORMAL_PERCENT = 0.2f;

	// Token: 0x040073E7 RID: 29671
	private const int PRELOAD_SINGLE_STRENGTH_ITEM_COUNT = 4;

	// Token: 0x040073E8 RID: 29672
	private const float MAX_DELTA_TIME = 200f;

	// Token: 0x040073E9 RID: 29673
	private const float MIN_DELTA_OFFSET = 0.5f;

	// Token: 0x040073EA RID: 29674
	private const float RECOVER_ANIM_TIME = 250f;

	// Token: 0x040073EB RID: 29675
	private const float RECOVER_STAY_TIME = 1400f;

	// Token: 0x040073EC RID: 29676
	private const float CLOSE_ANIM_TIME = 250f;

	// Token: 0x040073ED RID: 29677
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040073EE RID: 29678
	private readonly List<UUIItem> StrengthSingleLineActorList = new List<UUIItem>();

	// Token: 0x040073EF RID: 29679
	private readonly List<UUISprite> StrengthSingleLineSpriteList = new List<UUISprite>();

	// Token: 0x040073F0 RID: 29680
	private FRotator RotationCache = new FRotator(0f, 0f, 0f);

	// Token: 0x040073F1 RID: 29681
	[StaticVariableRuleIgnore]
	private static readonly FColor[] BarColor = new FColor[]
	{
		FColor.FromHex("#3db9cb"),
		FColor.FromHex("#cb3d55")
	};

	// Token: 0x040073F2 RID: 29682
	[StaticVariableRuleIgnore]
	private static readonly FColor[] LineColor = new FColor[]
	{
		FColor.FromHex("#234063"),
		FColor.FromHex("#633323")
	};

	// Token: 0x040073F3 RID: 29683
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x040073F4 RID: 29684
	[Nullable(2)]
	public CharacterActorComponent ActorComponent;

	// Token: 0x040073F5 RID: 29685
	private float TargetStrengthPercent = -1f;

	// Token: 0x040073F6 RID: 29686
	private float CurStrengthPercent;

	// Token: 0x040073F7 RID: 29687
	private bool IsRecover;

	// Token: 0x040073F8 RID: 29688
	private int RecoverAnimState;

	// Token: 0x040073F9 RID: 29689
	private float RecoverAnimStayTime;

	// Token: 0x040073FA RID: 29690
	private float RecoverPercentAnimSpeed;

	// Token: 0x040073FB RID: 29691
	private float RecoverBottomLimitPercent;

	// Token: 0x040073FC RID: 29692
	private int StrengthItemCount = 1;

	// Token: 0x040073FD RID: 29693
	private bool IsNormalState;

	// Token: 0x040073FE RID: 29694
	private float OffsetX;

	// Token: 0x040073FF RID: 29695
	private float OffsetY;

	// Token: 0x04007400 RID: 29696
	private float SpeedX;

	// Token: 0x04007401 RID: 29697
	private float SpeedY;

	// Token: 0x04007402 RID: 29698
	[Nullable(2)]
	private TimerHandle CloseAnimTimer;

	// Token: 0x020076D0 RID: 30416
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026979 RID: 158073
		BgTextureNormal,
		// Token: 0x0402697A RID: 158074
		BgTextureLow,
		// Token: 0x0402697B RID: 158075
		EffectTexture,
		// Token: 0x0402697C RID: 158076
		BarTexture,
		// Token: 0x0402697D RID: 158077
		StrengthLineItem,
		// Token: 0x0402697E RID: 158078
		StrengthSingleLineItem,
		// Token: 0x0402697F RID: 158079
		LightTexture,
		// Token: 0x04026980 RID: 158080
		AnimStart,
		// Token: 0x04026981 RID: 158081
		AnimClose,
		// Token: 0x04026982 RID: 158082
		AnimRecoverIn,
		// Token: 0x04026983 RID: 158083
		AnimRecoverOut
	}
}
