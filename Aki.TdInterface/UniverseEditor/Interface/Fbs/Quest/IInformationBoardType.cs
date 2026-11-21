using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DA RID: 17114
	public struct IInformationBoardType : IFlatbufferObject
	{
		// Token: 0x17007537 RID: 30007
		// (get) Token: 0x06018061 RID: 98401 RVA: 0x0036DD97 File Offset: 0x0036BF97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018062 RID: 98402 RVA: 0x0036DDA4 File Offset: 0x0036BFA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018063 RID: 98403 RVA: 0x0036DDAC File Offset: 0x0036BFAC
		public static IInformationBoardType GetRootAsIInformationBoardType(ByteBuffer _bb)
		{
			return IInformationBoardType.GetRootAsIInformationBoardType(_bb, default(IInformationBoardType));
		}

		// Token: 0x06018064 RID: 98404 RVA: 0x0036DDC8 File Offset: 0x0036BFC8
		public static IInformationBoardType GetRootAsIInformationBoardType(ByteBuffer _bb, IInformationBoardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018065 RID: 98405 RVA: 0x0036DDE5 File Offset: 0x0036BFE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018066 RID: 98406 RVA: 0x0036DDF4 File Offset: 0x0036BFF4
		public IInformationBoardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007538 RID: 30008
		// (get) Token: 0x06018067 RID: 98407 RVA: 0x0036DE04 File Offset: 0x0036C004
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

		// Token: 0x06018068 RID: 98408 RVA: 0x0036DE40 File Offset: 0x0036C040
		public static Offset<IInformationBoardType> CreateIInformationBoardType(FlatBufferBuilder builder, EInformationBoardType Type = EInformationBoardType.DangoAbyss)
		{
			builder.StartTable(1);
			IInformationBoardType.AddType(builder, Type);
			return IInformationBoardType.EndIInformationBoardType(builder);
		}

		// Token: 0x06018069 RID: 98409 RVA: 0x0036DE56 File Offset: 0x0036C056
		public static void StartIInformationBoardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601806A RID: 98410 RVA: 0x0036DE5F File Offset: 0x0036C05F
		public static void AddType(FlatBufferBuilder builder, EInformationBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601806B RID: 98411 RVA: 0x0036DE6A File Offset: 0x0036C06A
		public static Offset<IInformationBoardType> EndIInformationBoardType(FlatBufferBuilder builder)
		{
			return new Offset<IInformationBoardType>(builder.EndTable());
		}

		// Token: 0x0601806C RID: 98412 RVA: 0x0036DE78 File Offset: 0x0036C078
		public IInformationBoardTypeT UnPack()
		{
			IInformationBoardTypeT informationBoardTypeT = new IInformationBoardTypeT();
			this.UnPackTo(informationBoardTypeT);
			return informationBoardTypeT;
		}

		// Token: 0x0601806D RID: 98413 RVA: 0x0036DE93 File Offset: 0x0036C093
		public void UnPackTo(IInformationBoardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601806E RID: 98414 RVA: 0x0036DEA4 File Offset: 0x0036C0A4
		public static Offset<IInformationBoardType> Pack(FlatBufferBuilder builder, IInformationBoardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationBoardType>);
			}
			return IInformationBoardType.CreateIInformationBoardType(builder, _o.Type);
		}

		// Token: 0x0400C242 RID: 49730
		private Table __p;
	}
}
