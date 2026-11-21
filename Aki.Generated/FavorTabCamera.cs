using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D47 RID: 3399
	public struct FavorTabCamera : IFlatbufferObject
	{
		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x0024B634 File Offset: 0x00249834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x0024B641 File Offset: 0x00249841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0024B648 File Offset: 0x00249848
		public static FavorTabCamera GetRootAsFavorTabCamera(ByteBuffer _bb)
		{
			return FavorTabCamera.GetRootAsFavorTabCamera(_bb, default(FavorTabCamera));
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0024B664 File Offset: 0x00249864
		public static FavorTabCamera GetRootAsFavorTabCamera(ByteBuffer _bb, FavorTabCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x0024B681 File Offset: 0x00249881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0024B690 File Offset: 0x00249890
		public FavorTabCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x0024B6A0 File Offset: 0x002498A0
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

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x0024B6DC File Offset: 0x002498DC
		public string CameraSettingsName
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

		// Token: 0x06007342 RID: 29506 RVA: 0x0024B713 File Offset: 0x00249913
		public Span<byte> GetCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x0024B722 File Offset: 0x00249922
		public byte[] GetCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005292 RID: 21138
		private Table __p;
	}
}
