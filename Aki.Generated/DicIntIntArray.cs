using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B8 RID: 4536
	public struct DicIntIntArray : IFlatbufferObject
	{
		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x00347510 File Offset: 0x00345710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA06 RID: 59910 RVA: 0x0034751D File Offset: 0x0034571D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA07 RID: 59911 RVA: 0x00347524 File Offset: 0x00345724
		public static DicIntIntArray GetRootAsDicIntIntArray(ByteBuffer _bb)
		{
			return DicIntIntArray.GetRootAsDicIntIntArray(_bb, default(DicIntIntArray));
		}

		// Token: 0x0600EA08 RID: 59912 RVA: 0x00347540 File Offset: 0x00345740
		public static DicIntIntArray GetRootAsDicIntIntArray(ByteBuffer _bb, DicIntIntArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x0034755D File Offset: 0x0034575D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x0034756C File Offset: 0x0034576C
		public DicIntIntArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0600EA0B RID: 59915 RVA: 0x0034757C File Offset: 0x0034577C
		public int Key
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

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x0600EA0C RID: 59916 RVA: 0x003475B8 File Offset: 0x003457B8
		public IntArray? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntArray?(default(IntArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005309 RID: 21257
		private Table __p;
	}
}
