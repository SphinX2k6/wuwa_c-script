using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002587 RID: 9607
[NullableContext(2)]
[Nullable(0)]
public class OnHitMaterialAction
{
	// Token: 0x06017B9F RID: 97183 RVA: 0x007059DE File Offset: 0x00703BDE
	[NullableContext(1)]
	public OnHitMaterialAction(CharRenderingComponent RenderingCompInternal, [Nullable(2)] PawnTimeScaleComponent TimeScaleComp = null)
	{
		this.RenderingCompInternal = RenderingCompInternal;
		this.TimeScaleComp = TimeScaleComp;
	}

	// Token: 0x170024DA RID: 9434
	// (get) Token: 0x06017BA0 RID: 97184 RVA: 0x00705A02 File Offset: 0x00703C02
	public bool IsPlaying
	{
		get
		{
			return this.IsPlayingInternal;
		}
	}

	// Token: 0x170024DB RID: 9435
	// (get) Token: 0x06017BA1 RID: 97185 RVA: 0x00705A0A File Offset: 0x00703C0A
	public long BulletId
	{
		get
		{
			return this.BulletIdInternal;
		}
	}

	// Token: 0x170024DC RID: 9436
	// (get) Token: 0x06017BA2 RID: 97186 RVA: 0x00705A12 File Offset: 0x00703C12
	public int AttackerId
	{
		get
		{
			return this.AttackerIdInternal;
		}
	}

	// Token: 0x06017BA3 RID: 97187 RVA: 0x00705A1A File Offset: 0x00703C1A
	public bool IsDelayFinish()
	{
		return this.ElapsedMs >= this.DelayMsInternal;
	}

	// Token: 0x06017BA4 RID: 97188 RVA: 0x00705A2D File Offset: 0x00703C2D
	private bool IsFinish()
	{
		return (float)this.ElapsedMs > this.DurationMsInternal + (float)this.DelayMsInternal;
	}

	// Token: 0x06017BA5 RID: 97189 RVA: 0x00705A46 File Offset: 0x00703C46
	public bool ComparePriority(long bulletId, int attackerId)
	{
		return !this.IsBeginInternal || this.AttackerIdInternal == attackerId || SceneTeamModel.Instance.GetCurrentEntity.Id != this.AttackerIdInternal;
	}

	// Token: 0x06017BA6 RID: 97190 RVA: 0x00705A78 File Offset: 0x00703C78
	[NullableContext(1)]
	public void Start(string pathDp, int delay, long bulletId, int attackerId, [Nullable(2)] string pathPartDp = null)
	{
		this.IsBeginInternal = true;
		this.PathDpInternal = pathDp;
		this.DurationMsInternal = 1000f;
		this.DelayMsInternal = delay;
		this.BulletIdInternal = bulletId;
		this.AttackerIdInternal = attackerId;
		this.IsPlayingInternal = false;
		this.AssetDpPreload = null;
		this.AssetPartDpPreload = null;
		this.ElapsedMs = 0;
		this.IdInternal++;
		this.StartAsync(this.IdInternal, pathDp, pathPartDp);
		if (!TimerSystem.Instance.Has(this.TimerHandle))
		{
			this.TimerHandle = TimerSystem.Instance.Forever(new TTimerAction(this.Loop), 20f, 1f, null, "[OnHitMaterial.Loop]", true);
		}
	}

	// Token: 0x06017BA7 RID: 97191 RVA: 0x00705B30 File Offset: 0x00703D30
	[NullableContext(1)]
	private UniTask StartAsync(int id, string pathDp, [Nullable(2)] string pathPartDp)
	{
		OnHitMaterialAction.<StartAsync>d__30 <StartAsync>d__;
		<StartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartAsync>d__.<>4__this = this;
		<StartAsync>d__.id = id;
		<StartAsync>d__.pathDp = pathDp;
		<StartAsync>d__.pathPartDp = pathPartDp;
		<StartAsync>d__.<>1__state = -1;
		<StartAsync>d__.<>t__builder.Start<OnHitMaterialAction.<StartAsync>d__30>(ref <StartAsync>d__);
		return <StartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017BA8 RID: 97192 RVA: 0x00705B8C File Offset: 0x00703D8C
	[NullableContext(1)]
	private UniTask LoadDpAsset(string pathDp, [Nullable(new byte[]
	{
		1,
		2
	})] PD_CharacterControllerData_C[] materialCtrl, int index)
	{
		OnHitMaterialAction.<LoadDpAsset>d__31 <LoadDpAsset>d__;
		<LoadDpAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDpAsset>d__.pathDp = pathDp;
		<LoadDpAsset>d__.materialCtrl = materialCtrl;
		<LoadDpAsset>d__.index = index;
		<LoadDpAsset>d__.<>1__state = -1;
		<LoadDpAsset>d__.<>t__builder.Start<OnHitMaterialAction.<LoadDpAsset>d__31>(ref <LoadDpAsset>d__);
		return <LoadDpAsset>d__.<>t__builder.Task;
	}

	// Token: 0x06017BA9 RID: 97193 RVA: 0x00705BE0 File Offset: 0x00703DE0
	private void Loop(float deltaMs)
	{
		if (!this.RenderingCompInternal.IsValid())
		{
			this.End();
			this.Clear();
			return;
		}
		int elapsedMs = this.ElapsedMs;
		PawnTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		this.ElapsedMs = elapsedMs + (int)(deltaMs * ((timeScaleComp != null) ? timeScaleComp.CurrentTimeScale : 1f));
		if (!this.IsPlayingInternal && this.IsDelayFinish())
		{
			this.Play(this.AssetDpPreload, this.AssetPartDpPreload, "OnHitMaterialAction 开始播放");
			return;
		}
		if (this.IsPlayingInternal && this.IsFinish())
		{
			this.Stop(false);
			this.End();
			this.RemoveTimer();
		}
	}

	// Token: 0x06017BAA RID: 97194 RVA: 0x00705C78 File Offset: 0x00703E78
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
	}

