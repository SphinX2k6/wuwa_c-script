using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E65 RID: 3685
	public struct MotorQuality : IFlatbufferObject
	{
		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x00296021 File Offset: 0x00294221
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x0029602E File Offset: 0x0029422E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x00296038 File Offset: 0x00294238
		public static MotorQuality GetRootAsMotorQuality(ByteBuffer _bb)
		{
			return MotorQuality.GetRootAsMotorQuality(_bb, default(MotorQuality));
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x00296054 File Offset: 0x00294254
		public static MotorQuality GetRootAsMotorQuality(ByteBuffer _bb, MotorQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x00296071 File Offset: 0x00294271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x00296080 File Offset: 0x00294280
		public MotorQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x00296090 File Offset: 0x00294290
		public int QualityId
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

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06009B8E RID: 39822 RVA: 0x002960CC File Offset: 0x002942CC
		public string Path
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

		// Token: 0x06009B8F RID: 39823 RVA: 0x00296103 File Offset: 0x00294303
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x00296112 File Offset: 0x00294312
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06009B91 RID: 39825 RVA: 0x0029612C File Offset: 0x0029432C
		public string FramePath
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

		// Token: 0x06009B92 RID: 39826 RVA: 0x00296163 File Offset: 0x00294363
		public Span<byte> GetFramePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x00296172 File Offset: 0x00294372
		public byte[] GetFramePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06009B94 RID: 39828 RVA: 0x0029618C File Offset: 0x0029438C
		public string FrameShinePath
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

		// Token: 0x06009B95 RID: 39829 RVA: 0x002961C4 File Offset: 0x002943C4
		public Span<byte> GetFrameShinePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x002961D4 File Offset: 0x002943D4
		public byte[] GetFrameShinePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F11 RID: 20241
		private Table __p;
	}
}
