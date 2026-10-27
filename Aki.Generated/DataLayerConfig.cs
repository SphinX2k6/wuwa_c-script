using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE2 RID: 3042
	public struct DataLayerConfig : IFlatbufferObject
	{
		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06006117 RID: 24855 RVA: 0x00210F95 File Offset: 0x0020F195
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00210FA2 File Offset: 0x0020F1A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00210FAC File Offset: 0x0020F1AC
		public static DataLayerConfig GetRootAsDataLayerConfig(ByteBuffer _bb)
		{
			return DataLayerConfig.GetRootAsDataLayerConfig(_bb, default(DataLayerConfig));
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x00210FC8 File Offset: 0x0020F1C8
		public static DataLayerConfig GetRootAsDataLayerConfig(ByteBuffer _bb, DataLayerConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x00210FE5 File Offset: 0x0020F1E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x00210FF4 File Offset: 0x0020F1F4
		public DataLayerConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x00211004 File Offset: 0x0020F204
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x00211040 File Offset: 0x0020F240
		public string DataLayer
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

		// Token: 0x0600611F RID: 24863 RVA: 0x00211077 File Offset: 0x0020F277
		public Span<byte> GetDataLayerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x00211086 File Offset: 0x0020F286
		public byte[] GetDataLayerArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06006121 RID: 24865 RVA: 0x002110A0 File Offset: 0x0020F2A0
		public string CnName
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

		// Token: 0x06006122 RID: 24866 RVA: 0x002110D7 File Offset: 0x0020F2D7
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x002110E6 File Offset: 0x0020F2E6
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x00211100 File Offset: 0x0020F300
		public int LevelId
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x00211140 File Offset: 0x0020F340
		public bool InitLoad
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06006126 RID: 24870 RVA: 0x00211180 File Offset: 0x0020F380
		public bool OnlyActor
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x002111C0 File Offset: 0x0020F3C0
		public bool EnableSwitchNavMesh
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004C0F RID: 19471
		private Table __p;
	}
}
