using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C7 RID: 4551
	public struct FloatRange : IFlatbufferObject
	{
		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x0034808D File Offset: 0x0034628D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA6E RID: 60014 RVA: 0x0034809A File Offset: 0x0034629A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA6F RID: 60015 RVA: 0x003480A4 File Offset: 0x003462A4
		public static FloatRange GetRootAsFloatRange(ByteBuffer _bb)
		{
			return FloatRange.GetRootAsFloatRange(_bb, default(FloatRange));
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x003480C0 File Offset: 0x003462C0
		public static FloatRange GetRootAsFloatRange(ByteBuffer _bb, FloatRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x003480DD File Offset: 0x003462DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA72 RID: 60018 RVA: 0x003480EC File Offset: 0x003462EC
		public FloatRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x003480FC File Offset: 0x003462FC
		public float Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0600EA74 RID: 60020 RVA: 0x0034813C File Offset: 0x0034633C
		public float Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400532A RID: 21290
		private Table __p;
	}
}
