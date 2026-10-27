using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A26 RID: 27174
	public struct ILimitPlayerOption : IFlatbufferObject
	{
		// Token: 0x1700C995 RID: 51605
		// (get) Token: 0x0602F8DC RID: 194780 RVA: 0x00679515 File Offset: 0x00677715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8DD RID: 194781 RVA: 0x00679522 File Offset: 0x00677722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8DE RID: 194782 RVA: 0x0067952C File Offset: 0x0067772C
		public static ILimitPlayerOption GetRootAsILimitPlayerOption(ByteBuffer _bb)
		{
			return ILimitPlayerOption.GetRootAsILimitPlayerOption(_bb, default(ILimitPlayerOption));
		}

		// Token: 0x0602F8DF RID: 194783 RVA: 0x00679548 File Offset: 0x00677748
		public static ILimitPlayerOption GetRootAsILimitPlayerOption(ByteBuffer _bb, ILimitPlayerOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8E0 RID: 194784 RVA: 0x00679565 File Offset: 0x00677765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8E1 RID: 194785 RVA: 0x00679574 File Offset: 0x00677774
		public ILimitPlayerOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C996 RID: 51606
		// (get) Token: 0x0602F8E2 RID: 194786 RVA: 0x00679584 File Offset: 0x00677784
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

		// Token: 0x0602F8E3 RID: 194787 RVA: 0x006795C0 File Offset: 0x006777C0
		public static Offset<ILimitPlayerOption> CreateILimitPlayerOption(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerOption.AddType(builder, Type);
			return ILimitPlayerOption.EndILimitPlayerOption(builder);
		}

		// Token: 0x0602F8E4 RID: 194788 RVA: 0x006795D6 File Offset: 0x006777D6
		public static void StartILimitPlayerOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F8E5 RID: 194789 RVA: 0x006795DF File Offset: 0x006777DF
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F8E6 RID: 194790 RVA: 0x006795EA File Offset: 0x006777EA
		public static Offset<ILimitPlayerOption> EndILimitPlayerOption(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerOption>(builder.EndTable());
		}

		// Token: 0x0602F8E7 RID: 194791 RVA: 0x006795F8 File Offset: 0x006777F8
		public ILimitPlayerOptionT UnPack()
		{
			ILimitPlayerOptionT limitPlayerOptionT = new ILimitPlayerOptionT();
			this.UnPackTo(limitPlayerOptionT);
			return limitPlayerOptionT;
		}

		// Token: 0x0602F8E8 RID: 194792 RVA: 0x00679613 File Offset: 0x00677813
		public void UnPackTo(ILimitPlayerOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F8E9 RID: 194793 RVA: 0x00679624 File Offset: 0x00677824
		public static Offset<ILimitPlayerOption> Pack(FlatBufferBuilder builder, ILimitPlayerOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerOption>);
			}
			return ILimitPlayerOption.CreateILimitPlayerOption(builder, _o.Type);
		}

		// Token: 0x0401122D RID: 70189
		private Table __p;
	}
}
