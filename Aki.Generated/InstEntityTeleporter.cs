using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D76 RID: 3446
	public struct InstEntityTeleporter : IFlatbufferObject
	{
		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x00264AD9 File Offset: 0x00262CD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085CA RID: 34250 RVA: 0x00264AE6 File Offset: 0x00262CE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085CB RID: 34251 RVA: 0x00264AF0 File Offset: 0x00262CF0
		public static InstEntityTeleporter GetRootAsInstEntityTeleporter(ByteBuffer _bb)
		{
			return InstEntityTeleporter.GetRootAsInstEntityTeleporter(_bb, default(InstEntityTeleporter));
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x00264B0C File Offset: 0x00262D0C
		public static InstEntityTeleporter GetRootAsInstEntityTeleporter(ByteBuffer _bb, InstEntityTeleporter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085CD RID: 34253 RVA: 0x00264B29 File Offset: 0x00262D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085CE RID: 34254 RVA: 0x00264B38 File Offset: 0x00262D38
		public InstEntityTeleporter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060085CF RID: 34255 RVA: 0x00264B48 File Offset: 0x00262D48
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

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x00264B84 File Offset: 0x00262D84
		public int InstId
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

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060085D1 RID: 34257 RVA: 0x00264BC0 File Offset: 0x00262DC0
		public bool IsUnlockDefault
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x00264C00 File Offset: 0x00262E00
		public int EntityConfigId
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

		// Token: 0x04004DFE RID: 19966
		private Table __p;
	}
}
