using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE4 RID: 3556
	public struct GiantTotalProgress : IFlatbufferObject
	{
		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x060080C5 RID: 32965 RVA: 0x0026A544 File Offset: 0x00268744
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x0026A551 File Offset: 0x00268751
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x0026A558 File Offset: 0x00268758
		public static GiantTotalProgress GetRootAsGiantTotalProgress(ByteBuffer _bb)
		{
			return GiantTotalProgress.GetRootAsGiantTotalProgress(_bb, default(GiantTotalProgress));
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x0026A574 File Offset: 0x00268774
		public static GiantTotalProgress GetRootAsGiantTotalProgress(ByteBuffer _bb, GiantTotalProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x0026A591 File Offset: 0x00268791
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x0026A5A0 File Offset: 0x002687A0
		public GiantTotalProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x060080CB RID: 32971 RVA: 0x0026A5B0 File Offset: 0x002687B0
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

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x060080CC RID: 32972 RVA: 0x0026A5EC File Offset: 0x002687EC
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

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x0026A628 File Offset: 0x00268828
		public int Goal
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

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x060080CE RID: 32974 RVA: 0x0026A664 File Offset: 0x00268864
		public int DropId
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

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x0026A6A4 File Offset: 0x002688A4
		public string AttitudeDesc
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

		// Token: 0x060080D0 RID: 32976 RVA: 0x0026A6DC File Offset: 0x002688DC
		public Span<byte> GetAttitudeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x0026A6EC File Offset: 0x002688EC
		public byte[] GetAttitudeDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x060080D2 RID: 32978 RVA: 0x0026A704 File Offset: 0x00268904
		public string AssistDesc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x0026A73C File Offset: 0x0026893C
		public Span<byte> GetAssistDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x0026A74C File Offset: 0x0026894C
		public byte[] GetAssistDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x0026A764 File Offset: 0x00268964
		public string NodeDesc
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

		// Token: 0x060080D6 RID: 32982 RVA: 0x0026A79C File Offset: 0x0026899C
		public Span<byte> GetNodeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x0026A7AC File Offset: 0x002689AC
		public byte[] GetNodeDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005358 RID: 21336
		private Table __p;
	}
}
