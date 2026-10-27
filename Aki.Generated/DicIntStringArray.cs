using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BC RID: 4540
	public struct DicIntStringArray : IFlatbufferObject
	{
		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x0600EA27 RID: 59943 RVA: 0x00347915 File Offset: 0x00345B15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA28 RID: 59944 RVA: 0x00347922 File Offset: 0x00345B22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x0034792C File Offset: 0x00345B2C
		public static DicIntStringArray GetRootAsDicIntStringArray(ByteBuffer _bb)
		{
			return DicIntStringArray.GetRootAsDicIntStringArray(_bb, default(DicIntStringArray));
		}

		// Token: 0x0600EA2A RID: 59946 RVA: 0x00347948 File Offset: 0x00345B48
		public static DicIntStringArray GetRootAsDicIntStringArray(ByteBuffer _bb, DicIntStringArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA2B RID: 59947 RVA: 0x00347965 File Offset: 0x00345B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x00347974 File Offset: 0x00345B74
		public DicIntStringArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x00347984 File Offset: 0x00345B84
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

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0600EA2E RID: 59950 RVA: 0x003479C0 File Offset: 0x00345BC0
		public StringArray? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new StringArray?(default(StringArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0400530D RID: 21261
		private Table __p;
	}
}
