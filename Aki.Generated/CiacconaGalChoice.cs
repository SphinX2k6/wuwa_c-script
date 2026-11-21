using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C59 RID: 3161
	public struct CiacconaGalChoice : IFlatbufferObject
	{
		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x002155A2 File Offset: 0x002137A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x002155AF File Offset: 0x002137AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x002155B8 File Offset: 0x002137B8
		public static CiacconaGalChoice GetRootAsCiacconaGalChoice(ByteBuffer _bb)
		{
			return CiacconaGalChoice.GetRootAsCiacconaGalChoice(_bb, default(CiacconaGalChoice));
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x002155D4 File Offset: 0x002137D4
		public static CiacconaGalChoice GetRootAsCiacconaGalChoice(ByteBuffer _bb, CiacconaGalChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x002155F1 File Offset: 0x002137F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x00215600 File Offset: 0x00213800
		public CiacconaGalChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x00215610 File Offset: 0x00213810
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x0021564C File Offset: 0x0021384C
		public string Content
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

		// Token: 0x06005B1D RID: 23325 RVA: 0x00215683 File Offset: 0x00213883
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x00215692 File Offset: 0x00213892
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x002156AC File Offset: 0x002138AC
		public int RequiredInspiration
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x002156E8 File Offset: 0x002138E8
		public int UnlockCondition
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06005B21 RID: 23329 RVA: 0x00215728 File Offset: 0x00213928
		public int ToStep
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x00215768 File Offset: 0x00213968
		public int CorrSubEnding
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

		// Token: 0x0400515D RID: 20829
		private Table __p;
	}
}
