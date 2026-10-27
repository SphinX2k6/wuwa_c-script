using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4F RID: 8015
[NullableContext(2)]
[Nullable(0)]
public class ManipulateCursorUnit : HudUnitBase
{
	// Token: 0x0600F7F0 RID: 63472 RVA: 0x003BF534 File Offset: 0x003BD734
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIItem)));
		}
	}

	// Token: 0x0600F7F1 RID: 63473 RVA: 0x003BF738 File Offset: 0x003BD938
	protected override UniTask OnBeforeStartAsync()
	{
		ManipulateCursorUnit.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ManipulateCursorUnit.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F7F2 RID: 63474 RVA: 0x003BF77C File Offset: 0x003BD97C
	protected override void OnBeforeDestroy()
	{
		this.DestroyCloseTimer();
		if (!string.IsNullOrEmpty(this.IconPath) && this.DefaultIconSpriteData != null && this.IconSprite != null)
		{
			this.IconSprite.SetSprite(this.DefaultIconSpriteData, false);
		}
		this.IconPath = null;
		this.DefaultIconSpriteData = null;
		this.IconSprite = null;
		this.ThrowSprite = null;
		this.ArrowItem = null;
		if (this.KeyItem != null)
		{
			this.KeyItem.Destroy(null);
			this.KeyItem = null;
		}
		this.ProcessItem = null;
		this.ProcessSprite = null;
		this.CloseAnimCallback = null;
		if (this.LoadHandleId != 0)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
			this.LoadHandleId = 0;
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F7F3 RID: 63475 RVA: 0x003BF838 File Offset: 0x003BDA38
	[NullableContext(1)]
	public void Refresh(bool isInScreen, Vector2D position, bool isCastTarget)
	{
		this.UpdateProcess();
		this.RotatorCache.Yaw = (float)(Math.Atan2(position.Y, position.X) * 57.2957763671875 - 90.0);
		this.RotatorCache.Roll = 0f;
		this.RotatorCache.Pitch = 0f;
		bool flag = !isInScreen;
		if (this.ArrowItem.IsUIActiveInHierarchy() != flag)
		{
			this.ArrowItem.SetUIActive(flag);
		}
		if (flag)
		{
			this.ArrowItem.SetUIRelativeRotation(this.RotatorCache);
		}
		base.SetAnchorOffset((float)position.X, (float)position.Y);
		this.SetIsCastTarget(isCastTarget);
	}

	// Token: 0x0600F7F4 RID: 63476 RVA: 0x003BF8EC File Offset: 0x003BDAEC
	private void SetIsCastTarget(bool isCastTarget)
	{
		if (this.IsCastTarget == isCastTarget)
		{
			return;
		}
		this.IsCastTarget = isCastTarget;
		if (Info.Instance.OperationType != EOperationType.Desktop)
		{
			this.IconSprite.SetUIActive(!isCastTarget);
			this.ThrowSprite.SetUIActive(isCastTarget);
			return;
		}
		if (isCastTarget)
		{
			this.SetKeyAction("攻击");
			return;
		}
		this.SetKeyAction("幻象1");
	}

	// Token: 0x0600F7F5 RID: 63477 RVA: 0x003BF950 File Offset: 0x003BDB50
	public void SetIconPath(string iconPath)
	{
		if (this.IconSprite == null)
		{
			return;
		}
		if (this.IconPath == iconPath)
		{
			return;
		}
		if (this.IconPath == null && this.DefaultIconSpriteData == null)
		{
			this.DefaultIconSpriteData = this.IconSprite.GetSprite();
		}
		this.IconPath = iconPath;
		if (this.LoadHandleId != 0)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
			this.LoadHandleId = 0;
		}
		if (iconPath == null)
		{
			this.IconSprite.SetSprite(this.DefaultIconSpriteData, false);
			this.IconSprite.SetUIActive(true);
			return;
		}
		this.IconSprite.SetUIActive(false);
		this.LoadHandleId = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(iconPath, delegate([Nullable(2)] ULGUISpriteData_BaseObject spriteData, string _)
		{
			if (this.IconSprite == null || this.IconPath != iconPath || spriteData == null)
			{
				return;
			}
			this.IconSprite.SetSprite(spriteData, false);
			this.IconSprite.SetUIActive(true);
		}, ResourceSystem.EResourceLoadPriority.BattleUi, this.MemoryTag);
	}

	// Token: 0x0600F7F6 RID: 63478 RVA: 0x003BFA37 File Offset: 0x003BDC37
	[NullableContext(1)]
	public void SetKeyAction(string actionName)
	{
		CombineKeyItem keyItem = this.KeyItem;
		if (keyItem == null)
		{
			return;
		}
		keyItem.RefreshAction(actionName);
	}

	// Token: 0x0600F7F7 RID: 63479 RVA: 0x003BFA4C File Offset: 0x003BDC4C
	public void StartProcess(float totalSeconds)
	{
		UUIItem processItem = this.ProcessItem;
		if (processItem != null)
		{
			processItem.SetUIActive(true);
		}
		this.SetProcess(0f);
		if (totalSeconds > 0f)
		{
			this.ProcessSpeed = 1f / (totalSeconds * (float)TimeUtil.Instance.InverseMillisecond);
		}
		else
		{
			this.ProcessSpeed = 0f;
		}
		this.StartProcessTime = Time.Instance.WorldTime;
	}

	// Token: 0x0600F7F8 RID: 63480 RVA: 0x003BFAB4 File Offset: 0x003BDCB4
	public void EndProcess(bool resetProcess)
	{
		this.StopProcessAnim();
		this.ProcessSpeed = 0f;
		if (resetProcess)
		{
			this.SetProcess(0f);
		}
	}

	// Token: 0x0600F7F9 RID: 63481 RVA: 0x003BFAD8 File Offset: 0x003BDCD8
	private void UpdateProcess()
	{
		if (this.ProcessSpeed <= 0f)
		{
			return;
		}
		float process = MathF.Min((float)((Time.Instance.WorldTime - this.StartProcessTime) * (double)this.ProcessSpeed), 1f);
		this.SetProcess(process);
	}

	// Token: 0x0600F7FA RID: 63482 RVA: 0x003BFB1F File Offset: 0x003BDD1F
	private void SetProcess(float percent)
	{
		UUISprite processSprite = this.ProcessSprite;
		if (processSprite == null)
		{
			return;
		}
		processSprite.SetFillAmount(percent);
	}

	// Token: 0x0600F7FB RID: 63483 RVA: 0x003BFB32 File Offset: 0x003BDD32
	public void PlayActivateEffect()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(6);
		uiNiagara.SetUIActive(true);
		uiNiagara.ActivateSystem(true);
	}

	// Token: 0x0600F7FC RID: 63484 RVA: 0x003BFB48 File Offset: 0x003BDD48
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.InitTweenAnim(9);
		base.InitTweenAnim(10);
		base.InitTweenAnim(12);
	}

	// Token: 0x0600F7FD RID: 63485 RVA: 0x003BFB70 File Offset: 0x003BDD70
	public void Appear()
	{
		this.IsActive = true;
		this.DestroyCloseTimer();
		if (base.InAsyncLoading())
		{
			return;
		}
		UUISprite iconSprite = this.IconSprite;
		if (iconSprite != null)
		{
			iconSprite.SetAlpha(1f);
		}
		UUISprite throwSprite = this.ThrowSprite;
		if (throwSprite != null)
		{
			throwSprite.SetAlpha(1f);
		}
		UUIItem arrowItem = this.ArrowItem;
		if (arrowItem == null)
		{
			return;
		}
		arrowItem.SetAlpha(1f);
	}

	// Token: 0x0600F7FE RID: 63486 RVA: 0x003BFBD4 File Offset: 0x003BDDD4
	public void PlayStartAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600F7FF RID: 63487 RVA: 0x003BFBE6 File Offset: 0x003BDDE6
	public void PlayCompleteAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(9);
	}

	// Token: 0x0600F800 RID: 63488 RVA: 0x003BFBF9 File Offset: 0x003BDDF9
	public void PlayInterruptedAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(10);
	}

	// Token: 0x0600F801 RID: 63489 RVA: 0x003BFC0C File Offset: 0x003BDE0C
	public void PlayProcessAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(8);
	}

	// Token: 0x0600F802 RID: 63490 RVA: 0x003BFC1E File Offset: 0x003BDE1E
	public void StopProcessAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.StopTweenAnim(8);
	}

	// Token: 0x0600F803 RID: 63491 RVA: 0x003BFC30 File Offset: 0x003BDE30
	public void PlayCloseAnim(float delay)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.IsActive = false;
		this.DestroyCloseTimer();
		if (base.InAsyncLoading())
		{
			Action closeAnimCallback = this.CloseAnimCallback;
			if (closeAnimCallback == null)
			{
				return;
			}
			closeAnimCallback();
			return;
		}
		else
		{
			if (delay > 20f)
			{
				this.CloseTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.OnCloseTimerEnd();
				}, (float)((int)delay), null, null, true, 1f);
				return;
			}
			this.OnCloseAnimTimerEnd();
			return;
		}
	}

	// Token: 0x0600F804 RID: 63492 RVA: 0x003BFCA4 File Offset: 0x003BDEA4
	private void OnCloseTimerEnd()
	{
		this.CloseTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnCloseAnimTimerEnd();
		}, 300f, null, null, true, 1f);
		UUIItem processItem = this.ProcessItem;
		if (processItem != null)
		{
			processItem.SetUIActive(false);
		}
		base.PlayTweenAnim(12);
	}

	// Token: 0x0600F805 RID: 63493 RVA: 0x003BFCF4 File Offset: 0x003BDEF4
	private void OnCloseAnimTimerEnd()
	{
		this.CloseTimer = null;
		Action closeAnimCallback = this.CloseAnimCallback;
		if (closeAnimCallback == null)
		{
			return;
		}
		closeAnimCallback();
	}

	// Token: 0x0600F806 RID: 63494 RVA: 0x003BFD0D File Offset: 0x003BDF0D
	public void StopCloseAnim()
	{
		this.DestroyCloseTimer();
		UUIItem processItem = this.ProcessItem;
		if (processItem != null)
		{
			processItem.SetUIActive(false);
		}
		base.StopTweenAnim(12);
	}

	// Token: 0x0600F807 RID: 63495 RVA: 0x003BFD2F File Offset: 0x003BDF2F
	private void DestroyCloseTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x0600F808 RID: 63496 RVA: 0x003BFD51 File Offset: 0x003BDF51
	[NullableContext(1)]
	public void SetCloseAnimCallback(Action closeAnimCallback)
	{
		this.CloseAnimCallback = closeAnimCallback;
	}

	// Token: 0x040072F3 RID: 29427
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x040072F4 RID: 29428
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x040072F5 RID: 29429
	private FRotator RotatorCache = new FRotator();

	// Token: 0x040072F6 RID: 29430
	private UUISprite IconSprite;

	// Token: 0x040072F7 RID: 29431
	private UUISprite ThrowSprite;

	// Token: 0x040072F8 RID: 29432
	private UUIItem ArrowItem;

	// Token: 0x040072F9 RID: 29433
	private CombineKeyItem KeyItem;

	// Token: 0x040072FA RID: 29434
	private UUIItem ProcessItem;

	// Token: 0x040072FB RID: 29435
	private UUISprite ProcessSprite;

	// Token: 0x040072FC RID: 29436
	private TimerHandle CloseTimer;

	// Token: 0x040072FD RID: 29437
	private Action CloseAnimCallback;

	// Token: 0x040072FE RID: 29438
	private bool IsActive;

	// Token: 0x040072FF RID: 29439
	private float ProcessSpeed;

	// Token: 0x04007300 RID: 29440
	private double StartProcessTime;

	// Token: 0x04007301 RID: 29441
	private bool IsCastTarget;

	// Token: 0x04007302 RID: 29442
	private string IconPath;

	// Token: 0x04007303 RID: 29443
	private ULGUISpriteData_BaseObject DefaultIconSpriteData;

	// Token: 0x04007304 RID: 29444
	private int LoadHandleId;

	// Token: 0x02008548 RID: 34120
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B640 RID: 177728
		IconSprite,
		// Token: 0x0402B641 RID: 177729
		ThrowSprite,
		// Token: 0x0402B642 RID: 177730
		ArrowItem,
		// Token: 0x0402B643 RID: 177731
		ProcessItem,
		// Token: 0x0402B644 RID: 177732
		ProcessSprite,
		// Token: 0x0402B645 RID: 177733
		LockNode,
		// Token: 0x0402B646 RID: 177734
		ActivateEffect,
		// Token: 0x0402B647 RID: 177735
		AnimStart,
		// Token: 0x0402B648 RID: 177736
		AnimProcess,
		// Token: 0x0402B649 RID: 177737
		AnimComplete,
		// Token: 0x0402B64A RID: 177738
		AnimInterrupted,
		// Token: 0x0402B64B RID: 177739
		AnimBanned,
		// Token: 0x0402B64C RID: 177740
		AnimClose,
		// Token: 0x0402B64D RID: 177741
		KeyItem
	}
}
