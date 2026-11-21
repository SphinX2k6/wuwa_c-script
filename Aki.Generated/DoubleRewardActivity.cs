using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDA RID: 3290
	public struct DoubleRewardActivity : IFlatbufferObject
	{
		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x002342A0 File Offset: 0x002324A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x002342AD File Offset: 0x002324AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x002342B4 File Offset: 0x002324B4
		public static DoubleRewardActivity GetRootAsDoubleRewardActivity(ByteBuffer _bb)
		{
			return DoubleRewardActivity.GetRootAsDoubleRewardActivity(_bb, default(DoubleRewardActivity));
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x002342D0 File Offset: 0x002324D0
		public static DoubleRewardActivity GetRootAsDoubleRewardActivity(ByteBuffer _bb, DoubleRewardActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x002342ED File Offset: 0x002324ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x002342FC File Offset: 0x002324FC
		public DoubleRewardActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x0023430C File Offset: 0x0023250C
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x00234348 File Offset: 0x00232548
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

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x00234384 File Offset: 0x00232584
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

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x002343C0 File Offset: 0x002325C0
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

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x00234400 File Offset: 0x00232600
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

		// Token: 0x060068C9 RID: 26825 RVA: 0x00234438 File Offset: 0x00232638
		public Span<byte> GetPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00234448 File Offset: 0x00232648
		public byte[] GetPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005207 RID: 20999
		private Table __p;
	}
}
