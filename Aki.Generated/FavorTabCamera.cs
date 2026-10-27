using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C63 RID: 3171
	public struct FavorTabCamera : IFlatbufferObject
	{
		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06006D2F RID: 27951 RVA: 0x0022C2E4 File Offset: 0x0022A4E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x0022C2F1 File Offset: 0x0022A4F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x0022C2F8 File Offset: 0x0022A4F8
		public static FavorTabCamera GetRootAsFavorTabCamera(ByteBuffer _bb)
		{
			return FavorTabCamera.GetRootAsFavorTabCamera(_bb, default(FavorTabCamera));
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x0022C314 File Offset: 0x0022A514
		public static FavorTabCamera GetRootAsFavorTabCamera(ByteBuffer _bb, FavorTabCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x0022C331 File Offset: 0x0022A531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x0022C340 File Offset: 0x0022A540
		public FavorTabCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x0022C350 File Offset: 0x0022A550
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x0022C38C File Offset: 0x0022A58C
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

		// Token: 0x06006D37 RID: 27959 RVA: 0x0022C3C3 File Offset: 0x0022A5C3
		public Span<byte> GetCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x0022C3D2 File Offset: 0x0022A5D2
		public byte[] GetCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CAE RID: 19630
		private Table __p;
	}
}
