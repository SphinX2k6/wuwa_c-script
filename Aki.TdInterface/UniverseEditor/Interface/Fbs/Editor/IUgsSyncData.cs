using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BC RID: 18620
	public struct IUgsSyncData : IFlatbufferObject
	{
		// Token: 0x1700870A RID: 34570
		// (get) Token: 0x0601D146 RID: 119110 RVA: 0x0041B1BC File Offset: 0x004193BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x0041B1C9 File Offset: 0x004193C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D148 RID: 119112 RVA: 0x0041B1D0 File Offset: 0x004193D0
		public static IUgsSyncData GetRootAsIUgsSyncData(ByteBuffer _bb)
		{
			return IUgsSyncData.GetRootAsIUgsSyncData(_bb, default(IUgsSyncData));
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x0041B1EC File Offset: 0x004193EC
		public static IUgsSyncData GetRootAsIUgsSyncData(ByteBuffer _bb, IUgsSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x0041B209 File Offset: 0x00419409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D14B RID: 119115 RVA: 0x0041B218 File Offset: 0x00419418
		public IUgsSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700870B RID: 34571
		// (get) Token: 0x0601D14C RID: 119116 RVA: 0x0041B228 File Offset: 0x00419428
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

		// Token: 0x1700870C RID: 34572
		// (get) Token: 0x0601D14D RID: 119117 RVA: 0x0041B264 File Offset: 0x00419464
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

		// Token: 0x0601D14E RID: 119118 RVA: 0x0041B29B File Offset: 0x0041949B
		public Span<byte> GetClientNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D14F RID: 119119 RVA: 0x0041B2AA File Offset: 0x004194AA
		public byte[] GetClientNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700870D RID: 34573
		// (get) Token: 0x0601D150 RID: 119120 RVA: 0x0041B2B8 File Offset: 0x004194B8
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

		// Token: 0x0601D151 RID: 119121 RVA: 0x0041B2EF File Offset: 0x004194EF
		public Span<byte> GetStreamNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D152 RID: 119122 RVA: 0x0041B2FE File Offset: 0x004194FE
		public byte[] GetStreamNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700870E RID: 34574
		// (get) Token: 0x0601D153 RID: 119123 RVA: 0x0041B30C File Offset: 0x0041950C
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

		// Token: 0x1700870F RID: 34575
		// (get) Token: 0x0601D154 RID: 119124 RVA: 0x0041B34C File Offset: 0x0041954C
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

		// Token: 0x0601D155 RID: 119125 RVA: 0x0041B384 File Offset: 0x00419584
		public Span<byte> GetLastSyncTimeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601D156 RID: 119126 RVA: 0x0041B394 File Offset: 0x00419594
		public byte[] GetLastSyncTimeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008710 RID: 34576
		// (get) Token: 0x0601D157 RID: 119127 RVA: 0x0041B3A4 File Offset: 0x004195A4
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

		// Token: 0x0601D158 RID: 119128 RVA: 0x0041B3E1 File Offset: 0x004195E1
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

		// Token: 0x0601D159 RID: 119129 RVA: 0x0041B41D File Offset: 0x0041961D
		public static void StartIUgsSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601D15A RID: 119130 RVA: 0x0041B426 File Offset: 0x00419626
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D15B RID: 119131 RVA: 0x0041B431 File Offset: 0x00419631
		public static void AddClientName(FlatBufferBuilder builder, StringOffset clientNameOffset)
		{
			builder.AddOffset(1, clientNameOffset.Value, 0);
		}

		// Token: 0x0601D15C RID: 119132 RVA: 0x0041B441 File Offset: 0x00419641
		public static void AddStreamName(FlatBufferBuilder builder, StringOffset streamNameOffset)
		{
			builder.AddOffset(2, streamNameOffset.Value, 0);
		}

		// Token: 0x0601D15D RID: 119133 RVA: 0x0041B451 File Offset: 0x00419651
		public static void AddCurrentChangeNumber(FlatBufferBuilder builder, int currentChangeNumber)
		{
			builder.AddInt(3, currentChangeNumber, 0);
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x0041B45C File Offset: 0x0041965C
		public static void AddLastSyncTime(FlatBufferBuilder builder, StringOffset lastSyncTimeOffset)
		{
			builder.AddOffset(4, lastSyncTimeOffset.Value, 0);
		}

		// Token: 0x0601D15F RID: 119135 RVA: 0x0041B46C File Offset: 0x0041966C
		public static void AddTimestamp(FlatBufferBuilder builder, int timestamp)
		{
			builder.AddInt(5, timestamp, 0);
		}

		// Token: 0x0601D160 RID: 119136 RVA: 0x0041B477 File Offset: 0x00419677
		public static Offset<IUgsSyncData> EndIUgsSyncData(FlatBufferBuilder builder)
		{
			return new Offset<IUgsSyncData>(builder.EndTable());
		}

		// Token: 0x0601D161 RID: 119137 RVA: 0x0041B484 File Offset: 0x00419684
		public IUgsSyncDataT UnPack()
		{
			IUgsSyncDataT ugsSyncDataT = new IUgsSyncDataT();
			this.UnPackTo(ugsSyncDataT);
			return ugsSyncDataT;
		}

		// Token: 0x0601D162 RID: 119138 RVA: 0x0041B4A0 File Offset: 0x004196A0
		public void UnPackTo(IUgsSyncDataT _o)
		{
			_o.Type = this.Type;
			_o.ClientName = this.ClientName;
			_o.StreamName = this.StreamName;
			_o.CurrentChangeNumber = this.CurrentChangeNumber;
			_o.LastSyncTime = this.LastSyncTime;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601D163 RID: 119139 RVA: 0x0041B4F8 File Offset: 0x004196F8
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

		// Token: 0x0400CEB2 RID: 52914
		private Table __p;
	}
}
