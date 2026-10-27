using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D6 RID: 4566
	public struct PhantomPropRandom : IFlatbufferObject
	{
		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x0600EAEE RID: 60142 RVA: 0x00349015 File Offset: 0x00347215
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x00349022 File Offset: 0x00347222
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x0034902C File Offset: 0x0034722C
		public static PhantomPropRandom GetRootAsPhantomPropRandom(ByteBuffer _bb)
		{
			return PhantomPropRandom.GetRootAsPhantomPropRandom(_bb, default(PhantomPropRandom));
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00349048 File Offset: 0x00347248
		public static PhantomPropRandom GetRootAsPhantomPropRandom(ByteBuffer _bb, PhantomPropRandom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x00349065 File Offset: 0x00347265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00349074 File Offset: 0x00347274
		public PhantomPropRandom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x0600EAF4 RID: 60148 RVA: 0x00349084 File Offset: 0x00347284
		public int RandGroupId
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

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x003490C0 File Offset: 0x003472C0
		public int RandNum
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

		// Token: 0x04005344 RID: 21316
		private Table __p;
	}
}
