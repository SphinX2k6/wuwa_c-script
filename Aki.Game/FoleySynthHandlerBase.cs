using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002573 RID: 9587
[NullableContext(2)]
[Nullable(0)]
public abstract class FoleySynthHandlerBase
{
	// Token: 0x06017AA8 RID: 96936 RVA: 0x006FF100 File Offset: 0x006FD300
	protected FoleySynthHandlerBase(CharacterActorComponent actorComp, CharacterAkComponent akComp, int recordCount)
	{
	}

	// Token: 0x170024B3 RID: 9395
	// (get) Token: 0x06017AA9 RID: 96937 RVA: 0x006FF175 File Offset: 0x006FD375
	// (set) Token: 0x06017AAA RID: 96938 RVA: 0x006FF17D File Offset: 0x006FD37D
	public CharacterActorComponent ActorComp { get; private set; } = actorComp;

	// Token: 0x170024B4 RID: 9396
	// (get) Token: 0x06017AAB RID: 96939 RVA: 0x006FF186 File Offset: 0x006FD386
	// (set) Token: 0x06017AAC RID: 96940 RVA: 0x006FF18E File Offset: 0x006FD38E
	public CharacterAkComponent AkComp { get; private set; } = akComp;

	// Token: 0x170024B5 RID: 9397
	// (get) Token: 0x06017AAD RID: 96941 RVA: 0x006FF197 File Offset: 0x006FD397
	// (set) Token: 0x06017AAE RID: 96942 RVA: 0x006FF19F File Offset: 0x006FD39F
	public int RecordCount { get; private set; } = recordCount;

