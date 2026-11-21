using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EC RID: 17132
	public struct IInformationViewType : IFlatbufferObject
	{
		// Token: 0x17007550 RID: 30032
		// (get) Token: 0x060180E0 RID: 98528 RVA: 0x0036EADD File Offset: 0x0036CCDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180E1 RID: 98529 RVA: 0x0036EAEA File Offset: 0x0036CCEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180E2 RID: 98530 RVA: 0x0036EAF4 File Offset: 0x0036CCF4
		public static IInformationViewType GetRootAsIInformationViewType(ByteBuffer _bb)
		{
			return IInformationViewType.GetRootAsIInformationViewType(_bb, default(IInformationViewType));
		}

		// Token: 0x060180E3 RID: 98531 RVA: 0x0036EB10 File Offset: 0x0036CD10
		public static IInformationViewType GetRootAsIInformationViewType(ByteBuffer _bb, IInformationViewType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180E4 RID: 98532 RVA: 0x0036EB2D File Offset: 0x0036CD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180E5 RID: 98533 RVA: 0x0036EB3C File Offset: 0x0036CD3C
		public IInformationViewType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007551 RID: 30033
		// (get) Token: 0x060180E6 RID: 98534 RVA: 0x0036EB4C File Offset: 0x0036CD4C
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180E7 RID: 98535 RVA: 0x0036EB88 File Offset: 0x0036CD88
		public static Offset<IInformationViewType> CreateIInformationViewType(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IInformationViewType.AddType(builder, Type);
			return IInformationViewType.EndIInformationViewType(builder);
		}

		// Token: 0x060180E8 RID: 98536 RVA: 0x0036EB9E File Offset: 0x0036CD9E
		public static void StartIInformationViewType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060180E9 RID: 98537 RVA: 0x0036EBA7 File Offset: 0x0036CDA7
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060180EA RID: 98538 RVA: 0x0036EBB2 File Offset: 0x0036CDB2
		public static Offset<IInformationViewType> EndIInformationViewType(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewType>(builder.EndTable());
		}

		// Token: 0x060180EB RID: 98539 RVA: 0x0036EBC0 File Offset: 0x0036CDC0
		public IInformationViewTypeT UnPack()
		{
			IInformationViewTypeT informationViewTypeT = new IInformationViewTypeT();
			this.UnPackTo(informationViewTypeT);
			return informationViewTypeT;
		}

		// Token: 0x060180EC RID: 98540 RVA: 0x0036EBDB File Offset: 0x0036CDDB
		public void UnPackTo(IInformationViewTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060180ED RID: 98541 RVA: 0x0036EBEC File Offset: 0x0036CDEC
		public static Offset<IInformationViewType> Pack(FlatBufferBuilder builder, IInformationViewTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewType>);
			}
			return IInformationViewType.CreateIInformationViewType(builder, _o.Type);
		}

		// Token: 0x0400C256 RID: 49750
		private Table __p;
	}
}
