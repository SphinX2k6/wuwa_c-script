using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDD RID: 3549
	public struct GiantAnimationRegister : IFlatbufferObject
	{
		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06008042 RID: 32834 RVA: 0x002692F5 File Offset: 0x002674F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x00269302 File Offset: 0x00267502
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x0026930C File Offset: 0x0026750C
		public static GiantAnimationRegister GetRootAsGiantAnimationRegister(ByteBuffer _bb)
		{
			return GiantAnimationRegister.GetRootAsGiantAnimationRegister(_bb, default(GiantAnimationRegister));
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x00269328 File Offset: 0x00267528
		public static GiantAnimationRegister GetRootAsGiantAnimationRegister(ByteBuffer _bb, GiantAnimationRegister obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00269345 File Offset: 0x00267545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00269354 File Offset: 0x00267554
		public GiantAnimationRegister __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06008048 RID: 32840 RVA: 0x00269364 File Offset: 0x00267564
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

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x002693A0 File Offset: 0x002675A0
		public string Desc
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

		// Token: 0x0600804A RID: 32842 RVA: 0x002693D7 File Offset: 0x002675D7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x002693E6 File Offset: 0x002675E6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x00269400 File Offset: 0x00267600
		public string AnimData
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

		// Token: 0x0600804D RID: 32845 RVA: 0x00269437 File Offset: 0x00267637
		public Span<byte> GetAnimDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x00269446 File Offset: 0x00267646
		public byte[] GetAnimDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005350 RID: 21328
		private Table __p;
	}
}
