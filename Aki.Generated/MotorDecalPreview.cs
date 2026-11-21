using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F17 RID: 3863
	public struct MotorDecalPreview : IFlatbufferObject
	{
		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06009D1B RID: 40219 RVA: 0x002A9631 File Offset: 0x002A7831
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x002A963E File Offset: 0x002A783E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x002A9648 File Offset: 0x002A7848
		public static MotorDecalPreview GetRootAsMotorDecalPreview(ByteBuffer _bb)
		{
			return MotorDecalPreview.GetRootAsMotorDecalPreview(_bb, default(MotorDecalPreview));
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x002A9664 File Offset: 0x002A7864
		public static MotorDecalPreview GetRootAsMotorDecalPreview(ByteBuffer _bb, MotorDecalPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x002A9681 File Offset: 0x002A7881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x002A9690 File Offset: 0x002A7890
		public MotorDecalPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x002A96A0 File Offset: 0x002A78A0
		public int StickerId
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

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06009D22 RID: 40226 RVA: 0x002A96DC File Offset: 0x002A78DC
		public string PreviewPath
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

		// Token: 0x06009D23 RID: 40227 RVA: 0x002A9713 File Offset: 0x002A7913
		public Span<byte> GetPreviewPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x002A9722 File Offset: 0x002A7922
		public byte[] GetPreviewPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054BC RID: 21692
		private Table __p;
	}
}
