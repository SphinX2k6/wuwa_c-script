using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B61 RID: 2913
	public struct CatchSignalDifficulty : IFlatbufferObject
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x001EF6F1 File Offset: 0x001ED8F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x001EF6FE File Offset: 0x001ED8FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x001EF708 File Offset: 0x001ED908
		public static CatchSignalDifficulty GetRootAsCatchSignalDifficulty(ByteBuffer _bb)
		{
			return CatchSignalDifficulty.GetRootAsCatchSignalDifficulty(_bb, default(CatchSignalDifficulty));
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x001EF724 File Offset: 0x001ED924
		public static CatchSignalDifficulty GetRootAsCatchSignalDifficulty(ByteBuffer _bb, CatchSignalDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x001EF741 File Offset: 0x001ED941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x001EF750 File Offset: 0x001ED950
		public CatchSignalDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x001EF760 File Offset: 0x001ED960
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x001EF79C File Offset: 0x001ED99C
		public string Name
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

		// Token: 0x0600526F RID: 21103 RVA: 0x001EF7D3 File Offset: 0x001ED9D3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x001EF7E2 File Offset: 0x001ED9E2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x001EF7FC File Offset: 0x001ED9FC
		public float SpeedRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x001EF83C File Offset: 0x001EDA3C
		public int TapTimeWindow
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x001EF87C File Offset: 0x001EDA7C
		public int PressTimeWindow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x001EF8BC File Offset: 0x001EDABC
		public int ReleaseTimeWindow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x001EF8FC File Offset: 0x001EDAFC
		public int TargetCompletion
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 80;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B61 RID: 19297
		private Table __p;
	}
}
