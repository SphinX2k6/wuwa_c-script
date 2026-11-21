using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001411 RID: 5137
[NullableContext(2)]
[Nullable(0)]
public class ManipulateCursorUnit : HudUnitBase
{
	// Token: 0x0600CC0F RID: 52239 RVA: 0x003CB020 File Offset: 0x003C9220
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

	// Token: 0x0600CC10 RID: 52240 RVA: 0x003CB224 File Offset: 0x003C9424
	protected override UniTask OnBeforeStartAsync()
	{
		ManipulateCursorUnit.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ManipulateCursorUnit.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC11 RID: 52241 RVA: 0x003CB268 File Offset: 0x003C9468
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

	// Token: 0x0600CC12 RID: 52242 RVA: 0x003CB324 File Offset: 0x003C9524
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

	// Token: 0x0600CC13 RID: 52243 RVA: 0x003CB3D8 File Offset: 0x003C95D8
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

	// Token: 0x0600CC14 RID: 52244 RVA: 0x003CB43C File Offset: 0x003C963C
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

	// Token: 0x0600CC15 RID: 52245 RVA: 0x003CB523 File Offset: 0x003C9723
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

	// Token: 0x0600CC16 RID: 52246 RVA: 0x003CB538 File Offset: 0x003C9738
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

	// Token: 0x0600CC17 RID: 52247 RVA: 0x003CB5A0 File Offset: 0x003C97A0
	public void EndProcess(bool resetProcess)
	{
		this.StopProcessAnim();
		this.ProcessSpeed = 0f;
		if (resetProcess)
		{
			this.SetProcess(0f);
		}
	}

	// Token: 0x0600CC18 RID: 52248 RVA: 0x003CB5C4 File Offset: 0x003C97C4
	private void UpdateProcess()
	{
		if (this.ProcessSpeed <= 0f)
		{
			return;
		}
		float process = MathF.Min((float)((Time.Instance.WorldTime - this.StartProcessTime) * (double)this.ProcessSpeed), 1f);
		this.SetProcess(process);
	}

	// Token: 0x0600CC19 RID: 52249 RVA: 0x003CB60B File Offset: 0x003C980B
	private void SetProcess(float percent)
	{
		UUISprite processSprite = this.ProcessSprite;
		if (processSprite == null)
		{
			return;
		}
		processSprite.SetFillAmount(percent);
	}

	// Token: 0x0600CC1A RID: 52250 RVA: 0x003CB61E File Offset: 0x003C981E
	public void PlayActivateEffect()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(6);
		uiNiagara.SetUIActive(true);
		uiNiagara.ActivateSystem(true);
	}

	// Token: 0x0600CC1B RID: 52251 RVA: 0x003CB634 File Offset: 0x003C9834
	private void InitAllTweenAnim()
	{
		base.InitTweenAnim(7);
		base.InitTweenAnim(8);
		base.InitTweenAnim(9);
		base.InitTweenAnim(10);
		base.InitTweenAnim(12);
	}

	// Token: 0x0600CC1C RID: 52252 RVA: 0x003CB65C File Offset: 0x003C985C
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

	// Token: 0x0600CC1D RID: 52253 RVA: 0x003CB6C0 File Offset: 0x003C98C0
	public void PlayStartAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(7);
	}

	// Token: 0x0600CC1E RID: 52254 RVA: 0x003CB6D2 File Offset: 0x003C98D2
	public void PlayCompleteAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(9);
	}

	// Token: 0x0600CC1F RID: 52255 RVA: 0x003CB6E5 File Offset: 0x003C98E5
	public void PlayInterruptedAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(10);
	}

	// Token: 0x0600CC20 RID: 52256 RVA: 0x003CB6F8 File Offset: 0x003C98F8
	public void PlayProcessAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.PlayTweenAnim(8);
	}

	// Token: 0x0600CC21 RID: 52257 RVA: 0x003CB70A File Offset: 0x003C990A
	public void StopProcessAnim()
	{
		if (!this.IsActive)
		{
			return;
		}
		base.StopTweenAnim(8);
	}

	// Token: 0x0600CC22 RID: 52258 RVA: 0x003CB71C File Offset: 0x003C991C
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

	// Token: 0x0600CC23 RID: 52259 RVA: 0x003CB790 File Offset: 0x003C9990
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

	// Token: 0x0600CC24 RID: 52260 RVA: 0x003CB7E0 File Offset: 0x003C99E0
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

	// Token: 0x0600CC25 RID: 52261 RVA: 0x003CB7F9 File Offset: 0x003C99F9
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

	// Token: 0x0600CC26 RID: 52262 RVA: 0x003CB81B File Offset: 0x003C9A1B
	private void DestroyCloseTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x0600CC27 RID: 52263 RVA: 0x003CB83D File Offset: 0x003C9A3D
	[NullableContext(1)]
	public void SetCloseAnimCallback(Action closeAnimCallback)
	{
		this.CloseAnimCallback = closeAnimCallback;
	}

	// Token: 0x040073D4 RID: 29652
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x040073D5 RID: 29653
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x040073D6 RID: 29654
	private FRotator RotatorCache = new FRotator();

	// Token: 0x040073D7 RID: 29655
	private UUISprite IconSprite;

	// Token: 0x040073D8 RID: 29656
	private UUISprite ThrowSprite;

	// Token: 0x040073D9 RID: 29657
	private UUIItem ArrowItem;

	// Token: 0x040073DA RID: 29658
	private CombineKeyItem KeyItem;

	// Token: 0x040073DB RID: 29659
	private UUIItem ProcessItem;

	// Token: 0x040073DC RID: 29660
	private UUISprite ProcessSprite;

	// Token: 0x040073DD RID: 29661
	private TimerHandle CloseTimer;

	// Token: 0x040073DE RID: 29662
	private Action CloseAnimCallback;

	// Token: 0x040073DF RID: 29663
	private bool IsActive;

	// Token: 0x040073E0 RID: 29664
	private float ProcessSpeed;

	// Token: 0x040073E1 RID: 29665
	private double StartProcessTime;

	// Token: 0x040073E2 RID: 29666
	private bool IsCastTarget;

	// Token: 0x040073E3 RID: 29667
	private string IconPath;

	// Token: 0x040073E4 RID: 29668
	private ULGUISpriteData_BaseObject DefaultIconSpriteData;

	// Token: 0x040073E5 RID: 29669
	private int LoadHandleId;

	// Token: 0x020076CD RID: 30413
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026964 RID: 158052
		IconSprite,
		// Token: 0x04026965 RID: 158053
		ThrowSprite,
		// Token: 0x04026966 RID: 158054
		ArrowItem,
		// Token: 0x04026967 RID: 158055
		ProcessItem,
		// Token: 0x04026968 RID: 158056
		ProcessSprite,
		// Token: 0x04026969 RID: 158057
		LockNode,
		// Token: 0x0402696A RID: 158058
		ActivateEffect,
		// Token: 0x0402696B RID: 158059
		AnimStart,
		// Token: 0x0402696C RID: 158060
		AnimProcess,
		// Token: 0x0402696D RID: 158061
		AnimComplete,
		// Token: 0x0402696E RID: 158062
		AnimInterrupted,
		// Token: 0x0402696F RID: 158063
		AnimBanned,
		// Token: 0x04026970 RID: 158064
		AnimClose,
		// Token: 0x04026971 RID: 158065
		KeyItem
	}
}
