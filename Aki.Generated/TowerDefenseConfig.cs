using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113E RID: 4414
	public struct TowerDefenseConfig : IFlatbufferObject
	{
		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600E028 RID: 57384 RVA: 0x00330D6D File Offset: 0x0032EF6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E029 RID: 57385 RVA: 0x00330D7A File Offset: 0x0032EF7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E02A RID: 57386 RVA: 0x00330D84 File Offset: 0x0032EF84
		public static TowerDefenseConfig GetRootAsTowerDefenseConfig(ByteBuffer _bb)
		{
			return TowerDefenseConfig.GetRootAsTowerDefenseConfig(_bb, default(TowerDefenseConfig));
		}

		// Token: 0x0600E02B RID: 57387 RVA: 0x00330DA0 File Offset: 0x0032EFA0
		public static TowerDefenseConfig GetRootAsTowerDefenseConfig(ByteBuffer _bb, TowerDefenseConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E02C RID: 57388 RVA: 0x00330DBD File Offset: 0x0032EFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E02D RID: 57389 RVA: 0x00330DCC File Offset: 0x0032EFCC
		public TowerDefenseConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x00330DDC File Offset: 0x0032EFDC
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

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600E02F RID: 57391 RVA: 0x00330E18 File Offset: 0x0032F018
		public bool ShowDifferent
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x00330E58 File Offset: 0x0032F058
		public int ActivityType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600E031 RID: 57393 RVA: 0x00330E94 File Offset: 0x0032F094
		public int EntranceId
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

		// Token: 0x0400527F RID: 21119
		private Table __p;
	}
}
