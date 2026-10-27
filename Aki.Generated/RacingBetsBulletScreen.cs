using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F89 RID: 3977
	public struct RacingBetsBulletScreen : IFlatbufferObject
	{
		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x002D4FB0 File Offset: 0x002D31B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x002D4FBD File Offset: 0x002D31BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x002D4FC4 File Offset: 0x002D31C4
		public static RacingBetsBulletScreen GetRootAsRacingBetsBulletScreen(ByteBuffer _bb)
		{
			return RacingBetsBulletScreen.GetRootAsRacingBetsBulletScreen(_bb, default(RacingBetsBulletScreen));
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x002D4FE0 File Offset: 0x002D31E0
		public static RacingBetsBulletScreen GetRootAsRacingBetsBulletScreen(ByteBuffer _bb, RacingBetsBulletScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x002D4FFD File Offset: 0x002D31FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x002D500C File Offset: 0x002D320C
		public RacingBetsBulletScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x002D501C File Offset: 0x002D321C
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

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x002D5058 File Offset: 0x002D3258
		public int SeasonId
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

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x002D5094 File Offset: 0x002D3294
		public int Type
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

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600B801 RID: 47105 RVA: 0x002D50D0 File Offset: 0x002D32D0
		public int DangoId
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

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x002D5110 File Offset: 0x002D3310
		public string Icon
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

		// Token: 0x0600B803 RID: 47107 RVA: 0x002D5148 File Offset: 0x002D3348
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x002D5158 File Offset: 0x002D3358
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002D5170 File Offset: 0x002D3370
		public string Name
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

		// Token: 0x0600B806 RID: 47110 RVA: 0x002D51A8 File Offset: 0x002D33A8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x002D51B8 File Offset: 0x002D33B8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005058 RID: 20568
		private Table __p;
	}
}