	// Token: 0x06017AAF RID: 96943 RVA: 0x006FF1A8 File Offset: 0x006FD3A8
	public virtual void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.CalCurrentFoleySynthTick(deltaTime);
	}

	// Token: 0x06017AB0 RID: 96944 RVA: 0x006FF1BA File Offset: 0x006FD3BA
	public void SetActive(bool active)
	{
		this.IsActive = active;
	}

	// Token: 0x06017AB1 RID: 96945 RVA: 0x006FF1C3 File Offset: 0x006FD3C3
	public virtual void Clear()
	{
		this.ActorComp = null;
		this.AkComp = null;
		this.UeAkComp = null;
	}

	// Token: 0x06017AB2 RID: 96946 RVA: 0x006FF1DC File Offset: 0x006FD3DC
	private void CalCurrentFoleySynthTick(float deltaTime)
	{
		float num = deltaTime * 0.001f;
		if (this.IsDebug)
		{
			this.DebugTime += num;
		}
		if (this.RecordTickCount == 0)
		{
			this.PreCacheBoneLocation();
			this.RecordTickCount++;
			return;
		}
		this.CalBoneRecord(num);
		if (this.RecordTickCount > this.RecordCount + this.RecordErrorFlag)
		{
			this.OnParseBoneSpeedForAudio();
		}
		this.RecordTickCount++;
		if (this.RecordTickCount == 2147483647)
		{
			this.RecordTickCount = this.RecordCount;
			this.RecordErrorFlag = 0;
		}
	}

	// Token: 0x06017AB3 RID: 96947
	protected abstract void PreCacheBoneLocation();

	// Token: 0x06017AB4 RID: 96948
	protected abstract void CalBoneRecord(float deltaTime);

	// Token: 0x06017AB5 RID: 96949 RVA: 0x006FF275 File Offset: 0x006FD475
	protected virtual void OnParseBoneSpeedForAudio()
	{
	}

	// Token: 0x06017AB6 RID: 96950 RVA: 0x006FF278 File Offset: 0x006FD478
	[NullableContext(1)]
	[return: Nullable(0)]
	protected ValueTuple<double, double> CalBoneSpeed(Vector nowLocation, Vector preLocation, float deltaTime)
	{
		this.TempVector.DeepCopy(nowLocation);
		this.TempVector.SubtractionEqual(preLocation);
		this.TempVector.DivisionEqual((double)deltaTime);
		double item = this.TempVector.Size();
		this.TempVector.AdditionEqual(this.ActorComp.ActorVelocityProxy);
		return new ValueTuple<double, double>(this.TempVector.Size(), item);
	}

	// Token: 0x06017AB7 RID: 96951 RVA: 0x006FF2E0 File Offset: 0x006FD4E0
	protected int GetPreRecordIndex(int size)
	{
		return (this.RecordIndex + this.RecordCount - size) % this.RecordCount;
	}

	// Token: 0x06017AB8 RID: 96952 RVA: 0x006FF2F8 File Offset: 0x006FD4F8
	[NullableContext(1)]
	protected FoleySynthRecord GetCurrentRecord(int configIndex)
	{
		return this.FoleySynthRecordsModel[this.RecordIndex][configIndex];
	}

	// Token: 0x06017AB9 RID: 96953 RVA: 0x006FF314 File Offset: 0x006FD514
	public void SetDebug(bool debug)
	{
		if (debug)
		{
			this.SavedPath = string.Concat(new string[]
			{
				UKismetSystemLibrary.GetProjectDirectory(),
				"/Saved/FoleySynth/FoleySynthRecord_",
				base.GetType().Name,
				"_",
				this.ActorComp.Actor.GetName(),
				".txt"
			});
			this.SavedRecords = "";
			this.IsDebug = true;
			this.DebugTime = 0f;
			return;
		}
		this.SavedRecords = "";
		this.IsDebug = false;
	}

	// Token: 0x06017ABA RID: 96954 RVA: 0x006FF3A8 File Offset: 0x006FD5A8
	public unsafe void SaveDebugInfo(FName? boneName, double speed, double acceleration, double boneSpeed)
	{
		if (!this.IsDebug)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 5);
		defaultInterpolatedStringHandler.AppendFormatted((boneName != null) ? boneName.GetValueOrDefault().ToString() : null);
		defaultInterpolatedStringHandler.AppendLiteral(",speed:");
		defaultInterpolatedStringHandler.AppendFormatted<double>(speed);
		defaultInterpolatedStringHandler.AppendLiteral(",acceleration:");
		defaultInterpolatedStringHandler.AppendFormatted<double>(acceleration);
		defaultInterpolatedStringHandler.AppendLiteral(",boneSpeed:");
		defaultInterpolatedStringHandler.AppendFormatted<double>(boneSpeed);
		defaultInterpolatedStringHandler.AppendLiteral(",debugTime:");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.DebugTime);
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		this.SavedRecords = this.SavedRecords + "\n" + text;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "-------------Ak[FoleySynth] Debug信息";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.ActorComp.Actor.GetName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Info", text);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0400C995 RID: 51605
	protected UAkComponent UeAkComp;

	// Token: 0x0400C996 RID: 51606
	[Nullable(1)]
	protected readonly List<List<FoleySynthRecord>> FoleySynthRecordsModel = new List<List<FoleySynthRecord>>();

	// Token: 0x0400C997 RID: 51607
	[Nullable(1)]
	protected readonly List<FoleySynthDynamicConfig> FoleySynthModelDynamicConfigs = new List<FoleySynthDynamicConfig>();

	// Token: 0x0400C998 RID: 51608
	[Nullable(1)]
	protected readonly List<Vector> PreModelBoneComponentLocations = new List<Vector>();

	// Token: 0x0400C999 RID: 51609
	protected int RecordIndex;

	// Token: 0x0400C99A RID: 51610
	protected int RecordTickCount;

	// Token: 0x0400C99B RID: 51611
	protected int RecordErrorFlag;

	// Token: 0x0400C99C RID: 51612
	[Nullable(1)]
	protected readonly Vector TempVector = Vector.Create();

	// Token: 0x0400C99D RID: 51613
	[Nullable(1)]
	protected readonly Vector TempBoneLocation = Vector.Create();

	// Token: 0x0400C99E RID: 51614
	protected bool IsActive;

	// Token: 0x0400C99F RID: 51615
	[Nullable(1)]
	protected string SavedRecords = "";

	// Token: 0x0400C9A0 RID: 51616
	protected bool IsDebug;

	// Token: 0x0400C9A1 RID: 51617
	[Nullable(1)]
	protected string SavedPath = "";

	// Token: 0x0400C9A2 RID: 51618
	protected float DebugTime;
}
