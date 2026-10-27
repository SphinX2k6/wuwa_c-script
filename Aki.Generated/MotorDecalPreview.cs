using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E32 RID: 3634
	public struct MotorDecalPreview : IFlatbufferObject
	{
		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x060096FB RID: 38651 RVA: 0x0028B975 File Offset: 0x00289B75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x0028B982 File Offset: 0x00289B82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x0028B98C File Offset: 0x00289B8C
		public static MotorDecalPreview GetRootAsMotorDecalPreview(ByteBuffer _bb)
		{
			return MotorDecalPreview.GetRootAsMotorDecalPreview(_bb, default(MotorDecalPreview));
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x0028B9A8 File Offset: 0x00289BA8
		public static MotorDecalPreview GetRootAsMotorDecalPreview(ByteBuffer _bb, MotorDecalPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x0028B9C5 File Offset: 0x00289BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x0028B9D4 File Offset: 0x00289BD4
		public MotorDecalPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06009701 RID: 38657 RVA: 0x0028B9E4 File Offset: 0x00289BE4
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

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x0028BA20 File Offset: 0x00289C20
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

		// Token: 0x06009703 RID: 38659 RVA: 0x0028BA57 File Offset: 0x00289C57
		public Span<byte> GetPreviewPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x0028BA66 File Offset: 0x00289C66
		public byte[] GetPreviewPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ED7 RID: 20183
		private Table __p;
	}
}
