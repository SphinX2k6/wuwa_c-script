using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C3E RID: 31806
	public struct ITransitionPopupLeftTopTip : IFlatbufferObject
	{
		// Token: 0x1700EE23 RID: 60963
		// (get) Token: 0x06039546 RID: 234822 RVA: 0x007BDDF9 File Offset: 0x007BBFF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039547 RID: 234823 RVA: 0x007BDE06 File Offset: 0x007BC006
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039548 RID: 234824 RVA: 0x007BDE10 File Offset: 0x007BC010
		public static ITransitionPopupLeftTopTip GetRootAsITransitionPopupLeftTopTip(ByteBuffer _bb)
		{
			return ITransitionPopupLeftTopTip.GetRootAsITransitionPopupLeftTopTip(_bb, default(ITransitionPopupLeftTopTip));
		}

		// Token: 0x06039549 RID: 234825 RVA: 0x007BDE2C File Offset: 0x007BC02C
		public static ITransitionPopupLeftTopTip GetRootAsITransitionPopupLeftTopTip(ByteBuffer _bb, ITransitionPopupLeftTopTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603954A RID: 234826 RVA: 0x007BDE49 File Offset: 0x007BC049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603954B RID: 234827 RVA: 0x007BDE58 File Offset: 0x007BC058
		public ITransitionPopupLeftTopTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE24 RID: 60964
		// (get) Token: 0x0603954C RID: 234828 RVA: 0x007BDE68 File Offset: 0x007BC068
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

		// Token: 0x1700EE25 RID: 60965
		// (get) Token: 0x0603954D RID: 234829 RVA: 0x007BDEA4 File Offset: 0x007BC0A4
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

		// Token: 0x0603954E RID: 234830 RVA: 0x007BDEDB File Offset: 0x007BC0DB
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603954F RID: 234831 RVA: 0x007BDEEA File Offset: 0x007BC0EA
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700EE26 RID: 60966
		// (get) Token: 0x06039550 RID: 234832 RVA: 0x007BDEF8 File Offset: 0x007BC0F8
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

		// Token: 0x06039551 RID: 234833 RVA: 0x007BDF2F File Offset: 0x007BC12F
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039552 RID: 234834 RVA: 0x007BDF3E File Offset: 0x007BC13E
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039553 RID: 234835 RVA: 0x007BDF4C File Offset: 0x007BC14C
		public static Offset<ITransitionPopupLeftTopTip> CreateITransitionPopupLeftTopTip(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, StringOffset TitleTextOffset = default(StringOffset), StringOffset ContentTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITransitionPopupLeftTopTip.AddContentText(builder, ContentTextOffset);
			ITransitionPopupLeftTopTip.AddTitleText(builder, TitleTextOffset);
			ITransitionPopupLeftTopTip.AddType(builder, Type);
			return ITransitionPopupLeftTopTip.EndITransitionPopupLeftTopTip(builder);
		}

		// Token: 0x06039554 RID: 234836 RVA: 0x007BDF70 File Offset: 0x007BC170
		public static void StartITransitionPopupLeftTopTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039555 RID: 234837 RVA: 0x007BDF79 File Offset: 0x007BC179
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039556 RID: 234838 RVA: 0x007BDF84 File Offset: 0x007BC184
		public static void AddTitleText(FlatBufferBuilder builder, StringOffset titleTextOffset)
		{
			builder.AddOffset(1, titleTextOffset.Value, 0);
		}

		// Token: 0x06039557 RID: 234839 RVA: 0x007BDF94 File Offset: 0x007BC194
		public static void AddContentText(FlatBufferBuilder builder, StringOffset contentTextOffset)
		{
			builder.AddOffset(2, contentTextOffset.Value, 0);
		}

		// Token: 0x06039558 RID: 234840 RVA: 0x007BDFA4 File Offset: 0x007BC1A4
		public static Offset<ITransitionPopupLeftTopTip> EndITransitionPopupLeftTopTip(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupLeftTopTip>(builder.EndTable());
		}

		// Token: 0x06039559 RID: 234841 RVA: 0x007BDFB4 File Offset: 0x007BC1B4
		public ITransitionPopupLeftTopTipT UnPack()
		{
			ITransitionPopupLeftTopTipT transitionPopupLeftTopTipT = new ITransitionPopupLeftTopTipT();
			this.UnPackTo(transitionPopupLeftTopTipT);
			return transitionPopupLeftTopTipT;
		}

		// Token: 0x0603955A RID: 234842 RVA: 0x007BDFCF File Offset: 0x007BC1CF
		public void UnPackTo(ITransitionPopupLeftTopTipT _o)
		{
			_o.Type = this.Type;
			_o.TitleText = this.TitleText;
			_o.ContentText = this.ContentText;
		}

		// Token: 0x0603955B RID: 234843 RVA: 0x007BDFF8 File Offset: 0x007BC1F8
		public static Offset<ITransitionPopupLeftTopTip> Pack(FlatBufferBuilder builder, ITransitionPopupLeftTopTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupLeftTopTip>);
			}
			StringOffset titleTextOffset = (_o.TitleText == null) ? default(StringOffset) : builder.CreateString(_o.TitleText);
			StringOffset contentTextOffset = (_o.ContentText == null) ? default(StringOffset) : builder.CreateString(_o.ContentText);
			return ITransitionPopupLeftTopTip.CreateITransitionPopupLeftTopTip(builder, _o.Type, titleTextOffset, contentTextOffset);
		}

		// Token: 0x040132F5 RID: 78581
		private Table __p;
	}
}
