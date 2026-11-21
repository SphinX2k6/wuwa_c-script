using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEA RID: 3562
	public struct GmAccount : IFlatbufferObject
	{
		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x0026B558 File Offset: 0x00269758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x0026B565 File Offset: 0x00269765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x0026B56C File Offset: 0x0026976C
		public static GmAccount GetRootAsGmAccount(ByteBuffer _bb)
		{
			return GmAccount.GetRootAsGmAccount(_bb, default(GmAccount));
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x0026B588 File Offset: 0x00269788
		public static GmAccount GetRootAsGmAccount(ByteBuffer _bb, GmAccount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x0026B5A5 File Offset: 0x002697A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x0026B5B4 File Offset: 0x002697B4
		public GmAccount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x0026B5C4 File Offset: 0x002697C4
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

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x0600813D RID: 33085 RVA: 0x0026B600 File Offset: 0x00269800
		public string GmName
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

		// Token: 0x0600813E RID: 33086 RVA: 0x0026B637 File Offset: 0x00269837
		public Span<byte> GetGmNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x0026B646 File Offset: 0x00269846
		public byte[] GetGmNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x0026B660 File Offset: 0x00269860
		public string FirstName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x0026B697 File Offset: 0x00269897
		public Span<byte> GetFirstNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x0026B6A6 File Offset: 0x002698A6
		public byte[] GetFirstNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06008143 RID: 33091 RVA: 0x0026B6C0 File Offset: 0x002698C0
		public int GmOrderListId
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

		// Token: 0x04005360 RID: 21344
		private Table __p;
	}
}
