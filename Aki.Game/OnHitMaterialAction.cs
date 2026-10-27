using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02003031 RID: 12337
[NullableContext(2)]
[Nullable(0)]
public class OnHitMaterialAction
{
	// Token: 0x0601A240 RID: 107072 RVA: 0x006DDCD4 File Offset: 0x006DBED4
	[NullableContext(1)]
	public OnHitMaterialAction(CharRenderingComponent RenderingCompInternal, [Nullable(2)] PawnTimeScaleComponent TimeScaleComp = null)
	{
		this.RenderingCompInternal = RenderingCompInternal;
		this.TimeScaleComp = TimeScaleComp;
	}

	// Token: 0x170023F6 RID: 9206
	// (get) Token: 0x0601A241 RID: 107073 RVA: 0x006DDCF8 File Offset: 0x006DBEF8
	public bool IsPlaying
	{
		get
		{
			return this.IsPlayingInternal;
		}
	}

	// Token: 0x170023F7 RID: 9207
	// (get) Token: 0x0601A242 RID: 107074 RVA: 0x006DDD00 File Offset: 0x006DBF00
	public long BulletId
	{
		get
		{
			return this.BulletIdInternal;
		}
	}

	// Token: 0x170023F8 RID: 9208
	// (get) Token: 0x0601A243 RID: 107075 RVA: 0x006DDD08 File Offset: 0x006DBF08
	public int AttackerId
	{
		get
		{
			return this.AttackerIdInternal;
		}
	}

	// Token: 0x0601A244 RID: 107076 RVA: 0x006DDD10 File Offset: 0x006DBF10
	public bool IsDelayFinish()
	{
		return this.ElapsedMs >= this.DelayMsInternal;
	}

	// Token: 0x0601A245 RID: 107077 RVA: 0x006DDD23 File Offset: 0x006DBF23
	private bool IsFinish()
	{
		return (float)this.ElapsedMs > this.DurationMsInternal + (float)this.DelayMsInternal;
	}

	// Token: 0x0601A246 RID: 107078 RVA: 0x006DDD3C File Offset: 0x006DBF3C
	public bool ComparePriority(long bulletId, int attackerId)
	{
		return !this.IsBeginInternal || this.AttackerIdInternal == attackerId || SceneTeamModel.Instance.GetCurrentEntity.Id != this.AttackerIdInternal;
	}

	// Token: 0x0601A247 RID: 107079 RVA: 0x006DDD70 File Offset: 0x006DBF70
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

	// Token: 0x0601A248 RID: 107080 RVA: 0x006DDE28 File Offset: 0x006DC028
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

	// Token: 0x0601A249 RID: 107081 RVA: 0x006DDE84 File Offset: 0x006DC084
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

	// Token: 0x0601A24A RID: 107082 RVA: 0x006DDED8 File Offset: 0x006DC0D8
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

	// Token: 0x0601A24B RID: 107083 RVA: 0x006DDF70 File Offset: 0x006DC170
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
	}

	// Token: 0x0601A24C RID: 107084 RVA: 0x006DDF94 File Offset: 0x006DC194
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

	// Token: 0x0601A24D RID: 107085 RVA: 0x006DDFE0 File Offset: 0x006DC1E0
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

	// Token: 0x0601A24E RID: 107086 RVA: 0x006DE058 File Offset: 0x006DC258
	private void Clear()
	{
		this.Handle = -1;
		this.PartHandle = -1;
		this.AssetDpPreload = null;
		this.AssetPartDpPreload = null;
		this.IsPlayingInternal = false;
		this.RemoveTimer();
	}

	// Token: 0x0601A24F RID: 107087 RVA: 0x006DE083 File Offset: 0x006DC283
	public void Dispose()
	{
		this.Stop(true);
		this.End();
		this.RemoveTimer();
	}

	// Token: 0x0601A250 RID: 107088 RVA: 0x006DE098 File Offset: 0x006DC298
	public void End()
	{
		this.IsBeginInternal = false;
	}

	// Token: 0x0400C67E RID: 50814
	private const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x0400C67F RID: 50815
	private const int SECOND_TO_MILLISECOND = 1000;

	// Token: 0x0400C680 RID: 50816
	private TimerHandle TimerHandle;

	// Token: 0x0400C681 RID: 50817
	[Nullable(1)]
	private readonly CharRenderingComponent RenderingCompInternal;

	// Token: 0x0400C682 RID: 50818
	private readonly PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400C683 RID: 50819
	private const int INVALID_HANDLE = -1;

	// Token: 0x0400C684 RID: 50820
	private int Handle = -1;

	// Token: 0x0400C685 RID: 50821
	private int PartHandle = -1;

	// Token: 0x0400C686 RID: 50822
	private string PathDpInternal;

	// Token: 0x0400C687 RID: 50823
	private int ElapsedMs;

	// Token: 0x0400C688 RID: 50824
	private float DurationMsInternal;

	// Token: 0x0400C689 RID: 50825
	private int DelayMsInternal;

	// Token: 0x0400C68A RID: 50826
	private bool IsPlayingInternal;

	// Token: 0x0400C68B RID: 50827
	private long BulletIdInternal;

	// Token: 0x0400C68C RID: 50828
	private int AttackerIdInternal;

	// Token: 0x0400C68D RID: 50829
	private UObject AssetDpPreload;

	// Token: 0x0400C68E RID: 50830
	private UObject AssetPartDpPreload;

	// Token: 0x0400C68F RID: 50831
	private bool IsBeginInternal;

	// Token: 0x0400C690 RID: 50832
	private int IdInternal;
}
