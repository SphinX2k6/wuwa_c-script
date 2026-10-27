using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9C RID: 27804
	public struct IPhoneBoardTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CF0E RID: 53006
		// (get) Token: 0x06030FFF RID: 200703 RVA: 0x006A6DFE File Offset: 0x006A4FFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031000 RID: 200704 RVA: 0x006A6E0B File Offset: 0x006A500B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031001 RID: 200705 RVA: 0x006A6E14 File Offset: 0x006A5014
		public static IPhoneBoardTypeBase GetRootAsIPhoneBoardTypeBase(ByteBuffer _bb)
		{
			return IPhoneBoardTypeBase.GetRootAsIPhoneBoardTypeBase(_bb, default(IPhoneBoardTypeBase));
		}

		// Token: 0x06031002 RID: 200706 RVA: 0x006A6E30 File Offset: 0x006A5030
		public static IPhoneBoardTypeBase GetRootAsIPhoneBoardTypeBase(ByteBuffer _bb, IPhoneBoardTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031003 RID: 200707 RVA: 0x006A6E4D File Offset: 0x006A504D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031004 RID: 200708 RVA: 0x006A6E5C File Offset: 0x006A505C
		public IPhoneBoardTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF0F RID: 53007
		// (get) Token: 0x06031005 RID: 200709 RVA: 0x006A6E6C File Offset: 0x006A506C
		public EPhoneBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return (EPhoneBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031006 RID: 200710 RVA: 0x006A6EA8 File Offset: 0x006A50A8
		public static Offset<IPhoneBoardTypeBase> CreateIPhoneBoardTypeBase(FlatBufferBuilder builder, EPhoneBoardType Type = EPhoneBoardType.MessageBoard)
		{
			builder.StartTable(1);
			IPhoneBoardTypeBase.AddType(builder, Type);
			return IPhoneBoardTypeBase.EndIPhoneBoardTypeBase(builder);
		}

		// Token: 0x06031007 RID: 200711 RVA: 0x006A6EBE File Offset: 0x006A50BE
		public static void StartIPhoneBoardTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031008 RID: 200712 RVA: 0x006A6EC7 File Offset: 0x006A50C7
		public static void AddType(FlatBufferBuilder builder, EPhoneBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031009 RID: 200713 RVA: 0x006A6ED2 File Offset: 0x006A50D2
		public static Offset<IPhoneBoardTypeBase> EndIPhoneBoardTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhoneBoardTypeBase>(builder.EndTable());
		}

		// Token: 0x0603100A RID: 200714 RVA: 0x006A6EE0 File Offset: 0x006A50E0
		public IPhoneBoardTypeBaseT UnPack()
		{
			IPhoneBoardTypeBaseT phoneBoardTypeBaseT = new IPhoneBoardTypeBaseT();
			this.UnPackTo(phoneBoardTypeBaseT);
			return phoneBoardTypeBaseT;
		}

		// Token: 0x0603100B RID: 200715 RVA: 0x006A6EFB File Offset: 0x006A50FB
		public void UnPackTo(IPhoneBoardTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603100C RID: 200716 RVA: 0x006A6F0C File Offset: 0x006A510C
		public static Offset<IPhoneBoardTypeBase> Pack(FlatBufferBuilder builder, IPhoneBoardTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhoneBoardTypeBase>);
			}
			return IPhoneBoardTypeBase.CreateIPhoneBoardTypeBase(builder, _o.Type);
		}

		// Token: 0x040115F3 RID: 71155
		private Table __p;
	}
}
