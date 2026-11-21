using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCB RID: 3275
	public struct DetectionText : IFlatbufferObject
	{
		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x002312AD File Offset: 0x0022F4AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x002312BA File Offset: 0x0022F4BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x002312C4 File Offset: 0x0022F4C4
		public static DetectionText GetRootAsDetectionText(ByteBuffer _bb)
		{
			return DetectionText.GetRootAsDetectionText(_bb, default(DetectionText));
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x002312E0 File Offset: 0x0022F4E0
		public static DetectionText GetRootAsDetectionText(ByteBuffer _bb, DetectionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x002312FD File Offset: 0x0022F4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x0023130C File Offset: 0x0022F50C
		public DetectionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x0023131C File Offset: 0x0022F51C
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600675F RID: 26463 RVA: 0x00231358 File Offset: 0x0022F558
		public int ConditionGroupId
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x00231394 File Offset: 0x0022F594
		public string Text
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

		// Token: 0x06006761 RID: 26465 RVA: 0x002313CB File Offset: 0x0022F5CB
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x002313DA File Offset: 0x0022F5DA
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06006763 RID: 26467 RVA: 0x002313F4 File Offset: 0x0022F5F4
		public string SubText
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

		// Token: 0x06006764 RID: 26468 RVA: 0x0023142C File Offset: 0x0022F62C
		public Span<byte> GetSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x0023143C File Offset: 0x0022F63C
		public byte[] GetSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06006766 RID: 26470 RVA: 0x00231454 File Offset: 0x0022F654
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x0023148C File Offset: 0x0022F68C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x0023149C File Offset: 0x0022F69C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x002314B4 File Offset: 0x0022F6B4
		public int HelpGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051F8 RID: 20984
		private Table __p;
	}
}
