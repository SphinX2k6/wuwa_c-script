using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4B RID: 3659
	public struct InfrPasser : IFlatbufferObject
	{
		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x0027D6C8 File Offset: 0x0027B8C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x0027D6D5 File Offset: 0x0027B8D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x0027D6DC File Offset: 0x0027B8DC
		public static InfrPasser GetRootAsInfrPasser(ByteBuffer _bb)
		{
			return InfrPasser.GetRootAsInfrPasser(_bb, default(InfrPasser));
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x0027D6F8 File Offset: 0x0027B8F8
		public static InfrPasser GetRootAsInfrPasser(ByteBuffer _bb, InfrPasser obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0027D715 File Offset: 0x0027B915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0027D724 File Offset: 0x0027B924
		public InfrPasser __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600899B RID: 35227 RVA: 0x0027D734 File Offset: 0x0027B934
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

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x0027D770 File Offset: 0x0027B970
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x0027D7A7 File Offset: 0x0027B9A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x0027D7B6 File Offset: 0x0027B9B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040053CB RID: 21451
		private Table __p;
	}
}
