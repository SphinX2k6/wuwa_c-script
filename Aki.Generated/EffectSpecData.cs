using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D06 RID: 3334
	public struct EffectSpecData : IFlatbufferObject
	{
		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x0023F795 File Offset: 0x0023D995
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x0023F7A2 File Offset: 0x0023D9A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0023F7AC File Offset: 0x0023D9AC
		public static EffectSpecData GetRootAsEffectSpecData(ByteBuffer _bb)
		{
			return EffectSpecData.GetRootAsEffectSpecData(_bb, default(EffectSpecData));
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x0023F7C8 File Offset: 0x0023D9C8
		public static EffectSpecData GetRootAsEffectSpecData(ByteBuffer _bb, EffectSpecData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x0023F7E5 File Offset: 0x0023D9E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x0023F7F4 File Offset: 0x0023D9F4
		public EffectSpecData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x0023F804 File Offset: 0x0023DA04
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06006DA6 RID: 28070 RVA: 0x0023F840 File Offset: 0x0023DA40
		public int SpecType
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

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x0023F87C File Offset: 0x0023DA7C
		public int EffectRegularType
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

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06006DA8 RID: 28072 RVA: 0x0023F8B8 File Offset: 0x0023DAB8
		public int LifeTime
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

		// Token: 0x06006DA9 RID: 28073 RVA: 0x0023F8F8 File Offset: 0x0023DAF8
		public int Children(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x0023F938 File Offset: 0x0023DB38
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x0023F964 File Offset: 0x0023DB64
		public Span<int> GetChildrenBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x0023F974 File Offset: 0x0023DB74
		public int[] GetChildrenArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x0023F98C File Offset: 0x0023DB8C
		[NullableContext(1)]
		public int[] Children()
		{
			return this.GetChildrenArray();
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x0023F994 File Offset: 0x0023DB94
		[NullableContext(1)]
		public IEnumerable<int> ChildrenIter()
		{
			EffectSpecData.<ChildrenIter>d__22 <ChildrenIter>d__ = new EffectSpecData.<ChildrenIter>d__22(-2);
			<ChildrenIter>d__.<>3__<>4__this = this;
			return <ChildrenIter>d__;
		}

		// Token: 0x04005246 RID: 21062
		private Table __p;
	}
}
