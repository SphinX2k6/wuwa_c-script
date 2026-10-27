using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE4 RID: 3300
	public struct GachaTextureInfo : IFlatbufferObject
	{
		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06007851 RID: 30801 RVA: 0x002464C5 File Offset: 0x002446C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x002464D2 File Offset: 0x002446D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x002464DC File Offset: 0x002446DC
		public static GachaTextureInfo GetRootAsGachaTextureInfo(ByteBuffer _bb)
		{
			return GachaTextureInfo.GetRootAsGachaTextureInfo(_bb, default(GachaTextureInfo));
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x002464F8 File Offset: 0x002446F8
		public static GachaTextureInfo GetRootAsGachaTextureInfo(ByteBuffer _bb, GachaTextureInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00246515 File Offset: 0x00244715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x00246524 File Offset: 0x00244724
		public GachaTextureInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06007857 RID: 30807 RVA: 0x00246534 File Offset: 0x00244734
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

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06007858 RID: 30808 RVA: 0x00246570 File Offset: 0x00244770
		public string GachaMainViewTexture
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

		// Token: 0x06007859 RID: 30809 RVA: 0x002465A7 File Offset: 0x002447A7
		public Span<byte> GetGachaMainViewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x002465B6 File Offset: 0x002447B6
		public byte[] GetGachaMainViewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600785B RID: 30811 RVA: 0x002465D0 File Offset: 0x002447D0
		public string GachaResultViewTexture
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

		// Token: 0x0600785C RID: 30812 RVA: 0x00246607 File Offset: 0x00244807
		public Span<byte> GetGachaResultViewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x00246616 File Offset: 0x00244816
		public byte[] GetGachaResultViewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x00246630 File Offset: 0x00244830
		public int ShowSequence
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

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x00246670 File Offset: 0x00244870
		public string BindPoint
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

		// Token: 0x06007860 RID: 30816 RVA: 0x002466A8 File Offset: 0x002448A8
		public Span<byte> GetBindPointBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x002466B8 File Offset: 0x002448B8
		public byte[] GetBindPointArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x002466D0 File Offset: 0x002448D0
		public int IdArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x00246710 File Offset: 0x00244910
		public int IdArrayLength
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

		// Token: 0x06007864 RID: 30820 RVA: 0x0024673C File Offset: 0x0024493C
		public Span<int> GetIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x0024674C File Offset: 0x0024494C
		public int[] GetIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x00246764 File Offset: 0x00244964
		public int TrialId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x002467A4 File Offset: 0x002449A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IdArrayIter()或GetIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IdArray()
		{
			GachaTextureInfo gachaTextureInfo = this;
			return gachaTextureInfo.GetIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x002467C8 File Offset: 0x002449C8
		[NullableContext(1)]
		public readonly IEnumerable<int> IdArrayIter()
		{
			GachaTextureInfo.<IdArrayIter>d__32 <IdArrayIter>d__ = new GachaTextureInfo.<IdArrayIter>d__32(-2);
			<IdArrayIter>d__.<>3__<>4__this = this;
			return <IdArrayIter>d__;
		}

		// Token: 0x04004D55 RID: 19797
		private Table __p;
	}
}
