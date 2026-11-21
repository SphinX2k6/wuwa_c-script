using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C3B RID: 31803
	public struct ITransitionPopupLeftBottomTransition : IFlatbufferObject
	{
		// Token: 0x1700EE1C RID: 60956
		// (get) Token: 0x06039528 RID: 234792 RVA: 0x007BDB0C File Offset: 0x007BBD0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039529 RID: 234793 RVA: 0x007BDB19 File Offset: 0x007BBD19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603952A RID: 234794 RVA: 0x007BDB20 File Offset: 0x007BBD20
		public static ITransitionPopupLeftBottomTransition GetRootAsITransitionPopupLeftBottomTransition(ByteBuffer _bb)
		{
			return ITransitionPopupLeftBottomTransition.GetRootAsITransitionPopupLeftBottomTransition(_bb, default(ITransitionPopupLeftBottomTransition));
		}

		// Token: 0x0603952B RID: 234795 RVA: 0x007BDB3C File Offset: 0x007BBD3C
		public static ITransitionPopupLeftBottomTransition GetRootAsITransitionPopupLeftBottomTransition(ByteBuffer _bb, ITransitionPopupLeftBottomTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603952C RID: 234796 RVA: 0x007BDB59 File Offset: 0x007BBD59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603952D RID: 234797 RVA: 0x007BDB68 File Offset: 0x007BBD68
		public ITransitionPopupLeftBottomTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE1D RID: 60957
		// (get) Token: 0x0603952E RID: 234798 RVA: 0x007BDB78 File Offset: 0x007BBD78
		public ETransitionPopupStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return (ETransitionPopupStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE1E RID: 60958
		// (get) Token: 0x0603952F RID: 234799 RVA: 0x007BDBB4 File Offset: 0x007BBDB4
		public string TitleText
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

		// Token: 0x06039530 RID: 234800 RVA: 0x007BDBEB File Offset: 0x007BBDEB
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06039531 RID: 234801 RVA: 0x007BDBFA File Offset: 0x007BBDFA
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700EE1F RID: 60959
		// (get) Token: 0x06039532 RID: 234802 RVA: 0x007BDC08 File Offset: 0x007BBE08
		public string ContentText
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

		// Token: 0x06039533 RID: 234803 RVA: 0x007BDC3F File Offset: 0x007BBE3F
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039534 RID: 234804 RVA: 0x007BDC4E File Offset: 0x007BBE4E
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039535 RID: 234805 RVA: 0x007BDC5C File Offset: 0x007BBE5C
		public static Offset<ITransitionPopupLeftBottomTransition> CreateITransitionPopupLeftBottomTransition(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, StringOffset TitleTextOffset = default(StringOffset), StringOffset ContentTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITransitionPopupLeftBottomTransition.AddContentText(builder, ContentTextOffset);
			ITransitionPopupLeftBottomTransition.AddTitleText(builder, TitleTextOffset);
			ITransitionPopupLeftBottomTransition.AddType(builder, Type);
			return ITransitionPopupLeftBottomTransition.EndITransitionPopupLeftBottomTransition(builder);
		}

		// Token: 0x06039536 RID: 234806 RVA: 0x007BDC80 File Offset: 0x007BBE80
		public static void StartITransitionPopupLeftBottomTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039537 RID: 234807 RVA: 0x007BDC89 File Offset: 0x007BBE89
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039538 RID: 234808 RVA: 0x007BDC94 File Offset: 0x007BBE94
		public static void AddTitleText(FlatBufferBuilder builder, StringOffset titleTextOffset)
		{
			builder.AddOffset(1, titleTextOffset.Value, 0);
		}

		// Token: 0x06039539 RID: 234809 RVA: 0x007BDCA4 File Offset: 0x007BBEA4
		public static void AddContentText(FlatBufferBuilder builder, StringOffset contentTextOffset)
		{
			builder.AddOffset(2, contentTextOffset.Value, 0);
		}

		// Token: 0x0603953A RID: 234810 RVA: 0x007BDCB4 File Offset: 0x007BBEB4
		public static Offset<ITransitionPopupLeftBottomTransition> EndITransitionPopupLeftBottomTransition(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupLeftBottomTransition>(builder.EndTable());
		}

		// Token: 0x0603953B RID: 234811 RVA: 0x007BDCC4 File Offset: 0x007BBEC4
		public ITransitionPopupLeftBottomTransitionT UnPack()
		{
			ITransitionPopupLeftBottomTransitionT transitionPopupLeftBottomTransitionT = new ITransitionPopupLeftBottomTransitionT();
			this.UnPackTo(transitionPopupLeftBottomTransitionT);
			return transitionPopupLeftBottomTransitionT;
		}

		// Token: 0x0603953C RID: 234812 RVA: 0x007BDCDF File Offset: 0x007BBEDF
		public void UnPackTo(ITransitionPopupLeftBottomTransitionT _o)
		{
			_o.Type = this.Type;
			_o.TitleText = this.TitleText;
			_o.ContentText = this.ContentText;
		}

		// Token: 0x0603953D RID: 234813 RVA: 0x007BDD08 File Offset: 0x007BBF08
		public static Offset<ITransitionPopupLeftBottomTransition> Pack(FlatBufferBuilder builder, ITransitionPopupLeftBottomTransitionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupLeftBottomTransition>);
			}
			StringOffset titleTextOffset = (_o.TitleText == null) ? default(StringOffset) : builder.CreateString(_o.TitleText);
			StringOffset contentTextOffset = (_o.ContentText == null) ? default(StringOffset) : builder.CreateString(_o.ContentText);
			return ITransitionPopupLeftBottomTransition.CreateITransitionPopupLeftBottomTransition(builder, _o.Type, titleTextOffset, contentTextOffset);
		}

		// Token: 0x040132F1 RID: 78577
		private Table __p;
	}
}
