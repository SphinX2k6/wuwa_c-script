using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001161 RID: 4449
	public struct RoleTrialUiConfig : IFlatbufferObject
	{
		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600D38E RID: 54158 RVA: 0x003210B1 File Offset: 0x0031F2B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x003210BE File Offset: 0x0031F2BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x003210C8 File Offset: 0x0031F2C8
		public static RoleTrialUiConfig GetRootAsRoleTrialUiConfig(ByteBuffer _bb)
		{
			return RoleTrialUiConfig.GetRootAsRoleTrialUiConfig(_bb, default(RoleTrialUiConfig));
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x003210E4 File Offset: 0x0031F2E4
		public static RoleTrialUiConfig GetRootAsRoleTrialUiConfig(ByteBuffer _bb, RoleTrialUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x00321101 File Offset: 0x0031F301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x00321110 File Offset: 0x0031F310
		public RoleTrialUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600D394 RID: 54164 RVA: 0x00321120 File Offset: 0x0031F320
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

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600D395 RID: 54165 RVA: 0x0032115C File Offset: 0x0031F35C
		public string Color1
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

		// Token: 0x0600D396 RID: 54166 RVA: 0x00321193 File Offset: 0x0031F393
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x003211A2 File Offset: 0x0031F3A2
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600D398 RID: 54168 RVA: 0x003211BC File Offset: 0x0031F3BC
		public string Color2
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

		// Token: 0x0600D399 RID: 54169 RVA: 0x003211F3 File Offset: 0x0031F3F3
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x00321202 File Offset: 0x0031F402
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600D39B RID: 54171 RVA: 0x0032121C File Offset: 0x0031F41C
		public string Color3
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

		// Token: 0x0600D39C RID: 54172 RVA: 0x00321254 File Offset: 0x0031F454
		public Span<byte> GetColor3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x00321264 File Offset: 0x0031F464
		public byte[] GetColor3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600D39E RID: 54174 RVA: 0x0032127C File Offset: 0x0031F47C
		public string Color4
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

		// Token: 0x0600D39F RID: 54175 RVA: 0x003212B4 File Offset: 0x0031F4B4
		public Span<byte> GetColor4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x003212C4 File Offset: 0x0031F4C4
		public byte[] GetColor4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x003212DC File Offset: 0x0031F4DC
		public string Color5
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

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x00321314 File Offset: 0x0031F514
		public Span<byte> GetColor5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x00321324 File Offset: 0x0031F524
		public byte[] GetColor5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400576A RID: 22378
		private Table __p;
	}
}
