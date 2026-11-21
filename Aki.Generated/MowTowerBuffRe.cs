using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F56 RID: 3926
	public struct MowTowerBuffRe : IFlatbufferObject
	{
		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600A317 RID: 41751 RVA: 0x002B6A85 File Offset: 0x002B4C85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x002B6A92 File Offset: 0x002B4C92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x002B6A9C File Offset: 0x002B4C9C
		public static MowTowerBuffRe GetRootAsMowTowerBuffRe(ByteBuffer _bb)
		{
			return MowTowerBuffRe.GetRootAsMowTowerBuffRe(_bb, default(MowTowerBuffRe));
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x002B6AB8 File Offset: 0x002B4CB8
		public static MowTowerBuffRe GetRootAsMowTowerBuffRe(ByteBuffer _bb, MowTowerBuffRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x002B6AD5 File Offset: 0x002B4CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x002B6AE4 File Offset: 0x002B4CE4
		public MowTowerBuffRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600A31D RID: 41757 RVA: 0x002B6AF4 File Offset: 0x002B4CF4
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

		// Token: 0x0600A31E RID: 41758 RVA: 0x002B6B30 File Offset: 0x002B4D30
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600A31F RID: 41759 RVA: 0x002B6B70 File Offset: 0x002B4D70
		public int BuffIdLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x002B6B9B File Offset: 0x002B4D9B
		public Span<long> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x002B6BAA File Offset: 0x002B4DAA
		public long[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600A322 RID: 41762 RVA: 0x002B6BC4 File Offset: 0x002B4DC4
		public string Texture
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

		// Token: 0x0600A323 RID: 41763 RVA: 0x002B6BFB File Offset: 0x002B4DFB
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x002B6C0A File Offset: 0x002B4E0A
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600A325 RID: 41765 RVA: 0x002B6C24 File Offset: 0x002B4E24
		public string Name
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

		// Token: 0x0600A326 RID: 41766 RVA: 0x002B6C5C File Offset: 0x002B4E5C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x002B6C6C File Offset: 0x002B4E6C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600A328 RID: 41768 RVA: 0x002B6C84 File Offset: 0x002B4E84
		public string Description
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

		// Token: 0x0600A329 RID: 41769 RVA: 0x002B6CBC File Offset: 0x002B4EBC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x002B6CCC File Offset: 0x002B4ECC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x002B6CE4 File Offset: 0x002B4EE4
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600A32C RID: 41772 RVA: 0x002B6D20 File Offset: 0x002B4F20
		public int DescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x002B6D4C File Offset: 0x002B4F4C
		[NullableContext(1)]
		public long[] BuffId()
		{
			return this.GetBuffIdArray();
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x002B6D54 File Offset: 0x002B4F54
		[NullableContext(1)]
		public IEnumerable<long> BuffIdIter()
		{
			MowTowerBuffRe.<BuffIdIter>d__31 <BuffIdIter>d__ = new MowTowerBuffRe.<BuffIdIter>d__31(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x002B6D69 File Offset: 0x002B4F69
		[NullableContext(1)]
		public string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x002B6D76 File Offset: 0x002B4F76
		[NullableContext(1)]
		public IEnumerable<string> DescriptionParamIter()
		{
			MowTowerBuffRe.<DescriptionParamIter>d__33 <DescriptionParamIter>d__ = new MowTowerBuffRe.<DescriptionParamIter>d__33(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x04005504 RID: 21764
		private Table __p;
	}
}
