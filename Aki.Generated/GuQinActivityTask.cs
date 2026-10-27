using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D20 RID: 3360
	public struct GuQinActivityTask : IFlatbufferObject
	{
		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06007DA7 RID: 32167 RVA: 0x002524C1 File Offset: 0x002506C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x002524CE File Offset: 0x002506CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x002524D8 File Offset: 0x002506D8
		public static GuQinActivityTask GetRootAsGuQinActivityTask(ByteBuffer _bb)
		{
			return GuQinActivityTask.GetRootAsGuQinActivityTask(_bb, default(GuQinActivityTask));
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x002524F4 File Offset: 0x002506F4
		public static GuQinActivityTask GetRootAsGuQinActivityTask(ByteBuffer _bb, GuQinActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x00252511 File Offset: 0x00250711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x00252520 File Offset: 0x00250720
		public GuQinActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x00252530 File Offset: 0x00250730
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

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0025256C File Offset: 0x0025076C
		public int ActivityId
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

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x002525A8 File Offset: 0x002507A8
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x002525E4 File Offset: 0x002507E4
		public int OpenDay
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

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x00252624 File Offset: 0x00250824
		public int NodeId
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

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x00252664 File Offset: 0x00250864
		public int PreQuestId
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

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x002526A4 File Offset: 0x002508A4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x002526DC File Offset: 0x002508DC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x002526EC File Offset: 0x002508EC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x00252704 File Offset: 0x00250904
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DB7 RID: 32183 RVA: 0x0025273C File Offset: 0x0025093C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x0025274C File Offset: 0x0025094C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x00252764 File Offset: 0x00250964
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x0025279C File Offset: 0x0025099C
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007DBB RID: 32187 RVA: 0x002527AC File Offset: 0x002509AC
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06007DBC RID: 32188 RVA: 0x002527C4 File Offset: 0x002509C4
		public string TabNumTxt
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x002527FC File Offset: 0x002509FC
		public Span<byte> GetTabNumTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0025280C File Offset: 0x00250A0C
		public byte[] GetTabNumTxtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x00252824 File Offset: 0x00250A24
		public string TabNumTexturePath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0025285C File Offset: 0x00250A5C
		public Span<byte> GetTabNumTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x0025286C File Offset: 0x00250A6C
		public byte[] GetTabNumTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x00252884 File Offset: 0x00250A84
		public string TabBgPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x002528BC File Offset: 0x00250ABC
		public Span<byte> GetTabBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x002528CC File Offset: 0x00250ACC
		public byte[] GetTabBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x002528E4 File Offset: 0x00250AE4
		public string FemaleTabBgPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x0025291C File Offset: 0x00250B1C
		public Span<byte> GetFemaleTabBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x0025292C File Offset: 0x00250B2C
		public byte[] GetFemaleTabBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06007DC8 RID: 32200 RVA: 0x00252944 File Offset: 0x00250B44
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D98 RID: 19864
		private Table __p;
	}
}
