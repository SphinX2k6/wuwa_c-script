using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF8 RID: 3064
	public struct DoubleRewardActivity : IFlatbufferObject
	{
		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060062E0 RID: 25312 RVA: 0x00214BE8 File Offset: 0x00212DE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x00214BF5 File Offset: 0x00212DF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00214BFC File Offset: 0x00212DFC
		public static DoubleRewardActivity GetRootAsDoubleRewardActivity(ByteBuffer _bb)
		{
			return DoubleRewardActivity.GetRootAsDoubleRewardActivity(_bb, default(DoubleRewardActivity));
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x00214C18 File Offset: 0x00212E18
		public static DoubleRewardActivity GetRootAsDoubleRewardActivity(ByteBuffer _bb, DoubleRewardActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00214C35 File Offset: 0x00212E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x00214C44 File Offset: 0x00212E44
		public DoubleRewardActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x00214C54 File Offset: 0x00212E54
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

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x00214C90 File Offset: 0x00212E90
		public int Type
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060062E8 RID: 25320 RVA: 0x00214CCC File Offset: 0x00212ECC
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x00214D08 File Offset: 0x00212F08
		public int UpRate
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x060062EA RID: 25322 RVA: 0x00214D48 File Offset: 0x00212F48
		public string Prefab
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

		// Token: 0x060062EB RID: 25323 RVA: 0x00214D80 File Offset: 0x00212F80
		public Span<byte> GetPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x00214D90 File Offset: 0x00212F90
		public byte[] GetPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C25 RID: 19493
		private Table __p;
	}
}
