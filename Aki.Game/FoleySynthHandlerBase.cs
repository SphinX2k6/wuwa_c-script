using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200301D RID: 12317
[NullableContext(2)]
[Nullable(0)]
public abstract class FoleySynthHandlerBase
{
	// Token: 0x0601A160 RID: 106848 RVA: 0x006D71F8 File Offset: 0x006D53F8
	protected FoleySynthHandlerBase(CharacterActorComponent actorComp, CharacterAkComponent akComp, int recordCount)
	{
	}

	// Token: 0x170023E5 RID: 9189
	// (get) Token: 0x0601A161 RID: 106849 RVA: 0x006D726D File Offset: 0x006D546D
	// (set) Token: 0x0601A162 RID: 106850 RVA: 0x006D7275 File Offset: 0x006D5475
	public CharacterActorComponent ActorComp { get; private set; } = actorComp;

	// Token: 0x170023E6 RID: 9190
	// (get) Token: 0x0601A163 RID: 106851 RVA: 0x006D727E File Offset: 0x006D547E
	// (set) Token: 0x0601A164 RID: 106852 RVA: 0x006D7286 File Offset: 0x006D5486
	public CharacterAkComponent AkComp { get; private set; } = akComp;

	// Token: 0x170023E7 RID: 9191
	// (get) Token: 0x0601A165 RID: 106853 RVA: 0x006D728F File Offset: 0x006D548F
	// (set) Token: 0x0601A166 RID: 106854 RVA: 0x006D7297 File Offset: 0x006D5497
	public int RecordCount { get; private set; } = recordCount;

	// Token: 0x0601A167 RID: 106855 RVA: 0x006D72A0 File Offset: 0x006D54A0
	public virtual void Tick(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.CalCurrentFoleySynthTick(deltaTime);
	}

	// Token: 0x0601A168 RID: 106856 RVA: 0x006D72B2 File Offset: 0x006D54B2
	public void SetActive(bool active)
	{
		this.IsActive = active;
	}

	// Token: 0x0601A169 RID: 106857 RVA: 0x006D72BB File Offset: 0x006D54BB
	public virtual void Clear()
	{
		this.ActorComp = null;
		this.AkComp = null;
		this.UeAkComp = null;
	}

	// Token: 0x0601A16A RID: 106858 RVA: 0x006D72D4 File Offset: 0x006D54D4
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

	// Token: 0x0601A16B RID: 106859
	protected abstract void PreCacheBoneLocation();

	// Token: 0x0601A16C RID: 106860
	protected abstract void CalBoneRecord(float deltaTime);

	// Token: 0x0601A16D RID: 106861 RVA: 0x006D736D File Offset: 0x006D556D
	protected virtual void OnParseBoneSpeedForAudio()
	{
	}

	// Token: 0x0601A16E RID: 106862 RVA: 0x006D7370 File Offset: 0x006D5570
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

	// Token: 0x0601A16F RID: 106863 RVA: 0x006D73D8 File Offset: 0x006D55D8
	protected int GetPreRecordIndex(int size)
	{
		return (this.RecordIndex + this.RecordCount - size) % this.RecordCount;
	}

	// Token: 0x0601A170 RID: 106864 RVA: 0x006D73F0 File Offset: 0x006D55F0
	[NullableContext(1)]
	protected FoleySynthRecord GetCurrentRecord(int configIndex)
	{
		return this.FoleySynthRecordsModel[this.RecordIndex][configIndex];
	}

	// Token: 0x0601A171 RID: 106865 RVA: 0x006D740C File Offset: 0x006D560C
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

	// Token: 0x0601A172 RID: 106866 RVA: 0x006D74A0 File Offset: 0x006D56A0
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

	// Token: 0x0400C5C8 RID: 50632
	protected UAkComponent UeAkComp;

	// Token: 0x0400C5C9 RID: 50633
	[Nullable(1)]
	protected readonly List<List<FoleySynthRecord>> FoleySynthRecordsModel = new List<List<FoleySynthRecord>>();

	// Token: 0x0400C5CA RID: 50634
	[Nullable(1)]
	protected readonly List<FoleySynthDynamicConfig> FoleySynthModelDynamicConfigs = new List<FoleySynthDynamicConfig>();

	// Token: 0x0400C5CB RID: 50635
	[Nullable(1)]
	protected readonly List<Vector> PreModelBoneComponentLocations = new List<Vector>();

	// Token: 0x0400C5CC RID: 50636
	protected int RecordIndex;

	// Token: 0x0400C5CD RID: 50637
	protected int RecordTickCount;

	// Token: 0x0400C5CE RID: 50638
	protected int RecordErrorFlag;

	// Token: 0x0400C5CF RID: 50639
	[Nullable(1)]
	protected readonly Vector TempVector = Vector.Create();

	// Token: 0x0400C5D0 RID: 50640
	[Nullable(1)]
	protected readonly Vector TempBoneLocation = Vector.Create();

	// Token: 0x0400C5D1 RID: 50641
	protected bool IsActive;

	// Token: 0x0400C5D2 RID: 50642
	[Nullable(1)]
	protected string SavedRecords = "";

	// Token: 0x0400C5D3 RID: 50643
	protected bool IsDebug;

	// Token: 0x0400C5D4 RID: 50644
	[Nullable(1)]
	protected string SavedPath = "";

	// Token: 0x0400C5D5 RID: 50645
	protected float DebugTime;
}
