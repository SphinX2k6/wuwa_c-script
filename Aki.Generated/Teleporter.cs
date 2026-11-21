using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001250 RID: 4688
	public struct Teleporter : IFlatbufferObject
	{
		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x00355698 File Offset: 0x00353898
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x003556A5 File Offset: 0x003538A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x003556AC File Offset: 0x003538AC
		public static Teleporter GetRootAsTeleporter(ByteBuffer _bb)
		{
			return Teleporter.GetRootAsTeleporter(_bb, default(Teleporter));
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x003556C8 File Offset: 0x003538C8
		public static Teleporter GetRootAsTeleporter(ByteBuffer _bb, Teleporter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x003556E5 File Offset: 0x003538E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x003556F4 File Offset: 0x003538F4
		public Teleporter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x00355704 File Offset: 0x00353904
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

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600EA8E RID: 60046 RVA: 0x00355740 File Offset: 0x00353940
		public int MapId
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

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x0035577C File Offset: 0x0035397C
		public int ObjectId
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

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600EA90 RID: 60048 RVA: 0x003557B8 File Offset: 0x003539B8
		public int FogId
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

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x003557F8 File Offset: 0x003539F8
		public int Type
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

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600EA92 RID: 60050 RVA: 0x00355838 File Offset: 0x00353A38
		public int TeleportEntityConfigId
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

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x00355878 File Offset: 0x00353A78
		public string Plot
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

		// Token: 0x0600EA94 RID: 60052 RVA: 0x003558B0 File Offset: 0x00353AB0
		public Span<byte> GetPlotBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x003558C0 File Offset: 0x00353AC0
		public byte[] GetPlotArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600EA96 RID: 60054 RVA: 0x003558D8 File Offset: 0x00353AD8
		public int AfterNetworkAction
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x00355918 File Offset: 0x00353B18
		public bool ShowWorldMap
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400589A RID: 22682
		private Table __p;
	}
}
