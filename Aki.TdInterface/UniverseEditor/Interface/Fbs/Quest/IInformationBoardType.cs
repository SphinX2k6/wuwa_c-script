using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E9C RID: 16028
	public struct IInformationBoardType : IFlatbufferObject
	{
		// Token: 0x17006F4A RID: 28490
		// (get) Token: 0x06016A14 RID: 92692 RVA: 0x00344E0F File Offset: 0x0034300F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A15 RID: 92693 RVA: 0x00344E1C File Offset: 0x0034301C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A16 RID: 92694 RVA: 0x00344E24 File Offset: 0x00343024
		public static IInformationBoardType GetRootAsIInformationBoardType(ByteBuffer _bb)
		{
			return IInformationBoardType.GetRootAsIInformationBoardType(_bb, default(IInformationBoardType));
		}

		// Token: 0x06016A17 RID: 92695 RVA: 0x00344E40 File Offset: 0x00343040
		public static IInformationBoardType GetRootAsIInformationBoardType(ByteBuffer _bb, IInformationBoardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A18 RID: 92696 RVA: 0x00344E5D File Offset: 0x0034305D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A19 RID: 92697 RVA: 0x00344E6C File Offset: 0x0034306C
		public IInformationBoardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F4B RID: 28491
		// (get) Token: 0x06016A1A RID: 92698 RVA: 0x00344E7C File Offset: 0x0034307C
		public EInformationBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationBoardType.DangoAbyss;
				}
				return (EInformationBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016A1B RID: 92699 RVA: 0x00344EB8 File Offset: 0x003430B8
		public static Offset<IInformationBoardType> CreateIInformationBoardType(FlatBufferBuilder builder, EInformationBoardType Type = EInformationBoardType.DangoAbyss)
		{
			builder.StartTable(1);
			IInformationBoardType.AddType(builder, Type);
			return IInformationBoardType.EndIInformationBoardType(builder);
		}

		// Token: 0x06016A1C RID: 92700 RVA: 0x00344ECE File Offset: 0x003430CE
		public static void StartIInformationBoardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016A1D RID: 92701 RVA: 0x00344ED7 File Offset: 0x003430D7
		public static void AddType(FlatBufferBuilder builder, EInformationBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A1E RID: 92702 RVA: 0x00344EE2 File Offset: 0x003430E2
		public static Offset<IInformationBoardType> EndIInformationBoardType(FlatBufferBuilder builder)
		{
			return new Offset<IInformationBoardType>(builder.EndTable());
		}

		// Token: 0x06016A1F RID: 92703 RVA: 0x00344EF0 File Offset: 0x003430F0
		public IInformationBoardTypeT UnPack()
		{
			IInformationBoardTypeT informationBoardTypeT = new IInformationBoardTypeT();
			this.UnPackTo(informationBoardTypeT);
			return informationBoardTypeT;
		}

		// Token: 0x06016A20 RID: 92704 RVA: 0x00344F0B File Offset: 0x0034310B
		public void UnPackTo(IInformationBoardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016A21 RID: 92705 RVA: 0x00344F1C File Offset: 0x0034311C
		public static Offset<IInformationBoardType> Pack(FlatBufferBuilder builder, IInformationBoardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationBoardType>);
			}
			return IInformationBoardType.CreateIInformationBoardType(builder, _o.Type);
		}

		// Token: 0x0400B866 RID: 47206
		private Table __p;
	}
}
