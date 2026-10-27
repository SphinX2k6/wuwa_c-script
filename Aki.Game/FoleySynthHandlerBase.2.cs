using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200301E RID: 12318
[NullableContext(1)]
[Nullable(0)]
public class FoleySynthHandlerBase<[Nullable(0)] T> : FoleySynthHandlerBase where T : FoleySynthModelConfig
{
	// Token: 0x0601A173 RID: 106867 RVA: 0x006D75BF File Offset: 0x006D57BF
	[NullableContext(2)]
	public FoleySynthHandlerBase(CharacterActorComponent actorComp, CharacterAkComponent akComp, int recordCount) : base(actorComp, akComp, recordCount)
	{
	}

	// Token: 0x0601A174 RID: 106868 RVA: 0x006D75D8 File Offset: 0x006D57D8
	public virtual void Init(IReadOnlyList<T> configs)
	{
		this.OnInit(configs);
		this.RecordIndex = 0;
		this.RecordErrorFlag = 0;
		this.RecordTickCount = 0;
		CharacterAkComponent akComp = base.AkComp;
		this.UeAkComp = ((akComp != null) ? akComp.GetAkComponentBySocketName(CharacterNameDefines.Instance.HIT_CASE_NAME) : null);
		this.IsActive = true;
		for (int i = 0; i < base.RecordCount; i++)
		{
			List<FoleySynthRecord> list = new List<FoleySynthRecord>();
			for (int j = 0; j < this.FoleySynthModelConfigs.Count; j++)
			{
				list.Add(new FoleySynthRecord());
			}
			this.FoleySynthRecordsModel.Add(list);
		}
		for (int k = 0; k < this.FoleySynthModelConfigs.Count; k++)
		{
			this.PreModelBoneComponentLocations.Add(Vector.Create());
			this.FoleySynthModelDynamicConfigs.Add(new FoleySynthDynamicConfig());
		}
	}

	// Token: 0x0601A175 RID: 106869 RVA: 0x006D76A4 File Offset: 0x006D58A4
	protected virtual void OnInit(IReadOnlyList<T> config)
	{
	}

	// Token: 0x0601A176 RID: 106870 RVA: 0x006D76A8 File Offset: 0x006D58A8
	protected override void PreCacheBoneLocation()
	{
		for (int i = 0; i < this.FoleySynthModelConfigs.Count; i++)
		{
			T t = this.FoleySynthModelConfigs[i];
			FTransformDouble ftransformDouble = base.ActorComp.Actor.Mesh.D_GetSocketTransform(t.BoneName.Value, ERelativeTransformSpace.RTS_Component);
			Vector vector = this.PreModelBoneComponentLocations[i];
			FVectorDouble translation = ftransformDouble.GetTranslation();
			vector.DeepCopy(translation);
		}
	}

	// Token: 0x0601A177 RID: 106871 RVA: 0x006D771C File Offset: 0x006D591C
	protected override void CalBoneRecord(float deltaTime)
	{
		this.RecordIndex = (this.RecordIndex + 1) % base.RecordCount;
		int preRecordIndex = base.GetPreRecordIndex(1);
		for (int i = 0; i < this.FoleySynthModelConfigs.Count; i++)
		{
			T t = this.FoleySynthModelConfigs[i];
			FVectorDouble fvectorDouble = base.ActorComp.Actor.Mesh.D_GetSocketLocation(t.BoneName.Value);
			this.TempBoneLocation.DeepCopy(fvectorDouble);
			this.TempBoneLocation.SubtractionEqual(base.ActorComp.ActorLocationProxy);
			ValueTuple<double, double> valueTuple = base.CalBoneSpeed(this.TempBoneLocation, this.PreModelBoneComponentLocations[i], deltaTime);
			double item = valueTuple.Item1;
			double item2 = valueTuple.Item2;
			this.FoleySynthRecordsModel[this.RecordIndex][i].Speed = item;
			this.FoleySynthRecordsModel[this.RecordIndex][i].BoneSpeed = item2;
			double speed = this.FoleySynthRecordsModel[preRecordIndex][i].Speed;
			double acceleration = (item - speed) / (double)deltaTime;
			this.FoleySynthRecordsModel[this.RecordIndex][i].Acceleration = acceleration;
			this.PreModelBoneComponentLocations[i].DeepCopy(this.TempBoneLocation);
			if (this.IsDebug)
			{
				base.SaveDebugInfo(t.BoneName, item, acceleration, item2);
			}
		}
	}

	// Token: 0x0400C5D6 RID: 50646
	protected readonly List<T> FoleySynthModelConfigs = new List<T>();
}
