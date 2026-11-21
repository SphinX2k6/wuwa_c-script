using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD0 RID: 19664
	public struct IEditorSaviorSyncData : IFlatbufferObject
	{
		// Token: 0x17008C04 RID: 35844
		// (get) Token: 0x0601E4AD RID: 124077 RVA: 0x0043E68E File Offset: 0x0043C88E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4AE RID: 124078 RVA: 0x0043E69B File Offset: 0x0043C89B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4AF RID: 124079 RVA: 0x0043E6A4 File Offset: 0x0043C8A4
		public static IEditorSaviorSyncData GetRootAsIEditorSaviorSyncData(ByteBuffer _bb)
		{
			return IEditorSaviorSyncData.GetRootAsIEditorSaviorSyncData(_bb, default(IEditorSaviorSyncData));
		}

		// Token: 0x0601E4B0 RID: 124080 RVA: 0x0043E6C0 File Offset: 0x0043C8C0
		public static IEditorSaviorSyncData GetRootAsIEditorSaviorSyncData(ByteBuffer _bb, IEditorSaviorSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4B1 RID: 124081 RVA: 0x0043E6DD File Offset: 0x0043C8DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4B2 RID: 124082 RVA: 0x0043E6EC File Offset: 0x0043C8EC
		public IEditorSaviorSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C05 RID: 35845
		// (get) Token: 0x0601E4B3 RID: 124083 RVA: 0x0043E6FC File Offset: 0x0043C8FC
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

		// Token: 0x17008C06 RID: 35846
		// (get) Token: 0x0601E4B4 RID: 124084 RVA: 0x0043E738 File Offset: 0x0043C938
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

		// Token: 0x0601E4B5 RID: 124085 RVA: 0x0043E76F File Offset: 0x0043C96F
		public Span<byte> GetClientNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E4B6 RID: 124086 RVA: 0x0043E77E File Offset: 0x0043C97E
		public byte[] GetClientNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008C07 RID: 35847
		// (get) Token: 0x0601E4B7 RID: 124087 RVA: 0x0043E78C File Offset: 0x0043C98C
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

		// Token: 0x0601E4B8 RID: 124088 RVA: 0x0043E7C3 File Offset: 0x0043C9C3
		public Span<byte> GetClientRootBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E4B9 RID: 124089 RVA: 0x0043E7D2 File Offset: 0x0043C9D2
		public byte[] GetClientRootArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008C08 RID: 35848
		// (get) Token: 0x0601E4BA RID: 124090 RVA: 0x0043E7E0 File Offset: 0x0043C9E0
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

		// Token: 0x17008C09 RID: 35849
		// (get) Token: 0x0601E4BB RID: 124091 RVA: 0x0043E820 File Offset: 0x0043CA20
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

		// Token: 0x0601E4BC RID: 124092 RVA: 0x0043E85D File Offset: 0x0043CA5D
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

		// Token: 0x0601E4BD RID: 124093 RVA: 0x0043E891 File Offset: 0x0043CA91
		public static void StartIEditorSaviorSyncData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E4BE RID: 124094 RVA: 0x0043E89A File Offset: 0x0043CA9A
		public static void AddType(FlatBufferBuilder builder, EP4SyncMethodType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E4BF RID: 124095 RVA: 0x0043E8A5 File Offset: 0x0043CAA5
		public static void AddClientName(FlatBufferBuilder builder, StringOffset clientNameOffset)
		{
			builder.AddOffset(1, clientNameOffset.Value, 0);
		}

		// Token: 0x0601E4C0 RID: 124096 RVA: 0x0043E8B5 File Offset: 0x0043CAB5
		public static void AddClientRoot(FlatBufferBuilder builder, StringOffset clientRootOffset)
		{
			builder.AddOffset(2, clientRootOffset.Value, 0);
		}

		// Token: 0x0601E4C1 RID: 124097 RVA: 0x0043E8C5 File Offset: 0x0043CAC5
		public static void AddChangeNum(FlatBufferBuilder builder, int changeNum)
		{
			builder.AddInt(3, changeNum, 0);
		}

		// Token: 0x0601E4C2 RID: 124098 RVA: 0x0043E8D0 File Offset: 0x0043CAD0
		public static void AddTimestamp(FlatBufferBuilder builder, int timestamp)
		{
			builder.AddInt(4, timestamp, 0);
		}

		// Token: 0x0601E4C3 RID: 124099 RVA: 0x0043E8DB File Offset: 0x0043CADB
		public static Offset<IEditorSaviorSyncData> EndIEditorSaviorSyncData(FlatBufferBuilder builder)
		{
			return new Offset<IEditorSaviorSyncData>(builder.EndTable());
		}

		// Token: 0x0601E4C4 RID: 124100 RVA: 0x0043E8E8 File Offset: 0x0043CAE8
		public IEditorSaviorSyncDataT UnPack()
		{
			IEditorSaviorSyncDataT editorSaviorSyncDataT = new IEditorSaviorSyncDataT();
			this.UnPackTo(editorSaviorSyncDataT);
			return editorSaviorSyncDataT;
		}

		// Token: 0x0601E4C5 RID: 124101 RVA: 0x0043E903 File Offset: 0x0043CB03
		public void UnPackTo(IEditorSaviorSyncDataT _o)
		{
			_o.Type = this.Type;
			_o.ClientName = this.ClientName;
			_o.ClientRoot = this.ClientRoot;
			_o.ChangeNum = this.ChangeNum;
			_o.Timestamp = this.Timestamp;
		}

		// Token: 0x0601E4C6 RID: 124102 RVA: 0x0043E944 File Offset: 0x0043CB44
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

		// Token: 0x0400D82D RID: 55341
		private Table __p;
	}
}
