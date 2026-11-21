using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E3 RID: 17891
	public struct ITakePhoto2TaggedActorTarget : IFlatbufferObject
	{
		// Token: 0x17007D1A RID: 32026
		// (get) Token: 0x0601A21B RID: 107035 RVA: 0x003B9060 File Offset: 0x003B7260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A21C RID: 107036 RVA: 0x003B906D File Offset: 0x003B726D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A21D RID: 107037 RVA: 0x003B9074 File Offset: 0x003B7274
		public static ITakePhoto2TaggedActorTarget GetRootAsITakePhoto2TaggedActorTarget(ByteBuffer _bb)
		{
			return ITakePhoto2TaggedActorTarget.GetRootAsITakePhoto2TaggedActorTarget(_bb, default(ITakePhoto2TaggedActorTarget));
		}

		// Token: 0x0601A21E RID: 107038 RVA: 0x003B9090 File Offset: 0x003B7290
		public static ITakePhoto2TaggedActorTarget GetRootAsITakePhoto2TaggedActorTarget(ByteBuffer _bb, ITakePhoto2TaggedActorTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A21F RID: 107039 RVA: 0x003B90AD File Offset: 0x003B72AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A220 RID: 107040 RVA: 0x003B90BC File Offset: 0x003B72BC
		public ITakePhoto2TaggedActorTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D1B RID: 32027
		// (get) Token: 0x0601A221 RID: 107041 RVA: 0x003B90CC File Offset: 0x003B72CC
		public ETakePhoto2TargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2TargetType.Entity;
				}
				return (ETakePhoto2TargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D1C RID: 32028
		// (get) Token: 0x0601A222 RID: 107042 RVA: 0x003B9108 File Offset: 0x003B7308
		public bool IsOptionalTarget
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007D1D RID: 32029
		// (get) Token: 0x0601A223 RID: 107043 RVA: 0x003B9148 File Offset: 0x003B7348
		public ITakePhoto2TargetCameraDistanceCondition? TargetCameraDistanceCondition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetCameraDistanceCondition?(default(ITakePhoto2TargetCameraDistanceCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D1E RID: 32030
		// (get) Token: 0x0601A224 RID: 107044 RVA: 0x003B91A8 File Offset: 0x003B73A8
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A225 RID: 107045 RVA: 0x003B91E0 File Offset: 0x003B73E0
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601A226 RID: 107046 RVA: 0x003B91F0 File Offset: 0x003B73F0
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007D1F RID: 32031
		// (get) Token: 0x0601A227 RID: 107047 RVA: 0x003B9200 File Offset: 0x003B7400
		public ITakePhoto2TargetPosByRangeCondition? TargetPosCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITakePhoto2TargetPosByRangeCondition?(default(ITakePhoto2TargetPosByRangeCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D20 RID: 32032
		// (get) Token: 0x0601A228 RID: 107048 RVA: 0x003B9260 File Offset: 0x003B7460
		public int TargetSatisfiedCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D21 RID: 32033
		// (get) Token: 0x0601A229 RID: 107049 RVA: 0x003B92A0 File Offset: 0x003B74A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A22A RID: 107050 RVA: 0x003B92E0 File Offset: 0x003B74E0
		public static Offset<ITakePhoto2TaggedActorTarget> CreateITakePhoto2TaggedActorTarget(FlatBufferBuilder builder, ETakePhoto2TargetType Type = ETakePhoto2TargetType.Entity, bool IsOptionalTarget = false, Offset<ITakePhoto2TargetCameraDistanceCondition> TargetCameraDistanceConditionOffset = default(Offset<ITakePhoto2TargetCameraDistanceCondition>), StringOffset TagOffset = default(StringOffset), Offset<ITakePhoto2TargetPosByRangeCondition> TargetPosConditionOffset = default(Offset<ITakePhoto2TargetPosByRangeCondition>), int TargetSatisfiedCount = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ITakePhoto2TaggedActorTarget.AddTargetSatisfiedCount(builder, TargetSatisfiedCount);
			ITakePhoto2TaggedActorTarget.AddTargetPosCondition(builder, TargetPosConditionOffset);
			ITakePhoto2TaggedActorTarget.AddTag(builder, TagOffset);
			ITakePhoto2TaggedActorTarget.AddTargetCameraDistanceCondition(builder, TargetCameraDistanceConditionOffset);
			ITakePhoto2TaggedActorTarget.AddNullMask(builder, NullMask);
			ITakePhoto2TaggedActorTarget.AddIsOptionalTarget(builder, IsOptionalTarget);
			ITakePhoto2TaggedActorTarget.AddType(builder, Type);
			return ITakePhoto2TaggedActorTarget.EndITakePhoto2TaggedActorTarget(builder);
		}

		// Token: 0x0601A22B RID: 107051 RVA: 0x003B932F File Offset: 0x003B752F
		public static void StartITakePhoto2TaggedActorTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A22C RID: 107052 RVA: 0x003B9338 File Offset: 0x003B7538
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2TargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A22D RID: 107053 RVA: 0x003B9343 File Offset: 0x003B7543
		public static void AddIsOptionalTarget(FlatBufferBuilder builder, bool isOptionalTarget)
		{
			builder.AddBool(1, isOptionalTarget, false);
		}

		// Token: 0x0601A22E RID: 107054 RVA: 0x003B934E File Offset: 0x003B754E
		public static void AddTargetCameraDistanceCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset)
		{
			builder.AddOffset(2, targetCameraDistanceConditionOffset.Value, 0);
		}

		// Token: 0x0601A22F RID: 107055 RVA: 0x003B935E File Offset: 0x003B755E
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(3, tagOffset.Value, 0);
		}

		// Token: 0x0601A230 RID: 107056 RVA: 0x003B936E File Offset: 0x003B756E
		public static void AddTargetPosCondition(FlatBufferBuilder builder, Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset)
		{
			builder.AddOffset(4, targetPosConditionOffset.Value, 0);
		}

		// Token: 0x0601A231 RID: 107057 RVA: 0x003B937E File Offset: 0x003B757E
		public static void AddTargetSatisfiedCount(FlatBufferBuilder builder, int targetSatisfiedCount)
		{
			builder.AddInt(5, targetSatisfiedCount, 0);
		}

		// Token: 0x0601A232 RID: 107058 RVA: 0x003B9389 File Offset: 0x003B7589
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601A233 RID: 107059 RVA: 0x003B9394 File Offset: 0x003B7594
		public static Offset<ITakePhoto2TaggedActorTarget> EndITakePhoto2TaggedActorTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TaggedActorTarget>(builder.EndTable());
		}

		// Token: 0x0601A234 RID: 107060 RVA: 0x003B93A4 File Offset: 0x003B75A4
		public ITakePhoto2TaggedActorTargetT UnPack()
		{
			ITakePhoto2TaggedActorTargetT takePhoto2TaggedActorTargetT = new ITakePhoto2TaggedActorTargetT();
			this.UnPackTo(takePhoto2TaggedActorTargetT);
			return takePhoto2TaggedActorTargetT;
		}

		// Token: 0x0601A235 RID: 107061 RVA: 0x003B93C0 File Offset: 0x003B75C0
		public void UnPackTo(ITakePhoto2TaggedActorTargetT _o)
		{
			_o.Type = this.Type;
			_o.IsOptionalTarget = this.IsOptionalTarget;
			_o.TargetCameraDistanceCondition = ((this.TargetCameraDistanceCondition != null) ? this.TargetCameraDistanceCondition.Value.UnPack() : null);
			_o.Tag = this.Tag;
			_o.TargetPosCondition = ((this.TargetPosCondition != null) ? this.TargetPosCondition.Value.UnPack() : null);
			_o.TargetSatisfiedCount = this.TargetSatisfiedCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A236 RID: 107062 RVA: 0x003B9468 File Offset: 0x003B7668
		public static Offset<ITakePhoto2TaggedActorTarget> Pack(FlatBufferBuilder builder, ITakePhoto2TaggedActorTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TaggedActorTarget>);
			}
			Offset<ITakePhoto2TargetCameraDistanceCondition> targetCameraDistanceConditionOffset = (_o.TargetCameraDistanceCondition == null) ? default(Offset<ITakePhoto2TargetCameraDistanceCondition>) : ITakePhoto2TargetCameraDistanceCondition.Pack(builder, _o.TargetCameraDistanceCondition);
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			Offset<ITakePhoto2TargetPosByRangeCondition> targetPosConditionOffset = (_o.TargetPosCondition == null) ? default(Offset<ITakePhoto2TargetPosByRangeCondition>) : ITakePhoto2TargetPosByRangeCondition.Pack(builder, _o.TargetPosCondition);
			return ITakePhoto2TaggedActorTarget.CreateITakePhoto2TaggedActorTarget(builder, _o.Type, _o.IsOptionalTarget, targetCameraDistanceConditionOffset, tagOffset, targetPosConditionOffset, _o.TargetSatisfiedCount, _o.NullMask);
		}

		// Token: 0x0400C7C2 RID: 51138
		private Table __p;
	}
}