	// Token: 0x06017BAB RID: 97195 RVA: 0x00705C9C File Offset: 0x00703E9C
	private void Play(UObject assetDp, UObject assetPartDp, [Nullable(1)] string reason = "OnHitMaterialAction 开始播放")
	{
		this.IsPlayingInternal = true;
		if (!this.RenderingCompInternal.IsValid())
		{
			return;
		}
		if (assetDp != null)
		{
			this.Handle = this.RenderingCompInternal.AddMaterialControllerData(assetDp);
		}
		if (assetPartDp != null)
		{
			this.PartHandle = this.RenderingCompInternal.AddMaterialControllerData(assetPartDp);
		}
	}

	// Token: 0x06017BAC RID: 97196 RVA: 0x00705CE8 File Offset: 0x00703EE8
	public void Stop(bool force = false)
	{
		if (!this.RenderingCompInternal.IsValid())
		{
			this.Clear();
			return;
		}
		if (this.Handle != -1)
		{
			this.RenderingCompInternal.RemoveMaterialControllerData(this.Handle);
		}
		if (this.PartHandle != -1)
		{
			this.RenderingCompInternal.RemoveMaterialControllerData(this.PartHandle);
		}
		this.Handle = -1;
		this.PartHandle = -1;
		this.AssetDpPreload = null;
		this.AssetPartDpPreload = null;
		this.IsPlayingInternal = false;
	}

	// Token: 0x06017BAD RID: 97197 RVA: 0x00705D60 File Offset: 0x00703F60
	private void Clear()
	{
		this.Handle = -1;
		this.PartHandle = -1;
		this.AssetDpPreload = null;
		this.AssetPartDpPreload = null;
		this.IsPlayingInternal = false;
		this.RemoveTimer();
	}

	// Token: 0x06017BAE RID: 97198 RVA: 0x00705D8B File Offset: 0x00703F8B
	public void Dispose()
	{
		this.Stop(true);
		this.End();
		this.RemoveTimer();
	}

	// Token: 0x06017BAF RID: 97199 RVA: 0x00705DA0 File Offset: 0x00703FA0
	public void End()
	{
		this.IsBeginInternal = false;
	}

	// Token: 0x0400CA4D RID: 51789
	private const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400CA4E RID: 51790
	private const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400CA4F RID: 51791
	private TimerHandle TimerHandle;

	// Token: 0x0400CA50 RID: 51792
	[Nullable(1)]
	private readonly CharRenderingComponent RenderingCompInternal;

	// Token: 0x0400CA51 RID: 51793
	private readonly PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400CA52 RID: 51794
	private const int INVALID_HANDLE = -1;

	// Token: 0x0400CA53 RID: 51795
	private int Handle = -1;

	// Token: 0x0400CA54 RID: 51796
	private int PartHandle = -1;

	// Token: 0x0400CA55 RID: 51797
	private string PathDpInternal;

	// Token: 0x0400CA56 RID: 51798
	private int ElapsedMs;

	// Token: 0x0400CA57 RID: 51799
	private float DurationMsInternal;

	// Token: 0x0400CA58 RID: 51800
	private int DelayMsInternal;

	// Token: 0x0400CA59 RID: 51801
	private bool IsPlayingInternal;

	// Token: 0x0400CA5A RID: 51802
	private long BulletIdInternal;

	// Token: 0x0400CA5B RID: 51803
	private int AttackerIdInternal;

	// Token: 0x0400CA5C RID: 51804
	private UObject AssetDpPreload;

	// Token: 0x0400CA5D RID: 51805
	private UObject AssetPartDpPreload;

	// Token: 0x0400CA5E RID: 51806
	private bool IsBeginInternal;

	// Token: 0x0400CA5F RID: 51807
	private int IdInternal;
}
