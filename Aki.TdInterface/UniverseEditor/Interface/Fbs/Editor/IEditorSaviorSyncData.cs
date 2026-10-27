using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200486B RID: 18539
	public struct IEditorSaviorSyncData : IFlatbufferObject
	{
		// Token: 0x170085BA RID: 34234
		// (get) Token: 0x0601CCBC RID: 117948 RVA: 0x00411DE6 File Offset: 0x0040FFE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CCBD RID: 117949 RVA: 0x00411DF3 File Offset: 0x0040FFF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CCBE RID: 117950 RVA: 0x00411DFC File Offset: 0x0040FFFC
		public static IEditorSaviorSyncData GetRootAsIEditorSaviorSyncData(ByteBuffer _bb)
		{
			return IEditorSaviorSyncData.GetRootAsIEditorSaviorSyncData(_bb, default(IEditorSaviorSyncData));
		}

		// Token: 0x0601CCBF RID: 117951 RVA: 0x00411E18 File Offset: 0x00410018
		public static IEditorSaviorSyncData GetRootAsIEditorSaviorSyncData(ByteBuffer _bb, IEditorSaviorSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CCC0 RID: 117952 RVA: 0x00411E35 File Offset: 0x00410035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CCC1 RID: 117953 RVA: 0x00411E44 File Offset: 0x00410044
		public IEditorSaviorSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085BB RID: 34235
		// (get) Token: 0x0601CCC2 RID: 117954 RVA: 0x00411E54 File Offset: 0x00410054
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

		// Token: 0x170085BC RID: 34236
		// (get) Token: 0x0601CCC3 RID: 117955 RVA: 0x00411E90 File Offset: 0x00410090
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

		// Token: 0x0601CCC4 RID: 117956 RVA: 0x00411EC7 File Offset: 0x004100C7
		public Span<byte> GetClientNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CCC5 RID: 117957 RVA: 0x00411ED6 File Offset: 0x004100D6
		public byte[] GetClientNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170085BD RID: 34237
		// (get) Token: 0x0601CCC6 RID: 117958 RVA: 0x00411EE4 File Offset: 0x004100E4
		public string ClientRoot
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

		// Token: 0x0601CCC7 RID: 117959 RVA: 0x00411F1B File Offset: 0x0041011B
		public Span<byte> GetClientRootBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CCC8 RID: 117960 RVA: 0x00411F2A File Offset: 0x0041012A
		public byte[] GetClientRootArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170085BE RID: 34238
		// (get) Token: 0x0601CCC9 RID: 117961 RVA: 0x00411F38 File Offset: 0x00410138
		public int ChangeNum
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

		// Token: 0x170085BF RID: 34239
		// (get) Token: 0x0601CCCA RID: 117962 RVA: 0x00411F78 File Offset: 0x00410178
		public int Timestamp
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CCCB RID: 117963 RVA: 0x00411FB5 File Offset: 0x004101B5
		public static Offset<IEditorSaviorSyncData> CreateIEditorSaviorSyncData(FlatBufferBuilder builder, EP4SyncMethodType Type = EP4SyncMethodType.EditorSavior, StringOffset ClientNameOffset = default(StringOffset), StringOffset ClientRootOffset = default(StringOffset), int ChangeNum = 0, int Timestamp = 0)
		{
			builder.StartTable(5);
			IEditorSaviorSyncData.AddTimestamp(builder, Timestamp);
			IEditorSaviorSyncData.AddChangeNum(builder, ChangeNum);
			IEditorSaviorSyncData.AddClientRoot(builder, ClientRootOffset);
			IEditorSaviorSyncData.AddClientName(builder, ClientNameOffset);
			IEditorSaviorSyncData.AddType(builder, Type);
			return IEditorSaviorSyncData.EndIEditorSaviorSyncData(builder);
		}

		// Token: 0x0601CCCC RID: 117964 RVA: 0x00411FE9 File Offset: 0x004101E9
		public static void StartIEditorSaviorSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601CCCD RID: 117965 RVA: 0x00411FF2 File Offset: 0x004101F2
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CCCE RID: 117966 RVA: 0x00411FFD File Offset: 0x004101FD
		public static void AddClientName(FlatBufferBuilder builder, StringOffset clientNameOffset)
		{
			builder.AddOffset(1, clientNameOffset.Value, 0);
		}

		// Token: 0x0601CCCF RID: 117967 RVA: 0x0041200D File Offset: 0x0041020D
		public static void AddClientRoot(FlatBufferBuilder builder, StringOffset clientRootOffset)
		{
			builder.AddOffset(2, clientRootOffset.Value, 0);
		}

		// Token: 0x0601CCD0 RID: 117968 RVA: 0x0041201D File Offset: 0x0041021D
		public static void AddChangeNum(FlatBufferBuilder builder, int changeNum)
		{
			builder.AddInt(3, changeNum, 0);
		}

		// Token: 0x0601CCD1 RID: 117969 RVA: 0x00412028 File Offset: 0x00410228
		public static void AddTimestamp(FlatBufferBuilder builder, int timestamp)
		{
			builder.AddInt(4, timestamp, 0);
		}

		// Token: 0x0601CCD2 RID: 117970 RVA: 0x00412033 File Offset: 0x00410233
		public static Offset<IEditorSaviorSyncData> EndIEditorSaviorSyncData(FlatBufferBuilder builder)
		{
			return new Offset<IEditorSaviorSyncData>(builder.EndTable());
		}

		// Token: 0x0601CCD3 RID: 117971 RVA: 0x00412040 File Offset: 0x00410240
		public IEditorSaviorSyncDataT UnPack()
		{
			IEditorSaviorSyncDataT editorSaviorSyncDataT = new IEditorSaviorSyncDataT();
			this.UnPackTo(editorSaviorSyncDataT);
			return editorSaviorSyncDataT;
		}

		// Token: 0x0601CCD4 RID: 117972 RVA: 0x0041205B File Offset: 0x0041025B
		public void UnPackTo(IEditorSaviorSyncDataT _o)
		{
			_o.Type = this.Type;
			_o.ClientName = this.ClientName;
			_o.ClientRoot = this.ClientRoot;
			_o.ChangeNum = this.ChangeNum;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601CCD5 RID: 117973 RVA: 0x0041209C File Offset: 0x0041029C
		public static Offset<IEditorSaviorSyncData> Pack(FlatBufferBuilder builder, IEditorSaviorSyncDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorSaviorSyncData>);
			}
			StringOffset clientNameOffset = (_o.ClientName == null) ? default(StringOffset) : builder.CreateString(_o.ClientName);
			StringOffset clientRootOffset = (_o.ClientRoot == null) ? default(StringOffset) : builder.CreateString(_o.ClientRoot);
			return IEditorSaviorSyncData.CreateIEditorSaviorSyncData(builder, _o.Type, clientNameOffset, clientRootOffset, _o.ChangeNum, _o.Timestamp);
		}

		// Token: 0x0400CDF3 RID: 52723
		private Table __p;
	}
}
