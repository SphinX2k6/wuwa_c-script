using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001126 RID: 4390
	public struct TetrisPreset : IFlatbufferObject
	{
		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x0032CBD2 File Offset: 0x0032ADD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE4E RID: 56910 RVA: 0x0032CBDF File Offset: 0x0032ADDF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x0032CBE8 File Offset: 0x0032ADE8
		public static TetrisPreset GetRootAsTetrisPreset(ByteBuffer _bb)
		{
			return TetrisPreset.GetRootAsTetrisPreset(_bb, default(TetrisPreset));
		}

		// Token: 0x0600DE50 RID: 56912 RVA: 0x0032CC04 File Offset: 0x0032AE04
		public static TetrisPreset GetRootAsTetrisPreset(ByteBuffer _bb, TetrisPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE51 RID: 56913 RVA: 0x0032CC21 File Offset: 0x0032AE21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE52 RID: 56914 RVA: 0x0032CC30 File Offset: 0x0032AE30
		public TetrisPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600DE53 RID: 56915 RVA: 0x0032CC40 File Offset: 0x0032AE40
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

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x0032CC7C File Offset: 0x0032AE7C
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

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x0032CCB8 File Offset: 0x0032AEB8
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

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600DE56 RID: 56918 RVA: 0x0032CCF4 File Offset: 0x0032AEF4
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

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x0032CD34 File Offset: 0x0032AF34
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

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600DE58 RID: 56920 RVA: 0x0032CD74 File Offset: 0x0032AF74
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

		// Token: 0x04005264 RID: 21092
		private Table __p;
	}
}
