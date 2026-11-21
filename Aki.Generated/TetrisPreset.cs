using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125C RID: 4700
	public struct TetrisPreset : IFlatbufferObject
	{
		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600EBB4 RID: 60340 RVA: 0x003580F2 File Offset: 0x003562F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x003580FF File Offset: 0x003562FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x00358108 File Offset: 0x00356308
		public static TetrisPreset GetRootAsTetrisPreset(ByteBuffer _bb)
		{
			return TetrisPreset.GetRootAsTetrisPreset(_bb, default(TetrisPreset));
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x00358124 File Offset: 0x00356324
		public static TetrisPreset GetRootAsTetrisPreset(ByteBuffer _bb, TetrisPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x00358141 File Offset: 0x00356341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x00358150 File Offset: 0x00356350
		public TetrisPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600EBBA RID: 60346 RVA: 0x00358160 File Offset: 0x00356360
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

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600EBBB RID: 60347 RVA: 0x0035819C File Offset: 0x0035639C
		public int LevelId
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

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600EBBC RID: 60348 RVA: 0x003581D8 File Offset: 0x003563D8
		public int Round
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

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600EBBD RID: 60349 RVA: 0x00358214 File Offset: 0x00356414
		public int ShapeId
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

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600EBBE RID: 60350 RVA: 0x00358254 File Offset: 0x00356454
		public int Color
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

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600EBBF RID: 60351 RVA: 0x00358294 File Offset: 0x00356494
		public int Gem
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

		// Token: 0x040058A7 RID: 22695
		private Table __p;
	}
}
