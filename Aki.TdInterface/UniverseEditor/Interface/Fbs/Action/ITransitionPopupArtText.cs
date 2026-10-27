using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743C RID: 29756
	public struct ITransitionPopupArtText : IFlatbufferObject
	{
		// Token: 0x1700E1EE RID: 57838
		// (get) Token: 0x060360EC RID: 221420 RVA: 0x0075A460 File Offset: 0x00758660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060360ED RID: 221421 RVA: 0x0075A46D File Offset: 0x0075866D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060360EE RID: 221422 RVA: 0x0075A474 File Offset: 0x00758674
		public static ITransitionPopupArtText GetRootAsITransitionPopupArtText(ByteBuffer _bb)
		{
			return ITransitionPopupArtText.GetRootAsITransitionPopupArtText(_bb, default(ITransitionPopupArtText));
		}

		// Token: 0x060360EF RID: 221423 RVA: 0x0075A490 File Offset: 0x00758690
		public static ITransitionPopupArtText GetRootAsITransitionPopupArtText(ByteBuffer _bb, ITransitionPopupArtText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060360F0 RID: 221424 RVA: 0x0075A4AD File Offset: 0x007586AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060360F1 RID: 221425 RVA: 0x0075A4BC File Offset: 0x007586BC
		public ITransitionPopupArtText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1EF RID: 57839
		// (get) Token: 0x060360F2 RID: 221426 RVA: 0x0075A4CC File Offset: 0x007586CC
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

		// Token: 0x1700E1F0 RID: 57840
		// (get) Token: 0x060360F3 RID: 221427 RVA: 0x0075A508 File Offset: 0x00758708
		public ITransitionPopupYuanChengArtText? ArtTextType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransitionPopupYuanChengArtText?(default(ITransitionPopupYuanChengArtText).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060360F4 RID: 221428 RVA: 0x0075A565 File Offset: 0x00758765
		public static Offset<ITransitionPopupArtText> CreateITransitionPopupArtText(FlatBufferBuilder builder, ETransitionPopupStyleType Type = ETransitionPopupStyleType.LeftTopTip, Offset<ITransitionPopupYuanChengArtText> ArtTextTypeOffset = default(Offset<ITransitionPopupYuanChengArtText>))
		{
			builder.StartTable(2);
			ITransitionPopupArtText.AddArtTextType(builder, ArtTextTypeOffset);
			ITransitionPopupArtText.AddType(builder, Type);
			return ITransitionPopupArtText.EndITransitionPopupArtText(builder);
		}

		// Token: 0x060360F5 RID: 221429 RVA: 0x0075A582 File Offset: 0x00758782
		public static void StartITransitionPopupArtText(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060360F6 RID: 221430 RVA: 0x0075A58B File Offset: 0x0075878B
		public static void AddType(FlatBufferBuilder builder, ETransitionPopupStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060360F7 RID: 221431 RVA: 0x0075A596 File Offset: 0x00758796
		public static void AddArtTextType(FlatBufferBuilder builder, Offset<ITransitionPopupYuanChengArtText> artTextTypeOffset)
		{
			builder.AddOffset(1, artTextTypeOffset.Value, 0);
		}

		// Token: 0x060360F8 RID: 221432 RVA: 0x0075A5A6 File Offset: 0x007587A6
		public static Offset<ITransitionPopupArtText> EndITransitionPopupArtText(FlatBufferBuilder builder)
		{
			return new Offset<ITransitionPopupArtText>(builder.EndTable());
		}

		// Token: 0x060360F9 RID: 221433 RVA: 0x0075A5B4 File Offset: 0x007587B4
		public ITransitionPopupArtTextT UnPack()
		{
			ITransitionPopupArtTextT transitionPopupArtTextT = new ITransitionPopupArtTextT();
			this.UnPackTo(transitionPopupArtTextT);
			return transitionPopupArtTextT;
		}

		// Token: 0x060360FA RID: 221434 RVA: 0x0075A5D0 File Offset: 0x007587D0
		public void UnPackTo(ITransitionPopupArtTextT _o)
		{
			_o.Type = this.Type;
			_o.ArtTextType = ((this.ArtTextType != null) ? this.ArtTextType.Value.UnPack() : null);
		}

		// Token: 0x060360FB RID: 221435 RVA: 0x0075A618 File Offset: 0x00758818
		public static Offset<ITransitionPopupArtText> Pack(FlatBufferBuilder builder, ITransitionPopupArtTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransitionPopupArtText>);
			}
			Offset<ITransitionPopupYuanChengArtText> artTextTypeOffset = (_o.ArtTextType == null) ? default(Offset<ITransitionPopupYuanChengArtText>) : ITransitionPopupYuanChengArtText.Pack(builder, _o.ArtTextType);
			return ITransitionPopupArtText.CreateITransitionPopupArtText(builder, _o.Type, artTextTypeOffset);
		}

		// Token: 0x040122BB RID: 74427
		private Table __p;
	}
}
