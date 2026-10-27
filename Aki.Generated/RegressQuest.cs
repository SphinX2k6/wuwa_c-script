using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB1 RID: 4017
	public struct RegressQuest : IFlatbufferObject
	{
		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0600BB17 RID: 47895 RVA: 0x002DC2E8 File Offset: 0x002DA4E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x002DC2F5 File Offset: 0x002DA4F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x002DC2FC File Offset: 0x002DA4FC
		public static RegressQuest GetRootAsRegressQuest(ByteBuffer _bb)
		{
			return RegressQuest.GetRootAsRegressQuest(_bb, default(RegressQuest));
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x002DC318 File Offset: 0x002DA518
		public static RegressQuest GetRootAsRegressQuest(ByteBuffer _bb, RegressQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x002DC335 File Offset: 0x002DA535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x002DC344 File Offset: 0x002DA544
		public RegressQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x0600BB1D RID: 47901 RVA: 0x002DC354 File Offset: 0x002DA554
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

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x0600BB1E RID: 47902 RVA: 0x002DC390 File Offset: 0x002DA590
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600BB1F RID: 47903 RVA: 0x002DC3CC File Offset: 0x002DA5CC
		public string TargetName
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

		// Token: 0x0600BB20 RID: 47904 RVA: 0x002DC403 File Offset: 0x002DA603
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x002DC412 File Offset: 0x002DA612
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x002DC42C File Offset: 0x002DA62C
		public int TaskSubType
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

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600BB23 RID: 47907 RVA: 0x002DC46C File Offset: 0x002DA66C
		public int AccessPathId
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

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x002DC4AC File Offset: 0x002DA6AC
		public int TargetReward
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

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600BB25 RID: 47909 RVA: 0x002DC4EC File Offset: 0x002DA6EC
		public int ProgressType
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

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x002DC52C File Offset: 0x002DA72C
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600BB27 RID: 47911 RVA: 0x002DC56C File Offset: 0x002DA76C
		public int Version
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400508A RID: 20618
		private Table __p;
	}
}
