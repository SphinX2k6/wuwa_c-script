using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D21 RID: 19745
	public struct IUgsSyncData : IFlatbufferObject
	{
		// Token: 0x17008D52 RID: 36178
		// (get) Token: 0x0601E933 RID: 125235 RVA: 0x00447958 File Offset: 0x00445B58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E934 RID: 125236 RVA: 0x00447965 File Offset: 0x00445B65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E935 RID: 125237 RVA: 0x0044796C File Offset: 0x00445B6C
		public static IUgsSyncData GetRootAsIUgsSyncData(ByteBuffer _bb)
		{
			return IUgsSyncData.GetRootAsIUgsSyncData(_bb, default(IUgsSyncData));
		}

		// Token: 0x0601E936 RID: 125238 RVA: 0x00447988 File Offset: 0x00445B88
		public static IUgsSyncData GetRootAsIUgsSyncData(ByteBuffer _bb, IUgsSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E937 RID: 125239 RVA: 0x004479A5 File Offset: 0x00445BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E938 RID: 125240 RVA: 0x004479B4 File Offset: 0x00445BB4
		public IUgsSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D53 RID: 36179
		// (get) Token: 0x0601E939 RID: 125241 RVA: 0x004479C4 File Offset: 0x00445BC4
		public EP4SyncMethodType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EP4SyncMethodType.EditorSavior;
				}
				return (EP4SyncMethodType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D54 RID: 36180
		// (get) Token: 0x0601E93A RID: 125242 RVA: 0x00447A00 File Offset: 0x00445C00
		public string ClientName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E93B RID: 125243 RVA: 0x00447A37 File Offset: 0x00445C37
		public Span<byte> GetClientNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E93C RID: 125244 RVA: 0x00447A46 File Offset: 0x00445C46
		public byte[] GetClientNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D55 RID: 36181
		// (get) Token: 0x0601E93D RID: 125245 RVA: 0x00447A54 File Offset: 0x00445C54
		public string StreamName
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

		// Token: 0x0601E93E RID: 125246 RVA: 0x00447A8B File Offset: 0x00445C8B
		public Span<byte> GetStreamNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E93F RID: 125247 RVA: 0x00447A9A File Offset: 0x00445C9A
		public byte[] GetStreamNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008D56 RID: 36182
		// (get) Token: 0x0601E940 RID: 125248 RVA: 0x00447AA8 File Offset: 0x00445CA8
		public int CurrentChangeNumber
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D57 RID: 36183
		// (get) Token: 0x0601E941 RID: 125249 RVA: 0x00447AE8 File Offset: 0x00445CE8
		public string LastSyncTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E942 RID: 125250 RVA: 0x00447B20 File Offset: 0x00445D20
		public Span<byte> GetLastSyncTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601E943 RID: 125251 RVA: 0x00447B30 File Offset: 0x00445D30
		public byte[] GetLastSyncTimeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008D58 RID: 36184
		// (get) Token: 0x0601E944 RID: 125252 RVA: 0x00447B40 File Offset: 0x00445D40
		public int Timestamp
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

		// Token: 0x0601E945 RID: 125253 RVA: 0x00447B7D File Offset: 0x00445D7D
		public static Offset<IUgsSyncData> CreateIUgsSyncData(FlatBufferBuilder builder, EP4SyncMethodType Type = EP4SyncMethodType.EditorSavior, StringOffset ClientNameOffset = default(StringOffset), StringOffset StreamNameOffset = default(StringOffset), int CurrentChangeNumber = 0, StringOffset LastSyncTimeOffset = default(StringOffset), int Timestamp = 0)
		{
			builder.StartTable(6);
			IUgsSyncData.AddTimestamp(builder, Timestamp);
			IUgsSyncData.AddLastSyncTime(builder, LastSyncTimeOffset);
			IUgsSyncData.AddCurrentChangeNumber(builder, CurrentChangeNumber);
			IUgsSyncData.AddStreamName(builder, StreamNameOffset);
			IUgsSyncData.AddClientName(builder, ClientNameOffset);
			IUgsSyncData.AddType(builder, Type);
			return IUgsSyncData.EndIUgsSyncData(builder);
		}

		// Token: 0x0601E946 RID: 125254 RVA: 0x00447BB9 File Offset: 0x00445DB9
		public static void StartIUgsSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601E947 RID: 125255 RVA: 0x00447BC2 File Offset: 0x00445DC2
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E948 RID: 125256 RVA: 0x00447BCD File Offset: 0x00445DCD
		public static void AddClientName(FlatBufferBuilder builder, StringOffset clientNameOffset)
		{
			builder.AddOffset(1, clientNameOffset.Value, 0);
		}

		// Token: 0x0601E949 RID: 125257 RVA: 0x00447BDD File Offset: 0x00445DDD
		public static void AddStreamName(FlatBufferBuilder builder, StringOffset streamNameOffset)
		{
			builder.AddOffset(2, streamNameOffset.Value, 0);
		}

		// Token: 0x0601E94A RID: 125258 RVA: 0x00447BED File Offset: 0x00445DED
		public static void AddCurrentChangeNumber(FlatBufferBuilder builder, int currentChangeNumber)
		{
			builder.AddInt(3, currentChangeNumber, 0);
		}

		// Token: 0x0601E94B RID: 125259 RVA: 0x00447BF8 File Offset: 0x00445DF8
		public static void AddLastSyncTime(FlatBufferBuilder builder, StringOffset lastSyncTimeOffset)
		{
			builder.AddOffset(4, lastSyncTimeOffset.Value, 0);
		}

		// Token: 0x0601E94C RID: 125260 RVA: 0x00447C08 File Offset: 0x00445E08
		public static void AddTimestamp(FlatBufferBuilder builder, int timestamp)
		{
			builder.AddInt(5, timestamp, 0);
		}

		// Token: 0x0601E94D RID: 125261 RVA: 0x00447C13 File Offset: 0x00445E13
		public static Offset<IUgsSyncData> EndIUgsSyncData(FlatBufferBuilder builder)
		{
			return new Offset<IUgsSyncData>(builder.EndTable());
		}

		// Token: 0x0601E94E RID: 125262 RVA: 0x00447C20 File Offset: 0x00445E20
		public IUgsSyncDataT UnPack()
		{
			IUgsSyncDataT ugsSyncDataT = new IUgsSyncDataT();
			this.UnPackTo(ugsSyncDataT);
			return ugsSyncDataT;
		}

		// Token: 0x0601E94F RID: 125263 RVA: 0x00447C3C File Offset: 0x00445E3C
		public void UnPackTo(IUgsSyncDataT _o)
		{
			_o.Type = this.Type;
			_o.ClientName = this.ClientName;
			_o.StreamName = this.StreamName;
			_o.CurrentChangeNumber = this.CurrentChangeNumber;
			_o.LastSyncTime = this.LastSyncTime;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601E950 RID: 125264 RVA: 0x00447C94 File Offset: 0x00445E94
		public static Offset<IUgsSyncData> Pack(FlatBufferBuilder builder, IUgsSyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUgsSyncData>);
			}
			StringOffset clientNameOffset = (_o.ClientName == null) ? default(StringOffset) : builder.CreateString(_o.ClientName);
			StringOffset streamNameOffset = (_o.StreamName == null) ? default(StringOffset) : builder.CreateString(_o.StreamName);
			StringOffset lastSyncTimeOffset = (_o.LastSyncTime == null) ? default(StringOffset) : builder.CreateString(_o.LastSyncTime);
			return IUgsSyncData.CreateIUgsSyncData(builder, _o.Type, clientNameOffset, streamNameOffset, _o.CurrentChangeNumber, lastSyncTimeOffset, _o.Timestamp);
		}

		// Token: 0x0400D8EB RID: 55531
		private Table __p;
	}
}
