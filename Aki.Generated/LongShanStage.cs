using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDB RID: 3547
	public struct LongShanStage : IFlatbufferObject
	{
		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06008F74 RID: 36724 RVA: 0x0027AD85 File Offset: 0x00278F85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x0027AD92 File Offset: 0x00278F92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0027AD9C File Offset: 0x00278F9C
		public static LongShanStage GetRootAsLongShanStage(ByteBuffer _bb)
		{
			return LongShanStage.GetRootAsLongShanStage(_bb, default(LongShanStage));
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x0027ADB8 File Offset: 0x00278FB8
		public static LongShanStage GetRootAsLongShanStage(ByteBuffer _bb, LongShanStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x0027ADD5 File Offset: 0x00278FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x0027ADE4 File Offset: 0x00278FE4
		public LongShanStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x0027ADF4 File Offset: 0x00278FF4
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

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06008F7B RID: 36731 RVA: 0x0027AE30 File Offset: 0x00279030
		public int ActivityId
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

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06008F7C RID: 36732 RVA: 0x0027AE6C File Offset: 0x0027906C
		public string Title
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

		// Token: 0x06008F7D RID: 36733 RVA: 0x0027AEA3 File Offset: 0x002790A3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x0027AEB2 File Offset: 0x002790B2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06008F7F RID: 36735 RVA: 0x0027AECC File Offset: 0x002790CC
		public string TitleDetail
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

		// Token: 0x06008F80 RID: 36736 RVA: 0x0027AF04 File Offset: 0x00279104
		public Span<byte> GetTitleDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x0027AF14 File Offset: 0x00279114
		public byte[] GetTitleDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06008F82 RID: 36738 RVA: 0x0027AF2C File Offset: 0x0027912C
		public int OpenConditionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06008F83 RID: 36739 RVA: 0x0027AF6C File Offset: 0x0027916C
		public int QuestionId
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

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06008F84 RID: 36740 RVA: 0x0027AFAC File Offset: 0x002791AC
		public string Picture
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x0027AFE4 File Offset: 0x002791E4
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x0027AFF4 File Offset: 0x002791F4
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06008F87 RID: 36743 RVA: 0x0027B00C File Offset: 0x0027920C
		public string RomeNumSprite
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x0027B044 File Offset: 0x00279244
		public Span<byte> GetRomeNumSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0027B054 File Offset: 0x00279254
		public byte[] GetRomeNumSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06008F8A RID: 36746 RVA: 0x0027B06C File Offset: 0x0027926C
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E76 RID: 20086
		private Table __p;
	}
}
