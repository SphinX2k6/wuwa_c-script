using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001159 RID: 4441
	public struct RoleTowerToken : IFlatbufferObject
	{
		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600D306 RID: 54022 RVA: 0x0031FE88 File Offset: 0x0031E088
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D307 RID: 54023 RVA: 0x0031FE95 File Offset: 0x0031E095
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D308 RID: 54024 RVA: 0x0031FE9C File Offset: 0x0031E09C
		public static RoleTowerToken GetRootAsRoleTowerToken(ByteBuffer _bb)
		{
			return RoleTowerToken.GetRootAsRoleTowerToken(_bb, default(RoleTowerToken));
		}

		// Token: 0x0600D309 RID: 54025 RVA: 0x0031FEB8 File Offset: 0x0031E0B8
		public static RoleTowerToken GetRootAsRoleTowerToken(ByteBuffer _bb, RoleTowerToken obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D30A RID: 54026 RVA: 0x0031FED5 File Offset: 0x0031E0D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D30B RID: 54027 RVA: 0x0031FEE4 File Offset: 0x0031E0E4
		public RoleTowerToken __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600D30C RID: 54028 RVA: 0x0031FEF4 File Offset: 0x0031E0F4
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

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600D30D RID: 54029 RVA: 0x0031FF30 File Offset: 0x0031E130
		public int ActivityId
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

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600D30E RID: 54030 RVA: 0x0031FF6C File Offset: 0x0031E16C
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600D30F RID: 54031 RVA: 0x0031FFA8 File Offset: 0x0031E1A8
		public int Quality
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

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x0031FFE8 File Offset: 0x0031E1E8
		public int UseCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600D311 RID: 54033 RVA: 0x00320028 File Offset: 0x0031E228
		public float UseCd
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600D312 RID: 54034 RVA: 0x0032006C File Offset: 0x0031E26C
		public int TypeId
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

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600D313 RID: 54035 RVA: 0x003200AC File Offset: 0x0031E2AC
		public int ZoneId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x003200EC File Offset: 0x0031E2EC
		public string IconTexture
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D315 RID: 54037 RVA: 0x00320124 File Offset: 0x0031E324
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D316 RID: 54038 RVA: 0x00320134 File Offset: 0x0031E334
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005761 RID: 22369
		private Table __p;
	}
}
