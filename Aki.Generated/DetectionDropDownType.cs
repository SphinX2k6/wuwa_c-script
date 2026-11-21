using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC9 RID: 3273
	public struct DetectionDropDownType : IFlatbufferObject
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x00230FC1 File Offset: 0x0022F1C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x00230FCE File Offset: 0x0022F1CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00230FD8 File Offset: 0x0022F1D8
		public static DetectionDropDownType GetRootAsDetectionDropDownType(ByteBuffer _bb)
		{
			return DetectionDropDownType.GetRootAsDetectionDropDownType(_bb, default(DetectionDropDownType));
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00230FF4 File Offset: 0x0022F1F4
		public static DetectionDropDownType GetRootAsDetectionDropDownType(ByteBuffer _bb, DetectionDropDownType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00231011 File Offset: 0x0022F211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00231020 File Offset: 0x0022F220
		public DetectionDropDownType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x00231030 File Offset: 0x0022F230
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

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06006746 RID: 26438 RVA: 0x0023106C File Offset: 0x0022F26C
		public string Text
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

		// Token: 0x06006747 RID: 26439 RVA: 0x002310A3 File Offset: 0x0022F2A3
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x002310B2 File Offset: 0x0022F2B2
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051F6 RID: 20982
		private Table __p;
	}
}
