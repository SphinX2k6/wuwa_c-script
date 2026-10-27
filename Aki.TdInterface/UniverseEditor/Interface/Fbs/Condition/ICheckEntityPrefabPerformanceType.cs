using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A12 RID: 18962
	public struct ICheckEntityPrefabPerformanceType : IFlatbufferObject
	{
		// Token: 0x17008942 RID: 35138
		// (get) Token: 0x0601DAA1 RID: 121505 RVA: 0x0042C9B4 File Offset: 0x0042ABB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DAA2 RID: 121506 RVA: 0x0042C9C1 File Offset: 0x0042ABC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x0042C9C8 File Offset: 0x0042ABC8
		public static ICheckEntityPrefabPerformanceType GetRootAsICheckEntityPrefabPerformanceType(ByteBuffer _bb)
		{
			return ICheckEntityPrefabPerformanceType.GetRootAsICheckEntityPrefabPerformanceType(_bb, default(ICheckEntityPrefabPerformanceType));
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x0042C9E4 File Offset: 0x0042ABE4
		public static ICheckEntityPrefabPerformanceType GetRootAsICheckEntityPrefabPerformanceType(ByteBuffer _bb, ICheckEntityPrefabPerformanceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DAA5 RID: 121509 RVA: 0x0042CA01 File Offset: 0x0042AC01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAA6 RID: 121510 RVA: 0x0042CA10 File Offset: 0x0042AC10
		public ICheckEntityPrefabPerformanceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008943 RID: 35139
		// (get) Token: 0x0601DAA7 RID: 121511 RVA: 0x0042CA20 File Offset: 0x0042AC20
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008944 RID: 35140
		// (get) Token: 0x0601DAA8 RID: 121512 RVA: 0x0042CA5C File Offset: 0x0042AC5C
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008945 RID: 35141
		// (get) Token: 0x0601DAA9 RID: 121513 RVA: 0x0042CA98 File Offset: 0x0042AC98
		public string PerformanceTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DAAA RID: 121514 RVA: 0x0042CACF File Offset: 0x0042ACCF
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601DAAB RID: 121515 RVA: 0x0042CADE File Offset: 0x0042ACDE
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008946 RID: 35142
		// (get) Token: 0x0601DAAC RID: 121516 RVA: 0x0042CAEC File Offset: 0x0042ACEC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DAAD RID: 121517 RVA: 0x0042CB29 File Offset: 0x0042AD29
		public static Offset<ICheckEntityPrefabPerformanceType> CreateICheckEntityPrefabPerformanceType(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, StringOffset PerformanceTagOffset = default(StringOffset), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			ICheckEntityPrefabPerformanceType.AddPerformanceTag(builder, PerformanceTagOffset);
			ICheckEntityPrefabPerformanceType.AddEntityId(builder, EntityId);
			ICheckEntityPrefabPerformanceType.AddCompare(builder, Compare);
			ICheckEntityPrefabPerformanceType.AddType(builder, Type);
			return ICheckEntityPrefabPerformanceType.EndICheckEntityPrefabPerformanceType(builder);
		}

		// Token: 0x0601DAAE RID: 121518 RVA: 0x0042CB55 File Offset: 0x0042AD55
		public static void StartICheckEntityPrefabPerformanceType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DAAF RID: 121519 RVA: 0x0042CB5E File Offset: 0x0042AD5E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DAB0 RID: 121520 RVA: 0x0042CB69 File Offset: 0x0042AD69
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DAB1 RID: 121521 RVA: 0x0042CB74 File Offset: 0x0042AD74
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0601DAB2 RID: 121522 RVA: 0x0042CB84 File Offset: 0x0042AD84
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601DAB3 RID: 121523 RVA: 0x0042CB8F File Offset: 0x0042AD8F
		public static Offset<ICheckEntityPrefabPerformanceType> EndICheckEntityPrefabPerformanceType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityPrefabPerformanceType>(builder.EndTable());
		}

		// Token: 0x0601DAB4 RID: 121524 RVA: 0x0042CB9C File Offset: 0x0042AD9C
		public ICheckEntityPrefabPerformanceTypeT UnPack()
		{
			ICheckEntityPrefabPerformanceTypeT checkEntityPrefabPerformanceTypeT = new ICheckEntityPrefabPerformanceTypeT();
			this.UnPackTo(checkEntityPrefabPerformanceTypeT);
			return checkEntityPrefabPerformanceTypeT;
		}

		// Token: 0x0601DAB5 RID: 121525 RVA: 0x0042CBB7 File Offset: 0x0042ADB7
		public void UnPackTo(ICheckEntityPrefabPerformanceTypeT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PerformanceTag = this.PerformanceTag;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601DAB6 RID: 121526 RVA: 0x0042CBEC File Offset: 0x0042ADEC
		public static Offset<ICheckEntityPrefabPerformanceType> Pack(FlatBufferBuilder builder, ICheckEntityPrefabPerformanceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityPrefabPerformanceType>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return ICheckEntityPrefabPerformanceType.CreateICheckEntityPrefabPerformanceType(builder, _o.Type, _o.EntityId, performanceTagOffset, _o.Compare);
		}

		// Token: 0x0400D25C RID: 53852
		private Table __p;
	}
}
