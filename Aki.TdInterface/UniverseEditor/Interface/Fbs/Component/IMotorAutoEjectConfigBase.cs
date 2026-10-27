using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A5 RID: 21925
	public struct IMotorAutoEjectConfigBase : IFlatbufferObject
	{
		// Token: 0x1700A1F1 RID: 41457
		// (get) Token: 0x060244BD RID: 148669 RVA: 0x00502B9B File Offset: 0x00500D9B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060244BE RID: 148670 RVA: 0x00502BA8 File Offset: 0x00500DA8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060244BF RID: 148671 RVA: 0x00502BB0 File Offset: 0x00500DB0
		public static IMotorAutoEjectConfigBase GetRootAsIMotorAutoEjectConfigBase(ByteBuffer _bb)
		{
			return IMotorAutoEjectConfigBase.GetRootAsIMotorAutoEjectConfigBase(_bb, default(IMotorAutoEjectConfigBase));
		}

		// Token: 0x060244C0 RID: 148672 RVA: 0x00502BCC File Offset: 0x00500DCC
		public static IMotorAutoEjectConfigBase GetRootAsIMotorAutoEjectConfigBase(ByteBuffer _bb, IMotorAutoEjectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060244C1 RID: 148673 RVA: 0x00502BE9 File Offset: 0x00500DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060244C2 RID: 148674 RVA: 0x00502BF8 File Offset: 0x00500DF8
		public IMotorAutoEjectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1F2 RID: 41458
		// (get) Token: 0x060244C3 RID: 148675 RVA: 0x00502C08 File Offset: 0x00500E08
		public EMotorAutoEjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorAutoEjectType.NextHook;
				}
				return (EMotorAutoEjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060244C4 RID: 148676 RVA: 0x00502C44 File Offset: 0x00500E44
		public static Offset<IMotorAutoEjectConfigBase> CreateIMotorAutoEjectConfigBase(FlatBufferBuilder builder, EMotorAutoEjectType Type = EMotorAutoEjectType.NextHook)
		{
			builder.StartTable(1);
			IMotorAutoEjectConfigBase.AddType(builder, Type);
			return IMotorAutoEjectConfigBase.EndIMotorAutoEjectConfigBase(builder);
		}

		// Token: 0x060244C5 RID: 148677 RVA: 0x00502C5A File Offset: 0x00500E5A
		public static void StartIMotorAutoEjectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060244C6 RID: 148678 RVA: 0x00502C63 File Offset: 0x00500E63
		public static void AddType(FlatBufferBuilder builder, EMotorAutoEjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060244C7 RID: 148679 RVA: 0x00502C6E File Offset: 0x00500E6E
		public static Offset<IMotorAutoEjectConfigBase> EndIMotorAutoEjectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IMotorAutoEjectConfigBase>(builder.EndTable());
		}

		// Token: 0x060244C8 RID: 148680 RVA: 0x00502C7C File Offset: 0x00500E7C
		public IMotorAutoEjectConfigBaseT UnPack()
		{
			IMotorAutoEjectConfigBaseT motorAutoEjectConfigBaseT = new IMotorAutoEjectConfigBaseT();
			this.UnPackTo(motorAutoEjectConfigBaseT);
			return motorAutoEjectConfigBaseT;
		}

		// Token: 0x060244C9 RID: 148681 RVA: 0x00502C97 File Offset: 0x00500E97
		public void UnPackTo(IMotorAutoEjectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060244CA RID: 148682 RVA: 0x00502CA8 File Offset: 0x00500EA8
		public static Offset<IMotorAutoEjectConfigBase> Pack(FlatBufferBuilder builder, IMotorAutoEjectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorAutoEjectConfigBase>);
			}
			return IMotorAutoEjectConfigBase.CreateIMotorAutoEjectConfigBase(builder, _o.Type);
		}

		// Token: 0x0400E8D7 RID: 59607
		private Table __p;
	}
}
