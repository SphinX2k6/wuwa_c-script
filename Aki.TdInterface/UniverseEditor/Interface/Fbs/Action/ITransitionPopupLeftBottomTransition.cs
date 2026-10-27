using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007448 RID: 29768
	public struct ITransitionPopupLeftBottomTransition : IFlatbufferObject
	{
		// Token: 0x1700E1FF RID: 57855
		// (get) Token: 0x0603613F RID: 221503 RVA: 0x0075ADE0 File Offset: 0x00758FE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036140 RID: 221504 RVA: 0x0075ADED File Offset: 0x00758FED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036141 RID: 221505 RVA: 0x0075ADF4 File Offset: 0x00758FF4
		public static ITransitionPopupLeftBottomTransition GetRootAsITransitionPopupLeftBottomTransition(ByteBuffer _bb)
		{
			return ITransitionPopupLeftBottomTransition.GetRootAsITransitionPopupLeftBottomTransition(_bb, default(ITransitionPopupLeftBottomTransition));
		}

		// Token: 0x06036142 RID: 221506 RVA: 0x0075AE10 File Offset: 0x00759010
		public static ITransitionPopupLeftBottomTransition GetRootAsITransitionPopupLeftBottomTransition(ByteBuffer _bb, ITransitionPopupLeftBottomTransition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036143 RID: 221507 RVA: 0x0075AE2D File Offset: 0x0075902D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036144 RID: 221508 RVA: 0x0075AE3C File Offset: 0x0075903C
		public ITransitionPopupLeftBottomTransition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E200 RID: 57856
		// (get) Token: 0x06036145 RID: 221509 RVA: 0x0075AE4C File Offset: 0x0075904C
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

		// Token: 0x1700E201 RID: 57857
		// (get) Token: 0x06036146 RID: 221510 RVA: 0x0075AE88 File Offset: 0x00759088
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

		// Token: 0x06036147 RID: 221511 RVA: 0x0075AEBF File Offset: 0x007590BF
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036148 RID: 221512 RVA: 0x0075AECE File Offset: 0x007590CE
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E202 RID: 57858
		// (get) Token: 0x06036149 RID: 221513 RVA: 0x0075AEDC File Offset: 0x007590DC
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

		// Token: 0x0603614A RID: 221514 RVA: 0x0075AF13 File Offset: 0x00759113
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603614B RID: 221515 RVA: 0x0075AF22 File Offset: 0x00759122
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603614C RID: 221516 RVA: 0x0075AF30 File Offset: 0x00759130
		public static Offset<ITransitionPopupLeftBottomTransition> CreateITransitionPopupLeftBottomTransition(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, StringOffset TitleTextOffset = default(StringOffset), StringOffset ContentTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITransitionPopupLeftBottomTransition.AddContentText(builder, ContentTextOffset);
			ITransitionPopupLeftBottomTransition.AddTitleText(builder, TitleTextOffset);
			ITransitionPopupLeftBottomTransition.AddType(builder, Type);
			return ITransitionPopupLeftBottomTransition.EndITransitionPopupLeftBottomTransition(builder);
		}

		// Token: 0x0603614D RID: 221517 RVA: 0x0075AF54 File Offset: 0x00759154
		public static void StartITransitionPopupLeftBottomTransition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603614E RID: 221518 RVA: 0x0075AF5D File Offset: 0x0075915D
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603614F RID: 221519 RVA: 0x0075AF68 File Offset: 0x00759168
		public static void AddTitleText(FlatBufferBuilder builder, StringOffset titleTextOffset)
		{
			builder.AddOffset(1, titleTextOffset.Value, 0);
		}

		// Token: 0x06036150 RID: 221520 RVA: 0x0075AF78 File Offset: 0x00759178
		public static void AddContentText(FlatBufferBuilder builder, StringOffset contentTextOffset)
		{
			builder.AddOffset(2, contentTextOffset.Value, 0);
		}

		// Token: 0x06036151 RID: 221521 RVA: 0x0075AF88 File Offset: 0x00759188
		public static Offset<ITransitionPopupLeftBottomTransition> EndITransitionPopupLeftBottomTransition(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupLeftBottomTransition>(builder.EndTable());
		}

		// Token: 0x06036152 RID: 221522 RVA: 0x0075AF98 File Offset: 0x00759198
		public ITransitionPopupLeftBottomTransitionT UnPack()
		{
			ITransitionPopupLeftBottomTransitionT transitionPopupLeftBottomTransitionT = new ITransitionPopupLeftBottomTransitionT();
			this.UnPackTo(transitionPopupLeftBottomTransitionT);
			return transitionPopupLeftBottomTransitionT;
		}

		// Token: 0x06036153 RID: 221523 RVA: 0x0075AFB3 File Offset: 0x007591B3
		public void UnPackTo(ITransitionPopupLeftBottomTransitionT _o)
		{
			_o.Type = this.Type;
			_o.TitleText = this.TitleText;
			_o.ContentText = this.ContentText;
		}

		// Token: 0x06036154 RID: 221524 RVA: 0x0075AFDC File Offset: 0x007591DC
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

		// Token: 0x040122CA RID: 74442
		private Table __p;
	}
}
