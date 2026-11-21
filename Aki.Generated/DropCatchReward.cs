using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF0 RID: 3312
	public struct DropCatchReward : IFlatbufferObject
	{
		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x0023AB42 File Offset: 0x00238D42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x0023AB4F File Offset: 0x00238D4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x0023AB58 File Offset: 0x00238D58
		public static DropCatchReward GetRootAsDropCatchReward(ByteBuffer _bb)
		{
			return DropCatchReward.GetRootAsDropCatchReward(_bb, default(DropCatchReward));
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x0023AB74 File Offset: 0x00238D74
		public static DropCatchReward GetRootAsDropCatchReward(ByteBuffer _bb, DropCatchReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x0023AB91 File Offset: 0x00238D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x0023ABA0 File Offset: 0x00238DA0
		public DropCatchReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x0023ABB0 File Offset: 0x00238DB0
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06006B89 RID: 27529 RVA: 0x0023ABEC File Offset: 0x00238DEC
		public int DropId
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

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06006B8A RID: 27530 RVA: 0x0023AC28 File Offset: 0x00238E28
		public int Score
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

		// Token: 0x0400522D RID: 21037
		private Table __p;
	}
}
