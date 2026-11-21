using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4C RID: 3916
	public struct MotorScene : IFlatbufferObject
	{
		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600A1C5 RID: 41413 RVA: 0x002B3CC0 File Offset: 0x002B1EC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x002B3CCD File Offset: 0x002B1ECD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x002B3CD4 File Offset: 0x002B1ED4
		public static MotorScene GetRootAsMotorScene(ByteBuffer _bb)
		{
			return MotorScene.GetRootAsMotorScene(_bb, default(MotorScene));
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x002B3CF0 File Offset: 0x002B1EF0
		public static MotorScene GetRootAsMotorScene(ByteBuffer _bb, MotorScene obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x002B3D0D File Offset: 0x002B1F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x002B3D1C File Offset: 0x002B1F1C
		public MotorScene __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600A1CB RID: 41419 RVA: 0x002B3D2C File Offset: 0x002B1F2C
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

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600A1CC RID: 41420 RVA: 0x002B3D68 File Offset: 0x002B1F68
		public int UnlockItem
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

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x002B3DA4 File Offset: 0x002B1FA4
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x002B3DE4 File Offset: 0x002B1FE4
		public string SceneId
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

		// Token: 0x0600A1CF RID: 41423 RVA: 0x002B3E1C File Offset: 0x002B201C
		public Span<byte> GetSceneIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x002B3E2C File Offset: 0x002B202C
		public byte[] GetSceneIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x0600A1D1 RID: 41425 RVA: 0x002B3E44 File Offset: 0x002B2044
		public string SceneName
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

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x002B3E7C File Offset: 0x002B207C
		public Span<byte> GetSceneNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x002B3E8C File Offset: 0x002B208C
		public byte[] GetSceneNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x0600A1D4 RID: 41428 RVA: 0x002B3EA4 File Offset: 0x002B20A4
		public string SceneIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x002B3EDC File Offset: 0x002B20DC
		public Span<byte> GetSceneIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x002B3EEC File Offset: 0x002B20EC
		public byte[] GetSceneIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F8 RID: 21752
		private Table __p;
	}
}
