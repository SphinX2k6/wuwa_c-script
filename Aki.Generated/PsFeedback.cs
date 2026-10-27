using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5F RID: 3935
	public struct PsFeedback : IFlatbufferObject
	{
		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x002CC394 File Offset: 0x002CA594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x002CC3A1 File Offset: 0x002CA5A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x002CC3A8 File Offset: 0x002CA5A8
		public static PsFeedback GetRootAsPsFeedback(ByteBuffer _bb)
		{
			return PsFeedback.GetRootAsPsFeedback(_bb, default(PsFeedback));
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x002CC3C4 File Offset: 0x002CA5C4
		public static PsFeedback GetRootAsPsFeedback(ByteBuffer _bb, PsFeedback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x002CC3E1 File Offset: 0x002CA5E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x002CC3F0 File Offset: 0x002CA5F0
		public PsFeedback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x002CC400 File Offset: 0x002CA600
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

		// Token: 0x0600B3CC RID: 46028 RVA: 0x002CC437 File Offset: 0x002CA637
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x002CC446 File Offset: 0x002CA646
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600B3CE RID: 46030 RVA: 0x002CC460 File Offset: 0x002CA660
		public string ActionName
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

		// Token: 0x0600B3CF RID: 46031 RVA: 0x002CC497 File Offset: 0x002CA697
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x002CC4A6 File Offset: 0x002CA6A6
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600B3D1 RID: 46033 RVA: 0x002CC4C0 File Offset: 0x002CA6C0
		public bool IsAxis
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600B3D2 RID: 46034 RVA: 0x002CC500 File Offset: 0x002CA700
		public string FeedbackPath
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

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x002CC538 File Offset: 0x002CA738
		public Span<byte> GetFeedbackPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x002CC548 File Offset: 0x002CA748
		public byte[] GetFeedbackPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600B3D5 RID: 46037 RVA: 0x002CC560 File Offset: 0x002CA760
		public string ListenTag
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

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x002CC598 File Offset: 0x002CA798
		public Span<byte> GetListenTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x002CC5A8 File Offset: 0x002CA7A8
		public byte[] GetListenTagArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600B3D8 RID: 46040 RVA: 0x002CC5C0 File Offset: 0x002CA7C0
		public int Priority
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

		// Token: 0x0400502D RID: 20525
		private Table __p;
	}
}
