using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CD RID: 4557
	public struct SlashTowerTagInfo : IFlatbufferObject
	{
		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600DEB8 RID: 57016 RVA: 0x0033A996 File Offset: 0x00338B96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x0033A9A3 File Offset: 0x00338BA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x0033A9AC File Offset: 0x00338BAC
		public static SlashTowerTagInfo GetRootAsSlashTowerTagInfo(ByteBuffer _bb)
		{
			return SlashTowerTagInfo.GetRootAsSlashTowerTagInfo(_bb, default(SlashTowerTagInfo));
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x0033A9C8 File Offset: 0x00338BC8
		public static SlashTowerTagInfo GetRootAsSlashTowerTagInfo(ByteBuffer _bb, SlashTowerTagInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x0033A9E5 File Offset: 0x00338BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x0033A9F4 File Offset: 0x00338BF4
		public SlashTowerTagInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x0033AA04 File Offset: 0x00338C04
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

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x0033AA40 File Offset: 0x00338C40
		public string Name
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

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x0033AA77 File Offset: 0x00338C77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x0033AA86 File Offset: 0x00338C86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600DEC2 RID: 57026 RVA: 0x0033AAA0 File Offset: 0x00338CA0
		public string Desc
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

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x0033AAD7 File Offset: 0x00338CD7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x0033AAE6 File Offset: 0x00338CE6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600DEC5 RID: 57029 RVA: 0x0033AB00 File Offset: 0x00338D00
		public string Path
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

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x0033AB38 File Offset: 0x00338D38
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x0033AB48 File Offset: 0x00338D48
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600DEC8 RID: 57032 RVA: 0x0033AB60 File Offset: 0x00338D60
		public string Color
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

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0033AB98 File Offset: 0x00338D98
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x0033ABA8 File Offset: 0x00338DA8
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005803 RID: 22531
		private Table __p;
	}
}
