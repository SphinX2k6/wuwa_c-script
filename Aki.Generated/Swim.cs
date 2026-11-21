using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001245 RID: 4677
	public struct Swim : IFlatbufferObject
	{
		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x003538C0 File Offset: 0x00351AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x003538CD File Offset: 0x00351ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x003538D4 File Offset: 0x00351AD4
		public static Swim GetRootAsSwim(ByteBuffer _bb)
		{
			return Swim.GetRootAsSwim(_bb, default(Swim));
		}

		// Token: 0x0600E9B6 RID: 59830 RVA: 0x003538F0 File Offset: 0x00351AF0
		public static Swim GetRootAsSwim(ByteBuffer _bb, Swim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x0035390D File Offset: 0x00351B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x0035391C File Offset: 0x00351B1C
		public Swim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x0035392C File Offset: 0x00351B2C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x00353963 File Offset: 0x00351B63
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x00353972 File Offset: 0x00351B72
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x0035398C File Offset: 0x00351B8C
		public float SprintZOffsetRate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0.2f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600E9BD RID: 59837 RVA: 0x003539CC File Offset: 0x00351BCC
		public float SprintZOffsetSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400588F RID: 22671
		private Table __p;
	}
}
