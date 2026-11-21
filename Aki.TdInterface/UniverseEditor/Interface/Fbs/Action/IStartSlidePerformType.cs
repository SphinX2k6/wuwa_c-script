using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200798C RID: 31116
	public struct IStartSlidePerformType : IFlatbufferObject
	{
		// Token: 0x1700E42C RID: 58412
		// (get) Token: 0x06036CEE RID: 224494 RVA: 0x00754CB5 File Offset: 0x00752EB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CEF RID: 224495 RVA: 0x00754CC2 File Offset: 0x00752EC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CF0 RID: 224496 RVA: 0x00754CCC File Offset: 0x00752ECC
		public static IStartSlidePerformType GetRootAsIStartSlidePerformType(ByteBuffer _bb)
		{
			return IStartSlidePerformType.GetRootAsIStartSlidePerformType(_bb, default(IStartSlidePerformType));
		}

		// Token: 0x06036CF1 RID: 224497 RVA: 0x00754CE8 File Offset: 0x00752EE8
		public static IStartSlidePerformType GetRootAsIStartSlidePerformType(ByteBuffer _bb, IStartSlidePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036CF2 RID: 224498 RVA: 0x00754D05 File Offset: 0x00752F05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036CF3 RID: 224499 RVA: 0x00754D14 File Offset: 0x00752F14
		public IStartSlidePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E42D RID: 58413
		// (get) Token: 0x06036CF4 RID: 224500 RVA: 0x00754D24 File Offset: 0x00752F24
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036CF5 RID: 224501 RVA: 0x00754D60 File Offset: 0x00752F60
		public static Offset<IStartSlidePerformType> CreateIStartSlidePerformType(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide)
		{
			builder.StartTable(1);
			IStartSlidePerformType.AddType(builder, Type);
			return IStartSlidePerformType.EndIStartSlidePerformType(builder);
		}

		// Token: 0x06036CF6 RID: 224502 RVA: 0x00754D76 File Offset: 0x00752F76
		public static void StartIStartSlidePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036CF7 RID: 224503 RVA: 0x00754D7F File Offset: 0x00752F7F
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036CF8 RID: 224504 RVA: 0x00754D8A File Offset: 0x00752F8A
		public static Offset<IStartSlidePerformType> EndIStartSlidePerformType(FlatBufferBuilder builder)
		{
			return new Offset<IStartSlidePerformType>(builder.EndTable());
		}

		// Token: 0x06036CF9 RID: 224505 RVA: 0x00754D98 File Offset: 0x00752F98
		public IStartSlidePerformTypeT UnPack()
		{
			IStartSlidePerformTypeT startSlidePerformTypeT = new IStartSlidePerformTypeT();
			this.UnPackTo(startSlidePerformTypeT);
			return startSlidePerformTypeT;
		}

		// Token: 0x06036CFA RID: 224506 RVA: 0x00754DB3 File Offset: 0x00752FB3
		public void UnPackTo(IStartSlidePerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036CFB RID: 224507 RVA: 0x00754DC4 File Offset: 0x00752FC4
		public static Offset<IStartSlidePerformType> Pack(FlatBufferBuilder builder, IStartSlidePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartSlidePerformType>);
			}
			return IStartSlidePerformType.CreateIStartSlidePerformType(builder, _o.Type);
		}

		// Token: 0x04012C84 RID: 76932
		private Table __p;
	}
}
