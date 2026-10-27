using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3C RID: 3644
	public struct MotorFightAttrShow : IFlatbufferObject
	{
		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x060097CF RID: 38863 RVA: 0x0028D8E5 File Offset: 0x0028BAE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x0028D8F2 File Offset: 0x0028BAF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x0028D8FC File Offset: 0x0028BAFC
		public static MotorFightAttrShow GetRootAsMotorFightAttrShow(ByteBuffer _bb)
		{
			return MotorFightAttrShow.GetRootAsMotorFightAttrShow(_bb, default(MotorFightAttrShow));
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x0028D918 File Offset: 0x0028BB18
		public static MotorFightAttrShow GetRootAsMotorFightAttrShow(ByteBuffer _bb, MotorFightAttrShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x0028D935 File Offset: 0x0028BB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x0028D944 File Offset: 0x0028BB44
		public MotorFightAttrShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x060097D5 RID: 38869 RVA: 0x0028D954 File Offset: 0x0028BB54
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

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x060097D6 RID: 38870 RVA: 0x0028D990 File Offset: 0x0028BB90
		public int AttriId
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

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x060097D7 RID: 38871 RVA: 0x0028D9CC File Offset: 0x0028BBCC
		public string Name
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

		// Token: 0x060097D8 RID: 38872 RVA: 0x0028DA03 File Offset: 0x0028BC03
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x0028DA12 File Offset: 0x0028BC12
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x060097DA RID: 38874 RVA: 0x0028DA2C File Offset: 0x0028BC2C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x0028DA64 File Offset: 0x0028BC64
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0028DA74 File Offset: 0x0028BC74
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x060097DD RID: 38877 RVA: 0x0028DA8C File Offset: 0x0028BC8C
		public bool ShowInMainGun
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x060097DE RID: 38878 RVA: 0x0028DACC File Offset: 0x0028BCCC
		public bool ShowInWingman
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x060097DF RID: 38879 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		public bool ShowInCommon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x060097E0 RID: 38880 RVA: 0x0028DB4C File Offset: 0x0028BD4C
		public int SortId
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

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x060097E1 RID: 38881 RVA: 0x0028DB8C File Offset: 0x0028BD8C
		public int Ratio
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x060097E2 RID: 38882 RVA: 0x0028DBD0 File Offset: 0x0028BDD0
		public bool IsNeedPercentSign
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004EE4 RID: 20196
		private Table __p;
	}
}
