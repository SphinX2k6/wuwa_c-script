using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758E RID: 30094
	public struct IRecordTimeStampType : IFlatbufferObject
	{
		// Token: 0x1700DD52 RID: 56658
		// (get) Token: 0x06034C94 RID: 216212 RVA: 0x007190F3 File Offset: 0x007172F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034C95 RID: 216213 RVA: 0x00719100 File Offset: 0x00717300
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034C96 RID: 216214 RVA: 0x00719108 File Offset: 0x00717308
		public static IRecordTimeStampType GetRootAsIRecordTimeStampType(ByteBuffer _bb)
		{
			return IRecordTimeStampType.GetRootAsIRecordTimeStampType(_bb, default(IRecordTimeStampType));
		}

		// Token: 0x06034C97 RID: 216215 RVA: 0x00719124 File Offset: 0x00717324
		public static IRecordTimeStampType GetRootAsIRecordTimeStampType(ByteBuffer _bb, IRecordTimeStampType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034C98 RID: 216216 RVA: 0x00719141 File Offset: 0x00717341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034C99 RID: 216217 RVA: 0x00719150 File Offset: 0x00717350
		public IRecordTimeStampType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD53 RID: 56659
		// (get) Token: 0x06034C9A RID: 216218 RVA: 0x00719160 File Offset: 0x00717360
		public EDungeonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonEventType.RecordTimeStamp;
				}
				return (EDungeonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DD54 RID: 56660
		// (get) Token: 0x06034C9B RID: 216219 RVA: 0x0071919C File Offset: 0x0071739C
		public ETimeStampType TimeStampType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETimeStampType.DungeonBegin;
				}
				return (ETimeStampType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034C9C RID: 216220 RVA: 0x007191D8 File Offset: 0x007173D8
		public static Offset<IRecordTimeStampType> CreateIRecordTimeStampType(FlatBufferBuilder builder, EDungeonEventType Type = EDungeonEventType.RecordTimeStamp, ETimeStampType TimeStampType = ETimeStampType.DungeonBegin)
		{
			builder.StartTable(2);
			IRecordTimeStampType.AddTimeStampType(builder, TimeStampType);
			IRecordTimeStampType.AddType(builder, Type);
			return IRecordTimeStampType.EndIRecordTimeStampType(builder);
		}

		// Token: 0x06034C9D RID: 216221 RVA: 0x007191F5 File Offset: 0x007173F5
		public static void StartIRecordTimeStampType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034C9E RID: 216222 RVA: 0x007191FE File Offset: 0x007173FE
		public static void AddType(FlatBufferBuilder builder, EDungeonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034C9F RID: 216223 RVA: 0x00719209 File Offset: 0x00717409
		public static void AddTimeStampType(FlatBufferBuilder builder, ETimeStampType timeStampType)
		{
			builder.AddByte(1, (byte)timeStampType, 0);
		}

		// Token: 0x06034CA0 RID: 216224 RVA: 0x00719214 File Offset: 0x00717414
		public static Offset<IRecordTimeStampType> EndIRecordTimeStampType(FlatBufferBuilder builder)
		{
			return new Offset<IRecordTimeStampType>(builder.EndTable());
		}

		// Token: 0x06034CA1 RID: 216225 RVA: 0x00719224 File Offset: 0x00717424
		public IRecordTimeStampTypeT UnPack()
		{
			IRecordTimeStampTypeT recordTimeStampTypeT = new IRecordTimeStampTypeT();
			this.UnPackTo(recordTimeStampTypeT);
			return recordTimeStampTypeT;
		}

		// Token: 0x06034CA2 RID: 216226 RVA: 0x0071923F File Offset: 0x0071743F
		public void UnPackTo(IRecordTimeStampTypeT _o)
		{
			_o.Type = this.Type;
			_o.TimeStampType = this.TimeStampType;
		}

		// Token: 0x06034CA3 RID: 216227 RVA: 0x0071925C File Offset: 0x0071745C
		public static Offset<IRecordTimeStampType> Pack(FlatBufferBuilder builder, IRecordTimeStampTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordTimeStampType>);
			}
			return IRecordTimeStampType.CreateIRecordTimeStampType(builder, _o.Type, _o.TimeStampType);
		}

		// Token: 0x04012777 RID: 75639
		private Table __p;
	}
}
