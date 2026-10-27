using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E13 RID: 28179
	public struct IRecordTimeStampType : IFlatbufferObject
	{
		// Token: 0x1700D20A RID: 53770
		// (get) Token: 0x06031C98 RID: 203928 RVA: 0x006BDA0B File Offset: 0x006BBC0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C99 RID: 203929 RVA: 0x006BDA18 File Offset: 0x006BBC18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C9A RID: 203930 RVA: 0x006BDA20 File Offset: 0x006BBC20
		public static IRecordTimeStampType GetRootAsIRecordTimeStampType(ByteBuffer _bb)
		{
			return IRecordTimeStampType.GetRootAsIRecordTimeStampType(_bb, default(IRecordTimeStampType));
		}

		// Token: 0x06031C9B RID: 203931 RVA: 0x006BDA3C File Offset: 0x006BBC3C
		public static IRecordTimeStampType GetRootAsIRecordTimeStampType(ByteBuffer _bb, IRecordTimeStampType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C9C RID: 203932 RVA: 0x006BDA59 File Offset: 0x006BBC59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C9D RID: 203933 RVA: 0x006BDA68 File Offset: 0x006BBC68
		public IRecordTimeStampType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D20B RID: 53771
		// (get) Token: 0x06031C9E RID: 203934 RVA: 0x006BDA78 File Offset: 0x006BBC78
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

		// Token: 0x1700D20C RID: 53772
		// (get) Token: 0x06031C9F RID: 203935 RVA: 0x006BDAB4 File Offset: 0x006BBCB4
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

		// Token: 0x06031CA0 RID: 203936 RVA: 0x006BDAF0 File Offset: 0x006BBCF0
		public static Offset<IRecordTimeStampType> CreateIRecordTimeStampType(FlatBufferBuilder builder, EDungeonEventType Type = EDungeonEventType.RecordTimeStamp, ETimeStampType TimeStampType = ETimeStampType.DungeonBegin)
		{
			builder.StartTable(2);
			IRecordTimeStampType.AddTimeStampType(builder, TimeStampType);
			IRecordTimeStampType.AddType(builder, Type);
			return IRecordTimeStampType.EndIRecordTimeStampType(builder);
		}

		// Token: 0x06031CA1 RID: 203937 RVA: 0x006BDB0D File Offset: 0x006BBD0D
		public static void StartIRecordTimeStampType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031CA2 RID: 203938 RVA: 0x006BDB16 File Offset: 0x006BBD16
		public static void AddType(FlatBufferBuilder builder, EDungeonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031CA3 RID: 203939 RVA: 0x006BDB21 File Offset: 0x006BBD21
		public static void AddTimeStampType(FlatBufferBuilder builder, ETimeStampType timeStampType)
		{
			builder.AddByte(1, (byte)timeStampType, 0);
		}

		// Token: 0x06031CA4 RID: 203940 RVA: 0x006BDB2C File Offset: 0x006BBD2C
		public static Offset<IRecordTimeStampType> EndIRecordTimeStampType(FlatBufferBuilder builder)
		{
			return new Offset<IRecordTimeStampType>(builder.EndTable());
		}

		// Token: 0x06031CA5 RID: 203941 RVA: 0x006BDB3C File Offset: 0x006BBD3C
		public IRecordTimeStampTypeT UnPack()
		{
			IRecordTimeStampTypeT recordTimeStampTypeT = new IRecordTimeStampTypeT();
			this.UnPackTo(recordTimeStampTypeT);
			return recordTimeStampTypeT;
		}

		// Token: 0x06031CA6 RID: 203942 RVA: 0x006BDB57 File Offset: 0x006BBD57
		public void UnPackTo(IRecordTimeStampTypeT _o)
		{
			_o.Type = this.Type;
			_o.TimeStampType = this.TimeStampType;
		}

		// Token: 0x06031CA7 RID: 203943 RVA: 0x006BDB74 File Offset: 0x006BBD74
		public static Offset<IRecordTimeStampType> Pack(FlatBufferBuilder builder, IRecordTimeStampTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordTimeStampType>);
			}
			return IRecordTimeStampType.CreateIRecordTimeStampType(builder, _o.Type, _o.TimeStampType);
		}

		// Token: 0x040117FB RID: 71675
		private Table __p;
	}
}
