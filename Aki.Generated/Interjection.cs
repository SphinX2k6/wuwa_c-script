using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7A RID: 3450
	public struct Interjection : IFlatbufferObject
	{
		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06008624 RID: 34340 RVA: 0x002656A0 File Offset: 0x002638A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008625 RID: 34341 RVA: 0x002656AD File Offset: 0x002638AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x002656B4 File Offset: 0x002638B4
		public static Interjection GetRootAsInterjection(ByteBuffer _bb)
		{
			return Interjection.GetRootAsInterjection(_bb, default(Interjection));
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x002656D0 File Offset: 0x002638D0
		public static Interjection GetRootAsInterjection(ByteBuffer _bb, Interjection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x002656ED File Offset: 0x002638ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x002656FC File Offset: 0x002638FC
		public Interjection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x0600862A RID: 34346 RVA: 0x0026570C File Offset: 0x0026390C
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

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600862B RID: 34347 RVA: 0x00265748 File Offset: 0x00263948
		public int TimberId
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

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600862C RID: 34348 RVA: 0x00265784 File Offset: 0x00263984
		public int UniversalToneId
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

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x002657C0 File Offset: 0x002639C0
		public string AkEvent
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x002657F8 File Offset: 0x002639F8
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x00265808 File Offset: 0x00263A08
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E02 RID: 19970
		private Table __p;
	}
}
