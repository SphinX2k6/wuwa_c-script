using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001183 RID: 4483
	public struct UiFloatConfig : IFlatbufferObject
	{
		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600E631 RID: 58929 RVA: 0x0033E8F8 File Offset: 0x0033CAF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E632 RID: 58930 RVA: 0x0033E905 File Offset: 0x0033CB05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E633 RID: 58931 RVA: 0x0033E90C File Offset: 0x0033CB0C
		public static UiFloatConfig GetRootAsUiFloatConfig(ByteBuffer _bb)
		{
			return UiFloatConfig.GetRootAsUiFloatConfig(_bb, default(UiFloatConfig));
		}

		// Token: 0x0600E634 RID: 58932 RVA: 0x0033E928 File Offset: 0x0033CB28
		public static UiFloatConfig GetRootAsUiFloatConfig(ByteBuffer _bb, UiFloatConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E635 RID: 58933 RVA: 0x0033E945 File Offset: 0x0033CB45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x0033E954 File Offset: 0x0033CB54
		public UiFloatConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600E637 RID: 58935 RVA: 0x0033E964 File Offset: 0x0033CB64
		public string ViewName
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

		// Token: 0x0600E638 RID: 58936 RVA: 0x0033E99B File Offset: 0x0033CB9B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x0033E9AA File Offset: 0x0033CBAA
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600E63A RID: 58938 RVA: 0x0033E9C4 File Offset: 0x0033CBC4
		public string Area
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

		// Token: 0x0600E63B RID: 58939 RVA: 0x0033E9FB File Offset: 0x0033CBFB
		public Span<byte> GetAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x0033EA0A File Offset: 0x0033CC0A
		public byte[] GetAreaArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600E63D RID: 58941 RVA: 0x0033EA24 File Offset: 0x0033CC24
		public int Priority
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

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600E63E RID: 58942 RVA: 0x0033EA60 File Offset: 0x0033CC60
		public bool OnlyShowInMain
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600E63F RID: 58943 RVA: 0x0033EAA0 File Offset: 0x0033CCA0
		public int RootItemIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600E640 RID: 58944 RVA: 0x0033EAE0 File Offset: 0x0033CCE0
		public bool IsWaitNormal
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600E641 RID: 58945 RVA: 0x0033EB20 File Offset: 0x0033CD20
		public bool HideInPureMode
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040052CC RID: 21196
		private Table __p;
	}
}
