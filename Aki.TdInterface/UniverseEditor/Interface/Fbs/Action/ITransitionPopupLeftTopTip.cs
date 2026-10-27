using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744B RID: 29771
	public struct ITransitionPopupLeftTopTip : IFlatbufferObject
	{
		// Token: 0x1700E206 RID: 57862
		// (get) Token: 0x0603615D RID: 221533 RVA: 0x0075B0CD File Offset: 0x007592CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603615E RID: 221534 RVA: 0x0075B0DA File Offset: 0x007592DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603615F RID: 221535 RVA: 0x0075B0E4 File Offset: 0x007592E4
		public static ITransitionPopupLeftTopTip GetRootAsITransitionPopupLeftTopTip(ByteBuffer _bb)
		{
			return ITransitionPopupLeftTopTip.GetRootAsITransitionPopupLeftTopTip(_bb, default(ITransitionPopupLeftTopTip));
		}

		// Token: 0x06036160 RID: 221536 RVA: 0x0075B100 File Offset: 0x00759300
		public static ITransitionPopupLeftTopTip GetRootAsITransitionPopupLeftTopTip(ByteBuffer _bb, ITransitionPopupLeftTopTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036161 RID: 221537 RVA: 0x0075B11D File Offset: 0x0075931D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036162 RID: 221538 RVA: 0x0075B12C File Offset: 0x0075932C
		public ITransitionPopupLeftTopTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E207 RID: 57863
		// (get) Token: 0x06036163 RID: 221539 RVA: 0x0075B13C File Offset: 0x0075933C
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

		// Token: 0x1700E208 RID: 57864
		// (get) Token: 0x06036164 RID: 221540 RVA: 0x0075B178 File Offset: 0x00759378
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

		// Token: 0x06036165 RID: 221541 RVA: 0x0075B1AF File Offset: 0x007593AF
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036166 RID: 221542 RVA: 0x0075B1BE File Offset: 0x007593BE
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E209 RID: 57865
		// (get) Token: 0x06036167 RID: 221543 RVA: 0x0075B1CC File Offset: 0x007593CC
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

		// Token: 0x06036168 RID: 221544 RVA: 0x0075B203 File Offset: 0x00759403
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036169 RID: 221545 RVA: 0x0075B212 File Offset: 0x00759412
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603616A RID: 221546 RVA: 0x0075B220 File Offset: 0x00759420
		public static Offset<ITransitionPopupLeftTopTip> CreateITransitionPopupLeftTopTip(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, StringOffset TitleTextOffset = default(StringOffset), StringOffset ContentTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITransitionPopupLeftTopTip.AddContentText(builder, ContentTextOffset);
			ITransitionPopupLeftTopTip.AddTitleText(builder, TitleTextOffset);
			ITransitionPopupLeftTopTip.AddType(builder, Type);
			return ITransitionPopupLeftTopTip.EndITransitionPopupLeftTopTip(builder);
		}

		// Token: 0x0603616B RID: 221547 RVA: 0x0075B244 File Offset: 0x00759444
		public static void StartITransitionPopupLeftTopTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603616C RID: 221548 RVA: 0x0075B24D File Offset: 0x0075944D
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603616D RID: 221549 RVA: 0x0075B258 File Offset: 0x00759458
		public static void AddTitleText(FlatBufferBuilder builder, StringOffset titleTextOffset)
		{
			builder.AddOffset(1, titleTextOffset.Value, 0);
		}

		// Token: 0x0603616E RID: 221550 RVA: 0x0075B268 File Offset: 0x00759468
		public static void AddContentText(FlatBufferBuilder builder, StringOffset contentTextOffset)
		{
			builder.AddOffset(2, contentTextOffset.Value, 0);
		}

		// Token: 0x0603616F RID: 221551 RVA: 0x0075B278 File Offset: 0x00759478
		public static Offset<ITransitionPopupLeftTopTip> EndITransitionPopupLeftTopTip(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupLeftTopTip>(builder.EndTable());
		}

		// Token: 0x06036170 RID: 221552 RVA: 0x0075B288 File Offset: 0x00759488
		public ITransitionPopupLeftTopTipT UnPack()
		{
			ITransitionPopupLeftTopTipT transitionPopupLeftTopTipT = new ITransitionPopupLeftTopTipT();
			this.UnPackTo(transitionPopupLeftTopTipT);
			return transitionPopupLeftTopTipT;
		}

		// Token: 0x06036171 RID: 221553 RVA: 0x0075B2A3 File Offset: 0x007594A3
		public void UnPackTo(ITransitionPopupLeftTopTipT _o)
		{
			_o.Type = this.Type;
			_o.TitleText = this.TitleText;
			_o.ContentText = this.ContentText;
		}

		// Token: 0x06036172 RID: 221554 RVA: 0x0075B2CC File Offset: 0x007594CC
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

		// Token: 0x040122CE RID: 74446
		private Table __p;
	}
}
