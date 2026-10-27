using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B6 RID: 4534
	public struct DicIntFloat : IFlatbufferObject
	{
		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x00347344 File Offset: 0x00345544
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00347351 File Offset: 0x00345551
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9F7 RID: 59895 RVA: 0x00347358 File Offset: 0x00345558
		public static DicIntFloat GetRootAsDicIntFloat(ByteBuffer _bb)
		{
			return DicIntFloat.GetRootAsDicIntFloat(_bb, default(DicIntFloat));
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x00347374 File Offset: 0x00345574
		public static DicIntFloat GetRootAsDicIntFloat(ByteBuffer _bb, DicIntFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x00347391 File Offset: 0x00345591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x003473A0 File Offset: 0x003455A0
		public DicIntFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600E9FB RID: 59899 RVA: 0x003473B0 File Offset: 0x003455B0
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

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0600E9FC RID: 59900 RVA: 0x003473EC File Offset: 0x003455EC
		public float Value
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

		// Token: 0x04005307 RID: 21255
		private Table __p;
	}
}
