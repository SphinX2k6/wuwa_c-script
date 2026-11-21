using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAE RID: 3502
	public struct FoleySynthConfig : IFlatbufferObject
	{
		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06007C53 RID: 31827 RVA: 0x00260951 File Offset: 0x0025EB51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x0026095E File Offset: 0x0025EB5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00260968 File Offset: 0x0025EB68
		public static FoleySynthConfig GetRootAsFoleySynthConfig(ByteBuffer _bb)
		{
			return FoleySynthConfig.GetRootAsFoleySynthConfig(_bb, default(FoleySynthConfig));
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00260984 File Offset: 0x0025EB84
		public static FoleySynthConfig GetRootAsFoleySynthConfig(ByteBuffer _bb, FoleySynthConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x002609A1 File Offset: 0x0025EBA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x002609B0 File Offset: 0x0025EBB0
		public FoleySynthConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x002609C0 File Offset: 0x0025EBC0
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

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x002609FC File Offset: 0x0025EBFC
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

		// Token: 0x06007C5B RID: 31835 RVA: 0x00260A33 File Offset: 0x0025EC33
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00260A42 File Offset: 0x0025EC42
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00260A5C File Offset: 0x0025EC5C
		public int Model1Config(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06007C5E RID: 31838 RVA: 0x00260A9C File Offset: 0x0025EC9C
		public int Model1ConfigLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00260AC7 File Offset: 0x0025ECC7
		public Span<int> GetModel1ConfigBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00260AD6 File Offset: 0x0025ECD6
		public int[] GetModel1ConfigArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x00260AF0 File Offset: 0x0025ECF0
		public int Model2Config(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x00260B30 File Offset: 0x0025ED30
		public int Model2ConfigLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x00260B5C File Offset: 0x0025ED5C
		public Span<int> GetModel2ConfigBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00260B6C File Offset: 0x0025ED6C
		public int[] GetModel2ConfigArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x00260B84 File Offset: 0x0025ED84
		public int Model2AccMaxCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06007C66 RID: 31846 RVA: 0x00260BC4 File Offset: 0x0025EDC4
		public int Model2VelMaxCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x00260C01 File Offset: 0x0025EE01
		[NullableContext(1)]
		public int[] Model1Config()
		{
			return this.GetModel1ConfigArray();
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x00260C09 File Offset: 0x0025EE09
		[NullableContext(1)]
		public IEnumerable<int> Model1ConfigIter()
		{
			FoleySynthConfig.<Model1ConfigIter>d__29 <Model1ConfigIter>d__ = new FoleySynthConfig.<Model1ConfigIter>d__29(-2);
			<Model1ConfigIter>d__.<>3__<>4__this = this;
			return <Model1ConfigIter>d__;
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x00260C1E File Offset: 0x0025EE1E
		[NullableContext(1)]
		public int[] Model2Config()
		{
			return this.GetModel2ConfigArray();
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x00260C26 File Offset: 0x0025EE26
		[NullableContext(1)]
		public IEnumerable<int> Model2ConfigIter()
		{
			FoleySynthConfig.<Model2ConfigIter>d__31 <Model2ConfigIter>d__ = new FoleySynthConfig.<Model2ConfigIter>d__31(-2);
			<Model2ConfigIter>d__.<>3__<>4__this = this;
			return <Model2ConfigIter>d__;
		}

		// Token: 0x0400531E RID: 21278
		private Table __p;
	}
}
