using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F02 RID: 16130
	public struct ILevelPlayRecallData : IFlatbufferObject
	{
		// Token: 0x17006FE2 RID: 28642
		// (get) Token: 0x06016D52 RID: 93522 RVA: 0x0034AFA3 File Offset: 0x003491A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x0034AFB0 File Offset: 0x003491B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x0034AFB8 File Offset: 0x003491B8
		public static ILevelPlayRecallData GetRootAsILevelPlayRecallData(ByteBuffer _bb)
		{
			return ILevelPlayRecallData.GetRootAsILevelPlayRecallData(_bb, default(ILevelPlayRecallData));
		}

		// Token: 0x06016D55 RID: 93525 RVA: 0x0034AFD4 File Offset: 0x003491D4
		public static ILevelPlayRecallData GetRootAsILevelPlayRecallData(ByteBuffer _bb, ILevelPlayRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D56 RID: 93526 RVA: 0x0034AFF1 File Offset: 0x003491F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D57 RID: 93527 RVA: 0x0034B000 File Offset: 0x00349200
		public ILevelPlayRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FE3 RID: 28643
		// (get) Token: 0x06016D58 RID: 93528 RVA: 0x0034B010 File Offset: 0x00349210
		public ERecallDataType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallDataType.LevelPlay;
				}
				return (ERecallDataType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006FE4 RID: 28644
		// (get) Token: 0x06016D59 RID: 93529 RVA: 0x0034B04C File Offset: 0x0034924C
		public int Id
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

		// Token: 0x17006FE5 RID: 28645
		// (get) Token: 0x06016D5A RID: 93530 RVA: 0x0034B088 File Offset: 0x00349288
		public ILevelPlayRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILevelPlayRecallConfig?(default(ILevelPlayRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016D5B RID: 93531 RVA: 0x0034B0E5 File Offset: 0x003492E5
		public static Offset<ILevelPlayRecallData> CreateILevelPlayRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0, Offset<ILevelPlayRecallConfig> RecallConfigOffset = default(Offset<ILevelPlayRecallConfig>))
		{
			builder.StartTable(3);
			ILevelPlayRecallData.AddRecallConfig(builder, RecallConfigOffset);
			ILevelPlayRecallData.AddId(builder, Id);
			ILevelPlayRecallData.AddType(builder, Type);
			return ILevelPlayRecallData.EndILevelPlayRecallData(builder);
		}

		// Token: 0x06016D5C RID: 93532 RVA: 0x0034B109 File Offset: 0x00349309
		public static void StartILevelPlayRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016D5D RID: 93533 RVA: 0x0034B112 File Offset: 0x00349312
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016D5E RID: 93534 RVA: 0x0034B11D File Offset: 0x0034931D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06016D5F RID: 93535 RVA: 0x0034B128 File Offset: 0x00349328
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<ILevelPlayRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(2, recallConfigOffset.Value, 0);
		}

		// Token: 0x06016D60 RID: 93536 RVA: 0x0034B138 File Offset: 0x00349338
		public static Offset<ILevelPlayRecallData> EndILevelPlayRecallData(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRecallData>(builder.EndTable());
		}

		// Token: 0x06016D61 RID: 93537 RVA: 0x0034B148 File Offset: 0x00349348
		public ILevelPlayRecallDataT UnPack()
		{
			ILevelPlayRecallDataT levelPlayRecallDataT = new ILevelPlayRecallDataT();
			this.UnPackTo(levelPlayRecallDataT);
			return levelPlayRecallDataT;
		}

		// Token: 0x06016D62 RID: 93538 RVA: 0x0034B164 File Offset: 0x00349364
		public void UnPackTo(ILevelPlayRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
		}

		// Token: 0x06016D63 RID: 93539 RVA: 0x0034B1B8 File Offset: 0x003493B8
		public static Offset<ILevelPlayRecallData> Pack(FlatBufferBuilder builder, ILevelPlayRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRecallData>);
			}
			Offset<ILevelPlayRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<ILevelPlayRecallConfig>) : ILevelPlayRecallConfig.Pack(builder, _o.RecallConfig);
			return ILevelPlayRecallData.CreateILevelPlayRecallData(builder, _o.Type, _o.Id, recallConfigOffset);
		}

		// Token: 0x0400B8DF RID: 47327
		private Table __p;
	}
}
