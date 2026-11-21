using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D6 RID: 28886
	public struct ILimitPlayerOption : IFlatbufferObject
	{
		// Token: 0x1700D395 RID: 54165
		// (get) Token: 0x0603229C RID: 205468 RVA: 0x006C986D File Offset: 0x006C7A6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603229D RID: 205469 RVA: 0x006C987A File Offset: 0x006C7A7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603229E RID: 205470 RVA: 0x006C9884 File Offset: 0x006C7A84
		public static ILimitPlayerOption GetRootAsILimitPlayerOption(ByteBuffer _bb)
		{
			return ILimitPlayerOption.GetRootAsILimitPlayerOption(_bb, default(ILimitPlayerOption));
		}

		// Token: 0x0603229F RID: 205471 RVA: 0x006C98A0 File Offset: 0x006C7AA0
		public static ILimitPlayerOption GetRootAsILimitPlayerOption(ByteBuffer _bb, ILimitPlayerOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322A0 RID: 205472 RVA: 0x006C98BD File Offset: 0x006C7ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322A1 RID: 205473 RVA: 0x006C98CC File Offset: 0x006C7ACC
		public ILimitPlayerOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D396 RID: 54166
		// (get) Token: 0x060322A2 RID: 205474 RVA: 0x006C98DC File Offset: 0x006C7ADC
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060322A3 RID: 205475 RVA: 0x006C9918 File Offset: 0x006C7B18
		public static Offset<ILimitPlayerOption> CreateILimitPlayerOption(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerOption.AddType(builder, Type);
			return ILimitPlayerOption.EndILimitPlayerOption(builder);
		}

		// Token: 0x060322A4 RID: 205476 RVA: 0x006C992E File Offset: 0x006C7B2E
		public static void StartILimitPlayerOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060322A5 RID: 205477 RVA: 0x006C9937 File Offset: 0x006C7B37
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060322A6 RID: 205478 RVA: 0x006C9942 File Offset: 0x006C7B42
		public static Offset<ILimitPlayerOption> EndILimitPlayerOption(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerOption>(builder.EndTable());
		}

		// Token: 0x060322A7 RID: 205479 RVA: 0x006C9950 File Offset: 0x006C7B50
		public ILimitPlayerOptionT UnPack()
		{
			ILimitPlayerOptionT limitPlayerOptionT = new ILimitPlayerOptionT();
			this.UnPackTo(limitPlayerOptionT);
			return limitPlayerOptionT;
		}

		// Token: 0x060322A8 RID: 205480 RVA: 0x006C996B File Offset: 0x006C7B6B
		public void UnPackTo(ILimitPlayerOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060322A9 RID: 205481 RVA: 0x006C997C File Offset: 0x006C7B7C
		public static Offset<ILimitPlayerOption> Pack(FlatBufferBuilder builder, ILimitPlayerOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerOption>);
			}
			return ILimitPlayerOption.CreateILimitPlayerOption(builder, _o.Type);
		}

		// Token: 0x04012097 RID: 73879
		private Table __p;
	}
}
