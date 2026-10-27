using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE9 RID: 3305
	public struct GamepadKey : IFlatbufferObject
	{
		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x002478F0 File Offset: 0x00245AF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x002478FD File Offset: 0x00245AFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00247904 File Offset: 0x00245B04
		public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb)
		{
			return GamepadKey.GetRootAsGamepadKey(_bb, default(GamepadKey));
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00247920 File Offset: 0x00245B20
		public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb, GamepadKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0024793D File Offset: 0x00245B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x0024794C File Offset: 0x00245B4C
		public GamepadKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x0024795C File Offset: 0x00245B5C
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

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060078EB RID: 30955 RVA: 0x00247998 File Offset: 0x00245B98
		public string KeyName
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

		// Token: 0x060078EC RID: 30956 RVA: 0x002479CF File Offset: 0x00245BCF
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x002479DE File Offset: 0x00245BDE
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x002479F8 File Offset: 0x00245BF8
		public string KeyDescription
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

		// Token: 0x060078EF RID: 30959 RVA: 0x00247A2F File Offset: 0x00245C2F
		public Span<byte> GetKeyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x00247A3E File Offset: 0x00245C3E
		public byte[] GetKeyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060078F1 RID: 30961 RVA: 0x00247A58 File Offset: 0x00245C58
		public string KeyDisplayName
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

		// Token: 0x060078F2 RID: 30962 RVA: 0x00247A90 File Offset: 0x00245C90
		public Span<byte> GetKeyDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x00247AA0 File Offset: 0x00245CA0
		public byte[] GetKeyDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060078F4 RID: 30964 RVA: 0x00247AB8 File Offset: 0x00245CB8
		public string KeyIconPath
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

		// Token: 0x060078F5 RID: 30965 RVA: 0x00247AF0 File Offset: 0x00245CF0
		public Span<byte> GetKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00247B00 File Offset: 0x00245D00
		public byte[] GetKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x00247B18 File Offset: 0x00245D18
		public string PsKeyIconPath
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

		// Token: 0x060078F8 RID: 30968 RVA: 0x00247B50 File Offset: 0x00245D50
		public Span<byte> GetPsKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00247B60 File Offset: 0x00245D60
		public byte[] GetPsKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x00247B78 File Offset: 0x00245D78
		public string BackBoneKeyIconPath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00247BB0 File Offset: 0x00245DB0
		public Span<byte> GetBackBoneKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00247BC0 File Offset: 0x00245DC0
		public byte[] GetBackBoneKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060078FD RID: 30973 RVA: 0x00247BD8 File Offset: 0x00245DD8
		public string NsKeyIconPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x00247C10 File Offset: 0x00245E10
		public Span<byte> GetNsKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x00247C20 File Offset: 0x00245E20
		public byte[] GetNsKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D5A RID: 19802
		private Table __p;
	}
}
