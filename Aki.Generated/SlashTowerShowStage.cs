using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CB RID: 4555
	public struct SlashTowerShowStage : IFlatbufferObject
	{
		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600DE98 RID: 56984 RVA: 0x0033A5CE File Offset: 0x003387CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x0033A5DB File Offset: 0x003387DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x0033A5E4 File Offset: 0x003387E4
		public static SlashTowerShowStage GetRootAsSlashTowerShowStage(ByteBuffer _bb)
		{
			return SlashTowerShowStage.GetRootAsSlashTowerShowStage(_bb, default(SlashTowerShowStage));
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x0033A600 File Offset: 0x00338800
		public static SlashTowerShowStage GetRootAsSlashTowerShowStage(ByteBuffer _bb, SlashTowerShowStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE9C RID: 56988 RVA: 0x0033A61D File Offset: 0x0033881D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x0033A62C File Offset: 0x0033882C
		public SlashTowerShowStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600DE9E RID: 56990 RVA: 0x0033A63C File Offset: 0x0033883C
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

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600DE9F RID: 56991 RVA: 0x0033A678 File Offset: 0x00338878
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

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x0033A6AF File Offset: 0x003388AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0033A6BE File Offset: 0x003388BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x0033A6D8 File Offset: 0x003388D8
		public int OutIndex
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

		// Token: 0x04005801 RID: 22529
		private Table __p;
	}
}
