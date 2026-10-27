using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D90 RID: 3472
	public struct KSCBuff : IFlatbufferObject
	{
		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x0026A9B8 File Offset: 0x00268BB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x0026A9C5 File Offset: 0x00268BC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x0026A9CC File Offset: 0x00268BCC
		public static KSCBuff GetRootAsKSCBuff(ByteBuffer _bb)
		{
			return KSCBuff.GetRootAsKSCBuff(_bb, default(KSCBuff));
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x0026A9E8 File Offset: 0x00268BE8
		public static KSCBuff GetRootAsKSCBuff(ByteBuffer _bb, KSCBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008836 RID: 34870 RVA: 0x0026AA05 File Offset: 0x00268C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x0026AA14 File Offset: 0x00268C14
		public KSCBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x0026AA24 File Offset: 0x00268C24
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

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06008839 RID: 34873 RVA: 0x0026AA60 File Offset: 0x00268C60
		public string AssetPath
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

		// Token: 0x0600883A RID: 34874 RVA: 0x0026AA97 File Offset: 0x00268C97
		public Span<byte> GetAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x0026AAA6 File Offset: 0x00268CA6
		public byte[] GetAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E1D RID: 19997
		private Table __p;
	}
}
