using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F4 RID: 4852
	public struct DicStringFloat : IFlatbufferObject
	{
		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x003727B7 File Offset: 0x003709B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x003727C4 File Offset: 0x003709C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x003727CC File Offset: 0x003709CC
		public static DicStringFloat GetRootAsDicStringFloat(ByteBuffer _bb)
		{
			return DicStringFloat.GetRootAsDicStringFloat(_bb, default(DicStringFloat));
		}

		// Token: 0x0600F7AD RID: 63405 RVA: 0x003727E8 File Offset: 0x003709E8
		public static DicStringFloat GetRootAsDicStringFloat(ByteBuffer _bb, DicStringFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7AE RID: 63406 RVA: 0x00372805 File Offset: 0x00370A05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7AF RID: 63407 RVA: 0x00372814 File Offset: 0x00370A14
		public DicStringFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x00372824 File Offset: 0x00370A24
		public string Key
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

		// Token: 0x0600F7B1 RID: 63409 RVA: 0x0037285B File Offset: 0x00370A5B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F7B2 RID: 63410 RVA: 0x0037286A File Offset: 0x00370A6A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0600F7B3 RID: 63411 RVA: 0x00372884 File Offset: 0x00370A84
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

		// Token: 0x04005952 RID: 22866
		private Table __p;
	}
}
