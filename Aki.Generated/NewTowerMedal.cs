using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8D RID: 3725
	public struct NewTowerMedal : IFlatbufferObject
	{
		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06009F4C RID: 40780 RVA: 0x0029E144 File Offset: 0x0029C344
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x0029E151 File Offset: 0x0029C351
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x0029E158 File Offset: 0x0029C358
		public static NewTowerMedal GetRootAsNewTowerMedal(ByteBuffer _bb)
		{
			return NewTowerMedal.GetRootAsNewTowerMedal(_bb, default(NewTowerMedal));
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x0029E174 File Offset: 0x0029C374
		public static NewTowerMedal GetRootAsNewTowerMedal(ByteBuffer _bb, NewTowerMedal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x0029E191 File Offset: 0x0029C391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x0029E1A0 File Offset: 0x0029C3A0
		public NewTowerMedal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x0029E1B0 File Offset: 0x0029C3B0
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

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x0029E1EC File Offset: 0x0029C3EC
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

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x0029E228 File Offset: 0x0029C428
		public int GroupId
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

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06009F55 RID: 40789 RVA: 0x0029E264 File Offset: 0x0029C464
		public string Name
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

		// Token: 0x06009F56 RID: 40790 RVA: 0x0029E29C File Offset: 0x0029C49C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x0029E2AC File Offset: 0x0029C4AC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x0029E2C4 File Offset: 0x0029C4C4
		public int CycleId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06009F59 RID: 40793 RVA: 0x0029E304 File Offset: 0x0029C504
		public int Target
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x0029E344 File Offset: 0x0029C544
		public string Background
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

		// Token: 0x06009F5B RID: 40795 RVA: 0x0029E37C File Offset: 0x0029C57C
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x0029E38C File Offset: 0x0029C58C
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06009F5D RID: 40797 RVA: 0x0029E3A4 File Offset: 0x0029C5A4
		public string Icon
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

		// Token: 0x06009F5E RID: 40798 RVA: 0x0029E3DC File Offset: 0x0029C5DC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x0029E3EC File Offset: 0x0029C5EC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x0029E404 File Offset: 0x0029C604
		public string Desc
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

		// Token: 0x06009F61 RID: 40801 RVA: 0x0029E43C File Offset: 0x0029C63C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x0029E44C File Offset: 0x0029C64C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F3C RID: 20284
		private Table __p;
	}
}
